namespace BankClient_1
{
    partial class AddNewChartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1_AddChart = new System.Windows.Forms.Button();
            this.maskedTextBox1_Percentage = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1_TypeDeposit = new System.Windows.Forms.ComboBox();
            this.comboBox2_Currency = new System.Windows.Forms.ComboBox();
            this.maskedTextBox2_Month = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3_ChartName = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1_AddChart
            // 
            this.button1_AddChart.Location = new System.Drawing.Point(45, 160);
            this.button1_AddChart.Name = "button1_AddChart";
            this.button1_AddChart.Size = new System.Drawing.Size(202, 42);
            this.button1_AddChart.TabIndex = 0;
            this.button1_AddChart.Text = "Добавить";
            this.button1_AddChart.UseVisualStyleBackColor = true;
            this.button1_AddChart.Click += new System.EventHandler(this.button1_AddChart_Click);
            // 
            // maskedTextBox1_Percentage
            // 
            this.maskedTextBox1_Percentage.Location = new System.Drawing.Point(157, 64);
            this.maskedTextBox1_Percentage.Mask = "00";
            this.maskedTextBox1_Percentage.Name = "maskedTextBox1_Percentage";
            this.maskedTextBox1_Percentage.PromptChar = ' ';
            this.maskedTextBox1_Percentage.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBox1_Percentage.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Тип депозита";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Валюта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Процент";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Месяцы";
            // 
            // comboBox1_TypeDeposit
            // 
            this.comboBox1_TypeDeposit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1_TypeDeposit.Items.AddRange(new object[] {
            "Отзывной",
            "Безотзывной"});
            this.comboBox1_TypeDeposit.Location = new System.Drawing.Point(157, 11);
            this.comboBox1_TypeDeposit.Name = "comboBox1_TypeDeposit";
            this.comboBox1_TypeDeposit.Size = new System.Drawing.Size(121, 21);
            this.comboBox1_TypeDeposit.TabIndex = 9;
            // 
            // comboBox2_Currency
            // 
            this.comboBox2_Currency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2_Currency.Items.AddRange(new object[] {
            "USD",
            "BYN",
            "UZS",
            "EUR"});
            this.comboBox2_Currency.Location = new System.Drawing.Point(157, 38);
            this.comboBox2_Currency.Name = "comboBox2_Currency";
            this.comboBox2_Currency.Size = new System.Drawing.Size(121, 21);
            this.comboBox2_Currency.TabIndex = 10;
            // 
            // maskedTextBox2_Month
            // 
            this.maskedTextBox2_Month.Location = new System.Drawing.Point(157, 90);
            this.maskedTextBox2_Month.Mask = "00";
            this.maskedTextBox2_Month.Name = "maskedTextBox2_Month";
            this.maskedTextBox2_Month.PromptChar = ' ';
            this.maskedTextBox2_Month.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBox2_Month.TabIndex = 11;
            // 
            // maskedTextBox3_ChartName
            // 
            this.maskedTextBox3_ChartName.Location = new System.Drawing.Point(157, 116);
            this.maskedTextBox3_ChartName.Name = "maskedTextBox3_ChartName";
            this.maskedTextBox3_ChartName.PromptChar = ' ';
            this.maskedTextBox3_ChartName.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBox3_ChartName.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Название плана";
            // 
            // AddNewChartForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(290, 215);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBox3_ChartName);
            this.Controls.Add(this.maskedTextBox2_Month);
            this.Controls.Add(this.comboBox2_Currency);
            this.Controls.Add(this.comboBox1_TypeDeposit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox1_Percentage);
            this.Controls.Add(this.button1_AddChart);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(306, 254);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(306, 254);
            this.Name = "AddNewChartForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New chart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_AddChart;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1_Percentage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1_TypeDeposit;
        private System.Windows.Forms.ComboBox comboBox2_Currency;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2_Month;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3_ChartName;
        private System.Windows.Forms.Label label5;
    }
}