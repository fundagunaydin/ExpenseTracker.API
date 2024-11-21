using ExpenseTracker.API.Application.Dto.Expense;
using ExpenseTracker.API.Infrastructure;
using System.Threading.Tasks;

namespace ExpenseTracker.API.Application.Services.Expense
{
    public interface IExpenseService
    {
        Task<ApiResponse<ExpenseDto>> AddAsync(ExpenseCreateDto dto);

    }
}
