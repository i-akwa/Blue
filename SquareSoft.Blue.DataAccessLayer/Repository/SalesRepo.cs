using Services;
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
    public class SalesRepo
    {
        internal ApplicationDataContext context = new ApplicationDataContext();
        public DbSet<Sales> dbset;
        static Sales sales = new Sales();

        public SalesRepo(ApplicationDataContext _context)
        {
            this.context = _context;
            this.dbset = context.Set<Sales>();
        }


        public static int MakeSales(string userName, decimal salesAmount, DateTime salesDate,decimal discount, string payMethod)
        {
            try
            {
                int isInsert = 0;
                var makeSales = new Sales
                {
                    users_name = userName,
                    sales_amount = salesAmount,
                    sales_date = salesDate,
                    discount_given = discount,
                    payment_method = Aids.PickPayEnum(payMethod)
                };
                using (var context = new ApplicationDataContext())
                {
                    context.sales.Add(makeSales);
                    isInsert = context.SaveChanges(); ;
                }
                return isInsert;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int UpdateSalesPrice(int id, decimal newSalesPrice)
        {
            try
            {
                int saves = 0;
                using (var context = new ApplicationDataContext())
                {
                    sales = context.sales.Where(x => x.id == id).FirstOrDefault<Sales>();
                }
                if (sales != null)
                {
                    sales.sales_amount = newSalesPrice;
                    using (var context = new ApplicationDataContext())
                    {
                        context.Entry(sales).State = EntityState.Modified;
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
