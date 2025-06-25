using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public sealed class Expense
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Amount { get; set; }
        public DateTime ExpenseCreation { get; set; }
        public DateTime ExpenseExpiration { get; set; }
        public MetadataDto Metadata { get; set; } = null!;

        public Expense()
        {

        }

        public static implicit operator Expense(ExpenseDto expenseDto)
        {
            ArgumentNullException.ThrowIfNull(expenseDto);

            return new Expense()
            {
                Name = expenseDto.Name,
                Amount = expenseDto.Amount,
                Description = expenseDto.Description,
                ExpenseCreation = expenseDto.ExpenseCreation,
                ExpenseExpiration = expenseDto.ExpenseExpiration,
                Metadata = expenseDto.Metadata
            };
        }
    }
}
