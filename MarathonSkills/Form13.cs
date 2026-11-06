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
    // Практическая работа № 27. Форма «13. Список благотворительных организаций»
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void ButClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 frm10 = new Form10();
            frm10.Show();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkillsDBDataSet.Charity".
            this.charityTableAdapter.Fill(this.marathonSkillsDBDataSet.Charity);
            labelDate.Text = DateTime.Now.Date.ToString("dd.MM.yyyy");
            ColumnDescription.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            RunnersDataContext db = new RunnersDataContext();
            var charity = (from c in db.Charity
                           select c).ToArray();

            for (int i = 0; i < charity.Count(); i++)
            {
                charityDataGridView.Rows.Add(Res.LoadImage("CharityData/" + charity[i].CharityLogo, charity[i].CharityName),
                    charity[i].CharityName, charity[i].CharityDescription);
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
