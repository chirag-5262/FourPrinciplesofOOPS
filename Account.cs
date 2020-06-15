using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourPrinciplesofOOPS
{
    public class Account
    {
        private float balance;

        public void Deposit(float amount)
        {
            if(amount>0)
            this.balance = this.balance + amount;
        }
        public void Withdraw(float amount)
        {
            if (amount > 0)
                this.balance = this.balance - amount;
        }

        public float getBalance()
        {
            return balance;
        }

    }
}
