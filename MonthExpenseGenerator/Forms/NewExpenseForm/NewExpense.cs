using FieldValitatorApi.Validators;

namespace MonthExpenseManager
{
    public partial class NewExpense : Form
    {
        public NewExpense()
        {
            InitializeComponent();
        }

        private void AbortBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var isExpenseNameValid = ValidateExpenseName();

            if (!isExpenseNameValid)
            {
                return;
            }
        }

        private bool ValidateExpenseName()
        {
            if (!CommonFieldValitatorFunctions.RequiredFieldValidDelegate(this.ExpenseNameTextBox.Text))
            {
                this.errorProvider1.SetError(ExpenseNameTextBox, "Name field is null or whitespace");
                return false;
            }
            if (!CommonFieldValitatorFunctions.StringFieldLengthValidDelegate(this.ExpenseNameTextBox.Text, 1, 255))
            {
                this.errorProvider1.SetError(ExpenseNameTextBox, "Expense name must be a valid string with a length included between 1 and 255");
                return false;
            }
            return true;
        }

        private void ExpenseNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
