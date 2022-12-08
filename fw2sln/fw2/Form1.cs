namespace fw2
{
    public partial class Form1 : Form
    {
        public string uName ="Tanvir";
        public string pass="1234";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == uName && textBox2.Text == pass)
            {
                MessageBox.Show("Successful");
            }
            else {
                MessageBox.Show("Failed");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration r = new Registration();
            this.Hide();
            r.Show();
        }
    }
}