using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SquareSoft.Blue.Models
{
    [Table("products")]
    public class Products
    {
        [Key]
        public int id { get; set; }
        public string bq_number { get; set; }
        public string product_name { get; set; }
        public int quantity { get; set; }
        public int tooLowAlertNum { get; set; }
        public DateTime last_stock_date { get; set; }
        public int number_in_bulk { get; set; }
        public decimal bulk_price { get; set; }
        public decimal unit_price { get; set; }
        public DateTime created_at { get; set; }
        public string description { get; set; }
    }
}
