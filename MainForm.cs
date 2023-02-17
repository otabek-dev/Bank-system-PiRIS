using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankClient_1
{
    public partial class MainForm : Form
    {
        private DataBase databaseCon = new DataBase();
        private SqlDataAdapter adapter = null;
        private DataSet dataSet = null;

        public MainForm()
        {
            InitializeComponent();
            this.Text = "Bank system";

            toolStripButton_autoAddUsers.Visible = false;
            toolStripButton_search.Visible = false;
            toolStripButton_deposits.Visible = true;
        }

        // Метод обновления данных 
        public void UpdateDataGrid()
        {
            dataSet.Clear();

            adapter.Fill(dataSet, "Users");
            dataGridView1.DataSource = dataSet.Tables["Users"];
        }

        private void toolStripButton_UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }
        // Срабатывает при загрузке основной формы 
        private void Form1_Load(object sender, EventArgs e)
        {
            databaseCon.OpenConnection();

            adapter = new SqlDataAdapter("SELECT * FROM Users ORDER BY LastName", databaseCon.GetConnection);

            dataSet = new DataSet();

            adapter.Fill(dataSet, "Users");
            dataGridView1.DataSource = dataSet.Tables["Users"];

        }

        // Кнопка добавить нового пользователя
        private void toolStripButton_NewUserAddForm_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(this);
            addForm.ShowDialog();
        }

        // Изменение данных пользователя (при двойном клике)
        private void dataGridView_UpdateUserData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int userId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            UpdateForm updateForm = new UpdateForm(this, userId);
            updateForm.ShowDialog();
        }
        
        // Кнопка открыть новый депозит
        private void toolStripButton_OpenDepositForm_Click(object sender, EventArgs e)
        {
            DepositForm depositForm = new DepositForm(this);
            depositForm.ShowDialog();
            this.Visible = true;
        }

        // Кнопка удалить пользователя
        private void toolStripButton_DeleteButton_Click_1(object sender, EventArgs e)
        {
            string id = Microsoft.VisualBasic.Interaction.InputBox("Введите id пользователя чтобы удалить:");
            
            if(id != "")
                if (MessageBox.Show("Вы действительно хотите удалить этого пользователя?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    var command = new SqlCommand($"DELETE FROM Users WHERE Id = {id}", databaseCon.GetConnection);
                    adapter.DeleteCommand = command;
                    adapter.DeleteCommand.ExecuteNonQuery();
                }

            UpdateDataGrid();
        }
    }
}
