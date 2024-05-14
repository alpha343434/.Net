using Business2;
using DataAccess;
using Entities;
using DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{

    static void Main(string[] args)
    {
        var productManager = new ProductManager();

        productManager.AddProduct(new Product { ProductName = "product 1", CategoryId = 1234 });

        while (true);
        {
            Console.WriteLine("----Product Management Menu:------");
            Console.WriteLine("1 - Add Product");
            Console.WriteLine("2 - Get Product");
            Console.WriteLine("3 - Exit");
        }
        var choice = Console.ReadLine();

        switch(choice)
        {
            case "1":
                // call AddProduct function
                break;
            case "2":
                Console.WriteLine("Enter product name: ");
                var name = Console.ReadLine();
                //var product =  productManager.Get();
                break;
            case "3":
                return; // exit the loop
            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }
}﻿

