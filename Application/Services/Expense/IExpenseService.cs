using ExpenseTracker.API.Application.Dto.Expense;
using ExpenseTracker.API.Infrastructure;

namespace ExpenseTracker.API.Application.Services.Expense
{
    public interface IExpenseService
    {
        Task<ApiResponse<ExpenseDto>> AddAsync(ExpenseCreateDto dto);

    }
}
