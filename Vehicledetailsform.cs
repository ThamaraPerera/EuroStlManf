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
    public partial class Vehicledetailsform : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=delivery_management;Integrated Security=True");
        public Vehicledetailsform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("insert into Vehicle_data values ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox2.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "')", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully inserted");
            con.Close();
            var principalForm = Application.OpenForms.OfType<formDeliveryAndTransport>().FirstOrDefault();
            principalForm.BindDataV();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update Vehicle_data set licensePlate = '" + textBox2.Text + "',type = '" + comboBox2.Text + "',status = '" + comboBox1.Text + "',otherInfo = '" + textBox5.Text + "' where VID = '" + textBox1.Text + "'", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully updated");
            con.Close();
            var principalForm = Application.OpenForms.OfType<formDeliveryAndTransport>().FirstOrDefault();
            principalForm.BindDataV();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (MessageBox.Show("Are you sure you want to delelte?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("delete Vehicle_data where VID='" + textBox1.Text + "'", con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Successfully deleted");
                    con.Close();
                    var principalForm = Application.OpenForms.OfType<formDeliveryAndTransport>().FirstOrDefault();
                    principalForm.BindDataV();
                }
            }
            else
            {
                MessageBox.Show("Please enter Vehicle ID");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
