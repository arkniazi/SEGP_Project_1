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

namespace SEGP
{
    public partial class Login : Form
    {
        MySqlConnection myConnection = new MySqlConnection("SERVER=localhost;DATABASE=segp1;UID=root;Password=");
        MySqlCommand command = new MySqlCommand();
        MySqlDataReader read = null;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                myConnection.Open();
                command = myConnection.CreateCommand();
                command.CommandText = "select * from login";
                read = command.ExecuteReader();
                while (read.Read())
                {
                    String user = read.GetString(0);
                    String password = read.GetString(1);
                    if (user.Equals(textBox1.Text) && password.Equals(textBox2.Text))
                    {
                        this.Hide();
                        new Main().Show();

                    }
                    else
                    {
                        MessageBox.Show("Your Username or Password is incorrect!");
                    }
                }
            }
            catch(Exception a)
            {
                MessageBox.Show("Error:"+a);
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
