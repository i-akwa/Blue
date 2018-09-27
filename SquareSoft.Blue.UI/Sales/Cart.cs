using SquareSoft.Blue.DataAccessLayer.Data;
using SquareSoft.Blue.DataAccessLayer.Repository;
using SquareSoft.Blue.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;
using System.Reflection;
using System.Threading;
using System.Drawing.Printing;

namespace SquareSoft.Blue.UI
{
    public partial class LandingPage : Form
    {
        internal ApplicationDataContext context = new ApplicationDataContext();
        public LandingPage()
        {
            InitializeComponent();
            AutoComplete();
            headerPages1._username = "Welcome " + Login.username;
            txtLoyaltyPayMethod.Visible = false;
            txtPosPayMethod.Visible = false;
            chkCash.Checked = true;
            txtLoyaltyPayMethod.Text = "0";
            txtCashPayMethod.Text = "0";
            txtPosPayMethod.Text = "0";
            radAmount.Checked = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// List<newProd> demo;
        /// This List that holds the products to be binded to the cart grid.
        /// declared outside the button to avoid datalost on every click.
        /// </summary>
        List<NewProd> demo = new List<NewProd>();
        decimal newPrice = 0.0M;// would be use to manipulate values for lblamount which holds the total.
        decimal firstPrice = 0.0M;
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            //Checking if 
            if (txtsearch.Text != "")
            {
                //storing txtsearch in a string variable called name
                string name = txtsearch.Text;
                ProductRepo pRepo = new ProductRepo(context);//Instanciating a new object of type ProductRepo.
                var source = new BindingSource(); // new Bindinng datasource declared

                var newPro = pRepo.GetProductForCart(name);//Callig GetProductForCart(name) of the ProductRepo and assigning it to newPro

                if (demo.Any(x => x.product_Name == name || x.bqNum==name))//Checking if a product already exist, 
                {
                    foreach (var val in newPro)
                        firstPrice = val.unit_price;//make firstprice hold the original value
                    //then incrementing the quantity
                    demo.Where(w => w.product_Name == name || w.bqNum==name).ToList().ForEach(s => s.quantity += 1);

                    //then incrementing the price                   
                    demo.Where(w => w.product_Name == name || w.bqNum==name).ToList().ForEach(s => s.unit_price = firstPrice + s.unit_price);

                    //then incrementing Total
                    demo.Where(w => w.product_Name == name || w.bqNum==name).ToList().ForEach(s => newPrice += Convert.ToDecimal(s.unit_price / s.quantity));
                    lblAmount.Text = newPrice.ToString();

                    source.DataSource = demo;// Bindig demo to the datasource
                    CartGrid.DataSource = source; //binding datasource to grid
                    txtsearch.Text = "";
                    this.ActiveControl = txtsearch;
                }
                else //Just bind
                {
                    if (newPro.Count == 0)
                    {
                        MessageBox.Show("Product not Valid");
                    }
                    else if (newPro.Count > 0)
                    {
                        foreach (var vals in newPro)
                        {
                            vals.quantity += 1;
                            demo.Add(vals);

                            source.DataSource = demo;

                            newPrice += vals.unit_price;
                            lblAmount.Text = newPrice.ToString();//incrementing Totaln label
                        }
                        if (source != null)
                        {
                            CartGrid.DataSource = source;
                            txtsearch.Text = "";
                            this.ActiveControl = txtsearch;
                        }
                    }


                }
            }
            else
            {
                MessageBox.Show("Enter Valid Search Parameter");
            }
        }

        void AutoComplete()
        {
            //making objects of product repo class
            ProductRepo pro = new ProductRepo(context);
            var sourceString = pro.getAllProductNames();//calling a method to get all product names : sourceString to be used as the source of ma autocomplete fill

            ///Implementing autocomplete
            txtsearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtsearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            var source = new AutoCompleteStringCollection();
            source.AddRange(sourceString);
            txtsearch.AutoCompleteCustomSource = source;
        }

