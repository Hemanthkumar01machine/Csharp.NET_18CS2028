using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex9
{
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }

        private void signin_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string u=name_box.Text;
                string p=pass_box.Text;
                string dbconstring = "server=localhost;database=csharp;uid=Projects;pwd=myProjects;";
                MySqlConnection con = new MySqlConnection(dbconstring);
                con.Open();
                Console.WriteLine("Database Connected");

                string query = "select * from users";
                MySqlCommand command = new MySqlCommand(query, con);
                MySqlDataReader records= command.ExecuteReader();
                bool flag=false;

                while (records.Read())
                {
                    if (records.GetString(2).Equals(u) && records.GetString(3).Equals(p))
                    {
                        flag = true;
                        MessageBox.Show("Logged In", "User Account");
                    }
                }
                if (!flag)
                {
                    MessageBox.Show("Invalid Credentials", "User Account");
                }
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                name_box.Text = "";
                pass_box.Text = "";
            }
        }
    }
}
