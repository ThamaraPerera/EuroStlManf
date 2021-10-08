
namespace EuroStlManf
{
    partial class MonthlyDeliveryReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.deliverymanagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.delivery_managementDataSet = new EuroStlManf.delivery_managementDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.deliverymanagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delivery_managementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // deliverymanagementDataSetBindingSource
            // 
            this.deliverymanagementDataSetBindingSource.DataSource = this.delivery_managementDataSet;
            this.deliverymanagementDataSetBindingSource.Position = 0;
            // 
            // delivery_managementDataSet
            // 
            this.delivery_managementDataSet.DataSetName = "delivery_managementDataSet";
            this.delivery_managementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(267, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delivery report of the month";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 380);
            this.dataGridView1.TabIndex = 2;
            // 
            // MonthlyDeliveryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "MonthlyDeliveryReport";
            this.Text = "Monthly Delivery Report";
            this.Load += new System.EventHandler(this.WeeklyDeliveryReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deliverymanagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delivery_managementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource deliverymanagementDataSetBindingSource;
        private delivery_managementDataSet delivery_managementDataSet;
        private System.Windows.Forms.Label label1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}