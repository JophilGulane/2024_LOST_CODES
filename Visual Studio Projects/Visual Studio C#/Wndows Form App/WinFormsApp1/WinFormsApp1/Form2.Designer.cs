namespace WinFormsApp1
{
    partial class Form2
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
            label1 = new Label();
            user_id = new TextBox();
            label2 = new Label();
            user_password = new TextBox();
            login_btn = new Button();
            reset_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Mincho Demibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label1.Location = new Point(46, 90);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 0;
            label1.Text = "User ID:";
            label1.Click += label1_Click;
            // 
            // user_id
            // 
            user_id.Location = new Point(174, 90);
            user_id.Name = "user_id";
            user_id.Size = new Size(552, 27);
            user_id.TabIndex = 1;
            user_id.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Mincho Demibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label2.Location = new Point(46, 154);
            label2.Name = "label2";
            label2.Size = new Size(122, 30);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            label2.Click += label2_Click;
            // 
            // user_password
            // 
            user_password.Location = new Point(174, 154);
            user_password.Name = "user_password";
            user_password.PasswordChar = '*';
            user_password.Size = new Size(552, 27);
            user_password.TabIndex = 3;
            user_password.KeyPress += user_password_KeyPress;
            // 
            // login_btn
            // 
            login_btn.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.Location = new Point(174, 311);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(151, 61);
            login_btn.TabIndex = 4;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // reset_btn
            // 
            reset_btn.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reset_btn.Location = new Point(417, 311);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(151, 61);
            reset_btn.TabIndex = 5;
            reset_btn.Text = "Reset";
            reset_btn.UseVisualStyleBackColor = true;
            reset_btn.Click += reset_btn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reset_btn);
            Controls.Add(login_btn);
            Controls.Add(user_password);
            Controls.Add(label2);
            Controls.Add(user_id);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox user_id;
        private Label label2;
        private TextBox user_password;
        private Button login_btn;
        private Button reset_btn;
    }
}