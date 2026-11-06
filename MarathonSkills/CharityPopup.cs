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
    // Практическая работа № 7, задание 4. Всплывающее окно «Информация о благотворительной организации»
    public partial class CharityPopup : Form
    {
        string CharityName = "";

        public CharityPopup(string CharityName)
        {
            InitializeComponent();
            this.CharityName = CharityName;
        }

        private void CharityPopup_Load(object sender, EventArgs e)
        {
            try
            {
                RunnersDataContext db = new RunnersDataContext();

                var charity = (from c in db.Charity
                               where c.CharityName == CharityName
                               select c).ToArray();

                label1.Text = charity[0].CharityName;
                // Логотипы лежат в папке CharityData в корне проекта (ПР 7)
                pictureBox1.Image = Res.LoadImage("CharityData/" + charity[0].CharityLogo, charity[0].CharityName);
                textBox1.Text = (charity[0].CharityDescription ?? "").Replace("\n", "\r\n").Replace("\r\r", "\r");
            }
            catch (Exception ee)
            {
                MessageBox.Show("Ошибка! " + ee.Message, "Внимание!");
            }
        }

        // «OK»
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
