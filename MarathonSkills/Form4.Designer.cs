namespace MarathonSkills
{
    partial class Form4
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
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genderTableAdapter = new MarathonSkills.MarathonSkillsDBDataSetTableAdapters.GenderTableAdapter();
            this.countryTableAdapter = new MarathonSkills.MarathonSkillsDBDataSetTableAdapters.CountryTableAdapter();
            this.runnerTableAdapter = new MarathonSkills.MarathonSkillsDBDataSetTableAdapters.RunnerTableAdapter();
            this.userTableAdapter = new MarathonSkills.MarathonSkillsDBDataSetTableAdapters.UserTableAdapter();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.ButClose = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelL0 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.labelL1 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.labelL2 = new System.Windows.Forms.Label();
            this.RePasswordTextBox = new System.Windows.Forms.TextBox();
            this.labelL3 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.labelL4 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.labelR0 = new System.Windows.Forms.Label();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.labelR1 = new System.Windows.Forms.Label();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelR2 = new System.Windows.Forms.Label();
            this.countryBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marathonSkillsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // marathonSkillsDBDataSet
            // 
            this.marathonSkillsDBDataSet.DataSetName = "MarathonSkillsDBDataSet";
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataMember = "Gender";
            this.genderBindingSource.DataSource = this.marathonSkillsDBDataSet;
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.marathonSkillsDBDataSet;
            // 
            // genderTableAdapter
            // 
            this.genderTableAdapter.ClearBeforeFill = true;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // runnerTableAdapter
            // 
            this.runnerTableAdapter.ClearBeforeFill = true;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
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
            this.panelTop.Size = new System.Drawing.Size(1236, 131);
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top)) | ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left)) | ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Right));
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.Gold;
            this.labelTitle.Location = new System.Drawing.Point(0, 6);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1236, 40);
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
            this.labelCity.Size = new System.Drawing.Size(1236, 24);
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
            this.labelDate.Size = new System.Drawing.Size(1236, 22);
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
            this.panelBottom.Location = new System.Drawing.Point(0, 590);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1236, 51);
            this.panelBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom)) | ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left)) | ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Right));
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1236, 39);
            this.label1.Text = "Регистрация бегуна";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(0, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1236, 26);
            this.label2.Text = "Пожалуйста заполните всю информацию, чтобы зарегистрироваться в качестве бегуна";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelL0
            // 
            this.labelL0.Location = new System.Drawing.Point(20, 243);
            this.labelL0.Name = "labelL0";
            this.labelL0.Size = new System.Drawing.Size(230, 28);
            this.labelL0.Text = "Email:";
            this.labelL0.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(255, 240);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(300, 28);
            // 
            // labelL1
            // 
            this.labelL1.Location = new System.Drawing.Point(20, 283);
            this.labelL1.Name = "labelL1";
            this.labelL1.Size = new System.Drawing.Size(230, 28);
            this.labelL1.Text = "Пароль:";
            this.labelL1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(255, 280);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(300, 28);
            this.passwordTextBox.PasswordChar = '*';
            // 
            // labelL2
            // 
            this.labelL2.Location = new System.Drawing.Point(20, 323);
            this.labelL2.Name = "labelL2";
            this.labelL2.Size = new System.Drawing.Size(230, 28);
            this.labelL2.Text = "Подтвердите пароль:";
            this.labelL2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // RePasswordTextBox
            // 
            this.RePasswordTextBox.Location = new System.Drawing.Point(255, 320);
            this.RePasswordTextBox.Name = "RePasswordTextBox";
            this.RePasswordTextBox.Size = new System.Drawing.Size(300, 28);
            this.RePasswordTextBox.PasswordChar = '*';
            // 
            // labelL3
            // 
            this.labelL3.Location = new System.Drawing.Point(20, 363);
            this.labelL3.Name = "labelL3";
            this.labelL3.Size = new System.Drawing.Size(230, 28);
            this.labelL3.Text = "Имя:";
            this.labelL3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(255, 360);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(300, 28);
            // 
            // labelL4
            // 
            this.labelL4.Location = new System.Drawing.Point(20, 403);
            this.labelL4.Name = "labelL4";
            this.labelL4.Size = new System.Drawing.Size(230, 28);
            this.labelL4.Text = "Фамилия:";
            this.labelL4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(255, 400);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(300, 28);
            // 
            // labelR0
            // 
            this.labelR0.Location = new System.Drawing.Point(600, 243);
            this.labelR0.Name = "labelR0";
            this.labelR0.Size = new System.Drawing.Size(200, 28);
            this.labelR0.Text = "Пол:";
            this.labelR0.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // genderBox
            // 
            this.genderBox.Location = new System.Drawing.Point(805, 240);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(300, 26);
            this.genderBox.DataSource = this.genderBindingSource;
            this.genderBox.DisplayMember = "Gender";
            this.genderBox.ValueMember = "Gender";
            this.genderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderBox.FormattingEnabled = true;
            // 
            // labelR1
            // 
            this.labelR1.Location = new System.Drawing.Point(600, 283);
            this.labelR1.Name = "labelR1";
            this.labelR1.Size = new System.Drawing.Size(200, 28);
            this.labelR1.Text = "Дата рождения:";
            this.labelR1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(805, 280);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(300, 28);
            // 
            // labelR2
            // 
            this.labelR2.Location = new System.Drawing.Point(600, 323);
            this.labelR2.Name = "labelR2";
            this.labelR2.Size = new System.Drawing.Size(200, 28);
            this.labelR2.Text = "Страна:";
            this.labelR2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // countryBox
            // 
            this.countryBox.Location = new System.Drawing.Point(805, 320);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(300, 26);
            this.countryBox.DataSource = this.countryBindingSource;
            this.countryBox.DisplayMember = "CountryName";
            this.countryBox.ValueMember = "CountryCode";
            this.countryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryBox.FormattingEnabled = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 40);
            this.button1.Text = "Регистрация";
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(630, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 40);
            this.button2.Text = "Отмена";
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1236, 641);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills – Меню регистрации бегунов";
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.labelR2);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(this.labelR1);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.labelR0);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.labelL4);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.labelL3);
            this.Controls.Add(this.RePasswordTextBox);
            this.Controls.Add(this.labelL2);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.labelL1);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.labelL0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marathonSkillsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MarathonSkills.MarathonSkillsDBDataSet marathonSkillsDBDataSet;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private MarathonSkills.MarathonSkillsDBDataSetTableAdapters.GenderTableAdapter genderTableAdapter;
        private MarathonSkills.MarathonSkillsDBDataSetTableAdapters.CountryTableAdapter countryTableAdapter;
        private MarathonSkills.MarathonSkillsDBDataSetTableAdapters.RunnerTableAdapter runnerTableAdapter;
        private MarathonSkills.MarathonSkillsDBDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button ButClose;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelL0;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label labelL1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label labelL2;
        private System.Windows.Forms.TextBox RePasswordTextBox;
        private System.Windows.Forms.Label labelL3;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label labelL4;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label labelR0;
        private System.Windows.Forms.ComboBox genderBox;
        private System.Windows.Forms.Label labelR1;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.Label labelR2;
        private System.Windows.Forms.ComboBox countryBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
