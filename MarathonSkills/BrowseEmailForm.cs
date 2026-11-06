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
    // Практическая работа № 17. Форма просмотра E-mail списка
    public partial class BrowseEmailForm : Form
    {
        public BrowseEmailForm(string data)
        {
            InitializeComponent();
            richTextBox1.Text = data;
        }
    }
}
