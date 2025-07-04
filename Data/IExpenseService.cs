using Data.Models.Dto;

namespace Data
{
    public interface IExpenseService
    {
        Task<ExpenseDto> GetAsync(int id, CancellationToken token);

        Task<bool> PostAsync(ExpenseDto expense, CancellationToken token);
    }
}
