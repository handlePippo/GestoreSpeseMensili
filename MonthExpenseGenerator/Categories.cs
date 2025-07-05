using MonthExpenseGenerator.Models;
using MonthExpenseGenerator.Utils.Enum;

namespace MonthExpenseGenerator
{
    internal class Expenses : List<Expense>
    {
        public Expense this[string n]
        {
            get
            {
                return this[n];
            }
        }

        public Expense SearchByName(string s)
        {
            foreach (Expense spesa in this)
            {
                if (spesa.Name == s)
                {
                    return spesa;
                }
            }
            return null;
        }

        public virtual new void Add(Expense s) => base.Add(s);

        public void BulkAdd(bool baseProcedure, params Expense[] spese)
        {
            if (baseProcedure == true)
            {
                MockedSpeseGenerator();
                return;
            }

            if (spese == null)
            {
                throw new ArgumentNullException($"It's necessary to pass param for the field {nameof(spese)}");
            }

            foreach (var s in spese)
            {
                Add(s);
            }
        }

        /// <summary>
        /// private method to test the application
        /// </summary>
        [Obsolete]
        private void MockedSpeseGenerator()
        {
            Add(new Expense("Spesa sensuale di test 1", 1577, ExpenseCategory.Mandatory, Priority.Medium, "Descrizione sexy 1"));
            Add(new Expense("Spesa sensuale di test 2", 1130, ExpenseCategory.Extra, Priority.Medium, "Descrizione sexy 2"));
            Add(new Expense("Spesa sensuale di test 3", 1890, ExpenseCategory.Saving, Priority.Medium, "Descrizione sexy 3"));
        }
    }
}