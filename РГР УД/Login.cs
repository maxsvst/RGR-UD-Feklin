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

namespace РГР_УД
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void adminLoginButton_Click(object sender, EventArgs e)
        {
            //string adminLogin = adminLoginField.Text;
            //string adminPassword = adminPasswordField.Text;

            //DataBase DB = new DataBase();
            //DataTable table = new DataTable();
            //MySqlDataAdapter adapter = new MySqlDataAdapter();
            //MySqlCommand command = new MySqlCommand("mysql --user=@adminLogin --password --host=`localhost`", DB.getConnection());

            //command.Parameters.Add("@adminLogin", MySqlDbType.VarChar).Value = adminLogin;
            //command.Parameters.Add("@adminPassword", MySqlDbType.VarChar).Value = adminPassword;
            //adapter.SelectCommand = command;
            //adapter.Fill(table);

            //if (table.Rows.Count > 0)
            //{
            //    MessageBox.Show("Jopa");
            //}
            //else
            //{
            //    MessageBox.Show("123");
            //}





            string adminLog = "admin";
            string adminPass = "Barsik2020";
            if (adminLogin.Text == adminLog && adminPassword.Text == adminPass)
            {
                this.Hide();
                ChooseOperation F = new ChooseOperation();
                F.Show();
            }
            else
            {
                MessageBox.Show("Такого пользователя с правами администратора не существует");
            }



            //this.Hide();
            //ChooseOperation F = new ChooseOperation();
            //F.Show();
        }

        private void userLoginButton_Click(object sender, EventArgs e)
        {
            string userLog = "user";
            string userPass = "12345qwe";
            if (userLogin.Text == userLog && userPassword.Text == userPass) 
            {

                this.Hide();
                SelectOperation F = new SelectOperation();
                F.Show();
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует");
            }
        }
    }
}
