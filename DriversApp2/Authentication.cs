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

namespace DriversApp2
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }
        public int I;
        private int count = 1;
        private void ButtonAuthentication_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = С:\Users\79686\source\repos\DriversApp2\DriversApp2\DriversDatabase.mdf; Integrated Security = True");
            I = 0;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [Authentication] WHERE Login ='" + textBoxLogin.Text + "' AND Password ='" + textBoxPassword.Text + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            I = Convert.ToInt32(dt.Rows.Count.ToString());
            if (I == 0)
            {
                MessageBox.Show("Authentication error!");
                if (count++ == 5)
                {
                    MessageBox.Show("Exceeded the allowed number of attempts! Change your password.");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Authentication success!");
                this.Hide();
                Drivers f = new Drivers();
                f.Show();
            }
            con.Close();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
