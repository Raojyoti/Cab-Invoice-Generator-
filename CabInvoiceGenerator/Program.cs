﻿using System;

namespace CabInvoiceGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Cab Invoice generator");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double fare= invoiceGenerator.CalculateFare(2.0, 5);
            Console.WriteLine($"Fare :{fare}");
        }
    }
}
