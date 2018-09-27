using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SquareSoft.Blue.Models
{
    [Table("staffs")]
    public class UsersReg
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string user_type { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }
        
        public Nullable<DateTime> reg_date { get; set; }
        public string address { get; set; }
        public string tel { get; set; }
        
        public Nullable<DateTime> created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
