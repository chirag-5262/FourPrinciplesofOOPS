using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourPrinciplesofOOPS
{
    public class User
    {
        //Fields (Attributes)
        public string name;


        public User()
        {
        }

        public User(String Name)
        {
            this.name = Name;
        }

        //Methods 
        public void sayHello()
        {
            Console.WriteLine("Hi This is "+this.name);
        }
    }
}
