using Microsoft.VisualBasic.Logging;
using XIIRPL2_20_TICKETING.MasterForm;

namespace XIIRPL2_20_TICKETING
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Login login = new Login();
            //login.Show();
            //Application.Run();

            //Masterbandara masterbandara = new Masterbandara();
            //masterbandara.Show();
            //Application.Run();

            //Mastermaskapai mastermaskapai = new Mastermaskapai();
            //mastermaskapai.Show();
            //Application.Run();

            Masterkodepromo masterkodepromo = new Masterkodepromo();
            masterkodepromo.Show();
            Application.Run();
        }
    }
}