using System;

namespace ExpenseTracker.API.Application.Dto.Expense
{
    public class ExpenseCreateDto
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string? Category { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        //public virtual User User { get; set; }
    }

}
