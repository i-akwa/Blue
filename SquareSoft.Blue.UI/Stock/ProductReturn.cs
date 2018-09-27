using SquareSoft.Blue.DataAccessLayer.Data;
using SquareSoft.Blue.DataAccessLayer.Repository;
using SquareSoft.Blue.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareSoft.Blue.UI.Stock
{
    public partial class ProductReturn : Form
    {
        internal ApplicationDataContext context = new ApplicationDataContext();

        public ProductReturn()
        {
            InitializeComponent();
            editPanel.Visible = false;
            headerPages1._username = "Welcome " + Login.username;
            lblNotice1.Text = "Please select the roll of product you want to return \n and use the delete button.\n It will authomatically be returned if there was only 1'ONE' product.\n But will open the Edit Panel if products are more than 1.";
        }

        List<JointSalesProd> demo = new List<JointSalesProd>();
        decimal temp = 0.00M;

        void BindGrid()
        {
            ProductSalesRepo PSR = new ProductSalesRepo(context);
            var source = new BindingSource();
            int x = Convert.ToInt32(txtSearchId.Text);
            var newSalesRec = PSR.CallSalesById(x);
            foreach (var val in newSalesRec)
            {
                demo.Add(val);
                temp += val.AmounntPaid;
                total.Text = temp.ToString();
                source.DataSource = demo;
            }
            if (source != null)
            {
                dgvSales.DataSource = source;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            editPanel.Visible = false;
                    

            if (txtSearchId.Text!="")
            {
                demo.Clear();
                temp = 0.00M;
                BindGrid();
            }
        }

        private void dgvSales_KeyDown(object sender, KeyEventArgs e)
        {
            var source = new BindingSource();
            int id = Convert.ToInt32(this.dgvSales.CurrentRow.Cells[0].Value);
            int ProdId = Convert.ToInt32(this.dgvSales.CurrentRow.Cells[1].Value);
            int quantityBought = Convert.ToInt32(this.dgvSales.CurrentRow.Cells[3].Value);
            int amountPaid = Convert.ToInt32(this.dgvSales.CurrentRow.Cells[4].Value);

            decimal original_Price = Convert.ToInt32(this.dgvSales.CurrentRow.Cells[6].Value);


            if (e.KeyData==Keys.Delete)
            {
                if(demo.Any(x=>x.quantity==1&&x.id==id))
                {
                    //Reduce Total
                    demo.Where(w => w.id == id).ToList().ForEach(s => temp =temp-Convert.ToDecimal(s.OriginalPrice));
                    total.Text = temp.ToString();

                    //Remove That Record from ProductSales Table and grid
                    ProductSalesRepo PSR = new ProductSalesRepo(context);
                    PSR.DelRecordById(id);

                    var x = demo.Where(p => p.id == id).FirstOrDefault<JointSalesProd>();
                    demo.Remove(x);

                    //Update Sales table to reflect the price
                    int SalesId = Convert.ToInt32(txtSearchId.Text);
                    SalesRepo.UpdateSalesPrice(SalesId, temp);

                    //Update Product Table to add retured product
                    ProductRepo.AddProductQuantity(ProdId, 1);
                    source.DataSource = demo;//Bind Demo to datasource
                    dgvSales.DataSource = source;///Bind demo to grid
                }

                else if(demo.Any(x=>x.quantity>1&&x.id==id))
                {
                    demo.Clear();
                    temp = 0.00M;
                    BindGrid();
                    ClearControls();
                    editPanel.Visible = true;
                    ProductId.Text = ProdId.ToString();
                    ProdSalesId.Text = id.ToString();
                    OriginalPrice.Text = original_Price.ToString();
                    QuantityBought.Text = quantityBought.ToString();
                    AmountPaid.Text = amountPaid.ToString();
                }
            }
        }

        void ClearControls()
        {
            
            increment = 0;
            ProductId.Text = "";
            ProdSalesId.Text = "";
            OriginalPrice.Text = "0";
            QuantityReturned.Text = "0";
            QuantityBought.Text = "";
            AmountPaid.Text = "";
        }


        int increment = 0;
        
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            decimal tempTotal = Convert.ToDecimal(total.Text);
            decimal TempPrice = Convert.ToDecimal(OriginalPrice.Text);
            int p = Convert.ToInt32(QuantityBought.Text);

            if (Convert.ToInt32(QuantityBought.Text)-Convert.ToInt32(QuantityReturned.Text)==0)
            { btnSubtract.Enabled = false; }
            else
            {
                decimal newPrice = Convert.ToDecimal(AmountPaid.Text) - Convert.ToDecimal(OriginalPrice.Text);
                AmountPaid.Text = newPrice.ToString();
                tempTotal -= TempPrice;
                total.Text = tempTotal.ToString();
                increment += 1;
                QuantityReturned.Text = increment.ToString();

            }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMakeReturns_Click(object sender, EventArgs e)
        {
            ProductSalesRepo PSR = new ProductSalesRepo(context);
            var source = new BindingSource();
            int x = Convert.ToInt32(ProdSalesId.Text);
            int y = Convert.ToInt32(QuantityReturned.Text);
            int z = Convert.ToInt32(ProductId.Text);
            int c = Convert.ToInt32(QuantityReturned.Text);
            decimal aP = Convert.ToDecimal(AmountPaid.Text);//Convert The amount paid label into decimal and store it in aP.
            //totally deleting sales record of a particular product if all that product is totally Returned.
            if (aP > 0)
                ProductSalesRepo.UpdateQuantityandNewPrice(x, y, Convert.ToDecimal(AmountPaid.Text));
            else if (aP == 0)
                PSR.DelRecordById(x);


            //Update Sales table to reflect the price
            int SalesId = Convert.ToInt32(txtSearchId.Text);
            SalesRepo.UpdateSalesPrice(SalesId,Convert.ToDecimal(total.Text));

            //Update Product Table to add retured product
            ProductRepo.AddProductQuantity(z,c );

            ClearControls();//Clear the editPanels Control
            if(MessageBox.Show("Done Editing?", "Ok to continue", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                
                var newSalesRecord = PSR.CallSalesById(x);
                demo.Clear();
                temp = 0.00M;
                BindGrid();
                editPanel.Visible = false;
            }
            

        }
    }
}
