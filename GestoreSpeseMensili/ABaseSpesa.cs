using GestoreSpeseMensili.Utils.Enum;
using System;

namespace GestoreSpeseMensili
{
    /// <summary>
    /// ABaseSpesa
    /// </summary>
    internal abstract class ABaseSpesa
    {
        public string Name { get; set; }
        public ExpenseCategory Category { get; set; }
        public double Amount { get; set; }
        public DateTime CreatedAt { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="amount"></param>
        protected ABaseSpesa(string name, ExpenseCategory category, double amount)
        {
            CreatedAt = DateTime.Now;
            Name = name;
            Category = category;
            Amount = amount;
        }
    }
}