using System.Data.SqlClient;

namespace soru2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;


        public void btn_login_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM users where u_name=@user AND u_pass=@pass";

            con = new SqlConnection(
                "server=LAPTOP-Q640SRQG;" +
                "Initial Catalog=csharpExam;" +
                "Integrated Security=True"
                );
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@user", txt_user.Text);
            cmd.Parameters.AddWithValue("@pass", txt_pass.Text);

            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                
                Form2 f2 = new Form2();
                f2.username = txt_user.Text;
                f2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Please check your user name or password.");
            }


            con.Close();

        }
    }
}