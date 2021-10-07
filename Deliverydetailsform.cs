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
    public partial class Deliverydetailsform : Form
    {
        public Deliverydetailsform()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=delivery_management;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("insert into Delivery_data values ('" + textBox7.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully inserted");
            con.Close();
            var principalForm = Application.OpenForms.OfType<formDeliveryAndTransport>().FirstOrDefault();
            principalForm.BindDataD();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                con.Open();
                SqlCommand command = new SqlCommand("update Delivery_data set empID = '" + textBox1.Text + "',orderID = '" + textBox2.Text + "',VID = '" + textBox3.Text + "',deliveryDate = '" + dateTimePicker1.Text + "',destination = '" + textBox5.Text + "',mileage = '" + textBox6.Text + "' where DID = '" + textBox7.Text + "'", con);
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully updated");
                con.Close();
                var principalForm = Application.OpenForms.OfType<formDeliveryAndTransport>().FirstOrDefault();
                principalForm.BindDataD();
            }
            else
            {
                MessageBox.Show("Please enter Delivery ID");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                if (MessageBox.Show("Are you sure you want to delelte?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("delete Delivery_data where DID='" + textBox7.Text + "'", con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Successfully deleted");
                    con.Close();
                    var principalForm = Application.OpenForms.OfType<formDeliveryAndTransport>().FirstOrDefault();
                    principalForm.BindDataD();
                }
            }
            else
            {
                MessageBox.Show("Please enter Delivery ID");
            }
        }
    }
}
