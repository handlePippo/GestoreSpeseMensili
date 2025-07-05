using MyNewWinFormsApp;

namespace MonthExpenseGenerator.Extensions
{
    public static class FormExtensions
    {
        public static void IniatializeControls(this Form source)
        {
            if (source is Form1 form1)
            {
                form1.ExpenseDescriptionTextBox.Text = default;
                form1.ExpenseAmountTextBox.Text = default;
                form1.ExpenseCreationDtp.Value = DateTime.Today;
                form1.ExpenseExpirationDtp.Value = DateTime.Today;
                form1.AddExpenseBtn.Enabled = true;
                form1.ExpensesListBox.Items.Clear();
            }
        }

        public static void ResetControls(this Form source, bool value)
        {
            if (source is Form1 form1)
            {
                form1.ExpenseEditSaveBtn.Enabled = value;
                form1.ExpenseAmountTextBox.Enabled = value;
                form1.ExpenseCreationDtp.Enabled = value;
                form1.ExpenseExpirationDtp.Enabled = value;
                form1.ExpenseDescriptionTextBox.Cursor = Cursors.No;
            }
        }
    }
}