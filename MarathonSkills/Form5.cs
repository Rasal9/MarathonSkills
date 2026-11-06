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
    // Практическая работа № 13. Форма «5. Регистрация на марафон»
    public partial class Form5 : Form
    {
        string Email;
        decimal RaceCost_ = 0;
        char RaceKitOption_ = 'A';
        string[] EventId = new string[10];
        decimal EventCost = 0;
        decimal sponsorship_ = 0;

        RunnersDataContext RunDB = new RunnersDataContext();

        public static EventTypeDataContext EvDB = new EventTypeDataContext();

        Фильтр_Marathon_Skills[] Event_ = new Фильтр_Marathon_Skills[0];

        public Form5(string Email)
        {
            InitializeComponent();
            this.Email = Email;
            try
            {
                Event_ = (from ev in EvDB.Фильтр_Marathon_Skills
                          select ev).ToArray();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Ошибка загрузки видов марафона: " + ee.Message, "Внимание!");
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.Date.ToString("dd.MM.yyyy");
            this.charityTableAdapter.Fill(this.marathonSkillsDBDataSet.Charity);
            this.raceKitOptionTableAdapter.Fill(this.marathonSkillsDBDataSet.RaceKitOption);
            // Список видов марафона (элементы EventTypeList) берём из представления «Фильтр Marathon Skills»
            EventTypeList.Items.Clear();
            for (int j = 0; j < Event_.Count(); j++)
                EventTypeList.Items.Add(EventItemText(Event_[j]));
            RaceKitView.ClearSelection();
            label1Money.Text = "$" + (RaceCost_ + EventCost).ToString();
        }

        string EventItemText(Фильтр_Marathon_Skills ev)
        {
            return (ev.EventTypeName + " ($" + ev.Cost.ToString() + ")").ToString();
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

        // «Отмена»
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 frm9 = new Form9(Email);
            frm9.Show();
        }

        // Ввод суммы взноса — проверяем, что введены только цифры
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                labelError.Text = "";
                button2.Enabled = true;
                if (MoneyBox.Text != "" && double.Parse(MoneyBox.Text) > 0)
                {
                }
            }
            catch (System.FormatException)
            {
                labelError.Text = "Строка должна содержать только цифры";
                button2.Enabled = false;
            }
        }

        // «i» — информация о благотворительной организации
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                CharityPopup charityFrm = new CharityPopup(comboBox1.Text);
                charityFrm.Show();
            }
        }

        // Отметка вида марафона: пересчёт выполняем после того, как флажок изменит состояние
        private void EventTypeList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(delegate { EventTypeList_SelectedIndexChanged(sender, EventArgs.Empty); }));
        }

        // Выбор вида марафона
        private void EventTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int H = 0;
            EventCost = 0;
            if (EventTypeList.CheckedItems.Count != 0)
            {
                for (int i = 0; i < EventTypeList.CheckedItems.Count; i++)
                {
                    for (int j = 0; j < Event_.Count(); j++)
                    {
                        if (EventTypeList.CheckedItems[i].ToString() == EventItemText(Event_[j]))
                        {
                            EventId[H] = Event_[j].EventId;
                            EventCost += decimal.Parse(Event_[j].Cost.ToString());
                            H++;
                        }
                    }
                }
            }
            for (int k = H; k < EventId.Length; k++) EventId[k] = null;
            label1Money.Text = "$" + (RaceCost_ + EventCost).ToString();
        }

        // Выбор варианта комплекта
        private void RaceKitView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (RaceKitView.SelectedCells.Count != 0)
            {
                RaceKitOption_ = char.Parse(RaceKitView.SelectedCells[0].OwningRow.Cells["raceKitOptionId"].Value.ToString().Trim());

                var Race = (from r in RunDB.RaceKitOption
                            where r.RaceKitOptionId == RaceKitOption_
                            select r).ToArray();

                RaceCost_ = Race[0].Cost;
                label1Money.Text = "$" + (RaceCost_ + EventCost).ToString();
            }
        }

        // «Регистрация»
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (EventTypeList.CheckedItems.Count != 0)
                {
                    Registration Reg = new Registration();
                    var Runner_ = (from r in RunDB.Runner
                                   where r.Email == Email
                                   select r).ToArray();
                    Reg.RunnerId = Runner_[0].RunnerId;
                    Reg.RegistrationDateTime = DateTime.Now;
                    Reg.RaceKitOptionId = RaceKitOption_;
                    Reg.RegistrationStatusId = 1;
                    Reg.Cost = RaceCost_ + EventCost;
                    Reg.CharityId = int.Parse(comboBox1.SelectedValue.ToString());
                    Reg.SponsorshipTarget = decimal.Parse(MoneyBox.Text);
                    RunDB.Registration.InsertOnSubmit(Reg);
                    RunDB.SubmitChanges();
                    registrationTableAdapter.Fill(marathonSkillsDBDataSet.Registration);

                    for (int i = 0; i < EventId.Count(); i++)
                    {
                        if (EventId[i] == null) continue;
                        RegistrationEvent RegEv = new RegistrationEvent();
                        RegEv.RegistrationId = Reg.RegistrationId;
                        RegEv.EventId = EventId[i];
                        RunDB.RegistrationEvent.InsertOnSubmit(RegEv);
                        RunDB.SubmitChanges();
                    }
                    registrationEventTableAdapter.Fill(marathonSkillsDBDataSet.RegistrationEvent);
                    MessageBox.Show("Регистрация на марафон успешно завершена");
                }
                else MessageBox.Show("Выберите хотябы один вид марафона", "Внимание!");
            }
            catch (Exception ee)
            {
                MessageBox.Show("Ошибка: " + ee.Message, "Внимание!");
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
