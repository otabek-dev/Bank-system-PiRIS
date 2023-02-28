using BankClient_1.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;

namespace BankClient_1
{
    public partial class AddNewChartForm : Form
    {
        DataBase db = new DataBase();
        CultureInfo culture = CultureInfo.InvariantCulture;

        public AddNewChartForm()
        {
            InitializeComponent();
        }

        private void button1_AddChart_Click(object sender, EventArgs e)
        {
            Chart chart = new Chart(comboBox1_TypeDeposit.Text, 
                comboBox2_Currency.Text, 
                byte.Parse(maskedTextBox1_Percentage.Text), 
                byte.Parse(maskedTextBox2_Month.Text),
                maskedTextBox3_ChartName.Text);
           
            db.OpenConnection();

            var cmd = "INSERT INTO ChartOfAccounts(TypeDeposit, Currency, Percentages, DurationInMonths, ChartName) " +
                $"values(N'{chart.TypeDeposit}','{chart.Currency}', {chart.Percentage} , {chart.DurationInMonths}, N'{chart.ChartName}')";

            SqlCommand command = new SqlCommand(cmd, db.GetConnection);
            
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }
    }
}
