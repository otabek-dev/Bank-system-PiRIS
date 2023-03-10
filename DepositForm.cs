using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace BankClient_1
{
    public partial class DepositForm : Form
    {
        // Создаем поля класса
        DataBase dataBase = new DataBase();
        SqlDataAdapter adapter = null;
        DataSet dt = new DataSet();
        CultureInfo culture = CultureInfo.InvariantCulture;

        // Основной класс запускается при старте формы
        public DepositForm(MainForm mainForm)
        {
            InitializeComponent();
            

            StartPosition = FormStartPosition.CenterScreen;
            mainForm.Visible = false;
            
            KeyPreview = true;

            KeyDown += (s, e) =>
            {
                if (e.Control && e.KeyCode == Keys.R)
                {
                    UpdateDataGridDepositForm();
                }
            };
        }

        // Метод обновление данных
        private void UpdateDataGridDepositForm()
        {
            dt.Clear();
            adapter.Fill(dt, "deposit");
            dataGridView1.DataSource = dt.Tables["deposit"];
        }

        // Метод запускается при загрузки формы 
        private void DepositForm_Load(object sender, EventArgs e)
        {
            dataBase.OpenConnection();

            var cmd = "SELECT Users.FirstName, Users.LastName, deposit.* " +
                "FROM Users Right Outer Join deposit " +
                "ON Users.Id = deposit.userID";

            adapter = new SqlDataAdapter(cmd, dataBase.GetConnection);
            adapter.Fill(dt, "deposit");

            dataGridView1.DataSource = dt.Tables["deposit"];
        }

        // Кнопка новый депозит
        private void NewDepositButton_Click(object sender, EventArgs e)
        {
            AddNewDepositForm newDeposit = new AddNewDepositForm();
            newDeposit.StartPosition = FormStartPosition.CenterScreen;
            newDeposit.ShowDialog();
            UpdateDataGridDepositForm();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string typeDeposit = (string)dataGridView1.Rows[e.RowIndex].Cells[3].Value;
            string BillNumber = (string)dataGridView1.Rows[e.RowIndex].Cells["BillNumber"].Value;

            if (typeDeposit == "Отзывной")
            {
                if (MessageBox.Show("Закрыть депозит?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var command = new SqlCommand($"DELETE FROM deposit WHERE BillNumber = {BillNumber}", dataBase.GetConnection);
                    var command2 = new SqlCommand($"DELETE FROM deposit WHERE BillNumber = {BillNumber}", dataBase.GetConnection);

                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();

                    UpdateDataGridDepositForm();
                }
            }
        }

        // Закрытие банковского дня (кнопка)
        private void CloseBankDayButton_Click(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM deposit where TypeBill = N'Процентный'";
            SqlCommand command = new SqlCommand(cmd, dataBase.GetConnection);
            SqlDataReader reader = command.ExecuteReader();
            
            var cmdList = new List<string>();

            while (reader.Read())
            {
                double deposit = 
                    double.Parse(reader["deposit"].ToString())
                    + (double.Parse(reader["MonthlyIncome"].ToString()) 
                    / DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));

                cmd = "UPDATE deposit " +
                    $"SET deposit = {deposit.ToString(culture)} " +
                    $"WHERE ID = {reader["ID"]}";

                cmdList.Add(cmd);
            }

            reader.Close();
            
            for (int i = 0; i < cmdList.Count; i++)
            {
                SqlCommand sql = new SqlCommand(cmdList[i], dataBase.GetConnection);
                sql.ExecuteNonQuery();
            }

            UpdateDataGridDepositForm();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ChartOfAccounts chartOfAcc = new ChartOfAccounts();
            chartOfAcc.StartPosition = FormStartPosition.CenterParent;
            chartOfAcc.ShowDialog();
        }
    }
}
