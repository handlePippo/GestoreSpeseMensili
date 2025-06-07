using System;
using System.Collections.Generic;
using MonthExpenseManager.Utils.Enum;

namespace MonthExpenseManager
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

        public void BulkAdd(bool baseProcuedure, params Expense[] spese)
        {
            if (baseProcuedure == true)
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
                this.Add(s);
            }
        }

        /// <summary>
        /// private method to test the application
        /// </summary>
        [Obsolete]
        private void MockedSpeseGenerator()
        {
            this.Add(new Expense("Spesa sensuale di test 1", 1577, ExpenseCategory.Mandatory, Priority.Medium, "Descrizione sexy 1"));
            this.Add(new Expense("Spesa sensuale di test 2", 1130, ExpenseCategory.Extra, Priority.Medium, "Descrizione sexy 2"));
            this.Add(new Expense("Spesa sensuale di test 3", 1890, ExpenseCategory.Saving, Priority.Medium, "Descrizione sexy 3"));
        }
    }
}