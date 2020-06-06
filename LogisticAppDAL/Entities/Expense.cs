using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LogisticAppDAL.Entities
{
    public class Expense
    {
        [Key]
        public int Exp_ID { get; set; }
        public string Person { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        [ForeignKey("Expense_Category")]
        public int Exp_Cat_ID { get; set; }

        public Expense_Category Expense_Category { get; set; }
    }
}
