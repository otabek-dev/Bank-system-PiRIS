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

namespace BankClient_1
{
    public partial class AddNewUserForm : Form
    {
        MainForm mainForm = null;

        public AddNewUserForm()
        {
            InitializeComponent();
        }

        public AddNewUserForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataBase databaseCon = new DataBase();
            databaseCon.OpenConnection();
            var countCheker = 0;
            
            foreach (Control control in Controls)//цикл по всем контролам
            {
                if (control is TextBox)//если контрол является textbox-ом
                {
                    if (control.Text == "")//если textbox пустой
                    {
                        MessageBox.Show("Не все поля заполнены");//то вывести сообщение
                        countCheker++;
                        break;
                    }
                }
            }

            if (countCheker == 0)
            {
                var dateBirthday = string.Join("-", dateTimePicker_birthday.Text.Split('.').Reverse());
                var cmdText = $"INSERT INTO Users(FirstName, LastName, MiddleName, Age, PassportNumber, Birthday, " +
                    $"pol, gorodPro, phone, mail, work, identNumber, placeBirthday, addressPro, numberHome, doljnost, citizen, doxod ) " +
                    $"values('{textBoxName.Text}'," +
                    $"'{textBoxLastName.Text}'," +
                    $"'{textBoxMiddleName.Text}'," +
                    $"'{textBoxAge.Text}'," +
                    $"'{textBoxPassportNumber.Text}'," +
                    $"'{dateBirthday}'," +
                    $"N'{radioButton_jen.Text}'," +
                    $"'{textBox_gorodPro.Text}'," +
                    $"'{textBox_phone.Text}'," +
                    $"'{textBox_mail.Text}'," +
                    $"'{textBox_work.Text}'," +
                    $"'{textBox_idenNumber.Text}'," +
                    $"'{textBox_placeBirth.Text}'," +
                    $"'{textBox_addressPro.Text}'," +
                    $"'{textBox_phoneHome.Text}'," +
                    $"'{textBox_doljnost.Text}'," +
                    $"'{textBox_citizen.Text}'," +
                    $"'{textBox_doxod.Text}')";

                SqlCommand cmd = new SqlCommand(cmdText, databaseCon.GetConnection);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Добвлен новый пользователь!");
                    databaseCon.closeConnection();
                    this.Close();
                }
            }
        }

        private void AddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.UpdateDataGrid();
        }

        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }  
        }
    }
}
