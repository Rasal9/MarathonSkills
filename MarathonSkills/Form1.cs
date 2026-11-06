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
    // Практическая работа № 6. Форма «1. Главный экран системы»
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.Date.Day.ToString() + "." + DateTime.Now.Date.Month.ToString() + "." + DateTime.Now.Date.Year.ToString();
        }

        // «Я хочу стать бегуном» (ПР 9)
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        // «Я хочу стать спонсором бегуна» (ПР 7)
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 frm6 = new Form6();
            frm6.Show();
        }

        // «Я хочу узнать больше о событии» (ПР 22)
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 frm10 = new Form10();
            frm10.Show();
        }

        // «Login» (ПР 10)
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        // Если пользователь закрыл крестиком последнее видимое окно — завершаем приложение
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Program.ExitIfNoForms();
        }
    }
}
