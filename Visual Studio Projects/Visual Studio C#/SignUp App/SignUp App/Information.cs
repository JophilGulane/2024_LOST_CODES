using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUp_App
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void Information_Load(object sender, EventArgs e)
        {
            lblFName.Text = Signup.fName;
            lblLName.Text = Signup.lName;
            lblEmailAddress.Text = Signup.emailAddress;

            if (Signup.sms == true)
            {
                lblSMS.Text = "✓";
            }
            else if (Signup.report == true)
            {
                lblReport.Text = "✓";
            }
            else if (Signup.transaction == true)
            {
                lblTransaction.Text = "✓";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup sign = new Signup();
            sign.Show();
        }
    }
}
