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
    // Практическая работа № 11. Форма «9. Меню бегуна»
    public partial class Form9 : Form
    {
        string Email = "";

        public Form9(string Email)
        {
            InitializeComponent();
            this.Email = Email;
            labelDate.Text = DateTime.Now.Date.ToString("dd.MM.yyyy");
        }

        private void ButClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        // logout
        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        // «Регистрация на марафон» (ПР 13)
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm5 = new Form5(Email);
            frm5.Show();
        }

        // «Мои результаты» (ПР 14)
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form17 frm17 = new Form17(Email);
            frm17.Show();
        }

        // «Редактирование профиля» (ПР 15)
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form16 frm16 = new Form16(Email);
            frm16.Show();
        }

        // «Контакты»
        private void button5_Click(object sender, EventArgs e)
        {
            Form9Contacts frm9Cont = new Form9Contacts();
            frm9Cont.Show();
        }

        // Если пользователь закрыл крестиком последнее видимое окно — завершаем приложение
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Program.ExitIfNoForms();
        }
    }
}
