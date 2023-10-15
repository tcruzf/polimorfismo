using System;
using System.Drawing;
using System.Globalization;
using System.Collections.Generic;
using ProjectCourse.Entities;
using System.Runtime.InteropServices;

namespace ProjectCourse {

    class Program {
        static void Main(string[] args) {
            
            List<Product> list = new List<Product>();          
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i =1; i<= n; i++) {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? :");
                char ch = char.Parse(Console.ReadLine());
               
                Console.Write("Name :");
                string nameProd = Console.ReadLine();
                Console.Write("Price: ");
                double priceProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'c') {
                    
                    list.Add(new Product(nameProd, priceProd));

                }
                else if(ch == 'u') {
                    Console.Write("Manufacture date (dd/mm/yyyy) :");
                    DateTime manufac = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(nameProd, priceProd, manufac));
                }else if(ch == 'i'){
                    Console.Write("Customs fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(nameProd, priceProd, customFee ));
                }   
               
               

            }
            foreach (Product x in list) {
                Console.WriteLine($"{x.PriceTag()}");
            }

        }
    }
}