namespace cable_Billing.NewFolder
{
    partial class SMS
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.servergroupbox = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.backupbtnpanel = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsend = new System.Windows.Forms.Button();
            this.btnclosesms = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbservername = new System.Windows.Forms.ComboBox();
            this.cmbdatabasename = new System.Windows.Forms.ComboBox();
            this.txtmsgmono = new System.Windows.Forms.TextBox();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.servergroupbox.SuspendLayout();
            this.backupbtnpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select Server Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Select Database Name";
            // 
            // servergroupbox
            // 
            this.servergroupbox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.servergroupbox.Controls.Add(this.btnbrowse);
            this.servergroupbox.Controls.Add(this.txtmsgmono);
            this.servergroupbox.Controls.Add(this.cmbdatabasename);
            this.servergroupbox.Controls.Add(this.cmbservername);
            this.servergroupbox.Controls.Add(this.label4);
            this.servergroupbox.Controls.Add(this.label14);
            this.servergroupbox.Controls.Add(this.label2);
            this.servergroupbox.Controls.Add(this.label1);
            this.servergroupbox.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servergroupbox.Location = new System.Drawing.Point(30, 76);
            this.servergroupbox.Name = "servergroupbox";
            this.servergroupbox.Size = new System.Drawing.Size(604, 122);
            this.servergroupbox.TabIndex = 28;
            this.servergroupbox.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 217);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 18);
            this.label14.TabIndex = 1;
            // 
            // backupbtnpanel
            // 
            this.backupbtnpanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.backupbtnpanel.Controls.Add(this.label3);
            this.backupbtnpanel.Controls.Add(this.btnsend);
            this.backupbtnpanel.Controls.Add(this.btnclosesms);
            this.backupbtnpanel.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupbtnpanel.Location = new System.Drawing.Point(30, 221);
            this.backupbtnpanel.Name = "backupbtnpanel";
            this.backupbtnpanel.Size = new System.Drawing.Size(604, 52);
            this.backupbtnpanel.TabIndex = 29;
            this.backupbtnpanel.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 1;
            // 
            // btnbackup
            // 
            this.btnsend.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsend.Location = new System.Drawing.Point(178, 12);
            this.btnsend.Name = "btnbackup";
            this.btnsend.Size = new System.Drawing.Size(103, 32);
            this.btnsend.TabIndex = 22;
            this.btnsend.Text = "Back up";
            this.btnsend.UseVisualStyleBackColor = true;
            // 
            // btnclose
            // 
            this.btnclosesms.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclosesms.Location = new System.Drawing.Point(328, 12);
            this.btnclosesms.Name = "btnclose";
            this.btnclosesms.Size = new System.Drawing.Size(111, 31);
            this.btnclosesms.TabIndex = 25;
            this.btnclosesms.Text = "Close";
            this.btnclosesms.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Choose Database Path";
            // 
            // cmbservername
            // 
            this.cmbservername.FormattingEnabled = true;
            this.cmbservername.Location = new System.Drawing.Point(227, 7);
            this.cmbservername.Name = "cmbservername";
            this.cmbservername.Size = new System.Drawing.Size(260, 29);
            this.cmbservername.TabIndex = 30;
            // 
            // cmbdatabasename
            // 
            this.cmbdatabasename.FormattingEnabled = true;
            this.cmbdatabasename.Location = new System.Drawing.Point(227, 46);
            this.cmbdatabasename.Name = "cmbdatabasename";
            this.cmbdatabasename.Size = new System.Drawing.Size(260, 29);
            this.cmbdatabasename.TabIndex = 32;
            // 
            // txtdatabase
            // 
            this.txtmsgmono.Location = new System.Drawing.Point(227, 81);
            this.txtmsgmono.Name = "txtdatabase";
            this.txtmsgmono.Size = new System.Drawing.Size(260, 28);
            this.txtmsgmono.TabIndex = 33;
            // 
            // btnbrowse
            // 
            this.btnbrowse.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowse.Location = new System.Drawing.Point(493, 78);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(103, 32);
            this.btnbrowse.TabIndex = 34;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(293, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 33);
            this.label5.TabIndex = 30;
            this.label5.Text = "BackUp ";
            // 
            // backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 291);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.backupbtnpanel);
            this.Controls.Add(this.servergroupbox);
            this.Name = "backup";
            this.Text = "Backup";
            this.servergroupbox.ResumeLayout(false);
            this.servergroupbox.PerformLayout();
            this.backupbtnpanel.ResumeLayout(false);
            this.backupbtnpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox servergroupbox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbdatabasename;
        private System.Windows.Forms.ComboBox cmbservername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox backupbtnpanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnbackup;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.TextBox txtdatabase;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.Label label5;

    }
}