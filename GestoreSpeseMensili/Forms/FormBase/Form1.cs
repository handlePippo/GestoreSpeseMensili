using MonthExpenseManager.Utils;
using MonthExpenseManager.Utils.Enum;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MonthExpenseManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool removePlaceholder = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ResetControls(false);
            this.ComboChooseCategory.SelectedIndexChanged -= ComboChooseCategory_SelectedIndexChanged;
            this.ComboChooseCategory.SelectedIndex = 0;
            this.ComboChooseCategory.SelectedIndexChanged += ComboChooseCategory_SelectedIndexChanged;
        }

        private void Label2_Click(object sender, EventArgs e)
        {
        }

        private void EditSaveBtn_Click(object sender, EventArgs e)
        {
            if (this.ShopDetailTextBox.ReadOnly == true)
            {
                EditSaveShopBtn.Text = GenericCostants.ACTION_SAVE;
            }
            else
            {
                EditSaveShopBtn.Text = GenericCostants.ACTION_EDIT;
            }
            this.ShopDetailTextBox.ReadOnly = !ShopDetailTextBox.ReadOnly;
        }

        private void ComboChooseCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.IniatializeControls();
            this.ResetControls(false);
            if (removePlaceholder)
            {
                this.ComboChooseCategory.Items.RemoveAt(0);
                removePlaceholder = false;
                this.ComboChooseCategory.SelectedIndex = 0;
                return;
            }

            var item = ComboChooseCategory.SelectedItem.ToString();
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
                    SpeseListBox.Items.AddRange(speseName.ToArray());
                }
            }
            catch (Exception ex)
            {
                ex.Data["category"] = category;
                throw;
            }
        }

        private void AddShopBtn_Click(object sender, EventArgs e)
        {
            try
            {
                new NewExpense().ShowDialog();
                //if (e is EventArgsForActionType)
                //{
                //    SpeseListBox.Items.Add(e as EventArgsForActionType);
                //}
            }
            catch (Exception ex)
            {
                ex.Data["sender"] = sender;
                ex.Data["e"] = e;
                throw;
            }
        }

        private void SpeseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ResetControls(true);
        }
    }
}