        private void LandingPage_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtsearch;
            txtDiscount.Text = "0.0";
            this.AcceptButton = materialRaisedButton1;

        }
        private string CheckPayMethod()
        {
            string payMethod = "";

            if (chkCash.Checked)
            {
                payMethod = "Cash";
            }

            if (chkPos.Checked)
            {
                payMethod = "POS";
            }
            if (chkLoyalty.Checked)
            {
                payMethod = "Loyalty Card";
            }
            if (chkCash.Checked && chkPos.Checked)
            {
                payMethod = "Split (Cash/POS)";
            }
            if (chkCash.Checked && chkLoyalty.Checked)
            {
                payMethod = "Split (Cash/Loyalty)";
            }
            if (chkLoyalty.Checked && chkPos.Checked)
            {
                payMethod = "Split (Loyalty/POS)";
            }
            if (chkCash.Checked && chkPos.Checked && chkCash.Checked)
            {
                payMethod = "Split (Cash/POS/Cash)";
            }

            return payMethod;
        }
        private int CheckFullPayment()
        {
            string payMethod = CheckPayMethod();
            int IsFullyPaid = 0;

            if (payMethod.Equals("POS"))
            {
                if (Convert.ToDecimal(txtPosPayMethod.Text) == Convert.ToDecimal(lblAmount.Text))
                {
                    IsFullyPaid = 1;
                }
                else
                {
                    IsFullyPaid = 0;
                }
            }

            if (payMethod.Equals("Loyalty Card"))
            {
                if (Convert.ToDecimal(txtLoyaltyPayMethod.Text) == Convert.ToDecimal(lblAmount.Text))
                {
                    IsFullyPaid = 1;
                }
                else
                {
                    IsFullyPaid = 0;
                }
            }

            if (payMethod.Equals("Cash"))
            {
                if (Convert.ToDecimal(txtCashPayMethod.Text) == Convert.ToDecimal(lblAmount.Text))
                {
                    IsFullyPaid = 1;
                }
                else
                {
                    IsFullyPaid = 0;
                }
            }

            if (payMethod.Equals("Split (Cash/POS)"))
            {
                if (Convert.ToDecimal(txtPosPayMethod.Text) + Convert.ToDecimal(txtCashPayMethod.Text) == Convert.ToDecimal(lblAmount.Text))
                {
                    IsFullyPaid = 1;
                }
                else
                {
                    IsFullyPaid = 0;
                }
            }

            if (payMethod.Equals("Split (Cash/Loyalty)"))
            {
                if (Convert.ToDecimal(txtLoyaltyPayMethod.Text) + Convert.ToDecimal(txtCashPayMethod.Text) == Convert.ToDecimal(lblAmount.Text))
                {
                    IsFullyPaid = 1;
                }
                else
                {
                    IsFullyPaid = 0;
                }
            }

            if (payMethod.Equals("Split (Loyalty/POS)"))
            {
                if (Convert.ToDecimal(txtLoyaltyPayMethod.Text) + Convert.ToDecimal(txtPosPayMethod.Text) == Convert.ToDecimal(lblAmount.Text))
                {
                    IsFullyPaid = 1;
                }
                else
                {
                    IsFullyPaid = 0;
                }
            }

            if (payMethod.Equals("Split (Cash/POS/Cash)"))
            {
                if (Convert.ToDecimal(txtLoyaltyPayMethod.Text) + Convert.ToDecimal(txtPosPayMethod.Text) + Convert.ToDecimal(txtCashPayMethod.Text) == Convert.ToInt32(lblAmount.Text))
                {
                    IsFullyPaid = 1;
                }
                else
                {
                    IsFullyPaid = 0;
                }
            }
            return IsFullyPaid;
        }
        private void btnMakePay_Click(object sender, EventArgs e)
        {
            var total = Convert.ToDecimal(lblAmount.Text);
            if (CheckFullPayment() == 1&&total>0)
            {
                int inserted = SalesRepo.MakeSales(Login.username, Convert.ToDecimal(lblAmount.Text), DateTime.UtcNow, Convert.ToDecimal(txtDiscount.Text), CheckPayMethod());
                if (inserted > 0)
                {
                    int salesId = getId();
                    int i;//Iterator
                    for (i = 0; i < demo.Count; i++)
                    {
                        int success = ProductSalesRepo.add(salesId, demo[i].id, demo[i].quantity, demo[i].unit_price, System.DateTime.UtcNow, demo[i].unit_price / demo[i].quantity);
                        int insert = ProductRepo.MinusProducts(demo[i].id, Convert.ToInt32(demo[i].quantity));
                    }
                    MessageBox.Show(i + " different product(s) sold");

                    PrintDoc();
                    CartGrid.DataSource = null;
                    demo.Clear();
                    lblAmount.Text = "0.00";
                    newPrice = 0.00M;

                }
            }
            else
            {
                MessageBox.Show("Please Make Full Payment Before Checking Out");
            }
        }

