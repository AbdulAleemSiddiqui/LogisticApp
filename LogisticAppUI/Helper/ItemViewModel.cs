using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticAppUI.Helper
{
    public class ItemViewModel
    {
        public int I_ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Unit { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Quoted_Amount { get; set; }
        public string Category{ get; set; }

        public string Company { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
    }
}
