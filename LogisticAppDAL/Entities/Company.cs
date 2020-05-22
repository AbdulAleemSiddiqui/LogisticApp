using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LogisticAppDAL
{
    public class Company
    {
        [Key]
        public int C_ID { get; set; }
        [Required]
        public string C_Name { get; set; }
        public string C_Address { get; set; }
        public string C_Contact { get; set; }

        public ICollection<Employe> employes { get; set; }
    }
}