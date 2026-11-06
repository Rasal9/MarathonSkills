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
    // Практическая работа № 10. Форма «3. Форма авторизации»
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.Date.ToString("dd.MM.yyyy");
        }

        // «Назад» и «Отмена»
        private void ButClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        // «Войти»
        private void button1_Click(object sender, EventArgs e)
        {
            RunnersDataContext userDB = new RunnersDataContext();
            try
            {
                var user = (from u in userDB.User
                            where u.Email == loginBox.Text
                            select u).ToArray();
                if (user.Length > 0 && user[0].Email == loginBox.Text)
                {
                    if (user[0].Password == PasswordBox.Text)
                    {
                        if (user[0].RoleId == 'R')
                        {
                            this.Hide();
                            Form9 frm9 = new Form9(user[0].Email);
                            frm9.Show();
                        }
                        else if (user[0].RoleId == 'C')
                        {
                            this.Hide();
                            Form19 frm19 = new Form19();
                            frm19.Show();
                        }
                        else if (user[0].RoleId == 'A')
                        {
                            this.Hide();
                            Form20 frm20 = new Form20();
                            frm20.Show();
                        }
                    }
                    else MessageBox.Show("Не верный логин или пароль");
                }
                else MessageBox.Show("Не верный логин или пароль");
            }
            catch (Exception ee)
            {
                MessageBox.Show("Ошибка подключения к БД: " + ee.Message, "Внимание!");
            }
        }

        // Если пользователь закрыл крестиком последнее видимое окно — завершаем приложение
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Program.ExitIfNoForms();
        }
    }
}
