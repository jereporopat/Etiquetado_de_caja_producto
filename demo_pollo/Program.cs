using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//using SoftwareLocker;

namespace demo_pollo
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //habilitar para trial
            /*
            TrialMaker t = new TrialMaker("demo_pollo", Application.StartupPath + "\\RegFile.reg",
                 Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\PESetp.dbf",
                "TE: +(5411) 7079 7262 - (WA)+(5411) 7079 7262\ne-mail: info@siscod.com.ar - web: www.siscod.com",
                30, 200, "123");

            byte[] MyOwnKey = { 97, 250, 1, 5, 84, 21, 7, 63,
            4, 54, 87, 56, 123, 10, 3, 62,
            7, 9, 20, 36, 37, 21, 101, 57};
            t.TripleDESKey = MyOwnKey;

            TrialMaker.RunTypes RT = t.ShowDialog();
            bool is_trial;
            if (RT != TrialMaker.RunTypes.Expired)
            {
                if (RT == TrialMaker.RunTypes.Full)
                    is_trial = false;
                else
                    is_trial = true;

                Application.Run(new Main(is_trial));
            }
            */
            //sacar para trial
            Application.Run(new Main());
        }
    }
}
