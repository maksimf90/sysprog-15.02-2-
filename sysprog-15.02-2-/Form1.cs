using System;
using Npgsql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;

namespace sysprog_15._02_2_
{
    public partial class Form1 : Form
    {
        private int loginAttempts = 0;
        private bool isFormLocked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void loginbtn_Click(object sender, EventArgs e)
        {
            string login = Login.Text;
            string password = Password.Text;

            string connectionstring = ("host=localhost;port=5432;username=postgres;database=people;password=11111");

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionstring))
            {
                connection.Open();

                string query = ("SELECT COUNT (*) FROM users WHERE Login = @login AND Password = @password");

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("Login", login);
                    command.Parameters.AddWithValue("Password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Авторизация прошла успешно");
                        loginAttempts = 0;
                    }
                    else
                    {
                        MessageBox.Show("Данные неверны");
                        loginAttempts++;

                        if (loginAttempts > 3)
                        {
                            Form2 form2 = new Form2();
                            form2.ShowDialog();

                            if (form2.DialogResult == DialogResult.OK)
                            {
                                loginAttempts = 0;
                            }

                        }
                        
                    }

                }

            }

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
