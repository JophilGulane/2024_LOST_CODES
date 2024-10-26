namespace SignUp_App
{
    public partial class Signup : Form
    {

        public static string fName;
        public static string lName;
        public static string emailAddress;

        public static Boolean sms;
        public static Boolean report;
        public static Boolean transaction;
        Information info = new Information();

        public Signup()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            fName = txtFirstName.Text;
            lName = txtLastName.Text;
            emailAddress = txtEmailAddress.Text;

            info.Show();
        }

        private void chkSMSNotification_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSMSNotification.Checked)
            {
                sms = true;
                lblSMS.Text = "SMS Notification Services Charges may Apply";
            }
            else
            {
                sms = false;
                lblSMS.Text = "......";
            }
        }

        private void chkReports_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReports.Checked)
            {
                report = true;
            }
            else
            {
                report = false;
            }
        }

        private void chkTransaction_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTransaction.Checked)
            {
                transaction = true;
                lblTransaction.Text = "Transaction Services Charges may Apply";
            }
            else
            {
                transaction = false;
                lblTransaction.Text = "......";
            }
        }
    }
}
