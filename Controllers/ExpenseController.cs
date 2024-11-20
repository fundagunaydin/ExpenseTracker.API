
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;
using ExpenseTracker.API.Application.Services.Expense;
using ExpenseTracker.API.Application.Dto.Expense;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;

namespace ExpenseTracker.API.Controllers
{
    [Route("api/v1/[controller]")]

    public class ExpenseController
    {

        private readonly IExpenseService _expenseService;
        public ExpenseController(IExpenseService expenseService) 
        {
            _expenseService = expenseService;
        }


        /// <summary>
        /// Creates a expenses with given model.
        /// </summary>
        /// <param name="expense">Expense Dto</param>
        /// <remarks>
        /// Create a Expense on database with the given data from the request after several validations.
        /// </remarks>
        /// <returns>Newly created expense</returns>
        /// <response code="201">Returns the newly expense</response>
        /// <response code="400">If the request is null</response>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> CreateExpense([Required][FromBody] ExpenseCreateDto expense)
        {
            //var result = await _expenseService.AddAsync(expense);

            return null;

        }

    }
}
