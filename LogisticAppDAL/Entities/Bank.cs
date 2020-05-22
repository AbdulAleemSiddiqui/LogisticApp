using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LogisticAppDAL.Entities
{
    public class Bank
    {
        [Key]
        public int B_Id { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<Deposit_Slip> Deposit_Slips{ get; set; }
        public ICollection<Cheque> Cheques{ get; set; }

    }
}