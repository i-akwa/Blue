using Services;
using SquareSoft.Blue.DataAccessLayer.Data;
using SquareSoft.Blue.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SquareSoft.Blue.DataAccessLayer.Repository
{
    public class UserRepo
    {
        static UsersReg singleUser;
        internal ApplicationDataContext context = new ApplicationDataContext();
        public DbSet<UsersReg> dbset;
        public UserRepo(ApplicationDataContext _context)
        {
            this.context = _context;
            this.dbset = context.Set<UsersReg>();
        }
        public UserRepo()
        {
            
        }
        /// <summary>
        /// Adding New User to the database.
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="userType"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="regDate"></param>
        /// <param name="address"></param>
        /// <param name="tel"></param>
        /// <param name="createdAt"></param>
       
        public static int addUser(string fName, string lName, string userType, string userName, string password, DateTime regDate, string address, string tel, DateTime createdAt, DateTime updatedAt)
        {
            try
            {
                int isAdd = 0;
                var Reg = new UsersReg
                {
                    first_name = fName,
                    last_name = lName,
                    user_type = Aids.PickEnum(userType),
                    user_name = userName,
                    password = password.EncryptText("magic_encrypt1256"),
                    reg_date = regDate,
                    address = address,
                    tel = tel,
                    created_at = createdAt,
                    updated_at = updatedAt

                };

                using (var context = new ApplicationDataContext())
                {
                    context.staffs.Add(Reg);
                    isAdd = context.SaveChanges();
                }
                return isAdd;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// method to select all users data
        /// </summary>
        /// <returns></returns>
        public  List<UserValues> SelectUsers()
        {
            //data is a List<UserValues> type to hold the selected values of type List<UserValues>
            try
            {
                var data = (from user in context.staffs
                            select new UserValues()
                            {
                                firstName = user.first_name,
                                lastName = user.last_name,
                                userName = user.user_name,
                                address = user.address,
                                userType = user.user_type,
                                tel = user.tel
                            });
                List<UserValues> dataList = data.ToList();//converting data to list
                return dataList;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool CheckForAdmin()
        {
            var admin = context.staffs.Any(a => a.user_type == "Admin");
            return admin;
        }

        public  DataTable ToDataTable<T>(List<T> items)
        {
            try
            {
                DataTable dataTable = new DataTable(typeof(T).Name);

                //Get all the properties
                PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (PropertyInfo prop in Props)
                {
                    //Defining type of data column gives proper data table 
                    var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                    //Setting column names as Property names
                    dataTable.Columns.Add(prop.Name, type);
                }
                foreach (T item in items)
                {
                    var values = new object[Props.Length];
                    for (int i = 0; i < Props.Length; i++)
                    {
                        //inserting property values to datatable rows
                        values[i] = Props[i].GetValue(item, null);
                    }
                    dataTable.Rows.Add(values);
                }
                //put a breakpoint here and check datatable
                return dataTable;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int UpdateUserRecord(string userName, string column, string value)
        {
            try
            {
                int saved = 0;
                using (var context = new ApplicationDataContext())
                {
                    singleUser = context.staffs.Where(s => s.user_name == userName).FirstOrDefault<UsersReg>();
                }
                if (singleUser != null)
                {
                    if (column == "firstName")
                    { singleUser.first_name = value; }
                    else if (column == "lastName")
                    { singleUser.last_name = value; }
                    else if (column == "address")
                    { singleUser.address = value; }
                    else if (column == "tel")
                    { singleUser.tel = value; }
                    using (var con = new ApplicationDataContext())
                    {
                        con.Entry(singleUser).State = System.Data.Entity.EntityState.Modified;
                        saved = con.SaveChanges();
                    }

                }
                return saved;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }

    public class UserValues
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userType { get; set; }
        public string userName { get; set; }
        public string address { get; set; }
        public string  tel { get; set; }
    }
}
