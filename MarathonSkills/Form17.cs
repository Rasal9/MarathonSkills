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
    // Практическая работа № 14. Форма «17. Мои результаты»
    public partial class Form17 : Form
    {
        string Email = "";

        public Form17(string Email)
        {
            InitializeComponent();
            this.Email = Email;
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkillsDBDataSet.Мои_результаты".
            this.мои_результатыTableAdapter.Fill(this.marathonSkillsDBDataSet.Мои_результаты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkillsDBDataSet.Runner".
            this.runnerTableAdapter.Fill(this.marathonSkillsDBDataSet.Runner);
            labelDate.Text = DateTime.Now.Date.ToString("dd.MM.yyyy");
            RunnersDataContext UsRun = new RunnersDataContext();
            var runner = (from u in UsRun.Runner
                          select u).ToArray();
            for (int i = 0; i < runner.Count(); i++)
            {
                if (runner[i].Email == Email)
                {
                    genderTextBox.Text = runner[i].Gender;
                    int Age = runner[i].DateOfBirth.HasValue ? System.DateTime.Now.Date.Year - runner[i].DateOfBirth.Value.Year : 0;
                    if (Age < 18) AgeBox.Text = "до 18 лет";
                    else if (Age >= 18 && Age <= 29) AgeBox.Text = "18-29";
                    else if (Age >= 30 && Age <= 39) AgeBox.Text = "30-39";
                    else if (Age >= 40 && Age <= 55) AgeBox.Text = "40-55";
                    else if (Age >= 56 && Age <= 70) AgeBox.Text = "56-70";
                    else if (Age > 70) AgeBox.Text = "более 70";
                    моиРезультатыBindingSource.Filter = "RunnerId=" + runner[i].RunnerId.ToString();
                    break;
                }
            }
            if (моиРезультатыBindingSource.Filter == null) моиРезультатыBindingSource.Filter = "RunnerId=-1";
            // выводим только отфильтрованные (результаты текущего бегуна) строки
            for (int i = 0; i < моиРезультатыBindingSource.Count; i++)
            {
                DataRowView row = (DataRowView)моиРезультатыBindingSource[i];
                object t = row["RaceTime"];
                string time = t == DBNull.Value ? "" : TimeSpan.FromSeconds((int)t).ToString();
                dataGridView1.Rows.Add(row["MarathonName"], row["EventTypeName"], time);
            }
        }

        private void ButClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 frm9 = new Form9(Email);
            frm9.Show();
        }

        // logout — возврат на форму авторизации (код этой кнопки одинаков во всём приложении)
        private void butLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        // «Показать все результаты» (ПР 26)
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form14 frm14 = new Form14(17, Email);
            frm14.Show();
        }

        // Если пользователь закрыл крестиком последнее видимое окно — завершаем приложение
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Program.ExitIfNoForms();
        }
    }
}
