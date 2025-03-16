using QuanLyXe.Entities;
using QuanLyXe.Services;
using QuanLyXe.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe.Controllers
{
    class CarController
    {
        private readonly CarServices carServices;
        private int AutoIncrement = 1;

        public CarController(CarServices carServices)
        {
            this.carServices = carServices;
            this.AutoIncrement = carServices.GetLengthOfArray();
        }

        public void AddNewCar()
        { 
            int id = AutoIncrement++;
            string name = CarValidator.StandardString("Enter car name: ", "Car name invalid! Please re-enter car name: ");
            string brand = CarValidator.StandardString("Enter brand name: ", "Brand name invalid! Please re-enter car brand: ");
            float price = CarValidator.StandardFloatInput("Enter car price: ", "Car price invalid! Please re-enter car price: ");
            int quantity = CarValidator.StandardIntInput("Enter car quantity: ", "Car quantity invalid! Please re-enter car quantity: ");

            var carExisting = FindExistingCar(name, brand, price);
            if (carExisting != null)
            {
                carExisting.Quantity += quantity;
            }
            else
            {
                carServices.AddCar(new Car(id, name, brand, price, quantity));
               
            }
            Console.WriteLine("Add new car successfully");
        }

        public void DisplayAllCar()
        {
            var cars = carServices.GetAllCar();
            if (cars.Count == 0)
            {
                Console.WriteLine("Not found car");
            }
            else
            {
                cars.ForEach(car => car.DisplayInfo());
            }
        }

        public void SearchCarByName()
        {
            string keyword = CarValidator.StandardString("Search: ", "Invalid! please re-enter: ");
            var result = carServices.SearchCar(keyword);
            if (result == null)
            {
                Console.WriteLine($"Not found car name: {keyword}");
            }
            else
            {
                Console.WriteLine("Result search: ");
                result.DisplayInfo();
            }
        }

        public void DeleteCar()
        {
            int id = CarValidator.StandardIntInput("Enter car id to delete: ", "Invalid ID! Please re-enter: ");
            bool isDeleted = carServices.DeleteCar(id);
            Console.WriteLine(isDeleted ? "Car deleted successfully!" : "Car not found!");
        }

        public void SortCarByPrice()
        {
            List<Car> result = carServices.SortCarsByPrice();
            if(result.Count == 0)
            {
                Console.WriteLine("Not found car");
            }
            else
            {
                result.ForEach(x => x.DisplayInfo());
            }
        }

        public void UpdateCar()
        {
            int id = CarValidator.StandardIntInput("Enter car Id to update: ", "Invalid ID! Please re-enter: ");
            var carToUpdate = carServices.GetAllCar().FirstOrDefault(x => x.CarID == id);

            if (carToUpdate == null)
            {
                Console.WriteLine("Car not found!");
                return;
            }

            string newName = CarValidator.StandardString("Enter new name: ", "Invalid name! Please re-enter: ");
            if (!string.IsNullOrEmpty(newName))
            {
                carToUpdate.Name = newName;
            }
            string newBrand = CarValidator.StandardString("Enter new brand: ", "Invalid brand! Please re-enter: ");
            if (!string.IsNullOrEmpty(newBrand)){
                carToUpdate.Brand = newBrand;
            }
            float newPrice = CarValidator.StandardFloatInput("Enter new price: ", "Invalid price! Please re-enter: ");
            if(newPrice > 0)
            {
                carToUpdate.Price = newPrice;
            }
            int newQuantity = CarValidator.StandardIntInput("Enter new quantity : ", "Invalid quantity! Please re-enter: ");
            if (newQuantity > 0) carToUpdate.Quantity = newQuantity;

            Console.WriteLine("Car updated successfully!");


        }

        private Car FindExistingCar(string name, string brand, float price)
        {
            return carServices.GetAllCar()
                .FirstOrDefault(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase)
                                  && x.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase)
                                  && x.Price == price);
        }


    }
}
