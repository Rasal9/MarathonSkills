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
    // Практическая работа № 17. Форма «22. Управление бегунами»
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.Date.ToString("dd.MM.yyyy");
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkillsDBDataSet.RegistrationStatus".
            this.registrationStatusTableAdapter.Fill(this.marathonSkillsDBDataSet.RegistrationStatus);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkillsDBDataSet.runnerManage".
            this.runnerManageTableAdapter.Fill(this.marathonSkillsDBDataSet.runnerManage);
            StatusBox.SelectedIndex = -1;
            textBox1.Text = runnerManageBindingSource.Count.ToString();
        }

        private void ButClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form19 frm19 = new Form19();
            frm19.Show();
        }

        // logout — возврат на форму авторизации (код этой кнопки одинаков во всём приложении)
        private void butLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        // «Обновить»
        private void button1_Click(object sender, EventArgs e)
        {
            // статус
            if (StatusBox.SelectedItem != null)
            {
                runnerManageBindingSource.Filter = "RegistrationStatusId=" + StatusBox.SelectedValue;
            }
            // сортировка
            if (sortBox.SelectedItem != null)
            {
                System.Windows.Forms.DataGridViewColumn col = new DataGridViewColumn();
                switch (sortBox.SelectedIndex)
                {
                    case 0:
                        col = dataGridViewTextBoxColumn1;
                        break;
                    case 1:
                        col = dataGridViewTextBoxColumn2;
                        break;
                    case 2:
                        col = dataGridViewTextBoxColumn3;
                        break;
                    case 3:
                        col = dataGridViewTextBoxColumn4;
                        break;
                }
                runnersManageDGV.Sort(col, System.ComponentModel.ListSortDirection.Ascending);
            }
            textBox1.Text = runnerManageBindingSource.Count.ToString();
        }

        // «Детальная информация (CSV)»
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "csv|*.csv";
            if (fd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            string path = fd.FileName;
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                for (int i = 0; i < runnersManageDGV.Rows.Count; i++)
                {
                    sw.WriteLine(runnersManageDGV[0, i].Value.ToString() + ";" + runnersManageDGV[1, i].Value.ToString() + ";" + runnersManageDGV[2, i].Value.ToString() + ";" +
                        runnersManageDGV[6, i].Value.ToString() + ";" + runnersManageDGV[7, i].Value.ToString() + ";" + runnersManageDGV[8, i].Value.ToString() + ";"
                        + runnersManageDGV[3, i].Value.ToString());
                }
            }
            MessageBox.Show("Файл успешно записан", "Внимание!");
        }

        // «E-mail список»
        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder data = new StringBuilder();
            for (int i = 0; i < runnersManageDGV.Rows.Count; i++)
            {
                data.Append("\"" + runnersManageDGV[0, i].Value.ToString() + " " + runnersManageDGV[1, i].Value.ToString() + "\" <" + runnersManageDGV[2, i].Value.ToString() + ">; \n");
            }
            BrowseEmailForm form = new BrowseEmailForm(data.ToString());
            form.ShowDialog();
        }

        // Если пользователь закрыл крестиком последнее видимое окно — завершаем приложение
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Program.ExitIfNoForms();
        }
    }
}
