using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    internal class RealEstate
    {
        public string Address { get; }
        public int YearBuilt { get; }
        public double PurchasePrice 
        { 
            get; 
        }
        public double IncomeFromRent { get; set; }
        public double MonthlyExpense { get; set; }
        public double MonthlyEarnings //read only computed
        {
            get 
            { 
                return IncomeFromRent - MonthlyExpense; 
            }
        }

        //alternate computation using method
        public double GetMonthlyEarnings()
        {
            return IncomeFromRent - MonthlyExpense;
        }

        //constructor
        public RealEstate(string address, int yearBuilt, double puchasePrice) //same name as the class
        { 
            Address = address; 
            YearBuilt = yearBuilt;
            PurchasePrice = puchasePrice;
        }

        public override string ToString()
        {
            string outputStr = "Address: " + Address + "\n" +
                               "Year Built: " + YearBuilt + "\n" +
                               "Purchase Price: " + PurchasePrice.ToString("C") + "\n" +
                               "Income from rent: " + IncomeFromRent.ToString("C") + "\n" +
                               "Monthly Expenses: " + MonthlyExpense.ToString("C") + "\n" +
                               "Monthly Earnings: " + MonthlyEarnings.ToString("C") + "\n";
            return outputStr;
        }
    }
}
