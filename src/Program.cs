namespace KCNet_WinForms_Test.src
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
            Application.Run(new Form1());


            // Well I set the window title in the designer, not sure where it goes in the code.
            // https://stackoverflow.com/a/6970358

            // https://stackoverflow.com/questions/5104175/how-do-you-change-the-text-in-the-titlebar-in-windows-forms
        }
    }
}