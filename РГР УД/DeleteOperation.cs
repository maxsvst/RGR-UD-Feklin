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
    public partial class DeleteOperation : Form
    {
        string[] airlines = { "Номер авиакомпании", "Название авиакомпании", "Представитель авиакомпании" };
        string[] airplanes = { "Номер борта", "Название самолёта", "Количество мест", "Наличие бизнес", "Название авиакомпании" };
        string[] flights = { "Номер рейса", "Время посадки", "Аэропорт прибытия", "Выход(gates)", "Статус рейса", "Номер борта" };
        string[] tickets = { "Номер билета", "Номер места", "Номер пассажира", "Дата вылета", "Класс места", "Аэропорт отправления", "Время отправления", "Время прибытия", "Тип билета", "Номер рейса" };
        string[] passengers = { "Номер пассажира", "ФИО пассажира", "Паспорт(серия, номер)", "Дата рождения", "Пол пассажира", "Почта пассажира" };
        public DeleteOperation()
        {
            InitializeComponent();
            CB0.Text = "Все";
            CB1.Visible = false;
            CB2.Visible = false;
            CB3.Visible = false;
            CB4.Visible = false;
            CB5.Visible = false;
            CB6.Visible = false;
            CB7.Visible = false;
            CB8.Visible = false;
            CB9.Visible = false;
            CB10.Visible = false;
        }

        private void Table_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Table.SelectedIndex == 0)
            {
                CB1.Visible = true;
                CB2.Visible = true;
                CB3.Visible = true;
                CB1.Text = airlines[0];
                CB2.Text = airlines[1];
                CB3.Text = airlines[2];
                CB4.Visible = false;
                CB5.Visible = false;
                CB6.Visible = false;
                CB7.Visible = false;
                CB8.Visible = false;
                CB9.Visible = false;
                CB10.Visible = false;
            }
            else if (Table.SelectedIndex == 1)
            {
                CB1.Visible = true;
                CB2.Visible = true;
                CB3.Visible = true;
                CB4.Visible = true;
                CB5.Visible = true;
                CB1.Text = airplanes[0];
                CB2.Text = airplanes[1];
                CB3.Text = airplanes[2];
                CB4.Text = airplanes[3];
                CB5.Text = airplanes[4];
                CB6.Visible = false;
                CB7.Visible = false;
                CB8.Visible = false;
                CB9.Visible = false;
                CB10.Visible = false;
            }
            else if (Table.SelectedIndex == 2)
            {
                CB1.Visible = true;
                CB2.Visible = true;
                CB3.Visible = true;
                CB4.Visible = true;
                CB5.Visible = true;
                CB6.Visible = true;
                CB1.Text = flights[0];
                CB2.Text = flights[1];
                CB3.Text = flights[2];
                CB4.Text = flights[3];
                CB5.Text = flights[4];
                CB6.Text = flights[5];
                CB7.Visible = false;
                CB8.Visible = false;
                CB9.Visible = false;
                CB10.Visible = false;
            }
            else if (Table.SelectedIndex == 3)
            {
                CB1.Visible = true;
                CB2.Visible = true;
                CB3.Visible = true;
                CB4.Visible = true;
                CB5.Visible = true;
                CB6.Visible = true;
                CB7.Visible = true;
                CB8.Visible = true;
                CB9.Visible = true;
                CB10.Visible = true;
                CB1.Text = tickets[0];
                CB2.Text = tickets[1];
                CB3.Text = tickets[2];
                CB4.Text = tickets[3];
                CB5.Text = tickets[4];
                CB6.Text = tickets[5];
                CB7.Text = tickets[6];
                CB8.Text = tickets[7];
                CB9.Text = tickets[8];
                CB10.Text = tickets[9];
            }
            else if (Table.SelectedIndex == 4)
            {
                CB1.Visible = true;
                CB2.Visible = true;
                CB3.Visible = true;
                CB4.Visible = true;
                CB5.Visible = true;
                CB6.Visible = true;
                CB1.Text = passengers[0];
                CB2.Text = passengers[1];
                CB3.Text = passengers[2];
                CB4.Text = passengers[3];
                CB5.Text = passengers[4];
                CB6.Text = passengers[5];
                CB7.Visible = false;
                CB8.Visible = false;
                CB9.Visible = false;
                CB10.Visible = false;
            }
        }


        private void CB0_Click(object sender, EventArgs e)
        {
            if (CB0.Checked)
            {
                CB1.Checked = true;
                CB2.Checked = true;
                CB3.Checked = true;
                CB4.Checked = true;
                CB5.Checked = true;
                CB6.Checked = true;
                CB7.Checked = true;
                CB8.Checked = true;
                CB9.Checked = true;
                CB10.Checked = true;
            }
            else if (CB0.Checked == false)
            {
                CB1.Checked = false;
                CB2.Checked = false;
                CB3.Checked = false;
                CB4.Checked = false;
                CB5.Checked = false;
                CB6.Checked = false;
                CB7.Checked = false;
                CB8.Checked = false;
                CB9.Checked = false;
                CB10.Checked = false;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseOperation CO = new ChooseOperation();
            CO.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string table = null;
            string attr = null;
            string value = null;
            if (Table.SelectedIndex == 0)
            {
                table = "airline";
            }
            else if(Table.SelectedIndex == 1)
            {
                table = " airplane ";
            }
            else if (Table.SelectedIndex == 2)
            {
                table = "flight";
            }
            else if (Table.SelectedIndex == 3)
            {
                table = "ticket";
            }
            else if (Table.SelectedIndex == 4)
            {
                table = "passenger";
            }

            attr = CB0.Text;

            value = Condition.Text;

            DataBase DB = new DataBase();
            DataTable DT = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("DELETE FROM @table WHERE @attr = @value", DB.getConnection());

            command.Parameters.Add("@table", MySqlDbType.VarChar).Value = table;
            command.Parameters.Add("@attr", MySqlDbType.VarChar).Value = attr;
            command.Parameters.Add("@value", MySqlDbType.VarChar).Value = value;

            DB.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Запись удалена");
            else
                MessageBox.Show("Удаление не удалось");

            DB.closeConnection();
        }
    }
}
