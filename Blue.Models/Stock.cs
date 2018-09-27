using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SquareSoft.Blue.Models
{
    [Table("stocks")]
    public class Stock
    {
        public int id { get; set; }
        public DateTime created_at { get; set; }
        public string product_BQ { get; set; }
        public int bulk_quantity { get; set; } = 1;
        public string BulkType { get; set; }
        public decimal cost_price { get; set; }
        public string description { get; set; }
        public DateTime expDate { get; set; }
    }
}
