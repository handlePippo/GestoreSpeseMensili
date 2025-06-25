using Data.Models;

namespace Data
{
    public class ExpenseService : IExpenseService
    {
        private readonly IExpenseRepository expenseRepository;
        public ExpenseService(IExpenseRepository expenseRepository)
        {
            this.expenseRepository = expenseRepository;
        }

        public async Task<ExpenseDto> GetAsync(int id, CancellationToken token)
        {
            var expense = await expenseRepository.GetAsync(id, token)
                ?? throw new NullReferenceException();

            ExpenseDto expenseDto = expense;
            return expense;
        }

        public async Task<bool> PostAsync(ExpenseDto expenseDto, CancellationToken token)
        {
            Expense expense = expenseDto;
            return await expenseRepository.PostAsync(expense, token);
        }
    }
}
