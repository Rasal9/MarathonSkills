namespace MarathonSkills
{
    partial class Form5
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
            this.raceKitOptionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raceKitOptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marathonSkillsDBDataSet = new MarathonSkills.MarathonSkillsDBDataSet();
            this.raceKitOptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.charityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raceKitOptionTableAdapter = new MarathonSkills.MarathonSkillsDBDataSetTableAdapters.RaceKitOptionTableAdapter();
            this.charityTableAdapter = new MarathonSkills.MarathonSkillsDBDataSetTableAdapters.CharityTableAdapter();
            this.registrationTableAdapter = new MarathonSkills.MarathonSkillsDBDataSetTableAdapters.RegistrationTableAdapter();
            this.registrationEventTableAdapter = new MarathonSkills.MarathonSkillsDBDataSetTableAdapters.RegistrationEventTableAdapter();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.ButClose = new System.Windows.Forms.Button();
            this.butLogout = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EventTypeList = new System.Windows.Forms.CheckedListBox();
            this.RaceKitView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.MoneyBox = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1Money = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marathonSkillsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceKitOptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RaceKitView)).BeginInit();
            this.SuspendLayout();
            // 
            // marathonSkillsDBDataSet
            // 
            this.marathonSkillsDBDataSet.DataSetName = "MarathonSkillsDBDataSet";
            // 
            // raceKitOptionBindingSource
            // 
            this.raceKitOptionBindingSource.DataMember = "RaceKitOption";
            this.raceKitOptionBindingSource.DataSource = this.marathonSkillsDBDataSet;
            // 
            // charityBindingSource
            // 
            this.charityBindingSource.DataMember = "Charity";
            this.charityBindingSource.DataSource = this.marathonSkillsDBDataSet;
            // 
            // raceKitOptionTableAdapter
            // 
            this.raceKitOptionTableAdapter.ClearBeforeFill = true;
            // 
            // charityTableAdapter
            // 
            this.charityTableAdapter.ClearBeforeFill = true;
            // 
            // registrationTableAdapter
            // 
            this.registrationTableAdapter.ClearBeforeFill = true;
            // 
            // registrationEventTableAdapter
            // 
            this.registrationEventTableAdapter.ClearBeforeFill = true;
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
            this.panelTop.Size = new System.Drawing.Size(1150, 131);
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top)) | ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left)) | ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Right));
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.Gold;
            this.labelTitle.Location = new System.Drawing.Point(0, 6);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1150, 40);
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
            this.labelCity.Size = new System.Drawing.Size(1150, 24);
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
            this.labelDate.Size = new System.Drawing.Size(1150, 22);
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
            this.butLogout.Location = new System.Drawing.Point(1030, 20);
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
            this.panelBottom.Location = new System.Drawing.Point(0, 732);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1150, 51);
            this.panelBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom)) | ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left)) | ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Right));
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1150, 39);
            this.label1.Text = "Регистрация на марафон";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(0, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1150, 52);
            this.label2.Text = "Пожалуйста заполните всю информацию, чтобы зарегистрироваться на Marathon Skills 2016.\r\nС вами свяжутся после регистрации для уточнения оплаты и другой информации.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(60, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(480, 30);
            this.label3.Text = "Вид марафона";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(600, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(480, 30);
            this.label4.Text = "Варианты комплектов";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EventTypeList
            // 
            this.EventTypeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.EventTypeList.Location = new System.Drawing.Point(110, 290);
            this.EventTypeList.Name = "EventTypeList";
            this.EventTypeList.Size = new System.Drawing.Size(380, 150);
            this.EventTypeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EventTypeList.CheckOnClick = true;
            this.EventTypeList.FormattingEnabled = true;
            this.EventTypeList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.EventTypeList_ItemCheck);
            // 
            // RaceKitView
            // 
            this.RaceKitView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.raceKitOptionId,
                this.raceKitOptionDataGridViewTextBoxColumn,
                this.costDataGridViewTextBoxColumn});
            this.RaceKitView.Location = new System.Drawing.Point(620, 290);
            this.RaceKitView.Name = "RaceKitView";
            this.RaceKitView.Size = new System.Drawing.Size(460, 150);
            this.RaceKitView.AllowUserToAddRows = false;
            this.RaceKitView.AllowUserToDeleteRows = false;
            this.RaceKitView.AutoGenerateColumns = false;
            this.RaceKitView.DataSource = this.raceKitOptionBindingSource;
            this.RaceKitView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.RaceKitView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RaceKitView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RaceKitView.ReadOnly = true;
            this.RaceKitView.RowHeadersVisible = false;
            this.RaceKitView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RaceKitView.ColumnHeadersVisible = false;
            this.RaceKitView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.RaceKitView.MultiSelect = false;
            this.RaceKitView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RaceKitView_CellContentClick);
            // 
            // raceKitOptionId
            // 
            this.raceKitOptionId.DataPropertyName = "RaceKitOptionId";
            this.raceKitOptionId.HeaderText = "Id";
            this.raceKitOptionId.Name = "raceKitOptionId";
            this.raceKitOptionId.Width = 40;
            // 
            // raceKitOptionDataGridViewTextBoxColumn
            // 
            this.raceKitOptionDataGridViewTextBoxColumn.DataPropertyName = "RaceKitOption";
            this.raceKitOptionDataGridViewTextBoxColumn.HeaderText = "Комплект";
            this.raceKitOptionDataGridViewTextBoxColumn.Name = "raceKitOptionDataGridViewTextBoxColumn";
            this.raceKitOptionDataGridViewTextBoxColumn.Width = 330;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 80;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(60, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(480, 30);
            this.label5.Text = "Детали спонсорства";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(60, 523);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 24);
            this.label6.Text = "Взнос:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(235, 520);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 26);
            this.comboBox1.DataSource = this.charityBindingSource;
            this.comboBox1.DisplayMember = "CharityName";
            this.comboBox1.ValueMember = "CharityId";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.Text = "i";
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(60, 563);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 24);
            this.label7.Text = "Сумма взноса:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MoneyBox
            // 
            this.MoneyBox.Location = new System.Drawing.Point(235, 560);
            this.MoneyBox.Name = "MoneyBox";
            this.MoneyBox.Size = new System.Drawing.Size(250, 26);
            this.MoneyBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.DarkRed;
            this.labelError.Location = new System.Drawing.Point(235, 592);
            this.labelError.Name = "labelError";
            this.labelError.Text = "";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(600, 470);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(480, 30);
            this.label8.Text = "Регистрационный взнос";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1Money
            // 
            this.label1Money.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1Money.ForeColor = System.Drawing.Color.Silver;
            this.label1Money.Location = new System.Drawing.Point(600, 515);
            this.label1Money.Name = "label1Money";
            this.label1Money.Size = new System.Drawing.Size(480, 70);
            this.label1Money.Text = "$0";
            this.label1Money.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(330, 640);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 40);
            this.button2.Text = "Регистрация";
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(520, 640);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 40);
            this.button3.Text = "Отмена";
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form5
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1150, 783);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills – Регистрация на марафон";
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1Money);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.MoneyBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RaceKitView);
            this.Controls.Add(this.EventTypeList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marathonSkillsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceKitOptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RaceKitView)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MarathonSkills.MarathonSkillsDBDataSet marathonSkillsDBDataSet;
        private System.Windows.Forms.BindingSource raceKitOptionBindingSource;
        private System.Windows.Forms.BindingSource charityBindingSource;
        private MarathonSkills.MarathonSkillsDBDataSetTableAdapters.RaceKitOptionTableAdapter raceKitOptionTableAdapter;
        private MarathonSkills.MarathonSkillsDBDataSetTableAdapters.CharityTableAdapter charityTableAdapter;
        private MarathonSkills.MarathonSkillsDBDataSetTableAdapters.RegistrationTableAdapter registrationTableAdapter;
        private MarathonSkills.MarathonSkillsDBDataSetTableAdapters.RegistrationEventTableAdapter registrationEventTableAdapter;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button ButClose;
        private System.Windows.Forms.Button butLogout;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox EventTypeList;
        private System.Windows.Forms.DataGridView RaceKitView;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceKitOptionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceKitOptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MoneyBox;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1Money;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
