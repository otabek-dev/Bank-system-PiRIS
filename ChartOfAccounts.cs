using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankClient_1
{
    public partial class ChartOfAccounts : Form
    {
        DataBase db = new DataBase();
        SqlDataAdapter adapter = null;
        DataSet dt = new DataSet();

        public ChartOfAccounts()
        {
            InitializeComponent();
        }

        private void UpdateDataGridDepositForm()
        {
            dt.Clear();
            adapter.Fill(dt, "deposit");
            dataGridView1.DataSource = dt.Tables["deposit"];
        }

        private void PlanCheck_Load(object sender, EventArgs e)
        {
            db.OpenConnection();

            var cmd = "SELECT deposit.BillNumber, Users.FirstName, Users.LastName,deposit.Currency, deposit.Procent " +
                "FROM Users Right Outer Join deposit " +
                "ON Users.Id = deposit.userID " +
                "WHERE TypeBill = N'Основной'";

            adapter = new SqlDataAdapter(cmd, db.GetConnection);
            adapter.Fill(dt, "deposit");

            dataGridView1.DataSource = dt.Tables["deposit"];
        }
    }
}
