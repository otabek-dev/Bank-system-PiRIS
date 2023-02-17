using System;
using System.Windows.Forms;

namespace BankClient_1
{
    partial class AddForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxPassportNumber = new System.Windows.Forms.TextBox();
            this.dateTimePicker_birthday = new System.Windows.Forms.DateTimePicker();
            this.label_pol = new System.Windows.Forms.Label();
            this.label_gorod = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_mail = new System.Windows.Forms.Label();
            this.label_work = new System.Windows.Forms.Label();
            this.radioButton_muj = new System.Windows.Forms.RadioButton();
            this.radioButton_jen = new System.Windows.Forms.RadioButton();
            this.textBox_gorodPro = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.textBox_work = new System.Windows.Forms.TextBox();
            this.textBox_phoneHome = new System.Windows.Forms.TextBox();
            this.textBox_addressPro = new System.Windows.Forms.TextBox();
            this.textBox_placeBirth = new System.Windows.Forms.TextBox();
            this.textBox_idenNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_doxod = new System.Windows.Forms.TextBox();
            this.textBox_citizen = new System.Windows.Forms.TextBox();
            this.textBox_doljnost = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 693);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(345, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(136, 3);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(136, 179);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(200, 22);
            this.textBoxAge.TabIndex = 2;
            this.textBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAge_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Возраст";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(137, 48);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(199, 22);
            this.textBoxLastName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Номер паспорта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 222);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "День рождения";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(137, 92);
            this.textBoxMiddleName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(197, 22);
            this.textBoxMiddleName.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 319F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxPassportNumber, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAge, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLastName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMiddleName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker_birthday, 1, 5);
            this.dateTimePicker_birthday.MaxDate = DateTime.Now;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 25);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 261F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(345, 260);
            this.tableLayoutPanel1.TabIndex = 11;
            this.tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            // 
            // textBoxPassportNumber
            // 
            this.textBoxPassportNumber.Location = new System.Drawing.Point(137, 136);
            this.textBoxPassportNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassportNumber.Name = "textBoxPassportNumber";
            this.textBoxPassportNumber.Size = new System.Drawing.Size(197, 22);
            this.textBoxPassportNumber.TabIndex = 11;
            // 
            // dateTimePicker_birthday
            // 
            this.dateTimePicker_birthday.AllowDrop = true;
            this.dateTimePicker_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_birthday.Location = new System.Drawing.Point(137, 226);
            this.dateTimePicker_birthday.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_birthday.Name = "dateTimePicker_birthday";
            this.dateTimePicker_birthday.Size = new System.Drawing.Size(199, 22);
            this.dateTimePicker_birthday.TabIndex = 12;
            this.dateTimePicker_birthday.Value = new System.DateTime(2023, 1, 31, 11, 9, 20, 0);
            // 
            // label_pol
            // 
            this.label_pol.AutoSize = true;
            this.label_pol.Location = new System.Drawing.Point(20, 292);
            this.label_pol.Name = "label_pol";
            this.label_pol.Size = new System.Drawing.Size(33, 16);
            this.label_pol.TabIndex = 12;
            this.label_pol.Text = "Пол";
            // 
            // label_gorod
            // 
            this.label_gorod.AutoSize = true;
            this.label_gorod.Location = new System.Drawing.Point(18, 331);
            this.label_gorod.Name = "label_gorod";
            this.label_gorod.Size = new System.Drawing.Size(129, 16);
            this.label_gorod.TabIndex = 13;
            this.label_gorod.Text = "Город проживания";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(17, 368);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(67, 16);
            this.label_phone.TabIndex = 14;
            this.label_phone.Text = "Телефон";
            // 
            // label_mail
            // 
            this.label_mail.AutoSize = true;
            this.label_mail.Location = new System.Drawing.Point(19, 401);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(44, 16);
            this.label_mail.TabIndex = 15;
            this.label_mail.Text = "e-mail";
            // 
            // label_work
            // 
            this.label_work.AutoSize = true;
            this.label_work.Location = new System.Drawing.Point(19, 433);
            this.label_work.Name = "label_work";
            this.label_work.Size = new System.Drawing.Size(99, 16);
            this.label_work.TabIndex = 16;
            this.label_work.Text = "Место работы";
            // 
            // radioButton_muj
            // 
            this.radioButton_muj.AutoSize = true;
            this.radioButton_muj.Location = new System.Drawing.Point(151, 292);
            this.radioButton_muj.Name = "radioButton_muj";
            this.radioButton_muj.Size = new System.Drawing.Size(59, 20);
            this.radioButton_muj.TabIndex = 17;
            this.radioButton_muj.TabStop = true;
            this.radioButton_muj.Text = "Муж.";
            this.radioButton_muj.UseVisualStyleBackColor = true;
            // 
            // radioButton_jen
            // 
            this.radioButton_jen.AutoSize = true;
            this.radioButton_jen.Location = new System.Drawing.Point(216, 292);
            this.radioButton_jen.Name = "radioButton_jen";
            this.radioButton_jen.Size = new System.Drawing.Size(60, 20);
            this.radioButton_jen.TabIndex = 18;
            this.radioButton_jen.TabStop = true;
            this.radioButton_jen.Text = "Жен.";
            this.radioButton_jen.UseVisualStyleBackColor = true;
            // 
            // textBox_gorodPro
            // 
            this.textBox_gorodPro.Location = new System.Drawing.Point(150, 328);
            this.textBox_gorodPro.Name = "textBox_gorodPro";
            this.textBox_gorodPro.Size = new System.Drawing.Size(198, 22);
            this.textBox_gorodPro.TabIndex = 19;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(150, 360);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(198, 22);
            this.textBox_phone.TabIndex = 20;
            // 
            // textBox_mail
            // 
            this.textBox_mail.Location = new System.Drawing.Point(151, 397);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(197, 22);
            this.textBox_mail.TabIndex = 21;
            // 
            // textBox_work
            // 
            this.textBox_work.Location = new System.Drawing.Point(151, 427);
            this.textBox_work.Name = "textBox_work";
            this.textBox_work.Size = new System.Drawing.Size(198, 22);
            this.textBox_work.TabIndex = 22;
            // 
            // textBox_phoneHome
            // 
            this.textBox_phoneHome.Location = new System.Drawing.Point(151, 569);
            this.textBox_phoneHome.Name = "textBox_phoneHome";
            this.textBox_phoneHome.Size = new System.Drawing.Size(198, 22);
            this.textBox_phoneHome.TabIndex = 30;
            // 
            // textBox_addressPro
            // 
            this.textBox_addressPro.Location = new System.Drawing.Point(152, 533);
            this.textBox_addressPro.Name = "textBox_addressPro";
            this.textBox_addressPro.Size = new System.Drawing.Size(197, 22);
            this.textBox_addressPro.TabIndex = 29;
            // 
            // textBox_placeBirth
            // 
            this.textBox_placeBirth.Location = new System.Drawing.Point(151, 496);
            this.textBox_placeBirth.Name = "textBox_placeBirth";
            this.textBox_placeBirth.Size = new System.Drawing.Size(198, 22);
            this.textBox_placeBirth.TabIndex = 28;
            // 
            // textBox_idenNumber
            // 
            this.textBox_idenNumber.Location = new System.Drawing.Point(151, 464);
            this.textBox_idenNumber.Name = "textBox_idenNumber";
            this.textBox_idenNumber.Size = new System.Drawing.Size(198, 22);
            this.textBox_idenNumber.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 569);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Дом. номер";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 537);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Адрес проживания";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 504);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Место рожд.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 467);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Идент номер";
            // 
            // textBox_doxod
            // 
            this.textBox_doxod.Location = new System.Drawing.Point(152, 666);
            this.textBox_doxod.Name = "textBox_doxod";
            this.textBox_doxod.Size = new System.Drawing.Size(197, 22);
            this.textBox_doxod.TabIndex = 37;
            // 
            // textBox_citizen
            // 
            this.textBox_citizen.Location = new System.Drawing.Point(151, 629);
            this.textBox_citizen.Name = "textBox_citizen";
            this.textBox_citizen.Size = new System.Drawing.Size(198, 22);
            this.textBox_citizen.TabIndex = 36;
            // 
            // textBox_doljnost
            // 
            this.textBox_doljnost.Location = new System.Drawing.Point(151, 597);
            this.textBox_doljnost.Name = "textBox_doljnost";
            this.textBox_doljnost.Size = new System.Drawing.Size(198, 22);
            this.textBox_doljnost.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 670);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 16);
            this.label12.TabIndex = 33;
            this.label12.Text = "Доход";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 637);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 16);
            this.label13.TabIndex = 32;
            this.label13.Text = "Гражданство";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 600);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 16);
            this.label14.TabIndex = 31;
            this.label14.Text = "Должность";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(375, 750);
            this.Controls.Add(this.textBox_doxod);
            this.Controls.Add(this.textBox_citizen);
            this.Controls.Add(this.textBox_doljnost);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox_phoneHome);
            this.Controls.Add(this.textBox_addressPro);
            this.Controls.Add(this.textBox_placeBirth);
            this.Controls.Add(this.textBox_idenNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_work);
            this.Controls.Add(this.textBox_mail);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.textBox_gorodPro);
            this.Controls.Add(this.radioButton_jen);
            this.Controls.Add(this.radioButton_muj);
            this.Controls.Add(this.label_work);
            this.Controls.Add(this.label_mail);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.label_gorod);
            this.Controls.Add(this.label_pol);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddForm";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddForm_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxPassportNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        protected System.Windows.Forms.DateTimePicker dateTimePicker_birthday;
        private Label label_pol;
        private Label label_gorod;
        private Label label_phone;
        private Label label_mail;
        private Label label_work;
        private RadioButton radioButton_muj;
        private RadioButton radioButton_jen;
        private TextBox textBox_gorodPro;
        private TextBox textBox_phone;
        private TextBox textBox_mail;
        private TextBox textBox_work;
        private TextBox textBox_phoneHome;
        private TextBox textBox_addressPro;
        private TextBox textBox_placeBirth;
        private TextBox textBox_idenNumber;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox_doxod;
        private TextBox textBox_citizen;
        private TextBox textBox_doljnost;
        private Label label12;
        private Label label13;
        private Label label14;
    }
}