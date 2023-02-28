using System;

namespace BankClient_1
{
    partial class AddNewDepositForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_userID = new System.Windows.Forms.TextBox();
            this.textBox_deposit = new System.Windows.Forms.TextBox();
            this.comboBox_typeDeposit = new System.Windows.Forms.ComboBox();
            this.textBox_procent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_endDate = new System.Windows.Forms.DateTimePicker();
            this.textBox_monthlyIncome = new System.Windows.Forms.TextBox();
            this.textBox_contractID = new System.Windows.Forms.TextBox();
            this.comboBox_currency = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button_addNewDeposit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox4_ChartAcc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox_userID
            // 
            this.textBox_userID.Location = new System.Drawing.Point(44, 25);
            this.textBox_userID.Name = "textBox_userID";
            this.textBox_userID.Size = new System.Drawing.Size(169, 20);
            this.textBox_userID.TabIndex = 0;
            // 
            // textBox_deposit
            // 
            this.textBox_deposit.Location = new System.Drawing.Point(44, 209);
            this.textBox_deposit.Name = "textBox_deposit";
            this.textBox_deposit.Size = new System.Drawing.Size(169, 20);
            this.textBox_deposit.TabIndex = 1;
            this.textBox_deposit.TextChanged += new System.EventHandler(this.textBox_deposit_TextChanged);
            this.textBox_deposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_deposit_KeyPress);
            // 
            // comboBox_typeDeposit
            // 
            this.comboBox_typeDeposit.FormattingEnabled = true;
            this.comboBox_typeDeposit.Items.AddRange(new object[] {
            "Безотзывной",
            "Отзывной"});
            this.comboBox_typeDeposit.Location = new System.Drawing.Point(44, 77);
            this.comboBox_typeDeposit.Name = "comboBox_typeDeposit";
            this.comboBox_typeDeposit.Size = new System.Drawing.Size(169, 21);
            this.comboBox_typeDeposit.TabIndex = 2;
            // 
            // textBox_procent
            // 
            this.textBox_procent.Location = new System.Drawing.Point(44, 131);
            this.textBox_procent.Name = "textBox_procent";
            this.textBox_procent.Size = new System.Drawing.Size(169, 20);
            this.textBox_procent.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "UserID";
            // 
            // dateTimePicker_startDate
            // 
            this.dateTimePicker_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(44, 157);
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(169, 20);
            this.dateTimePicker_startDate.TabIndex = 6;
            // 
            // dateTimePicker_endDate
            // 
            this.dateTimePicker_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_endDate.Location = new System.Drawing.Point(44, 183);
            this.dateTimePicker_endDate.Name = "dateTimePicker_endDate";
            this.dateTimePicker_endDate.Size = new System.Drawing.Size(169, 20);
            this.dateTimePicker_endDate.TabIndex = 7;
            // 
            // textBox_monthlyIncome
            // 
            this.textBox_monthlyIncome.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox_monthlyIncome.Enabled = false;
            this.textBox_monthlyIncome.Location = new System.Drawing.Point(44, 235);
            this.textBox_monthlyIncome.Name = "textBox_monthlyIncome";
            this.textBox_monthlyIncome.Size = new System.Drawing.Size(169, 20);
            this.textBox_monthlyIncome.TabIndex = 9;
            // 
            // textBox_contractID
            // 
            this.textBox_contractID.Location = new System.Drawing.Point(44, 261);
            this.textBox_contractID.Name = "textBox_contractID";
            this.textBox_contractID.Size = new System.Drawing.Size(169, 20);
            this.textBox_contractID.TabIndex = 10;
            // 
            // comboBox_currency
            // 
            this.comboBox_currency.FormattingEnabled = true;
            this.comboBox_currency.Items.AddRange(new object[] {
            "usd",
            "byn",
            "uzs",
            "eur"});
            this.comboBox_currency.Location = new System.Drawing.Point(44, 104);
            this.comboBox_currency.Name = "comboBox_currency";
            this.comboBox_currency.Size = new System.Drawing.Size(169, 21);
            this.comboBox_currency.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Тип депозита";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Сумма";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Валюта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Процент";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Дата начала";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Дата конца";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(219, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Месячный доход";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(219, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "ID контракта";
            // 
            // button_addNewDeposit
            // 
            this.button_addNewDeposit.Location = new System.Drawing.Point(44, 289);
            this.button_addNewDeposit.Name = "button_addNewDeposit";
            this.button_addNewDeposit.Size = new System.Drawing.Size(169, 46);
            this.button_addNewDeposit.TabIndex = 21;
            this.button_addNewDeposit.Text = "Добавить";
            this.button_addNewDeposit.UseVisualStyleBackColor = true;
            this.button_addNewDeposit.Click += new System.EventHandler(this.button_addNewDeposit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(219, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "План счетов";
            // 
            // comboBox4_ChartAcc
            // 
            this.comboBox4_ChartAcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4_ChartAcc.FormattingEnabled = true;
            this.comboBox4_ChartAcc.Location = new System.Drawing.Point(44, 51);
            this.comboBox4_ChartAcc.Name = "comboBox4_ChartAcc";
            this.comboBox4_ChartAcc.Size = new System.Drawing.Size(169, 21);
            this.comboBox4_ChartAcc.TabIndex = 22;
            this.comboBox4_ChartAcc.SelectionChangeCommitted += new System.EventHandler(this.comboBox4_ChartAcc_SelectionChangeCommitted);
            // 
            // AddNewDepositForm
            // 
            this.ClientSize = new System.Drawing.Size(333, 358);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox4_ChartAcc);
            this.Controls.Add(this.button_addNewDeposit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_currency);
            this.Controls.Add(this.textBox_contractID);
            this.Controls.Add(this.textBox_monthlyIncome);
            this.Controls.Add(this.dateTimePicker_endDate);
            this.Controls.Add(this.dateTimePicker_startDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_procent);
            this.Controls.Add(this.comboBox_typeDeposit);
            this.Controls.Add(this.textBox_deposit);
            this.Controls.Add(this.textBox_userID);
            this.MaximumSize = new System.Drawing.Size(349, 397);
            this.MinimumSize = new System.Drawing.Size(349, 397);
            this.Name = "AddNewDepositForm";
            this.Load += new System.EventHandler(this.AddNewDepositForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_userID;
        private System.Windows.Forms.TextBox textBox_deposit;
        private System.Windows.Forms.ComboBox comboBox_typeDeposit;
        private System.Windows.Forms.TextBox textBox_procent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_startDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_endDate;
        private System.Windows.Forms.TextBox textBox_monthlyIncome;
        private System.Windows.Forms.TextBox textBox_contractID;
        private System.Windows.Forms.ComboBox comboBox_currency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_addNewDeposit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox4_ChartAcc;
    }
}
