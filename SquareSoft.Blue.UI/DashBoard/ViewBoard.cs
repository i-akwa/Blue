using SquareSoft.Blue.DataAccessLayer.Data;
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

namespace SquareSoft.Blue.UI.DashBoard
{
    public partial class ViewBoard : Form
    {
        public ViewBoard()
        {
            InitializeComponent();
        }

        public  void FillChat()
        {
            using (var context = new ApplicationDataContext())
            {
                chart1.DataSource =  context.Database.SqlQuery<SalesRec>("GetDayTotal").ToList(); // asigning a datasource to chart1
                // assigning database variables to the chart X & Y members
                chart1.Series["BarChat"].XValueMember = "dates";
                chart1.Series["BarChat"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chart1.Series["BarChat"].YValueMembers = "amount";
                chart1.Series["BarChat"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            }
        }

        private void ViewBoard_Load(object sender, EventArgs e)
        {
            FillChat();
        }
    }
}
