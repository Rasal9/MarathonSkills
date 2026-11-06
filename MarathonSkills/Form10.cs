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
    // Практическая работа № 22. Форма «10. Подробная информация»
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.Date.ToString("dd.MM.yyyy");
        }

        private void ButClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        // «Marathon Skills 2016» (ПР 23)
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 frm11 = new Form11();
            frm11.Show();
        }

        // «Насколько долгий марафон» (ПР 25)
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form15 frm15 = new Form15();
            frm15.Show();
        }

        // «Предыдущие результаты» (ПР 26)
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form14 frm14 = new Form14(10, null);
            frm14.Show();
        }

        // «Список благотворительных организаций» (ПР 27)
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 frm13 = new Form13();
            frm13.Show();
        }

        // Если пользователь закрыл крестиком последнее видимое окно — завершаем приложение
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Program.ExitIfNoForms();
        }
    }
}
