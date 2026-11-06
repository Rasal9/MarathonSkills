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
    // Практическая работа № 25. Форма «15. Насколько долгий марафон»
    // Данные — из файла «Ресурсы/Практическая 25/how-long-is-a-marathon-data.xlsx»
    public partial class Form15 : Form
    {
        double Speed;      // скорость, км/ч
        double Distanc;    // длина, км
        double marathIn;   // результат расчёта

        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.Date.ToString("dd.MM.yyyy");
            foreach (TabPage page in tabControl1.TabPages)
                foreach (Control c in page.Controls)
                {
                    PictureBox pb = c as PictureBox;
                    if (pb != null)
                        pb.Image = Res.LoadImage("how-long-is-a-marathon-images/" + pb.Tag, (string)pb.Tag);
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 frm10 = new Form10();
            frm10.Show();
        }

        // ---- вкладка «Скорость»: время прохождения 42 км
        void ShowSpeed(PictureBox pb, Label lb, double speed)
        {
            pictureBox2.Image = pb.Image;
            label3.Text = lb.Text;
            Speed = speed;
            marathIn = 42 / Speed;
            labelInfo.Text = label3.Text + " развивает максимальную скорость " + Speed.ToString() + " км/ч. \nЭто займет "
                + Math.Round(marathIn, 2).ToString() + " часов, \nчтобы завершить 42 км марафон";
        }

        // ---- вкладка «Дистанция»: сколько таких объектов в 42 км
        void ShowDistance(PictureBox pb, Label lb, double metres)
        {
            pictureBox2.Image = pb.Image;
            label3.Text = lb.Text;
            Distanc = metres / 1000;
            marathIn = 42 / Distanc;
            labelInfo.Text = label3.Text + " достигает длины " + (Distanc * 1000).ToString() + " м. \nЭто займет "
                + Math.Round(marathIn).ToString() + " из них, \nчтобы завершить 42 км марафон";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ShowSpeed(pictureBox8, label9, 345);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ShowSpeed(pictureBox9, label10, 0.03);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            ShowSpeed(pictureBox10, label11, 0.12);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            ShowSpeed(pictureBox11, label12, 35);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            ShowSpeed(pictureBox13, label13, 80);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ShowDistance(pictureBox3, label4, 73);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ShowDistance(pictureBox4, label5, 0.245);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ShowDistance(pictureBox5, label6, 105);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ShowDistance(pictureBox6, label7, 1.81);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ShowDistance(pictureBox7, label8, 10);
        }

        // Если пользователь закрыл крестиком последнее видимое окно — завершаем приложение
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Program.ExitIfNoForms();
        }
    }
}
