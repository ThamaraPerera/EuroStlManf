﻿using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EuroStlManf
{
    public partial class formDeliveryAndTransport : Form
    {
        public formDeliveryAndTransport()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=delivery_management;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Deliverydetailsform dlf = new Deliverydetailsform();
            dlf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vehicledetailsform vdf = new Vehicledetailsform();
            vdf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Breakdowndetailsform bdf = new Breakdowndetailsform();
            bdf.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MonthlyDeliveryReport mdr = new MonthlyDeliveryReport();
            mdr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MonthlyBreakdownReport mbr = new MonthlyBreakdownReport();
            mbr.Show();
        }

        public void BindDataV()
        {
            SqlCommand command = new SqlCommand("select VID,licensePlate,type,status from Vehicle_data where status='In' ", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void BindDataD()
        {
            SqlCommand command = new SqlCommand("select DID,empID,orderID,VID,destination from Delivery_data ORDER BY deliveryDate DESC", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        public void BindDataB()
        {
            SqlCommand command = new SqlCommand("select BID,empID,VID,orderID,location from Breakdown_data ORDER BY date DESC", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView3.DataSource = dt;
        }

        private void formDeliveryAndTransport_Load(object sender, EventArgs e)
        {
            BindDataV();
            BindDataD();
            BindDataB();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
