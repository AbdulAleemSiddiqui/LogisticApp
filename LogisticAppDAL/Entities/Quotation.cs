using LogisticAppDAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogisticAppDAL.Entities
{
    public class Quotation
    {
        [Key]
        public int Q_ID { get; set; }
        public string Q_No { get; set; }
        public DateTime Q_Date{ get; set; }
        [ForeignKey("Company")]
        public int Company_ID { get; set; }

        public Company company{ get; set; }

        public ICollection<Quotation_Item> items{ get; set; }
    }
}
