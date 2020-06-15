using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourPrinciplesofOOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            
            User user = new User(Name:"Chirag");
            user.sayHello();
            Console.ReadLine();
            ItaxCalculator calculator = GetCalculator();
            calculator.Calculatetax();

        }

        public static ItaxCalculator GetCalculator()
        {
            return new TaxCalculator2019();
        }
    }
}
