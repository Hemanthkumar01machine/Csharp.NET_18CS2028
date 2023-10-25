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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
            
        }

        private void submit_Click(object sender, EventArgs e)
        {   try
            {
                string n = name_box.Text;
                string email = email_box.Text;
                string u = uname_box.Text;
                string p = pass_box.Text;
                string dbconstring = "server=localhost;database=csharp;uid=Projects;pwd=myProjects;";
                MySqlConnection con = new MySqlConnection(dbconstring);
                con.Open();
                Console.WriteLine("Database Connected");

                //string query = "CREATE TABLE IF NOT EXISTS users (Name varchar(25), User_Email varchar(25), Username varchar(25), Password varchar(15));";
                
                //MySqlCommand command=new MySqlCommand(query, con);
                //command.ExecuteNonQuery();

                
                string query = "insert into users values(@data1,@data2,@data3,@data4)";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@data1",n);
                command.Parameters.AddWithValue("@data2",email);
                command.Parameters.AddWithValue("@data3",u);
                command.Parameters.AddWithValue("@data4",p);
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Account Created Successfully", "Account Creation Status");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
            finally
            {
                
                name_box.Text = "";
                email_box.Text = "";
                uname_box.Text = "";
                pass_box.Text = "";
            }


            


        }
    }
}
