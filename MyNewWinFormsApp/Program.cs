using Data;

namespace MyNewWinFormsApp;

static class Program
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

        IExpenseRepository repository = new ExpenseRepository();
        Application.Run(new Form1(new ExpenseService(repository)));
    }
}