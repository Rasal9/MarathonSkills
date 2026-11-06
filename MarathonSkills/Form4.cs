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
    // Практическая работа № 12. Форма «4. Меню регистрации бегунов»
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.Date.ToString("dd.MM.yyyy");
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkillsDBDataSet.Country".
            this.countryTableAdapter.Fill(this.marathonSkillsDBDataSet.Country);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkillsDBDataSet.Gender".
            this.genderTableAdapter.Fill(this.marathonSkillsDBDataSet.Gender);
            //  this.runnerTableAdapter.Fill(this.marathonSkillsDBDataSet.Runner);
            //  this.userTableAdapter.Fill(this.marathonSkillsDBDataSet.User);
        }

        private void ButClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        // «Отмена»
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        // «Регистрация»
        private void button1_Click(object sender, EventArgs e)
        {
            RunnersDataContext RunDB = new RunnersDataContext();
            Runner Runner_ = new Runner();
            User user_ = new User();
            var user = (from u in RunDB.User
                        where u.Email == emailTextBox.Text
                        select u).ToArray();
            if (user.Length == 0)
            {
                if (emailTextBox.Text != "" && passwordTextBox.Text != "" && firstNameTextBox.Text != "" && lastNameTextBox.Text != "" && genderBox.Text != "" &&
                    dateOfBirthDateTimePicker.Value != null && countryBox.SelectedValue != null)
                {
                    if (passwordTextBox.Text == RePasswordTextBox.Text)
                    {
                        int Age = System.DateTime.Now.Year - dateOfBirthDateTimePicker.Value.Year;
                        if (Age > 10)
                        {
                            user_.Email = emailTextBox.Text.ToString();
                            user_.FirstName = firstNameTextBox.Text;
                            user_.LastName = lastNameTextBox.Text;
                            user_.Password = passwordTextBox.Text;
                            user_.RoleId = 'R';
                            RunDB.User.InsertOnSubmit(user_);
                            RunDB.SubmitChanges();
                            userTableAdapter.Fill(marathonSkillsDBDataSet.User);
                            Runner_.Email = emailTextBox.Text;
                            Runner_.Gender = genderBox.SelectedValue.ToString();
                            Runner_.DateOfBirth = dateOfBirthDateTimePicker.Value;
                            Runner_.CountryCode = countryBox.SelectedValue.ToString();
                            RunDB.Runner.InsertOnSubmit(Runner_);
                            RunDB.SubmitChanges();
                            runnerTableAdapter.Fill(marathonSkillsDBDataSet.Runner);
                            this.Hide();
                            Form5 frm5 = new Form5(emailTextBox.Text);
                            frm5.Show();
                        }
                        else MessageBox.Show("Ваш возраст должен быть старше десяти лет", "Внимание!");
                    }
                    else MessageBox.Show("Поля пароль и подтверждение пароля не совпадают", "Внимание!");
                }
                else MessageBox.Show("Не все поля заполнены", "Внимание!");
            }
            else MessageBox.Show("Такой пользователь уже существует", "Внимание!");
        }

        // Если пользователь закрыл крестиком последнее видимое окно — завершаем приложение
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Program.ExitIfNoForms();
        }
    }
}
