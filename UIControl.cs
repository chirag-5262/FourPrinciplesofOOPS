using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourPrinciplesofOOPS
{
    public abstract class UIControl
    {
        public void enabled()
        {
            Console.WriteLine("Enabled");
        }

        public abstract void draw();

        
    }
}
