using BankClient_1.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace BankClient_1
{
    public partial class AddNewDepositForm : Form
    {
        DataBase dataBase = new DataBase();
        CultureInfo culture = CultureInfo.InvariantCulture;
        decimal monthlyIncome = 0;
        byte BillNumberLength = 13;

        public AddNewDepositForm()
        {
            InitializeComponent();
            comboBox_currency.Enabled = false;
            comboBox_typeDeposit.Enabled = false;
            //textBox_monthlyIncome.Enabled = false;
            textBox_procent.Enabled = false;
            textBox_contractID.Enabled = false;
            
            dateTimePicker_startDate.Enabled = false;
            dateTimePicker_endDate.Enabled = false;

            dateTimePicker_startDate.MinDate = DateTime.Now;
            dateTimePicker_endDate.MinDate = DateTime.Now;
        }

        private void button_addNewDeposit_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            string billNumber = string.Empty;
            var createdDate = string.Join("-", dateTimePicker_startDate.Text.Split('.').Reverse());
            var endDate = string.Join("-", dateTimePicker_endDate.Text.Split('.').Reverse());

            for (int i = 0; i < BillNumberLength; i++)
            {
                billNumber += r.Next(10);
            }

            var cmdTextPrimary = "INSERT INTO deposit(userID, TypeBill, TypeDeposit, Deposit, Procent, Currency, CreatedDate,EndDate, MonthlyIncome, ContractId, BillNumber)" +
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
                $"'{billNumber}');";

            var cmdTextPercent = "INSERT INTO deposit(userID, TypeBill, TypeDeposit, Deposit, Procent, Currency, CreatedDate,EndDate, MonthlyIncome, ContractId, BillNumber)" +
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
                $"'{billNumber}');";

            SqlCommand command = new SqlCommand(cmdTextPrimary, dataBase.GetConnection);
            SqlCommand command2 = new SqlCommand(cmdTextPercent, dataBase.GetConnection);

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

        private void AddNewDepositForm_Load(object sender, EventArgs e)
        {
            dataBase.OpenConnection();

            string cmd = "SELECT * FROM ChartOfAccounts";
            SqlCommand command = new SqlCommand(cmd, dataBase.GetConnection);
            SqlDataReader reader = command.ExecuteReader();
            List<Chart> chartList = new List<Chart>();

            while (reader.Read())
            {
                var chart = new Chart(
                    typeDeposit: reader["TypeDeposit"].ToString(),
                    currency: reader["Currency"].ToString(),
                    percentage: byte.Parse(reader["Percentages"].ToString()),
                    durationInMonths: byte.Parse(reader["DurationInMonths"].ToString()),
                    chartName: reader["ChartName"].ToString(),
                    id: int.Parse(reader["Id"].ToString()));

                chartList.Add(chart);
            }

            comboBox4_ChartAcc.DataSource = chartList;
            comboBox4_ChartAcc.DisplayMember = "ChartName";
            comboBox4_ChartAcc.ValueMember = "Id";

            textBox_contractID.Text = ((int)(Math.Pow(10,8) * new Random().NextDouble())).ToString();

            UpdateFieldsWhenChartSelectionChangeCommitted();
        }

        private void comboBox4_ChartAcc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UpdateFieldsWhenChartSelectionChangeCommitted();
        }

        private void UpdateFieldsWhenChartSelectionChangeCommitted()
        {
            if (comboBox4_ChartAcc.SelectedItem is Chart)
            {
                Chart chart = comboBox4_ChartAcc.SelectedItem as Chart;

                comboBox_currency.Text = chart.Currency;
                comboBox_typeDeposit.Text = chart.TypeDeposit;
                textBox_procent.Text = chart.Percentage.ToString();
                
                dateTimePicker_endDate.Value = DateTime.Now;
                dateTimePicker_endDate.Value = dateTimePicker_endDate.Value.AddMonths(chart.DurationInMonths);

                textBox_deposit_TextChanged(this, EventArgs.Empty);
            }
        }

        private void textBox_deposit_TextChanged(object sender, EventArgs e)
        {
            if (textBox_deposit.Text != string.Empty)
            {
                monthlyIncome = (decimal.Parse(textBox_deposit.Text, culture) * (decimal.Parse(textBox_procent.Text, culture) / 100)) / 12;
                textBox_monthlyIncome.Text = monthlyIncome.ToString(culture);
            }
            else
            {
                textBox_monthlyIncome.Text = string.Empty;
            }
        }

        private void textBox_deposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
