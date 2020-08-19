using System;
using System.Collections.Generic;
using System.Text;

namespace Abstracao.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        // override permite subscrever o método virtual
        public override void Withdraw(double amount)
        {
            // base: herda o comportamento do método e permite adapta-lo
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
