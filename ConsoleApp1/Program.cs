using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Real state app
            //Read-only Address (string), year built (int) and purchase price (double)
            //Read-write IncomeFromRent (double) and monthlyExpense (double)
            //Read-only computed MonthlyEarnings (double) and IncomeFromRent (dobule = IncomeFromRent - MonthlyExpenses)
            // Add constructor -> ToString()

            //with new I create an object building1
            RealEstate building1 = new RealEstate("328 Agnes", 1999, 900000);
            building1.IncomeFromRent = 1200.99;
            building1.MonthlyExpense = 289.98;
            WriteLine(building1);

            GetAdressYearAndPrice(out string address, out int year, out double price);
            RealEstate building2 = new RealEstate(address, year, price);
            WriteLine(building2.ToString());

            LoadIncomeAndExpenses(building2);
            WriteLine(building2);
        }

        static void LoadIncomeAndExpenses(RealEstate anybuilding)
        {
            //get user input for income and expese
            Write("Enter the income from rent for " + anybuilding.Address + ": ");
            anybuilding.IncomeFromRent = double.Parse(ReadLine());
            Write("Enter the expense for {0}: ", anybuilding.Address);
            anybuilding.MonthlyExpense = double.Parse(ReadLine());
            //set anybuilding monthly expense

        }
        //method and variables oput to be able to use it outside
        static void GetAdressYearAndPrice(out string address, out int year, out double price)
        {
            Write("Enter the address: ");
            address = ReadLine();
            Write("Enter the year built: ");
            year = int.Parse(ReadLine());
            Write("Enter the purchase price: ");
            price = double.Parse(ReadLine());
        }
    }
}
