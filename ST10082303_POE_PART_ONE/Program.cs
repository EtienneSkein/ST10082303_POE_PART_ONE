using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Program by Etienne Skein
// V 2.0

// main class
namespace ST10082303_POE_PART_ONE
{
    class Program
    {
        static void Main(string[] args)
        {   
            Expenses findA = new Expenses();
            RentOrBuy findB = new RentOrBuy();
            findA.Hello();
            findA.getMonthlyIncome(); 
            findA.getUserInfo();
            findB.rentOrBuy();
            RentOrBuy.findRepay();
            Expenses.remainder(findA.costs, findA.monthlyIncome);
            car c = new car();
            c.entry(findA.getMonthlyIncome());
            Console.Read();
        }
    }
}
