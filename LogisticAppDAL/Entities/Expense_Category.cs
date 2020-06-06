using System.ComponentModel.DataAnnotations;

namespace LogisticAppDAL.Entities
{
    public class Expense_Category
    {
        [Key]
        public int Exp_Cat_ID { get; set; }
        public string Exp_Cat_Name { get; set; }
    }
}