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
    public partial class Breakdowndetailsform : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=delivery_management;Integrated Security=True");
        public Breakdowndetailsform()
        {
            InitializeComponent();
        }

        private void Breakdowndetailsform_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("insert into Breakdown_data values ('" + textBox6.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Text + "','" + textBox5.Text + "')", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully inserted");
            con.Close();
            var principalForm = Application.OpenForms.OfType<formDeliveryAndTransport>().FirstOrDefault();
            principalForm.BindDataB();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update Breakdown_data set empID = '" + textBox1.Text + "',VID = '" + textBox2.Text + "',orderID = '" + textBox3.Text + "',date = '" + dateTimePicker1.Text + "',location = '" + textBox5.Text + "' where BID = '" + textBox6.Text + "'", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully updated");
            con.Close();
            var principalForm = Application.OpenForms.OfType<formDeliveryAndTransport>().FirstOrDefault();
            principalForm.BindDataB();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                if (MessageBox.Show("Are you sure you want to delelte?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("delete Breakdown_data where BID='" + textBox6.Text + "'", con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Successfully deleted");
                    con.Close();
                    var principalForm = Application.OpenForms.OfType<formDeliveryAndTransport>().FirstOrDefault();
                    principalForm.BindDataB();
                }
            }
            else
            {
                MessageBox.Show("Please enter Breakdown ID");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
