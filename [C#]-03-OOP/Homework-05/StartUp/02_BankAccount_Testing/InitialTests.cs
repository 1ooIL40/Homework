﻿
namespace StartUp._02_BankAccount_Testing
{
    using System;

    public static class InitialTests
    {
        public static void TestInterest()
        {
            var test = new BankAccountsAssembly.AccountModels.Deposit(
                new BankAccountsAssembly.CustomerModels.Company(),
                1500, (decimal)1.5);

            Console.WriteLine(test);
            Console.WriteLine(test.Balance);
            Console.WriteLine(test.InterestRate);
            Console.WriteLine(test.CalculateInterest(15));
        }
    }
}
