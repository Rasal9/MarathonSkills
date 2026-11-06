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
    // Практическая работа № 26. Форма «14. Предыдущие результаты»
    public partial class Form14 : Form
    {
        int FormNumber = 0;          // номер формы, с которой открыли (10 или 17)
        string Email;
        PrevResultDataContext PrevDB = new PrevResultDataContext();

        public Form14(int FormNumber, string Email)
        {
            InitializeComponent();
            this.FormNumber = FormNumber;
            this.Email = Email;
        }

        // «Назад»
        private void button1_Click(object sender, EventArgs e)
        {
            if (FormNumber == 17)
            {
                this.Hide();
                Form17 Backfrm = new Form17(Email);
                Backfrm.Show();
            }
            else if (FormNumber == 10)
            {
                this.Hide();
                Form10 Backfrm = new Form10();
                Backfrm.Show();
            }
            else
                MessageBox.Show("Ошибка передачи параметра формы", "Внимание!");
        }

        // Время забега в секундах -> чч:мм:сс
        static string RaceTimeText(int? seconds)
        {
            if (seconds == null) return "";
            TimeSpan t = TimeSpan.FromSeconds(seconds.Value);
            return string.Format("{0:00}:{1:00}:{2:00}", (int)t.TotalHours, t.Minutes, t.Seconds);
        }

        void ShowResults(IEnumerable<Предыдущие_результаты> results)
        {
            var PrevResult_ = results.OrderBy(p => p.RaceTime).ToArray();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < PrevResult_.Count(); i++)
            {
                dataGridView1.Rows.Add(i + 1, RaceTimeText(PrevResult_[i].RaceTime), PrevResult_[i].FirstName + " " + PrevResult_[i].LastName, PrevResult_[i].CountryName);
            }
            textBox2.Text = PrevResult_.Count().ToString();
        }

        // «Поиск»
        private void button2_Click(object sender, EventArgs e)
        {
            IQueryable<Предыдущие_результаты> PrevResult_ = from p in PrevDB.Предыдущие_результаты
                                                            select p;
            if (comboBox1.SelectedItem != null)
            {
                byte marathonId = byte.Parse(comboBox1.SelectedValue.ToString());
                PrevResult_ = PrevResult_.Where(p => p.MarathonId == marathonId);
            }
            if (comboBox2.SelectedItem != null)
            {
                string eventTypeId = comboBox2.SelectedValue.ToString();
                PrevResult_ = PrevResult_.Where(p => p.EventTypeId == eventTypeId);
            }
            ShowResults(PrevResult_);
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.Date.ToString("dd.MM.yyyy");
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkillsDBDataSet.EventType".
            this.eventTypeTableAdapter.Fill(this.marathonSkillsDBDataSet.EventType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkillsDBDataSet.Marathon".
            this.marathonTableAdapter.Fill(this.marathonSkillsDBDataSet.Marathon);
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

            ShowResults(from p in PrevDB.Предыдущие_результаты select p);

            RunnersDataContext runDB = new RunnersDataContext();
            textBox1.Text = runDB.RegistrationEvent.Count().ToString();
        }

        // Если пользователь закрыл крестиком последнее видимое окно — завершаем приложение
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Program.ExitIfNoForms();
        }
    }
}
