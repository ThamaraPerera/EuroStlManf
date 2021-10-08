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

namespace EuroStlManf
{
    public partial class MonthlyBreakdownReport : Form
    {
        public MonthlyBreakdownReport()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=delivery_management;Integrated Security=True");

        public void BindDataWB()
        {
            SqlCommand command = new SqlCommand("select * from Breakdown_data where date Between DATEADD(m, -1, GETDATE()) and GETDATE() ", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void MonthlyBreakdownReport_Load(object sender, EventArgs e)
        {
            BindDataWB();
        }
    }
}
