using Microsoft.AspNet.Identity.EntityFramework;
using SquareSoft.Blue.DataAccessLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareSoft.Blue.DataAccessLayer.Repository
{
    public class LoginHandler : IdentityDbContext
    {
        public static string LoginUser(string userName, string Password)
        {            
            using (var context = new ApplicationDataContext())
            {
                string name = context.staffs.FirstOrDefault(s => s.user_name == userName && s.password == Password)?.first_name ?? string.Empty;
                return name.ToString();
            }
        }
    }
}
