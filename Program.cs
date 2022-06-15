using System;
using System.Collections.Generic;

namespace KataJune13
{
    // Has the following classes:
    // 1. W2 class to represent income forms
    //    a. Give it two private set/public get properties
    //       decimal TaxableIncome and string CompanyName
    //    b. Create a constructor for the W2 class that takes
    //       taxable income and company name and assigns those values to the properties
    // 2. Utility method to get the W2s from the user
    //    a. Should return a W2Form[]
    //    b. Use a loop to keep asking the user to enter a W2
    // 3. TaxCalculator class to compute the taxes
    //    a. Has one public get/private set prop called incomeForms that is a W2Form[]
    //    b. Has a constructor that takes a W2Form[]
    //    c. One method called ComupteTaxes that computes the taxes by:
    //       i. Summing the income of all W2Forms
    //       ii. Multiplying the result by 0.17
    //       iii. then returning that result
    // 4. Then we have to write code to bring all this together.
    //    a. Delcare a W2Form[] variable to store the read W2s from the user
    //    b. Call the utility method to get a list of W2s from the user
    //    c. Create a TaxCalculator instand
    //    d. call TaxCalculator.ComputeTaxes
    //    e. Display the result
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Tax Calculator!");
            TaxCalculator newTaxCalculator = new TaxCalculator(EnterForm());
            decimal totalTax = newTaxCalculator.ComputeTaxes();
            Console.WriteLine($"Your total taxes due: {totalTax}");
        } 
        public static W2Form[] EnterForm()
        {
            var myForms = new List<W2Form>();
            bool continueRunning = true;
            while (continueRunning)
            {
                Console.WriteLine("Would you like to enter a W2 (y/n)?");
                string userResponse = Console.ReadLine().ToLower();
                if (userResponse != "y")
                {
                    continueRunning = false;
                }
                else
                {
                    W2Form newForm;
                    decimal newTaxableIncome;
                    string newCompanyName;
                    try
                    {
                        Console.Write("Please enter Taxable Income: ");
                        newTaxableIncome = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Please enter Company Name: ");
                        newCompanyName = Console.ReadLine();
                        newForm = new W2Form(newTaxableIncome, newCompanyName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            return myForms.ToArray();
        }
    }
}
