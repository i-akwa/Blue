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
    public class ProductRepo
    {
  //      static ApplicationDataContext con = new ApplicationDataContext();
        internal ApplicationDataContext context = new ApplicationDataContext();
        public DbSet<Products> dbset;
        static Products prod;

        public ProductRepo(ApplicationDataContext _context)
        {
            this.context = _context;
            this.dbset = context.Set<Products>();
        }

        public List<CheckProduct> SelectProductDetails()
        {
            List<CheckProduct> productList = new List<CheckProduct>();

            var pList = (from prodList in context.products
                         select new CheckProduct()
                         {
                             bq_number = prodList.bq_number,
                             product_Name = prodList.product_name,
                             unit_price = prodList.unit_price,
                             bulk_price = prodList.bulk_price,
                             tooLowAlertNum = prodList.tooLowAlertNum,
                             quantity = prodList.quantity
                         });
            productList = pList.ToList();
            return productList;
        }

        public List<ShortCheckProduct> TooLowProduct()
        {
            List<ShortCheckProduct> productList = new List<ShortCheckProduct>();
            var pList = (from prodList in context.products
                         where prodList.tooLowAlertNum > prodList.quantity
                         select new ShortCheckProduct()
                         {
                             bq_number = prodList.bq_number,
                             tooLowAlert = prodList.tooLowAlertNum,
                             quantity = prodList.quantity
                         });
            productList = pList.ToList();
            return productList;
        }

        public static int UpdateProductDetails(string bq, string colName, string value)
        {
            int succes = 0;
            using (var context = new ApplicationDataContext())
            {
                prod = context.products.Where(p => p.bq_number == bq).Single<Products>();
            }
            if (prod != null)
            {
                if (colName == "unit_price")
                {
                    prod.unit_price = Convert.ToDecimal(value);
                }
                if (colName == "product_Name")
                { prod.product_name = value; }
                if (colName == "bulk_price")
                { prod.bulk_price = Convert.ToDecimal(value); }
                if (colName == "tooLowAlertNum")
                { prod.tooLowAlertNum = Convert.ToInt32(value); }

                using (var con = new ApplicationDataContext())
                {
                    con.Entry(prod).State = EntityState.Modified;
                    succes = con.SaveChanges();
                }
            }
            return succes;
        }

        public  Products GetProdById(int id)
        {
            return context.products.Find(id);
        }
        public List<NewProd> GetProductForCart(string  name)
        {
            ///using anonymous type to initialize the Query
            try
            {
                var data = (from pro in context.products where (pro.product_name == name || pro.bq_number == name && pro.quantity >= 1) select new NewProd() { id = pro.id, product_Name = pro.product_name, unit_price = pro.unit_price, bqNum = pro.bq_number });
                //Converting My query result to a list
                List<NewProd> ListPro = data.ToList();
                return ListPro;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<NewProd> GetProductForCartWithId(int id)
        {
            ///using anonymous type to initialize the Query
            try
            {
                var data = (from pro in context.products where (pro.id == id) select new NewProd() { id = pro.id, product_Name = pro.product_name, unit_price = pro.unit_price });
                //Converting My query result to a list
                List<NewProd> ListPro = data.ToList();
                return ListPro;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Products GetProductName(string BQnum)
        {
            try
            {
                var prodName = (from prod in context.products where prod.bq_number == BQnum select prod).FirstOrDefault();
                // string name= prodName.ToString();
                return prodName;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Selects all products name from db
        /// </summary>
        /// <returns></returns>
        public string[] getAllProductNames()
        {
            try
            {
                //querying db for product names
                var data = from pro in context.products select pro.product_name;
                string[] arrayData = data.ToArray();// storing it in an array
                return arrayData;// returning the array
            }
            catch (Exception)
            {

                throw;
            }
        }

        public  IQueryable<Products> GetAllProducts()
        {
            return context.products;
        }

        public virtual void Delete(Products entity)
        {
            try
            {
                if (context.Entry(entity).State == EntityState.Detached)
                {
                    context.products.Attach(entity);
                }
                context.products.Remove(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual void Delete(int id)
        {
            Products entity = context.products.Find(id);
            Delete(entity);
        }
        /// <summary>
        /// Add a product to the database
        /// </summary>
        /// <param name="bqnum"></param>
        /// <param name="productName"></param>
        /// <param name="quantity"></param>
        /// <param name="lastStockDate"></param>
        /// <param name="numberInBulk"></param>
        /// <param name="bulkPrice"></param>
        /// <param name="unitPrice"></param>
        /// <param name="timeCreated"></param>
        /// <param name="expiryDate"></param>
        /// <param name="Description"></param>
        /// <returns>int </returns>
        public static int AddProducts(string bqnum,string productName,int quantity, int numberInBulk, decimal bulkPrice, decimal unitPrice, string Description,int LowAlertVal)
        {
            try
            {
                int saves;
                var prod = new Products
                {
                    bq_number = bqnum,
                    product_name = productName,
                    quantity = quantity,
                    last_stock_date = System.DateTime.UtcNow,
                    number_in_bulk = numberInBulk,
                    bulk_price = bulkPrice,
                    unit_price = unitPrice,
                    created_at = System.DateTime.UtcNow,

                    description = Description,
                    tooLowAlertNum = LowAlertVal
                };
                using (var context = new ApplicationDataContext())
                {
                    context.products.Add(prod);
                    saves = context.SaveChanges();
                }
                return saves;
            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// Updating Products if the products already exist
        /// </summary>
        /// <param name="bqnum"></param>
        /// <param name="lastStockDate"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public static int AddProducts(string bqnum, int quantity, decimal prize)
        {
            try
            {
                int saves = 0;
                using (var context = new ApplicationDataContext())
                {
                    prod = context.products.Where(s => s.bq_number == bqnum).FirstOrDefault<Products>();
                }
                if (prod != null)
                {
                    if (prize != Convert.ToDecimal(0))
                    {
                        prod.unit_price = prize;
                    }
                    prod.quantity = prod.quantity + quantity;
                    prod.last_stock_date = System.DateTime.UtcNow;

                    using (var context = new ApplicationDataContext())
                    {
                        context.Entry(prod).State = EntityState.Modified;
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

        /// <summary>
        /// subtracting Products on each sales
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="qnty"></param>
        /// <returns></returns>
        public static int MinusProducts(int productId, int qnty)
        {
            try
            {
                int saves = 0;
                using (var context = new ApplicationDataContext())
                {
                    prod = context.products.Where(s => s.id == productId).FirstOrDefault<Products>();
                }
                if (prod != null)
                {
                    prod.quantity = prod.quantity - qnty;
                    using (var context = new ApplicationDataContext())
                    {
                        context.Entry(prod).State = EntityState.Modified;
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

        public static int AddProductQuantity(int productId, int qnty)
        {
            try
            {
                int saves = 0;
                using (var context = new ApplicationDataContext())
                {
                    prod = context.products.Where(s => s.id == productId).FirstOrDefault<Products>();
                }
                if (prod != null)
                {
                    prod.quantity = prod.quantity + qnty;
                    using (var context = new ApplicationDataContext())
                    {
                        context.Entry(prod).State = EntityState.Modified;
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

        public List<CheckProduct> SelectProductDetails(string bq_number)
        {
            List<CheckProduct> productList = new List<CheckProduct>();

            var pList = (from prodList in context.products
                         where prodList.bq_number == bq_number
                         select new CheckProduct()
                         {
                             bq_number = prodList.bq_number,
                             product_Name = prodList.product_name,
                             unit_price = prodList.unit_price,
                             bulk_price = prodList.bulk_price,
                             tooLowAlertNum = prodList.tooLowAlertNum,
                             quantity = prodList.quantity
                         });
            productList = pList.ToList();
            return productList;
        }

    }




    /// <summary>
    /// Class called newProd: Created as an object to hold selected values.
    ///
    /// </summary>
    public class NewProd
    {
        public int id { get; set; }
        public string product_Name { get; set; }
        public decimal unit_price { get; set; }
        public int quantity { get; set; }
        public string bqNum { get; set; }
    }

    public class CheckProduct
    {
        public string bq_number { get; set; }
        public string product_Name { get; set; }
        public decimal unit_price { get; set; }
        public int tooLowAlertNum { get; set; }
        public decimal bulk_price { get; set; }
        public int quantity { get; set; }

    }

    public class ShortCheckProduct
    {
        public string bq_number { get; set; }
        public int tooLowAlert { get; set; }
        public int quantity { get; set; }
    }
}
