﻿//18. Write a C# Sharp program to calculate and print the electricity bill of a customer. From the keyboard,
//the customer's name, ID, and unit consumed should be taken and displayed along with the total amount due.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse_electricitybill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int id,unit;
            float charges,total,subcharge,finalamt;
            
            Console.WriteLine("Enter Customer id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customer Name: ");
            name= Console.ReadLine();
            Console.WriteLine("Unit consumed");
            unit=Convert.ToSingle(Console.ReadLine());
            {
                if (unit <= 199)
                {
                    charges = unit * 1.20f;
                }
                else if (unit > 200 && unit <= 400)
                {
                    charges = unit * 1.50f;
                }
                else if (unit > 400 && unit <= 600)
                {
                    charges = unit * 1.80f;
                }
                else if (unit < 600)
                {
                    charges = unit * 2.00f;
                }
                total = unit + charges;

                Console.WriteLine("Customer id: {0} Customer name: {1} Unit Consumed : {2} ", id, name, unit);
                Console.WriteLine("Amount Charges: {0} Per unit: {1}Rs", charges, total);
            }
            if(total>=400)
            {
                subcharge = total * 0.15f;
            }

            finalamt=total+subcharge;

            Console.WriteLine("Subcharges of 15%: {0} Final Amount: {1}",subcharge,finalamt)
            Console.ReadKey();

        }
    }
}
