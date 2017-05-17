using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProjectOOP
{

    // Редактирование и коллекция книг!!!
    /*Особиста бібліотека. Картотека домашньої бібліотеки: вихідні дані книги (автори, назва, видавництво та інше), 
     *розділ бібліотеки (спеціальна література, хобі, домашнє господарство, белетристика та інше),
     *походження та наявність книги в даний момент,
     *суб'єктивна оцінка книги. Вибір книг за довільним запитом; інвентаризація бібліотеки.*/ 
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new MainView());
        }


    }

   
}
