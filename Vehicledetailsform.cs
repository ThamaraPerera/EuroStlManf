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
    public partial class Vehicledetailsform : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=delivery_management;Integrated Security=True");
        public Vehicledetailsform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex vid = new Regex(@"\b[V]\d+");
            Regex lp = new Regex(@"\b[A-Z]{2,3}-[0-9]{4}$");

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Focus();
                MessageBox.Show("Please enter Vehicle ID");
            }
            else if (!vid.IsMatch(textBox1.Text))
            {
                textBox1.Focus();
                MessageBox.Show("Please enter a Valid Vehicle ID");
            }
            else if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox1.Focus();
                MessageBox.Show("Please enter License Plate");
            }
            else if (!lp.IsMatch(textBox2.Text))
            {
                textBox2.Focus();
                MessageBox.Show("Please enter a Valid License Plate");
            }
            else if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                textBox1.Focus();
                MessageBox.Show("Please select Vehicle Type");
            }
            else if (string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                textBox1.Focus();
                MessageBox.Show("Please select Status");
            }
            else if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                textBox1.Focus();
                MessageBox.Show("Other info cannot be empty");
            }

            else
            {
                con.Open();
                SqlCommand command = new SqlCommand("insert into Vehicle_data values ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox2.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "')", con);
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully inserted");
                con.Close();
                var principalForm = Application.OpenForms.OfType<formDeliveryAndTransport>().FirstOrDefault();
                principalForm.BindDataV();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Regex vid = new Regex(@"\b[V]\d+");
            Regex lp = new Regex(@"\b[A-Z]{2,3}-[0-9]{4}$");

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Focus();
                MessageBox.Show("Please enter Vehicle ID");
            }
            else if (!vid.IsMatch(textBox1.Text))
            {
                textBox1.Focus();
                MessageBox.Show("Please enter a Valid Vehicle ID");
            }
            else if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox1.Focus();
                MessageBox.Show("Please enter License Plate");
            }
            else if (!lp.IsMatch(textBox2.Text))
            {
                textBox2.Focus();
                MessageBox.Show("Please enter a Valid License Plate");
            }
            else if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                textBox1.Focus();
                MessageBox.Show("Please select Vehicle Type");
            }
            else if (string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                textBox1.Focus();
                MessageBox.Show("Please select Status");
            }
            else if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                textBox1.Focus();
                MessageBox.Show("Other info cannot be empty");
            }
            
            else
            {
                con.Open();
                SqlCommand command = new SqlCommand("update Vehicle_data set licensePlate = '" + textBox2.Text + "',type = '" + comboBox2.Text + "',status = '" + comboBox1.Text + "',otherInfo = '" + textBox5.Text + "' where VID = '" + textBox1.Text + "'", con);
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully updated");
                con.Close();
                var principalForm = Application.OpenForms.OfType<formDeliveryAndTransport>().FirstOrDefault();
                principalForm.BindDataV();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            if (textBox1.Text != "")
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("select licensePlate,type,status,otherInfo from Vehicle_data where VID='" + textBox1.Text + "'", con);
                    SqlDataReader srd = command.ExecuteReader();
                    while (srd.Read())
                        {
                            textBox2.Text = srd.GetValue(0).ToString();
                            comboBox2.Text = srd.GetValue(1).ToString();
                            comboBox1.Text = srd.GetValue(2).ToString();
                            textBox5.Text = srd.GetValue(3).ToString();
                        }
                    con.Close();
                }
            else
            {
                MessageBox.Show("Please enter Vehicle ID");
            }
        }
        //Regex email = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
        /*private void textBoxVID_validate(object sender, CancelEventArgs e)
        {
            Regex vid = new Regex(@"\b[V]\d+");
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProviderApp.SetError(textBox1, "Vehicle ID should not be left blank!");
            }
            else if (!vid.IsMatch(textBox1.Text))
                {
                    e.Cancel = true;
                    textBox1.Focus();
                    errorProviderApp.SetError(textBox1, "Please enter a valid vehicle ID!");
                }
                    else
                    {
                        e.Cancel = false;
                        errorProviderApp.SetError(textBox1, "");
                    }
        }

        private void textBoxLicense_validate(object sender, CancelEventArgs e)
        {
            Regex lp = new Regex(@"\b[A-Z]{2,3}-[0-9]{4}$");
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProviderApp.SetError(textBox1, "License plate should not be left blank!");
            }
            else if (!lp.IsMatch(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProviderApp.SetError(textBox1, "Please enter a valid License Plate number!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(textBox1, "");
            }
        }*/
    }
}
