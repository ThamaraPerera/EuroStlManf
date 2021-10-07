using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            Regex bid = new Regex(@"\b[B]\d+$");
            Regex eid = new Regex(@"\b[E]\d+$");
            Regex oid = new Regex(@"\b[O]\d+$");
            Regex vid = new Regex(@"\b[V]\d+$");
            Regex mil = new Regex(@"^\d+$");

            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                textBox6.Focus();
                MessageBox.Show("Please enter Breakdown ID");
            }
            else if (!bid.IsMatch(textBox6.Text))
            {
                textBox6.Focus();
                MessageBox.Show("Please enter a Valid Breakdown ID");
            }
            else if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Focus();
                MessageBox.Show("Please enter Employee ID");
            }
            else if (!eid.IsMatch(textBox1.Text))
            {
                textBox1.Focus();
                MessageBox.Show("Please enter a Valid Employee ID");
            }
            else if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Focus();
                MessageBox.Show("Please enter Order ID");
            }
            else if (!oid.IsMatch(textBox2.Text))
            {
                textBox2.Focus();
                MessageBox.Show("Please enter a Valid Order ID");
            }
            else if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                textBox3.Focus();
                MessageBox.Show("Please enter Vehicle ID");
            }
            else if (!vid.IsMatch(textBox3.Text))
            {
                textBox3.Focus();
                MessageBox.Show("Please enter a Valid Vehicle ID");
            }
            else if (string.IsNullOrWhiteSpace(dateTimePicker1.Text))
            {
                dateTimePicker1.Focus();
                MessageBox.Show("Please select a date");
            }
            else if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                textBox5.Focus();
                MessageBox.Show("Please enter Location");
            }
           
            else
            {
                con.Open();
                SqlCommand command = new SqlCommand("insert into Breakdown_data values ('" + textBox6.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + textBox5.Text + "')", con);
                SqlCommand command1 = new SqlCommand("update Vehicle_data set status = 'Out' where VID = '" + textBox3.Text + "'", con);
                command.ExecuteNonQuery();
                command1.ExecuteNonQuery();
                MessageBox.Show("Successfully inserted");
                con.Close();
                var principalForm = Application.OpenForms.OfType<formDeliveryAndTransport>().FirstOrDefault();
                principalForm.BindDataB();
                principalForm.BindDataV();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Regex bid = new Regex(@"\b[B]\d+$");
            Regex eid = new Regex(@"\b[E]\d+$");
            Regex oid = new Regex(@"\b[O]\d+$");
            Regex vid = new Regex(@"\b[V]\d+$");
            Regex mil = new Regex(@"^\d+$");

            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                textBox6.Focus();
                MessageBox.Show("Please enter Breakdown ID");
            }
            else if (!bid.IsMatch(textBox6.Text))
            {
                textBox6.Focus();
                MessageBox.Show("Please enter a Valid Breakdown ID");
            }
            else if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Focus();
                MessageBox.Show("Please enter Employee ID");
            }
            else if (!eid.IsMatch(textBox1.Text))
            {
                textBox1.Focus();
                MessageBox.Show("Please enter a Valid Employee ID");
            }
            else if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Focus();
                MessageBox.Show("Please enter Vehicle ID");
            }
            else if (!vid.IsMatch(textBox2.Text))
            {
                textBox2.Focus();
                MessageBox.Show("Please enter a Valid Vehicle ID");
            }
            else if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                textBox3.Focus();
                MessageBox.Show("Please enter Order ID");
            }
            else if (!oid.IsMatch(textBox3.Text))
            {
                textBox3.Focus();
                MessageBox.Show("Please enter a Valid Order ID");
            }
            else if (string.IsNullOrWhiteSpace(dateTimePicker1.Text))
            {
                dateTimePicker1.Focus();
                MessageBox.Show("Please select a date");
            }
            else if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                textBox5.Focus();
                MessageBox.Show("Please enter Location");
            }

            else
            {
                con.Open();
                SqlCommand command = new SqlCommand("update Breakdown_data set empID = '" + textBox1.Text + "',VID = '" + textBox3.Text + "',orderID = '" + textBox2.Text + "',date = '" + dateTimePicker1.Text + "',location = '" + textBox5.Text + "' where BID = '" + textBox6.Text + "'", con);
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully updated");
                con.Close();
                var principalForm = Application.OpenForms.OfType<formDeliveryAndTransport>().FirstOrDefault();
                principalForm.BindDataB();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            if (textBox6.Text != "")
            {
                con.Open();
                SqlCommand command = new SqlCommand("select empID,orderID,VID,date,location from Breakdown_data where BID='" + textBox6.Text + "'", con);
                SqlDataReader srd = command.ExecuteReader();
                while (srd.Read())
                {
                    textBox1.Text = srd.GetValue(0).ToString();
                    textBox2.Text = srd.GetValue(1).ToString();
                    textBox3.Text = srd.GetValue(2).ToString();
                    dateTimePicker1.Text = srd.GetValue(3).ToString();
                    textBox5.Text = srd.GetValue(4).ToString();
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please enter Breakdown ID");
            }
        }
    }
}
