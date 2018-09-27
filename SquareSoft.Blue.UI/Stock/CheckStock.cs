using SquareSoft.Blue.DataAccessLayer.Data;
using SquareSoft.Blue.DataAccessLayer.Repository;
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
    public partial class CheckStock : Form
    {

        internal ApplicationDataContext con = new ApplicationDataContext();
        public CheckStock()
        {
            InitializeComponent();
            FillGrid();
            FillTooLowGrid();
        }

        private void FillGrid()
        {
            ProductRepo pRepo = new ProductRepo(con);
            var dataSource = new BindingSource();
            dataSource.DataSource = pRepo.SelectProductDetails();
            dgvProducts.DataSource = dataSource;
        }

        private void FillGrid(string bq_Num)
        {
            ProductRepo pRepo = new ProductRepo(con);
            var dataSource = new BindingSource();
            dataSource.DataSource = pRepo.SelectProductDetails(bq_Num);
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = dataSource;
        }

        private void FillTooLowGrid()
        {
            ProductRepo pRepo = new ProductRepo(con);
            var dataSource = new BindingSource();
            dataSource.DataSource = pRepo.TooLowProduct();
            dgvTooLow.DataSource = null;
            dgvTooLow.DataSource = dataSource;
        }

        private void CheckStock_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'blueinventoryDataSet2.GetExpiredProducts' table. You can move, or remove it, as needed.
            //this.getExpiredProductsTableAdapter.Fill(this.blueinventoryDataSet2.GetExpiredProducts);
           // this.getExpiryDateBindingSource.Fill

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtBqNum.Text!="")
            {
                FillGrid(txtBqNum.Text);
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                int columnIndext = e.ColumnIndex;
                if(columnIndext!=0 && columnIndext!=5)
                {
                    txtValue.Text = dgvProducts.CurrentRow.Cells[columnIndext].Value.ToString();
                    lblColToEdit.Text = this.dgvProducts.CurrentCell.OwningColumn.Name.ToString() + " :";
                    txtBqNum.Text = this.dgvProducts.CurrentRow.Cells[0].Value.ToString();
                    lblProdName.Text = this.dgvProducts.CurrentRow.Cells[1].Value.ToString();
                    txtBqNum.ForeColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Cannot Edit This Column", "Warning", MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void dgvExpire_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int columnIndext = e.ColumnIndex;
                txtBqNum.Text = this.dgvExpire.CurrentRow.Cells[1].Value.ToString();
                txtBqNum.ForeColor = Color.Red;
            }
            catch(Exception ex)
            {

            }
        }

        private void dgvTooLow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int columnIndext = e.ColumnIndex;
                txtBqNum.Text = this.dgvTooLow.CurrentRow.Cells[0].Value.ToString();
                txtBqNum.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string bq = txtBqNum.Text;
            string colName = this.dgvProducts.CurrentCell.OwningColumn.Name.ToString();
            int Update = ProductRepo.UpdateProductDetails(bq, colName, txtValue.Text);
            if(Update<=0)
            {
                MessageBox.Show("Error during Edit Process \n please Try again", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                txtValue.Text = "";
                lblColToEdit.Text = "";
                lblProdName.Text = "";
                txtBqNum.Text = "";
                MessageBox.Show("Update Successful", "Alert", MessageBoxButtons.OK);
                FillGrid();
            }
        }
    }
}
