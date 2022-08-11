namespace Tracked
{
    internal static class Program
    {
        /// <summary>
        /// Created by Brendan J. Fosher
        /// Started on Aug. 11, 2022.
        /// https://github.com/EnergyAddicted/Tracked
        /// 
        ///  The main entry point for the application.
        /// </summary> 
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Launch_Form());
        }
    }
}