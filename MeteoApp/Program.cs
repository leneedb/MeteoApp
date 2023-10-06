using Microsoft.Data.Sqlite;

namespace MeteoApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var connection = new SqliteConnection("Data Source=MeteoData.db"))
            {
                connection.Open();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SettingsForm());
            Application.Run(new Form1());
        }
    }
}