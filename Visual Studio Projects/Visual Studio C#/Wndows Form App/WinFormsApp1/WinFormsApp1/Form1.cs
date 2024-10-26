namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Hello User!";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "CREATED";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "DELETED";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "SAVED";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 login_interface = new Form2();
            login_interface.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello User!";
        }
    }
}
