using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fw2
{
    public partial class Registration : Form
    {
        public string name;
        public string pass;
        public string email;
        public DateTime dob;
        public string phone;
        public Registration()
        {
            InitializeComponent();
        }

        private void lbldate_Click(object sender, EventArgs e)
        {

        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: " + this.name + " Password: " + this.pass + " Email: " + this.email + " Date Of Birth :" + dob + " Phone: " + phone);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = txtname.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            pass = textBox4.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            email = textBox2.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dob = DateTimePicker.MinimumDateTime;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            phone = textBox3.Text;
        }
    }
}
