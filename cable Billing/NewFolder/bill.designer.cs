namespace WindowsFormsApplication1.NewFolder
{
    partial class bill
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridbill = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.billgroupbox = new System.Windows.Forms.GroupBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnreport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnclose1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridbill)).BeginInit();
            this.billgroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.gridbill);
            this.panel2.Location = new System.Drawing.Point(32, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 203);
            this.panel2.TabIndex = 21;
            // 
            // gridbill
            // 
            this.gridbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridbill.Location = new System.Drawing.Point(12, 9);
            this.gridbill.Name = "gridbill";
            this.gridbill.Size = new System.Drawing.Size(488, 180);
            this.gridbill.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Customer ID";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(102, 28);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(81, 28);
            this.textBox4.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(323, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 28);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Name";
            // 
            // groupBox2
            // 
            this.billgroupbox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.billgroupbox.Controls.Add(this.label2);
            this.billgroupbox.Controls.Add(this.textBox2);
            this.billgroupbox.Controls.Add(this.textBox4);
            this.billgroupbox.Controls.Add(this.label8);
            this.billgroupbox.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billgroupbox.Location = new System.Drawing.Point(32, 45);
            this.billgroupbox.Name = "groupBox2";
            this.billgroupbox.Size = new System.Drawing.Size(514, 74);
            this.billgroupbox.TabIndex = 18;
            this.billgroupbox.TabStop = false;
            this.billgroupbox.Text = "Search Bill";
            this.billgroupbox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(443, 345);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(70, 31);
            this.btncancel.TabIndex = 23;
            this.btncancel.Text = "Exit";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnreport.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.Location = new System.Drawing.Point(70, 345);
            this.btnreport.Name = "btnsave";
            this.btnreport.Size = new System.Drawing.Size(92, 31);
            this.btnreport.TabIndex = 22;
            this.btnreport.Text = "Show All";
            this.btnreport.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(308, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 31);
            this.button1.TabIndex = 24;
            this.button1.Text = "Print All";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.btnclose1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose1.Location = new System.Drawing.Point(198, 345);
            this.btnclose1.Name = "button2";
            this.btnclose1.Size = new System.Drawing.Size(70, 31);
            this.btnclose1.TabIndex = 25;
            this.btnclose1.Text = "Print";
            this.btnclose1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(488, 180);
            this.dataGridView1.TabIndex = 1;
            // 
            // bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 590);
           // this.Controls.Add(this.btnclose2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncancel);
//            this.Controls.Add(this.btnreport);
//            this.Controls.Add(this.billgroupbox);
            this.Controls.Add(this.panel2);
            this.Name = "bill";
            this.Text = "bill";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridbill)).EndInit();
            this.billgroupbox.ResumeLayout(false);
            this.billgroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridbill;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}