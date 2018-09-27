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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SquareSoft.Blue.UI.Stock
{
    public partial class AddProduct : Form
    {
        internal ApplicationDataContext con = new ApplicationDataContext();
        public AddProduct()
        {
            try
            {
                InitializeComponent();
                headerPages2._username = "Welcome " + Login.username;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Call: O8182477691 and tell it the below problem \n" + ex.Message);
            }
            //txtBQNum.Focus();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblBulkCostPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                decimal quantity = 0;
                if (radIsBulk.Checked)
                    quantity = Convert.ToDecimal(Convert.ToDecimal(txtQuantity.Text) * Convert.ToInt32(txtSinglesInBulk.Text));
                else
                    quantity = Convert.ToDecimal(txtQuantity.Value);
                for (int i = 0; i <= 3; i++)
                {
                    if (i == 1)
                    {

                        if (ValidateForm() == true)
                        {
                            int update = ProductRepo.AddProducts(txtBQNum.Text, Convert.ToInt32(quantity), Convert.ToDecimal(txtUnitPrice.Text));//this version of AddProducts(x,x,x,x) taking 4 params if actually for updating the products tab if the product BQ already exists.
                            if (update > 0)
                                continue;

                            else
                            {
                                int ins = ProductRepo.AddProducts(txtBQNum.Text, txtProductNames.Text, Convert.ToInt32(quantity), Convert.ToInt32(txtSinglesInBulk.Text), Convert.ToDecimal(txtBulkPrice.Text), Convert.ToDecimal(txtUnitPrice.Text), txtDescription.Text, Convert.ToInt32(txtLowAlert.Text));//AddProducts(x,x,x,x,x,x,x,x,x,x,x) taking 11 params actually add the products to the database if its BQ doesnt exist in the database
                                if (ins <= 0)
                                {
                                    lblError.Text = "Error while inserting product";
                                    break;
                                }
                                else
                                    continue;
                            }
                        }
                        else
                            lblError.Text = "Error in data entry";
                        break;

                    }
                    if (i == 2)
                    {
                        string bulkType; ;
                        if (radIsBulk.Checked)
                        {
                            bulkType = cboBulkType.Text;
                        }
                        else
                        {
                            bulkType = "single";
                        }
                        lblError.Text = "Managing Stock...";
                        int stockInsert = StockRepo.AddStock(txtBQNum.Text, Convert.ToInt32(txtQuantity.Value), Convert.ToDecimal(txtUnitPrice.Text), txtDescription.Text, bulkType, Convert.ToDateTime(dtpExpiryDate.Text));//Making the next loop phase add and manage stock
                        if (stockInsert > 0)
                            continue;
                        else
                        {
                            lblError.Text = "Error adding stock";
                            break;
                        }
                    }
                    if (i > 2)
                    {
                        timer1.Enabled = true;
                        lblError.Text = "Product added and stock updated" ;
                        ClearForm();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        

        private void AddProduct_Load(object sender, EventArgs e)
        {
            try
            {
                this.ActiveControl = txtBQNum;
                lblNotice.Text = "Please this is needed especially in cases of \n similar products having little distinctions";
                txtUnitPrice.Text = 0.ToString();
                txtBulkCostPrice.Text = 0.ToString();
                txtBulkPrice.Text = 0.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Call: O8182477691 and tell it the below problem \n"+ex.Message);
            }
        }

        private void radIsBulk_CheckedChanged(object sender, EventArgs e)
        {
            if (radIsBulk.Checked == true)
                cboBulkType.Visible = true;
        }

        private void rdbSingle_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdbSingle.Checked == true)
                    cboBulkType.Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Call: O8182477691 and tell it the below problem \n" + ex.Message);
            }
        }
        /// <summary>
        /// Changing the value of the bulk quantity according to the drop down selected item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboBulkType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboBulkType.SelectedItem.Equals("DOZEN"))//if the selected value is a Dozen
                {
                    txtSinglesInBulk.Value = 12;
                    // lblNotice.ForeColor = System.Drawing.Color.Blue;
                }
                if (cboBulkType.SelectedItem.Equals("ROLL"))//if the selected value is a roll
                {
                    txtSinglesInBulk.Value = 10;
                }
                if (cboBulkType.SelectedItem.Equals("SCORE"))//if the selected value is a score
                {
                    txtSinglesInBulk.Value = 24;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Call: O8182477691 and tell it the below problem \n" + ex.Message);
            }

        }

        private void cboBulkType_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlAddProduct_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// method to validate the add product form
        /// </summary>
        /// <returns>true || false</returns>
        bool ValidateForm()
        {
            try
            {
                if (txtBQNum.Text != "" || txtQuantity.Value != 0 || txtUnitPrice.Text != "" || txtProductNames.Text != "" || dtpExpiryDate.Text != dtpLastStockDate.Text)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Call: O8182477691 and tell it the below problem \n"+ex.Message);
                return false;
            }       
        }

        /// <summary>
        /// method to clear the add product form
        /// </summary>
        void ClearForm()
        {
            try
            {
                txtBQNum.Text = "";
                txtBulkCostPrice.Text = "";
                txtBulkPrice.Text = "";
                txtDescription.Text = "";
                txtProductNames.Text = "";
                txtQuantity.Value = 0;
                txtSinglesInBulk.Value = 0;
                txtUnitPrice.Text = "";
                rdbSingle.Checked = false;
                radIsBulk.Checked = false;

                this.ActiveControl = txtBQNum;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Call: O8182477691 and tell it the below problem \n" + ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if(progressBar1.Value>=99)
            {
                timer1.Enabled=false;
                progressBar1.Value = 0;
            }
        }
        /// <summary>
        /// what happens when a BQ is first inserted/ when it repeats
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBQNum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ProductRepo prod = new ProductRepo(con);
                var query = prod.GetProductName(txtBQNum.Text) as Products;
                if (query != null)
                {
                    txtProductNames.Text = query.product_name;
                    txtLowAlert.Value = Convert.ToInt32(query.tooLowAlertNum);
                    txtUnitPrice.Text = query.unit_price.ToString();
                    txtDescription.Text = query.description;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Call: O8182477691 and tell it the below problem \n" + ex.Message);
            }
            
        }
    }
}
