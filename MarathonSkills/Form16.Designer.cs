namespace MarathonSkills
{
    partial class Form16
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
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.runnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.butLogout = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelF0 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.labelF1 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.labelF2 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.labelF3 = new System.Windows.Forms.Label();
            this.GenderBox = new System.Windows.Forms.ComboBox();
            this.labelF4 = new System.Windows.Forms.Label();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelF5 = new System.Windows.Forms.Label();
            this.CountryBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelP1 = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.labelP2 = new System.Windows.Forms.Label();
            this.RePasswordBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marathonSkillsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // marathonSkillsDBDataSet
            // 
            this.marathonSkillsDBDataSet.DataSetName = "MarathonSkillsDBDataSet";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.marathonSkillsDBDataSet;
            // 
            // runnerBindingSource
            // 
            this.runnerBindingSource.DataMember = "FK_Runner_User";
            this.runnerBindingSource.DataSource = this.userBindingSource;
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
            this.panelTop.Controls.Add(this.butLogout);
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
            // butLogout
            // 
            this.butLogout.Location = new System.Drawing.Point(980, 20);
            this.butLogout.Name = "butLogout";
            this.butLogout.Size = new System.Drawing.Size(100, 32);
            this.butLogout.Text = "logout";
            this.butLogout.BackColor = System.Drawing.SystemColors.Control;
            this.butLogout.UseVisualStyleBackColor = true;
            this.butLogout.Click += new System.EventHandler(this.butLogout_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(29)))), ((int)(((byte)(112)))));
            this.panelBottom.Location = new System.Drawing.Point(0, 610);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1100, 51);
            this.panelBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom)) | ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left)) | ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Right));
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1100, 39);
            this.label1.Text = "Редактирование профиля пользователя";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelF0
            // 
            this.labelF0.Location = new System.Drawing.Point(20, 203);
            this.labelF0.Name = "labelF0";
            this.labelF0.Size = new System.Drawing.Size(200, 24);
            this.labelF0.Text = "Email:";
            this.labelF0.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // emailTextBox
            // 
            this.emailTextBox.ForeColor = System.Drawing.Color.Silver;
            this.emailTextBox.Location = new System.Drawing.Point(225, 203);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(300, 26);
            this.emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            // 
            // labelF1
            // 
            this.labelF1.Location = new System.Drawing.Point(20, 245);
            this.labelF1.Name = "labelF1";
            this.labelF1.Size = new System.Drawing.Size(200, 24);
            this.labelF1.Text = "Имя:";
            this.labelF1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(225, 242);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(300, 26);
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "FirstName", true));
            // 
            // labelF2
            // 
            this.labelF2.Location = new System.Drawing.Point(20, 287);
            this.labelF2.Name = "labelF2";
            this.labelF2.Size = new System.Drawing.Size(200, 24);
            this.labelF2.Text = "Фамилия:";
            this.labelF2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(225, 284);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(300, 26);
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "LastName", true));
            // 
            // labelF3
            // 
            this.labelF3.Location = new System.Drawing.Point(20, 329);
            this.labelF3.Name = "labelF3";
            this.labelF3.Size = new System.Drawing.Size(200, 24);
            this.labelF3.Text = "Пол:";
            this.labelF3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // GenderBox
            // 
            this.GenderBox.Location = new System.Drawing.Point(225, 326);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(300, 26);
            this.GenderBox.DataSource = this.genderBindingSource;
            this.GenderBox.DisplayMember = "Gender";
            this.GenderBox.ValueMember = "Gender";
            this.GenderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.runnerBindingSource, "Gender", true));
            // 
            // labelF4
            // 
            this.labelF4.Location = new System.Drawing.Point(20, 371);
            this.labelF4.Name = "labelF4";
            this.labelF4.Size = new System.Drawing.Size(200, 24);
            this.labelF4.Text = "Дата рождения:";
            this.labelF4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(225, 368);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(300, 26);
            this.dateOfBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.runnerBindingSource, "DateOfBirth", true));
            // 
            // labelF5
            // 
            this.labelF5.Location = new System.Drawing.Point(20, 413);
            this.labelF5.Name = "labelF5";
            this.labelF5.Size = new System.Drawing.Size(200, 24);
            this.labelF5.Text = "Страна:";
            this.labelF5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CountryBox
            // 
            this.CountryBox.Location = new System.Drawing.Point(225, 410);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(300, 26);
            this.CountryBox.DataSource = this.countryBindingSource;
            this.CountryBox.DisplayMember = "CountryName";
            this.CountryBox.ValueMember = "CountryCode";
            this.CountryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CountryBox.FormattingEnabled = true;
            this.CountryBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.runnerBindingSource, "CountryCode", true));
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(640, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 28);
            this.label2.Text = "Смена пароля";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(640, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(420, 48);
            this.label3.Text = "Оставьте эти поля, незаполненными, если\r\nвы не хотите изменять пароль.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelP1
            // 
            this.labelP1.Location = new System.Drawing.Point(600, 303);
            this.labelP1.Name = "labelP1";
            this.labelP1.Size = new System.Drawing.Size(190, 24);
            this.labelP1.Text = "Пароль:";
            this.labelP1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(795, 300);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(260, 26);
            this.PasswordBox.PasswordChar = '*';
            // 
            // labelP2
            // 
            this.labelP2.Location = new System.Drawing.Point(600, 343);
            this.labelP2.Name = "labelP2";
            this.labelP2.Size = new System.Drawing.Size(190, 24);
            this.labelP2.Text = "Повтор пароля:";
            this.labelP2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // RePasswordBox
            // 
            this.RePasswordBox.Location = new System.Drawing.Point(795, 340);
            this.RePasswordBox.Name = "RePasswordBox";
            this.RePasswordBox.Size = new System.Drawing.Size(260, 26);
            this.RePasswordBox.PasswordChar = '*';
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 40);
            this.button1.Text = "Сохранить";
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(560, 490);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 40);
            this.button2.Text = "Отмена";
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButClose_Click);
            // 
            // Form16
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1100, 661);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills – Редактирование профиля";
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RePasswordBox);
            this.Controls.Add(this.labelP2);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.labelP1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CountryBox);
            this.Controls.Add(this.labelF5);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(this.labelF4);
            this.Controls.Add(this.GenderBox);
            this.Controls.Add(this.labelF3);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.labelF2);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.labelF1);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.labelF0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "Form16";
            this.Load += new System.EventHandler(this.Form16_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marathonSkillsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MarathonSkills.MarathonSkillsDBDataSet marathonSkillsDBDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource runnerBindingSource;
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
        private System.Windows.Forms.Button butLogout;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelF0;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label labelF1;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label labelF2;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label labelF3;
        private System.Windows.Forms.ComboBox GenderBox;
        private System.Windows.Forms.Label labelF4;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.Label labelF5;
        private System.Windows.Forms.ComboBox CountryBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelP1;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label labelP2;
        private System.Windows.Forms.TextBox RePasswordBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
