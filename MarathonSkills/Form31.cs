using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MarathonSkills
{
    // Практическая работа № 21. Форма «31. Редактирование пользователя»
    public partial class Form31 : Form
    {
        RunnersDataContext UsDB = new RunnersDataContext();
        string Email = "";

        public Form31(string Email)
        {
            InitializeComponent();
            this.Email = Email;
        }

        private void Form31_Load(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.Date.ToString("dd.MM.yyyy");
            this.roleTableAdapter.Fill(this.marathonSkillsDBDataSet.Role);
            this.userTableAdapter.Fill(this.marathonSkillsDBDataSet.User);
            ShowCurrentUser();
        }

        void ShowCurrentUser()
        {
            int i = userBindingSource.Find("Email", Email);
            if (i >= 0) userBindingSource.Position = i;
        }

        // «Назад» и «Отмена»
        private void ButClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form30 frm30 = new Form30();
            frm30.Show();
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
            if (user.Length == 0) return;
            if (firstNameTextBox.Text != "") user[0].FirstName = firstNameTextBox.Text;
            if (lastNameTextBox.Text != "") user[0].LastName = lastNameTextBox.Text;
            if (comboBox1.SelectedValue != null) user[0].RoleId = char.Parse(comboBox1.SelectedValue.ToString().Trim());
            if (PasswordBox.Text != "")
            {
                if (RePasswordBox.Text != "")
                {
                    if (RePasswordBox.Text == PasswordBox.Text)
                    {
                        user[0].Password = PasswordBox.Text;
                    }
                    else
                        MessageBox.Show("Поля пароль и подтверждение пароля не совпадают");
                }
                else
                    MessageBox.Show("Не заполнено поле подтверждения пароля");
            }
            UsDB.SubmitChanges();
            userTableAdapter.Fill(marathonSkillsDBDataSet.User);
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
