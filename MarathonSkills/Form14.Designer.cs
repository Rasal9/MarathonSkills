namespace MarathonSkills
{
    partial class Form14
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
            this.ColumnPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marathonSkillsDBDataSet = new MarathonSkills.MarathonSkillsDBDataSet();
            this.marathonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marathonTableAdapter = new MarathonSkills.MarathonSkillsDBDataSetTableAdapters.MarathonTableAdapter();
            this.eventTypeTableAdapter = new MarathonSkills.MarathonSkillsDBDataSetTableAdapters.EventTypeTableAdapter();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.ButClose = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marathonSkillsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // marathonSkillsDBDataSet
            // 
            this.marathonSkillsDBDataSet.DataSetName = "MarathonSkillsDBDataSet";
            // 
            // marathonBindingSource
            // 
            this.marathonBindingSource.DataMember = "Marathon";
            this.marathonBindingSource.DataSource = this.marathonSkillsDBDataSet;
            // 
            // eventTypeBindingSource
            // 
            this.eventTypeBindingSource.DataMember = "EventType";
            this.eventTypeBindingSource.DataSource = this.marathonSkillsDBDataSet;
            // 
            // marathonTableAdapter
            // 
            this.marathonTableAdapter.ClearBeforeFill = true;
            // 
            // eventTypeTableAdapter
            // 
            this.eventTypeTableAdapter.ClearBeforeFill = true;
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
            this.panelTop.Size = new System.Drawing.Size(1180, 131);
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top)) | ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left)) | ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Right));
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.Gold;
            this.labelTitle.Location = new System.Drawing.Point(0, 6);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1180, 40);
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
            this.labelCity.Size = new System.Drawing.Size(1180, 24);
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
            this.labelDate.Size = new System.Drawing.Size(1180, 22);
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
            this.ButClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(29)))), ((int)(((byte)(112)))));
            this.panelBottom.Location = new System.Drawing.Point(0, 670);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1180, 51);
            this.panelBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom)) | ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left)) | ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Right));
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1180, 44);
            this.label1.Text = "Результаты предыдущих гонок";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 203);
            this.label2.Name = "label2";
            this.label2.Text = "Марафон:";
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(140, 200);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(270, 26);
            this.comboBox1.DataSource = this.marathonBindingSource;
            this.comboBox1.DisplayMember = "MarathonName";
            this.comboBox1.ValueMember = "MarathonId";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 203);
            this.label3.Name = "label3";
            this.label3.Text = "Дистанция:";
            // 
            // comboBox2
            // 
            this.comboBox2.Location = new System.Drawing.Point(560, 200);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(270, 26);
            this.comboBox2.DataSource = this.eventTypeBindingSource;
            this.comboBox2.DisplayMember = "EventTypeName";
            this.comboBox2.ValueMember = "EventTypeId";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(880, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 34);
            this.button2.Text = "Поиск";
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 260);
            this.label4.Name = "label4";
            this.label4.Text = "Всего бегунов:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(260, 260);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 26);
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 260);
            this.label5.Name = "label5";
            this.label5.Text = "Всего бегунов финишировало:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(720, 260);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 26);
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.ColumnPlace,
                this.ColumnTime,
                this.ColumnName,
                this.ColumnCountry});
            this.dataGridView1.Location = new System.Drawing.Point(120, 305);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(900, 340);
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            // 
            // ColumnPlace
            // 
            this.ColumnPlace.HeaderText = "Место";
            this.ColumnPlace.Name = "ColumnPlace";
            this.ColumnPlace.Width = 90;
            // 
            // ColumnTime
            // 
            this.ColumnTime.HeaderText = "Время";
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.Width = 140;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Имя бегуна";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 380;
            // 
            // ColumnCountry
            // 
            this.ColumnCountry.HeaderText = "Страна";
            this.ColumnCountry.Name = "ColumnCountry";
            this.ColumnCountry.Width = 270;
            // 
            // Form14
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1180, 721);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2016 – Результаты предыдущих гонок";
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "Form14";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marathonSkillsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MarathonSkills.MarathonSkillsDBDataSet marathonSkillsDBDataSet;
        private System.Windows.Forms.BindingSource marathonBindingSource;
        private System.Windows.Forms.BindingSource eventTypeBindingSource;
        private MarathonSkills.MarathonSkillsDBDataSetTableAdapters.MarathonTableAdapter marathonTableAdapter;
        private MarathonSkills.MarathonSkillsDBDataSetTableAdapters.EventTypeTableAdapter eventTypeTableAdapter;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button ButClose;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCountry;
    }
}
