using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Resize Border
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            //NavBar
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;

            //Adding other forms to main form
            this.panel5.Controls.Clear();
            formHome FrmHome_Vrb = new formHome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmHome_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel5.Controls.Add(FrmHome_Vrb);
            FrmHome_Vrb.Show();

        }


        //Creating resizable form
        private const int cGrip = 16;
        private const int cCaption = 32;

        protected override void WndProc(ref Message m)
        {

            if (m.Msg == 0x84)
            {

                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);

                if (pos.Y < cCaption)
                {

                    m.Result = (IntPtr)2;
                    return;
                }

                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {

                    m.Result = (IntPtr)17;
                    return;

                }
            }

                base.WndProc(ref m);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //NavBar
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;

            //Adding other forms to main form
            this.panel5.Controls.Clear();
            formHome FrmHome_Vrb = new formHome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmHome_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel5.Controls.Add(FrmHome_Vrb);
            FrmHome_Vrb.Show();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //NavBar
            panel3.Height = button2.Height;
            panel3.Top = button2.Top;

            //Adding other forms to main form
            this.panel5.Controls.Clear();
            formSalaryAndAttend FrmSalaryAndAttend_Vrb = new formSalaryAndAttend() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmSalaryAndAttend_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel5.Controls.Add(FrmSalaryAndAttend_Vrb);
            FrmSalaryAndAttend_Vrb.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //NavBar
            panel3.Height = button5.Height;
            panel3.Top = button5.Top;

            //Adding other forms to main form
            this.panel5.Controls.Clear();
            formCustomer FrmCustomer_Vrb = new formCustomer() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmCustomer_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel5.Controls.Add(FrmCustomer_Vrb);
            FrmCustomer_Vrb.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //NavBar
            panel3.Height = button6.Height;
            panel3.Top = button6.Top;

            //Adding other forms to main form
            this.panel5.Controls.Clear();
            formDeliveryAndTransport FrmDeliveryAndTransport_Vrb = new formDeliveryAndTransport() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDeliveryAndTransport_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel5.Controls.Add(FrmDeliveryAndTransport_Vrb);
            FrmDeliveryAndTransport_Vrb.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //NavBar
            panel3.Height = button3.Height;
            panel3.Top = button3.Top;

            //Adding other forms to main form
            this.panel5.Controls.Clear();
            formSupplier FrmSupplier_Vrb = new formSupplier() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmSupplier_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel5.Controls.Add(FrmSupplier_Vrb);
            FrmSupplier_Vrb.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //NavBar
            panel3.Height = button4.Height;
            panel3.Top = button4.Top;

            //Adding other forms to main form
            this.panel5.Controls.Clear();
            formEmployee FrmEmployee_Vrb = new formEmployee() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmEmployee_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel5.Controls.Add(FrmEmployee_Vrb);
            FrmEmployee_Vrb.Show();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //NavBar
            panel3.Height = button7.Height;
            panel3.Top = button7.Top;

            //Adding other forms to main form
            this.panel5.Controls.Clear();
            formOrder FrmOrder_Vrb = new formOrder() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmOrder_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel5.Controls.Add(FrmOrder_Vrb);
            FrmOrder_Vrb.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonMaximiz_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {

                WindowState = FormWindowState.Maximized;

            }
            else
            {

                WindowState = FormWindowState.Normal;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
