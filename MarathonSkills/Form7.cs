using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MarathonSkills
{
    // Практическая работа № 8. Форма «7. Подтверждение спонсорства»
    public partial class Form7 : Form
    {
        public Form7(string SelRunner, string SelCharity, string Summ)
        {
            InitializeComponent();
            labelDate.Text = DateTime.Now.Date.ToString("dd.MM.yyyy");
            label4.Text = SelRunner;
            label5.Text = SelCharity;
            label6.Text = Summ;
        }

        private void ButClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        // «OK»
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        // Если пользователь закрыл крестиком последнее видимое окно — завершаем приложение
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Program.ExitIfNoForms();
        }
    }
}
