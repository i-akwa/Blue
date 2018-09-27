using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SquareSoft.Blue.UI.Stock;
using SquareSoft.Blue.UI.Staff;
using SquareSoft.Blue.UI.DashBoard;


namespace SquareSoft.Blue.UI.BlueControls
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
         
        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            AddProduct pro = new AddProduct();
            this.FindForm().Close();
            pro.Show();
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            LandingPage landingPage = new LandingPage();
            this.FindForm().Close();
            landingPage.Show();
        }

        private void btnStaffs_Click(object sender, EventArgs e)
        {
            StaffRegistration staff = new StaffRegistration();
            this.FindForm().Close();
            staff.Show();
        }

        private void btnDashBoards_Click(object sender, EventArgs e)
        {
            ViewBoard vB = new ViewBoard();
            this.FindForm().Close();
            vB.Show();
        }

        private void btnOrdersSupplies_Click(object sender, EventArgs e)
        {
            ProductReturn pR = new ProductReturn();
            this.FindForm().Close();
            pR.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogout1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.FindForm().Close();
            login.Show();
        }

        private void btnManagements_Click(object sender, EventArgs e)
        {
            CheckStock check = new CheckStock();
            this.FindForm().Close();
            check.Show();
        }
    }
}
