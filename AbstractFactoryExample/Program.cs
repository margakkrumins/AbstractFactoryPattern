﻿using System;
using System.Collections.Generic;
using Interfaces;
using AbstractFactories;
using Providers;

namespace AbstractFactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> accntNumbers = new List<string> {
                                        "CITI-456",
                                        "NATIONAL-987",
                                        "CHASE-222" };

            for (int i = 0; i < accntNumbers.Count; i++)
            {
                CreditUnionFactory anAbstractFactory =
                    CreditUnionFactoryProvider. GetCreditUnionFactory(accntNumbers[i]);

                if (anAbstractFactory == null)
                {
                    Console.WriteLine("Sorry. This credit union w/ account number" +
                                      $" ' {(accntNumbers[i])} ' is invalid.");
                }
                else
                {
                    ILoanAccount loan = anAbstractFactory.CreateLoanAccount();
                    ISavingsAccount savings = anAbstractFactory.CreateSavingsAccount();
                }
            }
            Console.ReadLine();
        }


    }
}
