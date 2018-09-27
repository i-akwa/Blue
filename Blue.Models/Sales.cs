using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SquareSoft.Blue.Models
{
    [Table("product_sales")]
    public class ProductSales
    {
        public int id { get; set; }
        public int sales_id { get; set; }
        public int product_id { get; set; }
        public int quantity { get; set; }
        public decimal amount_paid { get; set; }
        public DateTime sales_date { get; set; }
        public decimal original_price { get; set; }
        //    public decimal discount_given { get; set; }
         //   public PaymentMethod payment_method { get; set; }
    }


    [Table("sales")]
    public class Sales
    {
        public int id { get; set; }
        public string users_name { get; set; }
        public decimal sales_amount { get; set; }
        public DateTime sales_date { get; set; }
        public decimal discount_given { get; set; }
        public string payment_method { get; set; }
    }

    public enum PaymentMethod
    {
        Cash, POS, LoyaltyCard
    }
    
    public class SalesRec
    {
        public decimal amount { get; set; }
        public string dates { get; set; }
    }

}
