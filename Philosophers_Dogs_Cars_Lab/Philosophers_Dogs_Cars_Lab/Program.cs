//Author: Josh Werlein
//Purpose: Create an application with 3 classes of Philospher Dog and Car
//Date: 9/20/2023

namespace PhilosopherDogCar_List
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
            Application.Run(new PhilosopherDogCarListForm());
        }
    }
}