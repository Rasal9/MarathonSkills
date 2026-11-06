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
    // Практическая работа № 24. Форма «12. Интерактивная карта»
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // Карта и значки из папки «Ресурсы/Практическая 24»
            pictureBox1.Image = Res.LoadImage("map-icons/marathon-skills-2016-marathon-map.jpg", null) ?? Res.DrawMap(pictureBox1.Width, pictureBox1.Height);
            foreach (Control c in pictureBox1.Controls)
            {
                PictureBox pb = c as PictureBox;
                if (pb == null) continue;
                string panel = (string)pb.Tag;
                if (panel.StartsWith("cp"))
                    pb.Image = Res.LoadImage("map-icons/map-icon-checkpoint-" + panel.Substring(2) + ".png", null) ?? Res.DrawMarker(panel.Substring(2), false);
                else
                    pb.Image = Res.LoadImage("map-icons/map-icon-start.png", null) ?? Res.DrawMarker("START", true);
            }
            // значки особенностей контрольных точек
            foreach (Control panel in intetativeP.Controls)
                foreach (Control c in panel.Controls)
                {
                    PictureBox pb = c as PictureBox;
                    if (pb != null && pb.Tag != null)
                        pb.Image = Res.LoadImage("map-icons/" + pb.Tag, null) ?? Res.DrawIcon((string)pb.Tag);
                }
        }

        private void ButClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 frm11 = new Form11();
            frm11.Show();
        }

        // «X» — закрыть панель с информацией
        private void closeInteractiveP_Click(object sender, EventArgs e)
        {
            setInteractivePanel(null);
            closeInteractiveP.Visible = false;
        }

        // Показывает только переданную панель, остальные скрывает
        void setInteractivePanel(Panel panel)
        {
            int i = 40;
            foreach (Control c in intetativeP.Controls)
            {
                if (c is Panel)
                {
                    c.Visible = false;
                    c.TabIndex = i++;
                }
            }
            closeInteractiveP.Visible = false;

            if (panel != null)
            {
                panel.Visible = true;
                closeInteractiveP.Visible = true;
                closeInteractiveP.BringToFront();
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            setInteractivePanel(cp1);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            setInteractivePanel(cp2);
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            setInteractivePanel(cp3);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            setInteractivePanel(cp4);
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            setInteractivePanel(cp5);
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            setInteractivePanel(cp6);
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            setInteractivePanel(cp7);
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            setInteractivePanel(cp8);
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            setInteractivePanel(raceStart1);
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            setInteractivePanel(raceStart2);
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            setInteractivePanel(raceStart3);
        }

        // Если пользователь закрыл крестиком последнее видимое окно — завершаем приложение
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Program.ExitIfNoForms();
        }
    }
}
