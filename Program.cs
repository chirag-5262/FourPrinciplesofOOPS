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
            //Simple Class Ex
            User user = new User(Name:"Chirag");
            user.sayHello();
            Console.ReadLine();

            //Interface Ex
            ItaxCalculator calculator = GetCalculator();
            calculator.Calculatetax();

            //Encaptulation Ex
            var account = new Account();

            account.Deposit(10);
            account.Withdraw(5);
            account.getBalance();

            //Abstraction Ex
            MailService mailService = new MailService();
            mailService.sendEmail();

            //Inheritance Ex
            var textbox = new TextBox();
            textbox.enabled();

            //Polymorphism Ex
            var checkbox = new CheckBox();
            drawUIControl(checkbox);



        }
        //Polymorphism Ex
        public static void drawUIControl(UIControl control)
        {
            control.draw();
        }

        public static ItaxCalculator GetCalculator()
        {
            return new TaxCalculator2019();
        }
    }
}
