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
    // Практическая работа № 16. Форма «19. Меню координатора»
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void Form19_Load(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.Date.ToString("dd.MM.yyyy");
        }

        private void ButClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        // logout — возврат на форму авторизации (код этой кнопки одинаков во всём приложении)
        private void butLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        // «Бегуны» (ПР 17)
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form22 frm22 = new Form22();
            frm22.Show();
        }

        // Если пользователь закрыл крестиком последнее видимое окно — завершаем приложение
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Program.ExitIfNoForms();
        }
    }
}
