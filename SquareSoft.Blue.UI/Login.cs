using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SquareSoft.Blue.UI;
using SquareSoft.Blue.DataAccessLayer.Repository;
using SquareSoft.Blue.UI.BlueControls;
using Services;
using SquareSoft.Blue.DataAccessLayer.Data;
using SquareSoft.Blue.Models;
using System.Data.Entity;
using SquareSoft.Blue.UI.Staff;

namespace SquareSoft.Blue.UI
{
    public partial class Login : Form 
    {
        internal ApplicationDataContext context = new ApplicationDataContext();
        public DbSet<UsersReg> dbset;
        public Login(ApplicationDataContext _context)
        {
            this.context = _context;
            this.dbset = context.Set<UsersReg>();
        }
        public static string _username = "";
        public static string username
        {
            get;
             set;
        }
        public static void setUserName(string name)
        {
            username = name;
        }
        public Login()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        public static string DoLogin(string username, string password)
        {
            var valueReturn = LoginHandler.LoginUser(username, password.EncryptText("magic_encrypt1256"));//calling Loginghandler.login, then applying encription.
            setUserName(username);
            return valueReturn;
           
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var x = DoLogin(txtUserName.Text, txtPassword.Text);
            if (x != null)
            {
                LandingPage ldp = new LandingPage();
                setUserName(txtUserName.Text);
                this.Hide();
                ldp.Show();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            var userRepo = new UserRepo();
            if(userRepo.CheckForAdmin()==false)
            {
                StaffRegistration staff = new StaffRegistration();
                staff.ShowDialog();
                this.Hide();
            }
        }
    }
}
