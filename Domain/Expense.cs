using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using System;

namespace ExpenseTracker.API.Domain
{
    public class Expense 
    {
        public Expense() 
        {

        }
        public Guid Id { get; set; }

        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public string Category { get; set; }

        [MaxLength(100)]
        public string InsertedUser { get; set; }
        public DateTime? InsertedDate { get; set; }
        [MaxLength(100)]
        public string UpdatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [MaxLength(100)]
        public string DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool IsDeleted { get; set; }
    }

}
