using MonthExpenseManager.Utils.Enum;
using System;
using System.Windows.Forms;

namespace MonthExpenseManager
{
    internal static class Program
    {
        public static Expenses speseList;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            speseList = new Expenses();
            speseList.BulkAdd(false, new Expense("qweqweqw", 123, ExpenseCategory.Mandatory, Priority.High));
            Application.Run(new Form1());
        }
    }
}