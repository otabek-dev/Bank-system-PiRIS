using System;
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
            dateTimePicker_startDate.MinDate = DateTime.Now;
            dateTimePicker_endDate.MinDate = DateTime.Now;
        }

        private void button_addNewDeposit_Click(object sender, EventArgs e)
        {
            dataBase.OpenConnection();
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

            monthlyIncome = (decimal.Parse(textBox_deposit.Text, culture) * (decimal.Parse(textBox_procent.Text, culture) / 100)) / 12;
            textBox_monthlyIncome.Text = monthlyIncome.ToString(culture);
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
