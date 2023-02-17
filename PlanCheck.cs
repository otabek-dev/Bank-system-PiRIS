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
    public partial class PlanCheck : Form
    {
        DataBase db = new DataBase();
        SqlDataAdapter adapter = null;
        DataSet dt = new DataSet();

        public PlanCheck()
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
