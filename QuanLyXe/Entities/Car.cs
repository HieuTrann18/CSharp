using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe.Entities
{
    class Car
    {
        public int CarID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }

        public Car(int carID, string name, string brand, float price, int quantity)
        {
            CarID = carID;
            Name = name;
            Brand = brand;
            Price = price;
            Quantity = quantity;
        }

       public void DisplayInfo()
        {
            Console.WriteLine($"ID: {CarID}, Name: {Name}, Brand: {Brand}, Price: {Price}, Quantity: {Quantity}");
        }
    }
}
