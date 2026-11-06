namespace MarathonSkills
{
    partial class Form22
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marathonSkillsDBDataSet = new MarathonSkills.MarathonSkillsDBDataSet();
            this.registrationStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.runnerManageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrationStatusTableAdapter = new MarathonSkills.MarathonSkillsDBDataSetTableAdapters.RegistrationStatusTableAdapter();
            this.runnerManageTableAdapter = new MarathonSkills.MarathonSkillsDBDataSetTableAdapters.runnerManageTableAdapter();
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
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sortBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.runnersManageDGV = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marathonSkillsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnerManageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnersManageDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // marathonSkillsDBDataSet
            // 
            this.marathonSkillsDBDataSet.DataSetName = "MarathonSkillsDBDataSet";
            // 
            // registrationStatusBindingSource
            // 
            this.registrationStatusBindingSource.DataMember = "RegistrationStatus";
            this.registrationStatusBindingSource.DataSource = this.marathonSkillsDBDataSet;
            // 
            // runnerManageBindingSource
            // 
            this.runnerManageBindingSource.DataMember = "runnerManage";
            this.runnerManageBindingSource.DataSource = this.marathonSkillsDBDataSet;
            // 
            // registrationStatusTableAdapter
            // 
            this.registrationStatusTableAdapter.ClearBeforeFill = true;
            // 
            // runnerManageTableAdapter
            // 
            this.runnerManageTableAdapter.ClearBeforeFill = true;
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
            this.panelTop.Size = new System.Drawing.Size(1128, 131);
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top)) | ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left)) | ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Right));
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.Gold;
            this.labelTitle.Location = new System.Drawing.Point(0, 6);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1128, 40);
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
            this.labelCity.Size = new System.Drawing.Size(1128, 24);
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
            this.labelDate.Size = new System.Drawing.Size(1128, 22);
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
            this.butLogout.Location = new System.Drawing.Point(1008, 20);
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
            this.panelBottom.Location = new System.Drawing.Point(0, 778);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1128, 51);
            this.panelBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom)) | ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left)) | ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Right));
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1128, 39);
            this.label1.Text = "Управление бегунами";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(60, 190);
            this.label2.Name = "label2";
            this.label2.Text = "Сортировка и фильтрация";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(40, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 24);
            this.label3.Text = "Статус:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // StatusBox
            // 
            this.StatusBox.Location = new System.Drawing.Point(195, 230);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(230, 26);
            this.StatusBox.DataSource = this.registrationStatusBindingSource;
            this.StatusBox.DisplayMember = "RegistrationStatus";
            this.StatusBox.ValueMember = "RegistrationStatusId";
            this.StatusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusBox.FormattingEnabled = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(40, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 24);
            this.label4.Text = "Сортировать:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sortBox
            // 
            this.sortBox.Location = new System.Drawing.Point(195, 270);
            this.sortBox.Name = "sortBox";
            this.sortBox.Size = new System.Drawing.Size(230, 26);
            this.sortBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortBox.FormattingEnabled = true;
            this.sortBox.Items.AddRange(new object[] {
                "Имя",
                "Фамилия",
                "Email",
                "Статус"});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 34);
            this.button1.Text = "Обновить";
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 360);
            this.label5.Name = "label5";
            this.label5.Text = "Всего бегунов:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(265, 360);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 26);
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(820, 190);
            this.label6.Name = "label6";
            this.label6.Text = "Выгрузка";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(720, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(320, 36);
            this.button2.Text = "Детальная информация (CSV)";
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(720, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(320, 36);
            this.button3.Text = "E-mail список";
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // runnersManageDGV
            // 
            this.runnersManageDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.dataGridViewTextBoxColumn1,
                this.dataGridViewTextBoxColumn2,
                this.dataGridViewTextBoxColumn3,
                this.dataGridViewTextBoxColumn4,
                this.dataGridViewTextBoxColumn5,
                this.dataGridViewTextBoxColumn6,
                this.dataGridViewTextBoxColumn7,
                this.dataGridViewTextBoxColumn8,
                this.dataGridViewTextBoxColumn9,
                this.dataGridViewTextBoxColumn10,
                this.dataGridViewTextBoxColumn11});
            this.runnersManageDGV.Location = new System.Drawing.Point(20, 400);
            this.runnersManageDGV.Name = "runnersManageDGV";
            this.runnersManageDGV.Size = new System.Drawing.Size(1090, 365);
            this.runnersManageDGV.AllowUserToAddRows = false;
            this.runnersManageDGV.AllowUserToDeleteRows = false;
            this.runnersManageDGV.AutoGenerateColumns = false;
            this.runnersManageDGV.DataSource = this.runnerManageBindingSource;
            this.runnersManageDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.runnersManageDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.runnersManageDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.runnersManageDGV.ReadOnly = true;
            this.runnersManageDGV.RowHeadersVisible = false;
            this.runnersManageDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 220;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 220;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn3.HeaderText = "Email";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 330;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RegistrationStatus";
            this.dataGridViewTextBoxColumn4.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 280;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RunnerId";
            this.dataGridViewTextBoxColumn5.HeaderText = "RunnerId";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MarathonId";
            this.dataGridViewTextBoxColumn6.HeaderText = "MarathonId";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "RegistrationStatusId";
            this.dataGridViewTextBoxColumn7.HeaderText = "RegistrationStatusId";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn8.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "EventId";
            this.dataGridViewTextBoxColumn9.HeaderText = "EventId";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "EventTypeId";
            this.dataGridViewTextBoxColumn10.HeaderText = "EventTypeId";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "EventTypeName";
            this.dataGridViewTextBoxColumn11.HeaderText = "EventTypeName";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // Form22
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1128, 829);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.AutoScroll = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills – Управление бегунами";
            this.Controls.Add(this.runnersManageDGV);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sortBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "Form22";
            this.Load += new System.EventHandler(this.Form22_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marathonSkillsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnerManageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnersManageDGV)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MarathonSkills.MarathonSkillsDBDataSet marathonSkillsDBDataSet;
        private System.Windows.Forms.BindingSource registrationStatusBindingSource;
        private System.Windows.Forms.BindingSource runnerManageBindingSource;
        private MarathonSkills.MarathonSkillsDBDataSetTableAdapters.RegistrationStatusTableAdapter registrationStatusTableAdapter;
        private MarathonSkills.MarathonSkillsDBDataSetTableAdapters.runnerManageTableAdapter runnerManageTableAdapter;
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
        private System.Windows.Forms.ComboBox StatusBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sortBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView runnersManageDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}
