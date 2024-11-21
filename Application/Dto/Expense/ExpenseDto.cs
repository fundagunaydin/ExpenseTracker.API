using System;

namespace ExpenseTracker.API.Application.Dto.Expense
{
    public class ExpenseDto
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string? Category { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
    }
}
