using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogisticAppDAL
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
    }
}
