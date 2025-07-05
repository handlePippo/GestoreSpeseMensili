using Data;
using MonthExpenseGenerator;
using MonthExpenseGenerator.Extensions;
using MonthExpenseGenerator.Utils;
using MonthExpenseGenerator.Utils.Enum;
using MonthExpenseManager;

namespace MyNewWinFormsApp;

public partial class Form1 : Form
{
    private bool removePlaceholder = true;
    private readonly IExpenseService expenseService;

    public Form1(IExpenseService expenseService)
    {
        this.expenseService = expenseService;
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        this.ResetControls(false);
        this.CategoryComboBox.SelectedIndexChanged -= CategoryComboBox_SelectedIndexChanged!;
        this.CategoryComboBox.SelectedIndex = 0;
        this.CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged!;
    }

    private void ExpenseEditSaveBtn_Click(object sender, EventArgs e)
    {
        if (this.ExpenseDescriptionTextBox.ReadOnly == true)
        {
            ExpenseEditSaveBtn.Text = GenericCostants.ACTION_SAVE;
            ExpenseDescriptionTextBox.Cursor = Cursors.IBeam;
        }
        else
        {
            ExpenseEditSaveBtn.Text = GenericCostants.ACTION_EDIT;
            ExpenseDescriptionTextBox.Cursor = Cursors.No;
        }
        ExpenseDescriptionTextBox.ReadOnly = !ExpenseDescriptionTextBox.ReadOnly;
    }

    private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.IniatializeControls();
        this.ResetControls(false);
        if (removePlaceholder)
        {
            this.CategoryComboBox.Items.RemoveAt(0);
            removePlaceholder = false;
            this.CategoryComboBox.SelectedIndex = 0;
            return;
        }

        var item = CategoryComboBox.SelectedItem?.ToString();
        try
        {
            var category = (ExpenseCategory)Enum.Parse(typeof(ExpenseCategory), item);
            InjectSpese(category);
        }
        catch (Exception ex)
        {
            ex.Data["sender"] = sender;
            ex.Data["e"] = e;
            throw;
        }
    }

    private void InjectSpese(ExpenseCategory category)
    {
        try
        {
            var speseFiltered = Program.speseList.Where(s => s.Category == category);
            if (speseFiltered.Any() == true)
            {
                var speseName = speseFiltered.Select(s => s.Name);
                ExpensesListBox.Items.AddRange(speseName.ToArray());
            }
        }
        catch (Exception ex)
        {
            ex.Data["category"] = category;
            throw;
        }
    }

    private void AddExpenseBtn_Click(object sender, EventArgs e)
    {
        try
        {
            new NewExpense().ShowDialog();
        }
        catch (Exception ex)
        {
            ex.Data["sender"] = sender;
            ex.Data["e"] = e;
            throw;
        }
    }

    private void ExpensesListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.ResetControls(true);
    }
}
