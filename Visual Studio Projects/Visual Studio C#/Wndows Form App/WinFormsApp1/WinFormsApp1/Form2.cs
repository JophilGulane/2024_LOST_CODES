using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            login();

        }

        private void login()
        {
            string user_id_text_box = user_id.Text;
            string user_pass_text_box = user_password.Text;

            if (user_id_text_box == "Jays" && user_pass_text_box == "12345")
            {
                this.Hide();
                Form1 app_interface = new Form1();

                app_interface.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect User ID or Password");
            }
        }

        private void user_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                login();
            }
            if (e.KeyChar == (char)Keys.F1)
            {
                resetMyForm();
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            resetMyForm();
        }

        private void resetMyForm()
        {
            user_id.Text = "";
            user_password.Text = "";
        }
    }
}
