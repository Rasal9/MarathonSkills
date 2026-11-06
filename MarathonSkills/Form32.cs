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
    // Практическая работа № 20. Форма «32. Добавление нового пользователя»
    public partial class Form32 : Form
    {
        public Form32()
        {
            InitializeComponent();
        }

        private void Form32_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkillsDBDataSet.Role".
            this.roleTableAdapter.Fill(this.marathonSkillsDBDataSet.Role);
            labelDate.Text = DateTime.Now.Date.ToString("dd.MM.yyyy");
            //  this.userTableAdapter.Fill(this.marathonSkillsDBDataSet.User);
        }

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
            RunnersDataContext usDB = new RunnersDataContext();
            var user = (from u in usDB.User
                        where u.Email == emailTextBox.Text
                        select u).ToArray();
            if (user.Length == 0)
            {
                if (emailTextBox.Text != "" && firstNameTextBox.Text != "" && lastNameTextBox.Text != "" && comboBox1.Text != "" && passwordTextBox.Text != "" && RePasswordTextBox.Text != "")
                {
                    if (RePasswordTextBox.Text == passwordTextBox.Text)
                    {
                        User user_ = new User();
                        user_.Email = emailTextBox.Text;
                        user_.FirstName = firstNameTextBox.Text;
                        user_.LastName = lastNameTextBox.Text;
                        user_.RoleId = char.Parse(comboBox1.SelectedValue.ToString().Trim());
                        user_.Password = passwordTextBox.Text;
                        usDB.User.InsertOnSubmit(user_);
                        usDB.SubmitChanges();
                        userTableAdapter.Fill(marathonSkillsDBDataSet.User);
                        MessageBox.Show("Пользователь успешно добавлен");
                    }
                    else MessageBox.Show("Поля пароль и повтор пароля не совпадают");
                }
                else MessageBox.Show("Не все поля заполнены!", "Внимание!");
            }
            else MessageBox.Show("Данный пользователь уже зарегистрирован");
        }

        // «Отмена»
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form30 frm30 = new Form30();
            frm30.Show();
        }

        // Если пользователь закрыл крестиком последнее видимое окно — завершаем приложение
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Program.ExitIfNoForms();
        }
    }
}
