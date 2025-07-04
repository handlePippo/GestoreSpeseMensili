using Data.Models.Dto;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public sealed class Expense
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; init; } = null!;
        public string Description { get; init; } = null!;
        public decimal Amount { get; init; }
        public DateTime ExpenseCreation { get; init; }
        public DateTime ExpenseExpiration { get; init; }
        public MetadataDto Metadata { get; init; } = null!;

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
