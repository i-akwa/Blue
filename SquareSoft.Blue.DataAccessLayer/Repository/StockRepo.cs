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
    public class StockRepo
    {
        internal ApplicationDataContext context = new ApplicationDataContext();
        public DbSet<Stock> dbset;
        static Stock stock;

        public StockRepo(ApplicationDataContext _context)
        {
            this.context = _context;
            this.dbset = context.Set<Stock>();
        }

        public static int AddStock(string productBQ, int bulkQuantity,decimal unitPrice,string description,string bulkType,DateTime exp_Date)
        {
            try
            {
                int saves;
                var newstock = new Stock
                {
                    bulk_quantity = bulkQuantity,
                    cost_price = unitPrice,
                    created_at = System.DateTime.UtcNow,
                    description = description,
                    product_BQ = productBQ,
                    BulkType = bulkType,
                    expDate = exp_Date

                };

                using (var context = new ApplicationDataContext())
                {
                    context.stocks.Add(newstock);
                    saves = context.SaveChanges();
                }
                return saves;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int AddStock(string bqnum, int quantity, decimal costprice)
        {
            try
            {
                int saves = 0;
                using (var context = new ApplicationDataContext())
                {
                    stock = context.stocks.Where(s => s.product_BQ == bqnum).FirstOrDefault<Stock>();
                }
                if (stock != null)
                {

                    stock.bulk_quantity = stock.bulk_quantity + quantity;
                    if (costprice == 0)
                    {
                        stock.cost_price = stock.cost_price;
                    }
                    else
                    {
                        stock.cost_price = costprice;
                    }
                    using (var context = new ApplicationDataContext())
                    {
                        context.Entry(stock).State = EntityState.Modified;
                        saves = context.SaveChanges();
                    }
                }
                return saves;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
