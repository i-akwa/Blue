using SquareSoft.Blue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Aids
    {
        public static string PickEnum(string param)
        {

            List<string> newEnum = Enum.GetNames(typeof(UserTypes)).ToList();
            var newValue = newEnum.Single(s => s == param);

            return newValue;

        }

        public static string PickPayEnum(string param)
        {

            List<string> newEnum = Enum.GetNames(typeof(PaymentMethod)).ToList();
            var newValue = newEnum.Single(s => s == param);

            return newValue;

        }

        
    }
}
