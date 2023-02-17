using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace BankClient_1
{
    public partial class UpdateForm : Form
    {
        MainForm mainForm = null;
        int userId = -1;
        DataBase db = null;
        SqlDataReader sqlDataReader = null;
        SqlCommand cmd = null;

        public UpdateForm(MainForm mainForm, int userId)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.userId = userId;
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            db = new DataBase();
            db.OpenConnection();
            cmd = new SqlCommand($"SELECT * FROM Users WHERE Id = {userId}", db.GetConnection);

            sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                textBoxName.Text = sqlDataReader["FirstName"].ToString();
                textBoxLastName.Text = sqlDataReader["LastName"].ToString();
                textBoxMiddleName.Text = sqlDataReader["MiddleName"].ToString();
                textBoxAge.Text = sqlDataReader["Age"].ToString();
                textBoxPassportNumber.Text = sqlDataReader["PassportNumber"].ToString();
                dateTimePicker1.Value = (DateTime)sqlDataReader["Birthday"];
                textBox_gorodPro.Text = sqlDataReader["gorodPro"].ToString();
                textBox_phone.Text = sqlDataReader["phone"].ToString();
                textBox_mail.Text = sqlDataReader["mail"].ToString();
                textBox_work.Text = sqlDataReader["work"].ToString();
                textBox_idenNumber.Text = sqlDataReader["identNumber"].ToString();
                textBox_placeBirth.Text = sqlDataReader["placeBirthday"].ToString();
                textBox_addressPro.Text = sqlDataReader["addressPro"].ToString();
                textBox_phoneHome.Text = sqlDataReader["numberHome"].ToString();
                textBox_doljnost.Text = sqlDataReader["doljnost"].ToString();
                textBox_citizen.Text = sqlDataReader["citizen"].ToString();
                textBox_doxod.Text = sqlDataReader["doxod"].ToString();
            }

            if (sqlDataReader != null)
            {
                sqlDataReader.Close();
            }

            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db = new DataBase();
            db.OpenConnection();
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
                var dateBirthday = string.Join("-", dateTimePicker1.Text.Split('.').Reverse());

                cmd = new SqlCommand($"UPDATE Users Set FirstName = '{textBoxName.Text}'," +
                    $"LastName = '{textBoxLastName.Text}'," +
                    $"MiddleName = '{textBoxMiddleName.Text}'," +
                    $"Age = '{textBoxAge.Text}'," +
                    $"PassportNumber = '{textBoxPassportNumber.Text}'," +
                    $"Birthday = '{dateBirthday}'," +
                    $"gorodPro = '{textBox_gorodPro.Text}'," +
                    $"phone = '{textBox_phone.Text}'," +
                    $"mail = '{textBox_mail.Text}'," +
                    $"work = '{textBox_work.Text}'," +
                    $"identNumber = '{textBox_idenNumber.Text}'," +
                    $"placeBirthday = '{textBox_placeBirth.Text}'," +
                    $"addressPro = '{textBox_addressPro.Text}'," +
                    $"numberHome = '{textBox_phoneHome.Text}'," +
                    $"doljnost = '{textBox_doljnost.Text}'," +
                    $"citizen = '{textBox_citizen.Text}'," +
                    $"doxod = '{textBox_doxod.Text}' where id = {userId}", db.GetConnection);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Пользователь обновлен пользователь!");
                    db.closeConnection();
                    this.Close();
                }
            }
        }

        private void UpdateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.UpdateDataGrid();
        }

    }
}
