using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;

namespace BankClient_1
{
    public partial class AddNewDepositForm : Form
    {
        DataBase dataBase = new DataBase();
        decimal monthlyIncome = 0;

        public AddNewDepositForm()
        {
            InitializeComponent();
            dateTimePicker_startDate.MinDate = DateTime.Now;
            dateTimePicker_endDate.MinDate = DateTime.Now;
        }

        private void button_addNewDeposit_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            double result = r.NextDouble();
            
            dataBase.OpenConnection();

            var createdDate = string.Join("-", dateTimePicker_startDate.Text.Split('.').Reverse());
            var endDate = string.Join("-", dateTimePicker_endDate.Text.Split('.').Reverse());

            var cmdText = "INSERT INTO deposit(userID, TypeBill, TypeDeposit, Deposit, Procent, Currency, CreatedDate,EndDate, MonthlyIncome, ContractId, BillNumber)" +
                $"values ('{textBox_userID.Text}'," +
                $"N'Основной'," +
                $"N'{comboBox_typeDeposit.Text}', " +
                $"{textBox_deposit.Text}, " +
                $"{textBox_procent.Text}, " +
                $"'{comboBox_currency.Text}', " +
                $"'{createdDate}', " +
                $"'{endDate}', " +
                $"'{monthlyIncome.ToString()}', " +
                $"{textBox_contractID.Text}, " +
                $"'{(long)(result * Math.Pow(10, 13))}');";
            //result* Math.Pow(10, 13)
            //(long)(result * Math.Pow(10, 13))

            var cmdText2 = "INSERT INTO deposit(userID, TypeBill, TypeDeposit, Deposit, Procent, Currency, CreatedDate,EndDate, MonthlyIncome, ContractId, BillNumber)" +
                $"values ('{textBox_userID.Text}'," +
                $"N'Процентный'," +
                $"N'{comboBox_typeDeposit.Text}', " +
                $"{0}, " +
                $"{textBox_procent.Text}, " +
                $"'{comboBox_currency.Text}', " +
                $"'{createdDate}', " +
                $"'{endDate}', " +
                $"'{monthlyIncome.ToString()}', " +
                $"{(double.Parse(textBox_contractID.Text) + 1).ToString()}, " +
                $"'{(long)(result * Math.Pow(10, 13))}');";

            SqlCommand command = new SqlCommand(cmdText, dataBase.GetConnection);
            SqlCommand command2 = new SqlCommand(cmdText2, dataBase.GetConnection);

            try
            {
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                MessageBox.Show("Успешно!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.Normalize(), "Ошибка при выполнении запроса!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_rate_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker_endDate.Value = DateTime.Now;

            if (comboBox_typeDeposit.SelectedIndex == 0)
            {
                if (comboBox_rate.SelectedIndex == 0) 
                { 
                    textBox_procent.Text = "12";
                    dateTimePicker_endDate.Value = dateTimePicker_endDate.Value.AddMonths(13);
                }
                else if (comboBox_rate.SelectedIndex == 1)
                {
                    textBox_procent.Text = "19";
                    dateTimePicker_endDate.Value = dateTimePicker_endDate.Value.AddMonths(19);
                }
            }
            else if (comboBox_typeDeposit.SelectedIndex == 1)
            {
                if (comboBox_rate.SelectedIndex == 0)
                {   
                    textBox_procent.Text = "14"; 
                    dateTimePicker_endDate.Value = dateTimePicker_endDate.Value.AddMonths(6);
                }
                else if (comboBox_rate.SelectedIndex == 1)
                {
                    textBox_procent.Text = "9"; 
                    dateTimePicker_endDate.Value = dateTimePicker_endDate.Value.AddMonths(9);
                }
            }
            monthlyIncome = decimal.Round((decimal.Parse(textBox_deposit.Text) * (decimal.Parse(textBox_procent.Text) / 100)) / 12);
            textBox_monthlyIncome.Text = int.Parse(monthlyIncome.ToString()).ToString();
        }

        private void comboBox_typeDeposit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_typeDeposit.SelectedIndex == 0)
            {
                comboBox_rate.Items.Clear();
                comboBox_rate.Items.Add("12% (процентов) за 13 месяцев");
                comboBox_rate.Items.Add("19% (процентов) за 24 месяцев");
            }
            else if (comboBox_typeDeposit.SelectedIndex == 1)
            {
                comboBox_rate.Items.Clear();
                comboBox_rate.Items.Add("14% (процентов) за 6 месяцев");
                comboBox_rate.Items.Add("9% (процентов) за 9 месяцев");
            }
        }
    }
}
