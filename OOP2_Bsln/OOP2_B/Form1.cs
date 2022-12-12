using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace OOP2_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form1_Load();
        }

        string cs = "Data Source=DESKTOP-5RQSKVH\\SQLEXPRESS;Initial Catalog=SchoolManagementDB;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;
        
        private void Form1_Load()
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Student", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_BTN_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Student where S_name like '" + textBox1.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id =dataGridView1.Rows[e.RowIndex].Cells["S_ID"].Value.ToString();
            string name = dataGridView1.Rows[e.RowIndex].Cells["S_name"].Value.ToString();
            
            string sClass = dataGridView1.Rows[e.RowIndex].Cells["S_Class"].Value.ToString();
            string cgpa = dataGridView1.Rows[e.RowIndex].Cells["S_CGPA"].Value.ToString();

             textBox2.Text=id;
            textBox3.Text = name;
            textBox4.Text = sClass;
            textBox5.Text = cgpa;

            /*con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Student", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            string query1="Update Student set S_name= '"+textBox3.Text+"',S_class='"+textBox4.Text+"',S_CGPA='"+textBox5.Text+"' Where S_ID =" +textBox2.Text;
            SqlCommand cmd = new SqlCommand(query1,con);
            cmd.ExecuteNonQuery();
            Form1_Load();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            string query1 = "DELETE FROM Student Where S_ID =" + textBox2.Text;
            SqlCommand cmd = new SqlCommand(query1, con);
            cmd.ExecuteNonQuery();
            Form1_Load();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
          

            string query1 = "INSERT INTO Student( S_name, S_Class, S_CGPA) VALUES('"+textBox3.Text+"', '"+textBox4.Text+"', '"+textBox5.Text+"')";
            SqlCommand cmd = new SqlCommand(query1, con);
            cmd.ExecuteNonQuery();
            Form1_Load();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1_Load();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
    }
