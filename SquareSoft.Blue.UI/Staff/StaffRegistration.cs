using SquareSoft.Blue.DataAccessLayer.Data;
using SquareSoft.Blue.DataAccessLayer.Repository;
using SquareSoft.Blue.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareSoft.Blue.UI.Staff
{
    public partial class StaffRegistration : Form
    {
        SqlDataAdapter dat;
        SqlCommandBuilder scb;
        DataTable dt;
        internal ApplicationDataContext con = new ApplicationDataContext();
        public DbSet<UsersReg> dbset;

        UserRepo userRepo = new UserRepo();
        public StaffRegistration()
        {
            InitializeComponent();
            FillGrid();
            if(Login.username==null|| Login.username=="")
            {
                Login.username = "";
            }
            else
            {
                headerPages1._username = "Welcome " + Login.username;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StaffRegistration_Load(object sender, EventArgs e)
        {
            try
            {
                if (userRepo.CheckForAdmin() == false)
                {
                    cboUserType.Items.Add("Admin");
                    menu1.Enabled = false;
                }

                else
                {
                    cboUserType.Items.Add("Admin");
                    cboUserType.Items.Add("SalesPerson");
                    cboUserType.Items.Add("StockKeeper");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.Substring(0, 20));
            }


        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                UserRepo.addUser(txtFirstName.Text, txtLastName.Text, cboUserType.Text.ToString(),
                txtUserName.Text, txtPassword.Text, Convert.ToDateTime(dtpRegDate.Text), txtAddress.Text, txtTellNum.Text, Convert.ToDateTime(System.DateTime.UtcNow), DateTime.Now);
                FillGrid();
                if(Login.username=="")
                {
                    Login login = new Login();
                    login.Show();
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.Substring(0,20));
            }
            
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

       public void FillGrid()
        {
            UserRepo user = new UserRepo(con);
            var datasource = new BindingSource();
            datasource.DataSource= user.SelectUsers();
            dgvStaffRecord.DataSource = datasource; 
        }

        private void dgvStaffRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string colName = this.dgvStaffRecord.CurrentCell.OwningColumn.Name.ToString();
                string userName = this.dgvStaffRecord.CurrentRow.Cells[3].Value.ToString();
                
                int isUpdated=UserRepo.UpdateUserRecord(userName, colName, txtEditBox.Text);
                MessageBox.Show(colName.ToString() + " Updated Successfully");
                FillGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.Substring(0, 20));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvStaffRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int columnIndext = e.ColumnIndex;
                if (columnIndext != 2 && columnIndext != 3)
                {
                    txtEditBox.Text = dgvStaffRecord.CurrentRow.Cells[columnIndext].Value.ToString();
                    lblColumnName.Text = this.dgvStaffRecord.CurrentCell.OwningColumn.Name.ToString() + " :";
                    lblNameToEdit.Text = "(" + this.dgvStaffRecord.CurrentRow.Cells[0].Value.ToString() + ")";
                }
                else
                {
                    MessageBox.Show("Cannot Edit UserRole or userName", "Warning", MessageBoxButtons.OK);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.Substring(0, 20));
            }
            
        }
    }
}
