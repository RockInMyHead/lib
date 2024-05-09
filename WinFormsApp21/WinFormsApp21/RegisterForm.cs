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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MySql.Data.MySqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Text;

namespace WinFormsApp21
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        string connectionString = "Server=127.0.0.1;Database=mydb;User Id=root;Password=135797531AaA;"; // Данные от  SQL сервера
        private void button3_Click(object sender, EventArgs e)
        {
            string login = textBox2.Text;
            string name = textBox3.Text;
            string password = textBox1.Text;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = $"INSERT INTO mydb.пользователь (`ФИО`,`Логин`, `Пароль`) VALUES ('{name}','{login}','{password}');";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        label2.Text = "Регистрация прошла успешно, пожалуйста зайдите теперь под своим аккаунтом";
                    }
                }
                connection.Close();
            }
        }
    }
}
