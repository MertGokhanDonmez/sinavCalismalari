using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string username;

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();

        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        public void doList()
        {
            con = new SqlConnection(
                "server=LAPTOP-Q640SRQG;" +
                "Initial Catalog=csharpExam;" +
                "Integrated Security=True"
                );
            da = new SqlDataAdapter("Select * From notes", con);
            ds = new DataSet();

            

            con.Open();
            da.Fill(ds, "note");
            dgw.DataSource = ds.Tables["note"];

            con.Close();
            
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            lbl_user.Text = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doList();
        }
    }
}
