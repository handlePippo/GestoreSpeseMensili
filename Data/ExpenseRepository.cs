using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class ExpenseRepository : IExpenseRepository
    {
        public async Task<Expense> GetAsync(int id, CancellationToken token)
        {
            using (var context = new ExpenseGeneratorDbContext())
            {
                return await context.Expense.FirstOrDefaultAsync(e => e.Id == id, token) ?? throw new NullReferenceException();
            }
        }

        public async Task<bool> PostAsync(Expense expense, CancellationToken token)
        {
            using (var context = new ExpenseGeneratorDbContext())
            {
                await context.Expense.AddAsync(expense, token);
            }
            return true;
        }
    }
}
