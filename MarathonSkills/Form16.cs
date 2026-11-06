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
    // Практическая работа № 15. Форма «16. Редактирование профиля»
    public partial class Form16 : Form
    {
        string Email;
        RunnersDataContext UsDB = new RunnersDataContext();

        public Form16(string Email)
        {
            InitializeComponent();
            this.Email = Email;
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.Date.ToString("dd.MM.yyyy");
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkillsDBDataSet.Gender".
            this.genderTableAdapter.Fill(this.marathonSkillsDBDataSet.Gender);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkillsDBDataSet.Country".
            this.countryTableAdapter.Fill(this.marathonSkillsDBDataSet.Country);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkillsDBDataSet.Runner".
            this.runnerTableAdapter.Fill(this.marathonSkillsDBDataSet.Runner);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkillsDBDataSet.User".
            this.userTableAdapter.Fill(this.marathonSkillsDBDataSet.User);

            ShowCurrentUser();
        }

        // Переход к записи текущего пользователя
        void ShowCurrentUser()
        {
            int i = userBindingSource.Find("Email", Email);
            if (i >= 0) userBindingSource.Position = i;
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

        // «Сохранить»
        private void button1_Click(object sender, EventArgs e)
        {
            var user = (from u in UsDB.User
                        where u.Email == Email
                        select u).ToArray();
            var Runner = (from r in UsDB.Runner
                          where r.Email == Email
                          select r).ToArray();
            if (user.Length == 0 || Runner.Length == 0) { MessageBox.Show("Пользователь не найден", "Внимание!"); return; }

            if (firstNameTextBox.Text != "") user[0].FirstName = firstNameTextBox.Text; else MessageBox.Show("Не заполнено поле Имя");
            if (lastNameTextBox.Text != "") user[0].LastName = lastNameTextBox.Text; else MessageBox.Show("Не заполнено поле Фамилия");
            if (GenderBox.Text != "") Runner[0].Gender = GenderBox.Text; else MessageBox.Show("Не заполнено поле Пол");
            if (dateOfBirthDateTimePicker.Value != null) Runner[0].DateOfBirth = dateOfBirthDateTimePicker.Value; else MessageBox.Show("Не заполнено поле Дата рождения");
            if (CountryBox.SelectedValue != null && CountryBox.SelectedValue.ToString() != "") Runner[0].CountryCode = CountryBox.SelectedValue.ToString(); else MessageBox.Show("Не заполнено поле Страна");
            if (PasswordBox.Text != "")
            {
                if (RePasswordBox.Text != "")
                {
                    if (RePasswordBox.Text == PasswordBox.Text) user[0].Password = PasswordBox.Text; else MessageBox.Show("Поля пароль и подтверждение пароля не совпадают");
                }
                else MessageBox.Show("Не заполнено поле подтверждения пароля");
            }
            UsDB.SubmitChanges();
            userTableAdapter.Fill(marathonSkillsDBDataSet.User);
            runnerTableAdapter.Fill(marathonSkillsDBDataSet.Runner);
            ShowCurrentUser();
            MessageBox.Show("Данные успешно сохранены");
        }

        // Если пользователь закрыл крестиком последнее видимое окно — завершаем приложение
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Program.ExitIfNoForms();
        }
    }
}
