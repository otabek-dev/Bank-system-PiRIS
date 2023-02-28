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

        private void UpdateDataGridCheckOfAccForm()
        {
            dt.Clear();
            adapter.Fill(dt, "ChartOfAccounts");
            dataGridView1.DataSource = dt.Tables["ChartOfAccounts"];
        }

        private void PlanCheck_Load(object sender, EventArgs e)
        {
            db.OpenConnection();

            var cmd = "SELECT * FROM ChartOfAccounts";

            adapter = new SqlDataAdapter(cmd, db.GetConnection);
            
            UpdateDataGridCheckOfAccForm();
        }

        private void toolStripButton1_AddNewPlan_Click(object sender, EventArgs e)
        {
            AddNewChartForm chartForm = new AddNewChartForm();
            chartForm.StartPosition = FormStartPosition.CenterParent;
            chartForm.ShowDialog();
            UpdateDataGridCheckOfAccForm();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;

            if (MessageBox.Show($"Удалить план {dataGridView1.Rows[e.RowIndex].Cells["ChartName"].Value}?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var command = new SqlCommand($"DELETE FROM ChartOfAccounts WHERE Id = {id}", db.GetConnection);

                command.ExecuteNonQuery();

                UpdateDataGridCheckOfAccForm();
            }
        }
    }
}
