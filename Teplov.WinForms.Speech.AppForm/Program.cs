using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teplov.Develop.DonwloadForUrl.BL;

namespace Teplov.WinForms.Speech.AppForm
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
            MainForm mainForm = new MainForm();
            MessageService messageService = new MessageService();
            FileManager fileManager = new FileManager();
            MainPresenter presenter = new MainPresenter(messageService, mainForm, fileManager);
            Application.Run(mainForm);
        }
    }
}
