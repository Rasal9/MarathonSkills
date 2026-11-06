using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MarathonSkills
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // ПР 5: для проверки эталонной формы можно запустить new MainForm()
            Application.Run(new Form1());
        }

        /// <summary>
        /// Формы переключаются через Hide()/Show(), поэтому главная форма Form1 остаётся
        /// скрытой. Если пользователь закрыл последнее видимое окно — завершаем приложение.
        /// </summary>
        public static void ExitIfNoForms()
        {
            if (Application.OpenForms.Cast<Form>().All(f => !f.Visible))
                Application.Exit();
        }
    }
}
