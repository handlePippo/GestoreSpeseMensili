using Data;
using MonthExpenseGenerator.Models;
using MonthExpenseGenerator.Utils.Enum;
using MyNewWinFormsApp;

namespace MonthExpenseGenerator;

static class Program
{
    public static Expenses speseList;

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        speseList = new Expenses();
        speseList.BulkAdd(false, new Expense("Test expense", 123, ExpenseCategory.Mandatory, Priority.High));
        IExpenseRepository repository = new ExpenseRepository();
        Application.Run(new Form1(new ExpenseService(repository)));
    }
}