using LogisticAppDAL.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogisticAppDAL.Entities
{
    public class Employe
    {
        [Key]
        public int E_ID { get; set; }
        public string E_Name { get; set; }
        public string E_Contact { get; set; }
        [ForeignKey("Company")]
        public int Company_ID { get; set; }

        public Company company{ get; set; }
    }
}