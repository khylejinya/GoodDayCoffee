using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GoodDayCoffee
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=KHYLE-PC;Initial Catalog=GoodDayCoffee;Integrated Security=True;Pooling=False");


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(txt_AdminId.Text, out parsedValue))
            {
                MessageBox.Show("Invalid Employee Number. Check if the data only consists of numbers");
            }
            else
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Admin WHERE AdminId=" + txt_AdminId.Text + " AND AdminPassword='" + txt_AdminPassword.Text + "'", conn);
                /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
                DataTable dt = new DataTable(); //this is creating a virtual table  
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                    this.Hide();
                    new MainMenu().Show();
                }
                else
                    MessageBox.Show("Invalid username or password");
                conn.Close();
            }
        }
    }
}
