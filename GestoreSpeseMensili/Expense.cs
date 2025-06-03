using GestoreSpeseMensili.Utils.Enum;
using System;

namespace GestoreSpeseMensili
{
    internal class Expense : ABaseSpesa, IComparable<Expense>
    {
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DateTime? ClosureDate { get; set; }

        public Expense(string name, double amount, ExpenseCategory category, Priority priority, string description=null, DateTime? expirationDate=null, DateTime? closureDate=null) 
            : base(name, category, amount)
        {
            Priority = priority;
            Description = description ?? string.Empty;
            ExpirationDate = expirationDate;
            ClosureDate = closureDate;
            Category = category;
        }

        public int CompareTo(Expense other) => 1;
    }
}