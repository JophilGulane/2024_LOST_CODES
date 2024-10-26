namespace SignUp_App
{
    partial class Signup
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label2 = new Label();
            txtEmailAddress = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            lblTransaction = new Label();
            lblSMS = new Label();
            chkTransaction = new CheckBox();
            chkReports = new CheckBox();
            chkSMSNotification = new CheckBox();
            btnSignUp = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 71);
            label1.Name = "label1";
            label1.Size = new Size(132, 33);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(205, 64);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(881, 43);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(205, 132);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(881, 43);
            txtLastName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 139);
            label2.Name = "label2";
            label2.Size = new Size(131, 33);
            label2.TabIndex = 2;
            label2.Text = "Last Name:";
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.BorderStyle = BorderStyle.FixedSingle;
            txtEmailAddress.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailAddress.Location = new Point(205, 202);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(881, 43);
            txtEmailAddress.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 212);
            label3.Name = "label3";
            label3.Size = new Size(166, 33);
            label3.TabIndex = 4;
            label3.Text = "Email Address:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(lblTransaction);
            groupBox1.Controls.Add(lblSMS);
            groupBox1.Controls.Add(chkTransaction);
            groupBox1.Controls.Add(chkReports);
            groupBox1.Controls.Add(chkSMSNotification);
            groupBox1.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(33, 288);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1053, 278);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Services";
            // 
            // lblTransaction
            // 
            lblTransaction.AutoSize = true;
            lblTransaction.ForeColor = Color.Magenta;
            lblTransaction.Location = new Point(429, 192);
            lblTransaction.Name = "lblTransaction";
            lblTransaction.Size = new Size(51, 33);
            lblTransaction.TabIndex = 4;
            lblTransaction.Text = "......";
            // 
            // lblSMS
            // 
            lblSMS.AutoSize = true;
            lblSMS.BackColor = SystemColors.Control;
            lblSMS.ForeColor = Color.Magenta;
            lblSMS.Location = new Point(429, 54);
            lblSMS.Name = "lblSMS";
            lblSMS.Size = new Size(51, 33);
            lblSMS.TabIndex = 3;
            lblSMS.Text = "......";
            // 
            // chkTransaction
            // 
            chkTransaction.AutoSize = true;
            chkTransaction.Location = new Point(172, 192);
            chkTransaction.Name = "chkTransaction";
            chkTransaction.Size = new Size(241, 37);
            chkTransaction.TabIndex = 2;
            chkTransaction.Text = "Transaction Reports";
            chkTransaction.UseVisualStyleBackColor = true;
            chkTransaction.CheckedChanged += chkTransaction_CheckedChanged;
            // 
            // chkReports
            // 
            chkReports.AutoSize = true;
            chkReports.Location = new Point(172, 125);
            chkReports.Name = "chkReports";
            chkReports.Size = new Size(118, 37);
            chkReports.TabIndex = 1;
            chkReports.Text = "Reports";
            chkReports.UseVisualStyleBackColor = true;
            chkReports.CheckedChanged += chkReports_CheckedChanged;
            // 
            // chkSMSNotification
            // 
            chkSMSNotification.AutoSize = true;
            chkSMSNotification.Location = new Point(172, 54);
            chkSMSNotification.Name = "chkSMSNotification";
            chkSMSNotification.Size = new Size(201, 37);
            chkSMSNotification.TabIndex = 0;
            chkSMSNotification.Text = "SMS Notification";
            chkSMSNotification.UseVisualStyleBackColor = true;
            chkSMSNotification.CheckedChanged += chkSMSNotification_CheckedChanged;
            // 
            // btnSignUp
            // 
            btnSignUp.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignUp.Location = new Point(949, 597);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(137, 54);
            btnSignUp.TabIndex = 5;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 684);
            Controls.Add(btnSignUp);
            Controls.Add(groupBox1);
            Controls.Add(txtEmailAddress);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Name = "Signup";
            Text = "Sign Up";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtEmailAddress;
        private Label label3;
        private GroupBox groupBox1;
        private CheckBox chkTransaction;
        private CheckBox chkReports;
        private CheckBox chkSMSNotification;
        private Label lblTransaction;
        private Label lblSMS;
        private Button btnSignUp;
    }
}
