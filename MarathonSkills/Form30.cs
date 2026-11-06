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
    // Практическая работа № 19. Форма «30. Управление пользователями»
    public partial class Form30 : Form
    {
        public Form30()
        {
            InitializeComponent();
        }

        private void Form30_Load(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.Date.ToString("dd.MM.yyyy");
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkillsDBDataSet.User".
            this.userTableAdapter.Fill(this.marathonSkillsDBDataSet.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkillsDBDataSet.Role".
            this.roleTableAdapter.Fill(this.marathonSkillsDBDataSet.Role);
            textBox2.Text = userDataGridView.Rows.Count.ToString();
            for (int i = 0; i < userDataGridView.Columns.Count - 1; i++)
            {
                sortBox.Items.Add(userDataGridView.Columns[i].HeaderText);
            }
        }

        private void ButClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form20 frm20 = new Form20();
            frm20.Show();
        }

        // logout — возврат на форму авторизации (код этой кнопки одинаков во всём приложении)
        private void butLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        // «+ Добавление нового» (ПР 20)
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form32 frm32 = new Form32();
            frm32.Show();
        }

        // «Обновить» — сортировка и поиск
        private void button2_Click(object sender, EventArgs e)
        {
            if (sortBox.SelectedItem != null)
            {
                System.Windows.Forms.DataGridViewColumn col = new DataGridViewColumn();
                switch (sortBox.SelectedIndex)
                {
                    case 0: col = dataGridViewTextBoxColumn3; break;
                    case 1: col = dataGridViewTextBoxColumn4; break;
                    case 2: col = dataGridViewTextBoxColumn1; break;
                    case 3: col = dataGridViewTextBoxColumn5; break;
                }
                userDataGridView.Sort(col, System.ComponentModel.ListSortDirection.Ascending);
            }
            // сбрасываем прошлую подсветку
            for (int i = 0; i <= userDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j <= userDataGridView.RowCount - 1; j++)
                {
                    userDataGridView[i, j].Style.BackColor = Color.White; userDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            if (textBox1.Text != "")
            {
                bool first = true;
                for (int i = 0; i <= userDataGridView.ColumnCount - 2; i++)
                {
                    for (int j = 0; j <= userDataGridView.RowCount - 1; j++)
                    {
                        if (userDataGridView[i, j].Value != null)
                        {
                            if (userDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text, StringComparison.OrdinalIgnoreCase) != -1)
                            {
                                if (first) { userDataGridView.CurrentCell = userDataGridView[i, j]; first = false; }
                                userDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                                userDataGridView[i, j].Style.ForeColor = Color.Blue;
                            }
                        }
                    }
                }
            }
        }

        // Кнопка «Edit» в строке таблицы (ПР 21)
        private void userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                string Email = userDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.Hide();
                Form31 frm31 = new Form31(Email);
                frm31.Show();
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
