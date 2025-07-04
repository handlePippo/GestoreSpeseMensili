namespace Data.Models.Dto
{
    public sealed record ExpenseDto
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Amount { get; set; }
        public DateTime ExpenseCreation { get; set; }
        public DateTime ExpenseExpiration { get; set; }
        public MetadataDto Metadata { get; set; } = null!;


        public static implicit operator ExpenseDto(Expense expense)
        {
            ArgumentNullException.ThrowIfNull(expense);

            return new Expense()
            {
                Name = expense.Name,
                Amount = expense.Amount,
                Description = expense.Description,
                ExpenseCreation = expense.ExpenseCreation,
                ExpenseExpiration = expense.ExpenseExpiration,
                Metadata = expense.Metadata
            };
        }
    }
}