        /// <summary>
        /// txtDiscount contains the discount to be affected in the price.
        /// its text changed events manage the calculations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (radAmount.Checked)
            {
                if (txtDiscount.Text == "")
                {
                    txtDiscount.Text = "0.0";/*setting the textbox values to numeric even when empty**/
                    lblAmount.Text = newPrice.ToString();
                }
                decimal discount = Convert.ToDecimal(txtDiscount.Text);
                decimal total = Convert.ToDecimal(newPrice);
                total -= discount;
                lblAmount.Text = total.ToString();
            }
            if (radPercent.Checked)
            {
                if (txtDiscount.Text == "")
                {
                    txtDiscount.Text = "0.0";/*setting the textbox values to numeric even when empty**/
                    lblAmount.Text = newPrice.ToString();
                }
                decimal discount = Convert.ToDecimal(txtDiscount.Text);
                decimal total = Convert.ToDecimal(newPrice);
                decimal newPercent = total * (discount / 100);
                decimal newTotal = total - newPercent;
                lblAmount.Text = newTotal.ToString();
            }
        }

        /// <summary>
        /// method to get salesId to be used by product_sales Table.
        /// </summary>
        /// <returns>int salesId</returns>
        public int getId()
        {
            var id = (from s in context.sales orderby s.sales_date descending select s.id).First();
            int salesId = Convert.ToInt32(id);
            return salesId;
        }

        private void CartGrid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
        }

        private void chkCash_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCash.Checked)
            {
                txtCashPayMethod.Visible = true;
            }
            else
            {
                txtCashPayMethod.Visible = false;
            }
        }

        private void chkPos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPos.Checked)
            {
                txtPosPayMethod.Visible = true;
            }
            else
            {
                txtPosPayMethod.Visible = false;
            }
        }

        private void chkLoyalty_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLoyalty.Checked)
            {
                txtLoyaltyPayMethod.Visible = true;
            }
            else
            {
                txtLoyaltyPayMethod.Visible = false;
            }
        }

        private void radAmount_CheckedChanged(object sender, EventArgs e)
        {
            txtDiscount.Text = "0";
            decimal tempVal = Convert.ToDecimal(txtDiscount.Text);
            txtDiscount.Text = tempVal.ToString();
        }

        private void radPercent_CheckedChanged(object sender, EventArgs e)
        {
            txtDiscount.Text = "0";
            decimal tempVal = Convert.ToDecimal(txtDiscount.Text);
            txtDiscount.Text = tempVal.ToString();
        }

        private void CartGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

        }

        private void CartGrid_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(this.CartGrid.CurrentRow.Cells[0].Value);
                ProductRepo pRepo = new ProductRepo(context);//Instanciating a new object of type ProductRepo.
                var source = new BindingSource(); // new Bindinng datasource declared

                var newPro = pRepo.GetProductForCartWithId(id);//Callig GetProductForCart(name) of the ProductRepo and assigning it to newPro
                if (e.KeyData == Keys.Delete)// If a column is selected, and the delete Key is pressed.
                {
                    if (demo.Any(x => x.quantity > 1 && x.id== id))//Checking if a product Quantity Exceeds 1 and if true.  
                    {
                        foreach (var val in newPro)
                            firstPrice = val.unit_price;//make firstprice hold the original value
                                                        
                        demo.Where(w => w.id == id).ToList().ForEach(s => s.quantity -= 1);//then decrementing the quantity

                        //then decrementing the price                   
                        demo.Where(w => w.id == id).ToList().ForEach(s => s.unit_price = s.unit_price - firstPrice);

                        //then decrementing Total
                        demo.Where(w => w.id == id).ToList().ForEach(s => newPrice -= Convert.ToDecimal(s.unit_price / s.quantity));
                        lblAmount.Text = newPrice.ToString();

                        source.DataSource = demo;// Bindig demo to the datasource
                        CartGrid.DataSource = source; //binding datasource to grid
                    }
                    else if (demo.Any(x => x.quantity == 1 && x.id==id))//Check if product quantity is just left with 1.
                    {

                        demo.Where(w => w.id == id).ToList().ForEach(s => newPrice -= Convert.ToDecimal(s.unit_price / s.quantity));
                        lblAmount.Text = newPrice.ToString();

                        var x = demo.Where(p => p.id == id).FirstOrDefault<NewProd>();//Create an object of type NewProd
                        demo.Remove(x);//Remove That item from the list of items.

                        source.DataSource = demo;// Bindig demo to the datasource
                        CartGrid.DataSource = source; //binding datasource to grid
                    }
                }
            }
            catch(Exception ex)
            {
                //Unhandld Exceeptions.
            }

        }

        #region PrintSection
        private void PrintDoc()
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();

            printDialog.Document = printDoc;
            printDoc.PrintPage += new PrintPageEventHandler(PrintDoc_PrintPage);

            DialogResult result = printDialog.ShowDialog();
            if(result==DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 12);

            float fontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphics.DrawString("Welcome To Blackbit Solar Store",
                new Font("Courier New",18),
                new SolidBrush(Color.Black),startX,startY);

            foreach(var prod in demo)
            {
                string productName = prod.product_Name.PadRight(40);
                string quantity = prod.quantity.ToString().PadRight(20);
                string productPrice = prod.unit_price.ToString();
                string productLine = productName + quantity + productPrice;

                graphics.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
            }

            offset = offset + 20;
            graphics.DrawString("Total to pay".PadRight(30)+string.Format("{0:c}",newPrice), font, new SolidBrush(Color.Black), startX, startY + offset);

        }
        #endregion
    }
}
