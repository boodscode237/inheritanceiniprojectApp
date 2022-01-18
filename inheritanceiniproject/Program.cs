using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceiniproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IRentable> rentables = new List<IRentable>();
            List<IPurchasable> purchasables = new List<IPurchasable>();

            var vehicle = new VehiculeModel { DealerFee = 25, ProductName = "Kia Optima" };
            var book = new BookModel { ProductName = "Celestial Ring", NumberOfPages = 540 };
            var excavator = new ExcavatorModel { ProductName = "Buldozer", QuantityInStock = 2 };

            rentables.Add(excavator);
            rentables.Add(vehicle);

            purchasables.Add(book);
            purchasables.Add(vehicle);

            Console.Write("Do you want to rent or something? (rent,purchase) ");
            string decisionMade = Console.ReadLine();

            if (decisionMade.ToLower() == "rent")
            {
                foreach (var item in rentables)
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.Write("Do you want to rent this item (yes/no)? ");
                    string wantToRent = Console.ReadLine();

                    if (wantToRent.ToLower() == "yes")
                    {
                        item.Rent();
                    }


                    Console.Write("Do you want to return this item (yes/no)? ");
                    string wantToReturn = Console.ReadLine();

                    if (wantToReturn.ToLower() == "yes")
                    {
                        item.ReturnRental();
                    }
                }              
            }
            else
            {
                foreach (var purchasable in purchasables)
                {
                    Console.WriteLine($"Item: {purchasable.ProductName}");
                    Console.Write("Do you want to purchase this Product (yes/no)? ");
                    string wantToPurchase = Console.ReadLine();

                    if (wantToPurchase.ToLower() == "yes")
                    {
                        purchasable.Purchase();
                    }
                }
            }

            Console.WriteLine("We are through");
            Console.ReadLine();
        }
    }
}
