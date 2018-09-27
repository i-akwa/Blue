using SquareSoft.Blue.DataAccessLayer.Data;
using SquareSoft.Blue.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareSoft.Blue.DataAccessLayer.Repository
{
    public class ProductSalesRepo
    {
        internal ApplicationDataContext context = new ApplicationDataContext();
        public DbSet<ProductSales> dbset;
        static ProductSales prodsales = new ProductSales();
        public ProductSalesRepo(ApplicationDataContext _context)
        {
            this.context = _context;
            this.dbset = context.Set<ProductSales>();
        }
        /// <summary>
        /// select from Product sales table, but with the product name inclusive
        /// </summary>
        /// <param name="salesId"></param>
        /// <returns></returns>
        public List<JointSalesProd> CallSalesById(int salesId)
        {
            try
            {
                ApplicationDataContext context = new ApplicationDataContext();
                List<JointSalesProd> proSales = (from sales in context.products_sales
                                                 join prod in context.products on sales.product_id equals prod.id
                                                 where sales.sales_id == salesId
                                                 select new JointSalesProd()
                                                 {
                                                     id = sales.id,
                                                     productId = sales.product_id,
                                                     productName = prod.product_name,
                                                     quantity = sales.quantity,
                                                     AmounntPaid = sales.amount_paid,
                                                     SalesDate = sales.sales_date,
                                                     OriginalPrice = sales.original_price
                                                 }).ToList();
                //var proSales = (from sale in context.products_sales where sale.sales_id == salesId select sale).ToList();
                return proSales;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
        public static int add(int salesId, int productId, int quantity, decimal amountPaid, DateTime salesDate, decimal originalPrice)
        {
            try
            {
                int added = 0;
                var prodSales = new ProductSales()
                {
                    sales_id = salesId,
                    product_id = productId,
                    quantity = quantity,
                    amount_paid = amountPaid,
                    sales_date = salesDate,
                    original_price = originalPrice
                };
                using (var context = new ApplicationDataContext())
                {
                    context.products_sales.Add(prodSales);
                    added = context.SaveChanges();
                }
                return added;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int UpdateQuantityandNewPrice(int id, int quantity,decimal Newprice)
        {
            try
            {
                int saves = 0;
                using (var context = new ApplicationDataContext())
                {
                    prodsales = context.products_sales.Where(s => s.id == id).FirstOrDefault<ProductSales>();
                }
                if (prodsales != null)
                {
                    prodsales.amount_paid = Newprice;
                    prodsales.quantity -= quantity;
                    using (var context = new ApplicationDataContext())
                    {
                        context.Entry(prodsales).State = EntityState.Modified;
                        saves = context.SaveChanges();
                    }
                }
                return saves;
            }
            catch(Exception)
            {
                throw;
            }
        }


        public virtual void Delete(ProductSales entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();
        }
        public virtual void DelRecordById(int id)
        {            
            ProductSales prodSales = context.products_sales.Find(id);
            Delete(prodSales);
        }
    }

    public class JointSalesProd
    {
        public int id { get; set; }
        public int productId { get; set; }
        public string productName { get; set; }
        public decimal quantity { get; set; }
        public decimal AmounntPaid { get; set; }
        public DateTime SalesDate { get; set; }
        public decimal OriginalPrice { get; set; }
    }
}
