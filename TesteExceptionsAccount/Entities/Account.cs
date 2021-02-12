using System;
using System.Collections.Generic;
using System.Text;
using TesteExceptionsAccount.Entities.Exceptions;

namespace TesteExceptionsAccount.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double valor)
        {
            if (valor != 0)
            {
                Balance += valor;
            }
            else
            {
                throw new ExceptionAccount("Incorrect valor!!");
            }
           
        }

        public void Withdraw(double valor)
        {

            if (valor > WithDrawLimit )
            {
                throw new ExceptionAccount("Withdraw error: The amount exceeds withdraw limit");
            }else if(valor > Balance){
                throw new ExceptionAccount("Withdraw error: Not enough balance");
            }
            else
            {
                Balance -= valor;
            }
        }


    }
}
