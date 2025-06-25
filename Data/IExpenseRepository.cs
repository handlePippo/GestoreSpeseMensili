using Data.Models;

namespace Data
{
    public interface IExpenseRepository
    {
        Task<Expense> GetAsync(int id, CancellationToken token);

        Task<bool> PostAsync(Expense expense, CancellationToken token);
    }
}
