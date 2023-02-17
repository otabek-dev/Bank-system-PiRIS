using System;

namespace BankClient_1
{
    partial class NewDeposit
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
            this.comboBox_rate = new System.Windows.Forms.ComboBox();
            this.textBox_monthlyIncome = new System.Windows.Forms.TextBox();
            this.textBox_contractID = new System.Windows.Forms.TextBox();
            this.comboBox_currency = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button_addNewDeposit = new System.Windows.Forms.Button();
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
            this.textBox_deposit.Location = new System.Drawing.Point(44, 78);
            this.textBox_deposit.Name = "textBox_deposit";
            this.textBox_deposit.Size = new System.Drawing.Size(169, 20);
            this.textBox_deposit.TabIndex = 1;
            // 
            // comboBox_typeDeposit
            // 
            this.comboBox_typeDeposit.FormattingEnabled = true;
            this.comboBox_typeDeposit.Items.AddRange(new object[] {
            "Безотзывной",
            "Отзывной"});
            this.comboBox_typeDeposit.Location = new System.Drawing.Point(44, 51);
            this.comboBox_typeDeposit.Name = "comboBox_typeDeposit";
            this.comboBox_typeDeposit.Size = new System.Drawing.Size(169, 21);
            this.comboBox_typeDeposit.TabIndex = 2;
            this.comboBox_typeDeposit.SelectedIndexChanged += new System.EventHandler(this.comboBox_typeDeposit_SelectedIndexChanged);
            // 
            // textBox_procent
            // 
            this.textBox_procent.Location = new System.Drawing.Point(44, 158);
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
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(44, 184);
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(169, 20);
            this.dateTimePicker_startDate.TabIndex = 6;
            // 
            // dateTimePicker_endDate
            // 
            this.dateTimePicker_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_endDate.Location = new System.Drawing.Point(44, 210);
            this.dateTimePicker_endDate.Name = "dateTimePicker_endDate";
            this.dateTimePicker_endDate.Size = new System.Drawing.Size(169, 20);
            this.dateTimePicker_endDate.TabIndex = 7;
            // 
            // comboBox_rate
            // 
            this.comboBox_rate.FormattingEnabled = true;
            this.comboBox_rate.Items.AddRange(new object[] {
            "12 % Годовых 13 месяцев",
            "19 % Годовых 19 месяцев"});
            this.comboBox_rate.Location = new System.Drawing.Point(44, 131);
            this.comboBox_rate.Name = "comboBox_rate";
            this.comboBox_rate.Size = new System.Drawing.Size(169, 21);
            this.comboBox_rate.TabIndex = 8;
            this.comboBox_rate.SelectedIndexChanged += new System.EventHandler(this.comboBox_rate_SelectedIndexChanged);
            // 
            // textBox_monthlyIncome
            // 
            this.textBox_monthlyIncome.Location = new System.Drawing.Point(44, 236);
            this.textBox_monthlyIncome.Name = "textBox_monthlyIncome";
            this.textBox_monthlyIncome.Size = new System.Drawing.Size(169, 20);
            this.textBox_monthlyIncome.TabIndex = 9;
            // 
            // textBox_contractID
            // 
            this.textBox_contractID.Location = new System.Drawing.Point(44, 262);
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
            this.label2.Location = new System.Drawing.Point(219, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Тип депозита";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 81);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Тариф";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Процент";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Дата начала";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Дата конца";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(219, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Месячный доход";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(219, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "ID контракта";
            // 
            // button_addNewDeposit
            // 
            this.button_addNewDeposit.Location = new System.Drawing.Point(44, 288);
            this.button_addNewDeposit.Name = "button_addNewDeposit";
            this.button_addNewDeposit.Size = new System.Drawing.Size(169, 23);
            this.button_addNewDeposit.TabIndex = 21;
            this.button_addNewDeposit.Text = "Добавить";
            this.button_addNewDeposit.UseVisualStyleBackColor = true;
            this.button_addNewDeposit.Click += new System.EventHandler(this.button_addNewDeposit_Click);
            // 
            // NewDeposit
            // 
            this.ClientSize = new System.Drawing.Size(323, 364);
            this.Controls.Add(this.button_addNewDeposit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_currency);
            this.Controls.Add(this.textBox_contractID);
            this.Controls.Add(this.textBox_monthlyIncome);
            this.Controls.Add(this.comboBox_rate);
            this.Controls.Add(this.dateTimePicker_endDate);
            this.Controls.Add(this.dateTimePicker_startDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_procent);
            this.Controls.Add(this.comboBox_typeDeposit);
            this.Controls.Add(this.textBox_deposit);
            this.Controls.Add(this.textBox_userID);
            this.Name = "NewDeposit";
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
        private System.Windows.Forms.ComboBox comboBox_rate;
        private System.Windows.Forms.TextBox textBox_monthlyIncome;
        private System.Windows.Forms.TextBox textBox_contractID;
        private System.Windows.Forms.ComboBox comboBox_currency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_addNewDeposit;
    }
}
