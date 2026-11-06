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
    // Практическая работа № 7. Форма «6. Спонсор бегуна»
    public partial class Form6 : Form
    {
        public static int RunCBid = 0;
        public static RunnerCBDataContext RunnerCB = new RunnerCBDataContext();
        RunnerView2[] RunCB = new RunnerView2[0];

        public Form6()
        {
            InitializeComponent();
            try
            {
                RunCB = (from r in RunnerCB.RunnerView2
                         select r).ToArray();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Ошибка загрузки списка бегунов: " + ee.Message, "Внимание!");
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.Date.ToString("dd.MM.yyyy");
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkillsDBDataSet.Charity".
            this.charityTableAdapter.Fill(this.marathonSkillsDBDataSet.Charity);
            dateTimePicker1.MinDate = DateTime.Now.Date;
            comboBox1.BeginUpdate();
            for (int i = 0; i < RunCB.Count(); i++)
            {
                comboBox1.Items.Add(RunCB[i].FirstName + " " + RunCB[i].LastName + " - " + RunCB[i].BibNumber + "(" + RunCB[i].CountryCode + ")");
            }
            comboBox1.EndUpdate();
            label1Money.Text = "$" + MoneyBox.Text;
        }

        private void ButClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        // «+»
        private void button2_Click(object sender, EventArgs e)
        {
            if (MoneyBox.Text != "")
            {
                MoneyBox.Text = (int.Parse(MoneyBox.Text) + 10).ToString();
                label1Money.Text = "$" + MoneyBox.Text;
            }
        }

        // «-»
        private void button3_Click(object sender, EventArgs e)
        {
            if (MoneyBox.Text != "")
            {
                if (int.Parse(MoneyBox.Text) > 10)
                {
                    MoneyBox.Text = (int.Parse(MoneyBox.Text) - 10).ToString();
                    label1Money.Text = "$" + MoneyBox.Text;
                }
            }
        }

        // Ввод суммы пожертвования
        private void MoneyBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                labelError.Text = "";
                button2.Enabled = true;
                button3.Enabled = true;
                button5.Enabled = true;
                if (int.Parse(MoneyBox.Text) > 0)
                {
                    if (MoneyBox.Text != "")
                    {
                        label1Money.Text = "$" + MoneyBox.Text;
                    }
                    else
                        label1Money.Text = "";
                }
            }
            catch (System.FormatException)
            {
                labelError.Text = "Строка должна содержать только цифры";
                label1Money.Text = "";
                button2.Enabled = false;
                button3.Enabled = false;
                button5.Enabled = false;
            }
            catch (System.OverflowException)
            {
                labelError.Text = "Слишком большое число";
                button5.Enabled = false;
            }
        }

        // Выбор бегуна — показываем его благотворительную организацию
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                textBox3.Text = RunCB[comboBox1.SelectedIndex].CharityName;
            }
        }

        // «Отмена»
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        // «Заплатить»
        private void button5_Click(object sender, EventArgs e)
        {
            if (sponsorNameTextBox.Text == "" || comboBox1.SelectedIndex < 0 || textBox1.Text == "" ||
                !maskedTextBox1.MaskCompleted || textBox2.Text.Length != 3 || MoneyBox.Text == "")
            {
                MessageBox.Show("Не все поля заполнены", "Внимание!");
                return;
            }
            try
            {
                Sponsorship spons = new Sponsorship();
                spons.SponsorName = sponsorNameTextBox.Text;
                spons.RegistrationId = RunCB[comboBox1.SelectedIndex].RegistrationId;
                spons.Amount = int.Parse(MoneyBox.Text);

                RunnerCB.Sponsorship.InsertOnSubmit(spons);
                RunnerCB.SubmitChanges();

                sponsorshipTableAdapter1.Fill(marathonSkillsDBDataSet.Sponsorship);
                this.Hide();
                Form7 frm7 = new Form7(comboBox1.SelectedItem.ToString(), textBox3.Text, label1Money.Text);
                frm7.Show();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Ошибка: " + ee.Message, "Внимание!");
            }
        }

        // «i» — информация о благотворительной организации
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                CharityPopup charityFrm = new CharityPopup(textBox3.Text);
                charityFrm.Show();
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
