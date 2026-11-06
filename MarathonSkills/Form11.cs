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
    // Практическая работа № 23. Форма «11. Информация о Marathon Skills»
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.Date.ToString("dd.MM.yyyy");
            // Текст из файла «Ресурсы/Практическая 23/marathon-info.txt».
            // Если файл скопирован в папку проекта — берём его, иначе используем встроенный текст.
            string info = Res.ReadText("marathon-info.txt");
            richTextBox1.Text = info ?? Res.MarathonInfo;
            // Изображения из «Ресурсы/Практическая 23/marathon-photos»
            pictureBox2.Image = Res.LoadImage("marathon-photos/marathon-skills-2016-marathon-map.jpg", "Карта марафона");
            pictureBox1.Image = Res.LoadImage("marathon-photos/marathon-image-1.jpg", "Фото 1");
            pictureBox3.Image = Res.LoadImage("marathon-photos/marathon-image-2.jpg", "Фото 2");
            pictureBox4.Image = Res.LoadImage("marathon-photos/marathon-image-3.jpg", "Фото 3");
            pictureBox5.Image = Res.LoadImage("marathon-photos/marathon-image-4.jpg", "Фото 4");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 frm10 = new Form10();
            frm10.Show();
        }

        // Нажатие на карту — открываем интерактивную карту (ПР 24)
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 frm12 = new Form12();
            frm12.Show();
        }

        // Если пользователь закрыл крестиком последнее видимое окно — завершаем приложение
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Program.ExitIfNoForms();
        }
    }
}
