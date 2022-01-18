using System;

namespace inheritanceiniproject
{
    public class VehiculeModel : InventoryItemModel, IPurchasable, IRentable
    {
        public decimal DealerFee { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This excavator had been purchased");
        }
        public void Rent()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This excavator had been rented");
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            Console.WriteLine("This excavator had been return");
        }
    }
}
