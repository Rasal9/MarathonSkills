namespace MarathonSkills
{
    partial class Form6
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

        #region Код, автоматически созданный конструктором форм Windows Forms

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.marathonSkillsDBDataSet = new MarathonSkills.MarathonSkillsDBDataSet();
            this.charityTableAdapter = new MarathonSkills.MarathonSkillsDBDataSetTableAdapters.CharityTableAdapter();
            this.sponsorshipTableAdapter1 = new MarathonSkills.MarathonSkillsDBDataSetTableAdapters.SponsorshipTableAdapter();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.ButClose = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelS0 = new System.Windows.Forms.Label();
            this.sponsorNameTextBox = new System.Windows.Forms.TextBox();
            this.labelS1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelS2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelS3 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.labelS4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelS5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1Money = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.MoneyBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marathonSkillsDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // marathonSkillsDBDataSet
            // 
            this.marathonSkillsDBDataSet.DataSetName = "MarathonSkillsDBDataSet";
            // 
            // charityTableAdapter
            // 
            this.charityTableAdapter.ClearBeforeFill = true;
            // 
            // sponsorshipTableAdapter1
            // 
            this.sponsorshipTableAdapter1.ClearBeforeFill = true;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.ButClose);
            this.panelTop.Controls.Add(this.labelDate);
            this.panelTop.Controls.Add(this.labelCity);
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(29)))), ((int)(((byte)(112)))));
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1100, 131);
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top)) | ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left)) | ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Right));
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.Gold;
            this.labelTitle.Location = new System.Drawing.Point(0, 6);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1100, 40);
            this.labelTitle.Text = "Marathon Skills 2016";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(29)))), ((int)(((byte)(112)))));
            // 
            // labelCity
            // 
            this.labelCity.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCity.ForeColor = System.Drawing.Color.White;
            this.labelCity.Location = new System.Drawing.Point(0, 58);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(1100, 24);
            this.labelCity.Text = "Екатеринбург, Россия";
            this.labelCity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(29)))), ((int)(((byte)(112)))));
            // 
            // labelDate
            // 
            this.labelDate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDate.Location = new System.Drawing.Point(0, 92);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(1100, 22);
            this.labelDate.Text = "date";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(29)))), ((int)(((byte)(112)))));
            // 
            // ButClose
            // 
            this.ButClose.Location = new System.Drawing.Point(20, 20);
            this.ButClose.Name = "ButClose";
            this.ButClose.Size = new System.Drawing.Size(100, 32);
            this.ButClose.Text = "Назад";
            this.ButClose.BackColor = System.Drawing.SystemColors.Control;
            this.ButClose.UseVisualStyleBackColor = true;
            this.ButClose.Click += new System.EventHandler(this.ButClose_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(29)))), ((int)(((byte)(112)))));
            this.panelBottom.Location = new System.Drawing.Point(0, 670);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1100, 51);
            this.panelBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom)) | ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left)) | ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Right));
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1100, 39);
            this.label1.Text = "Спонсор бегуна";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(0, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1100, 48);
            this.label2.Text = "Пожалуйста выберите бегуна, которого вы хотели бы спонсировать и введите сумму спонсирования\r\nСпасибо за вашу поддержку бегунов и их благотворительных учреждений.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(40, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(520, 30);
            this.label3.Text = "Информация о спонсоре";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelS0
            // 
            this.labelS0.ForeColor = System.Drawing.Color.Silver;
            this.labelS0.Location = new System.Drawing.Point(20, 293);
            this.labelS0.Name = "labelS0";
            this.labelS0.Size = new System.Drawing.Size(180, 24);
            this.labelS0.Text = "Ваше имя:";
            this.labelS0.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sponsorNameTextBox
            // 
            this.sponsorNameTextBox.Location = new System.Drawing.Point(205, 290);
            this.sponsorNameTextBox.Name = "sponsorNameTextBox";
            this.sponsorNameTextBox.Size = new System.Drawing.Size(340, 26);
            // 
            // labelS1
            // 
            this.labelS1.ForeColor = System.Drawing.Color.Silver;
            this.labelS1.Location = new System.Drawing.Point(20, 335);
            this.labelS1.Name = "labelS1";
            this.labelS1.Size = new System.Drawing.Size(180, 24);
            this.labelS1.Text = "Бегун:";
            this.labelS1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(205, 332);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(340, 26);
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelS2
            // 
            this.labelS2.ForeColor = System.Drawing.Color.Silver;
            this.labelS2.Location = new System.Drawing.Point(20, 377);
            this.labelS2.Name = "labelS2";
            this.labelS2.Size = new System.Drawing.Size(180, 24);
            this.labelS2.Text = "Карта:";
            this.labelS2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(205, 374);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 26);
            // 
            // labelS3
            // 
            this.labelS3.ForeColor = System.Drawing.Color.Silver;
            this.labelS3.Location = new System.Drawing.Point(20, 419);
            this.labelS3.Name = "labelS3";
            this.labelS3.Size = new System.Drawing.Size(180, 24);
            this.labelS3.Text = "Номер карты:";
            this.labelS3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(205, 416);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(340, 26);
            this.maskedTextBox1.Mask = "9999 9999 9999 9999";
            // 
            // labelS4
            // 
            this.labelS4.ForeColor = System.Drawing.Color.Silver;
            this.labelS4.Location = new System.Drawing.Point(20, 461);
            this.labelS4.Name = "labelS4";
            this.labelS4.Size = new System.Drawing.Size(180, 24);
            this.labelS4.Text = "Срок действия:";
            this.labelS4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(205, 458);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(340, 26);
            this.dateTimePicker1.CustomFormat = "MM yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            // 
            // labelS5
            // 
            this.labelS5.ForeColor = System.Drawing.Color.Silver;
            this.labelS5.Location = new System.Drawing.Point(20, 503);
            this.labelS5.Name = "labelS5";
            this.labelS5.Size = new System.Drawing.Size(180, 24);
            this.labelS5.Text = "CVC:";
            this.labelS5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(205, 500);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 26);
            this.textBox2.MaxLength = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(640, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(380, 30);
            this.label4.Text = "Благотворительность";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(640, 285);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(380, 28);
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ReadOnly = true;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(815, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.Text = "i";
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(640, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(380, 30);
            this.label5.Text = "Сумма пожертвования";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1Money
            // 
            this.label1Money.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1Money.ForeColor = System.Drawing.Color.Silver;
            this.label1Money.Location = new System.Drawing.Point(640, 400);
            this.label1Money.Name = "label1Money";
            this.label1Money.Size = new System.Drawing.Size(380, 50);
            this.label1Money.Text = "$50";
            this.label1Money.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(735, 462);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.Text = "+";
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MoneyBox
            // 
            this.MoneyBox.Location = new System.Drawing.Point(770, 463);
            this.MoneyBox.Name = "MoneyBox";
            this.MoneyBox.Size = new System.Drawing.Size(120, 26);
            this.MoneyBox.Text = "50";
            this.MoneyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MoneyBox.TextChanged += new System.EventHandler(this.MoneyBox_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(895, 462);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.Text = "-";
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelError
            // 
            this.labelError.ForeColor = System.Drawing.Color.DarkRed;
            this.labelError.Location = new System.Drawing.Point(640, 497);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(380, 22);
            this.labelError.Text = "";
            this.labelError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(680, 530);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 38);
            this.button5.Text = "Заплатить";
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(840, 530);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 38);
            this.button4.Text = "Отмена";
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form6
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1100, 721);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2016 – Спонсоры бегуна";
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.MoneyBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1Money);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelS5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelS4);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.labelS3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelS2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelS1);
            this.Controls.Add(this.sponsorNameTextBox);
            this.Controls.Add(this.labelS0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marathonSkillsDBDataSet)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MarathonSkills.MarathonSkillsDBDataSet marathonSkillsDBDataSet;
        private MarathonSkills.MarathonSkillsDBDataSetTableAdapters.CharityTableAdapter charityTableAdapter;
        private MarathonSkills.MarathonSkillsDBDataSetTableAdapters.SponsorshipTableAdapter sponsorshipTableAdapter1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button ButClose;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelS0;
        private System.Windows.Forms.TextBox sponsorNameTextBox;
        private System.Windows.Forms.Label labelS1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelS2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelS3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label labelS4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelS5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1Money;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox MoneyBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}
