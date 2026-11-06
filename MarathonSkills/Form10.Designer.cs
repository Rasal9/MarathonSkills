namespace MarathonSkills
{
    partial class Form10
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.ButClose = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
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
            this.panelBottom.Location = new System.Drawing.Point(0, 546);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1100, 51);
            this.panelBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom)) | ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left)) | ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Right));
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1100, 52);
            this.label1.Text = "Подробная информация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(300, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 50);
            this.button3.Text = "Marathon Skills 2016";
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(560, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 50);
            this.button2.Text = "Насколько долгий марафон";
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(300, 300);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(240, 50);
            this.button4.Text = "Предыдущие результаты";
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(560, 300);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(240, 50);
            this.button5.Text = "Список благотворительных организаций";
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form10
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1100, 597);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2016 – Подробная информация";
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button ButClose;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}
