using MonthExpenseGenerator.Utils.Enum;

namespace MonthExpenseGenerator.Models
{
    /// <summary>
    /// ABaseSpesa
    /// </summary>
    internal abstract class ABaseExpense
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
        protected ABaseExpense(string name, ExpenseCategory category, double amount)
        {
            CreatedAt = DateTime.Now;
            Name = name;
            Category = category;
            Amount = amount;
        }
    }
}