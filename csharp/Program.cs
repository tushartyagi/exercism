using System;
using System.Numerics;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            var account = new BankAccount();
            account.Open();
            account.Close();         

            account.UpdateBalance(20);   
        }
    }
}
