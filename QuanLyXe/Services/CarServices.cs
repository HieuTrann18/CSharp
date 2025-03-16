using QuanLyXe.Data;
using QuanLyXe.Entities;
using QuanLyXe.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe.Services
{
    class CarServices : ICarService
    {

        private List<Car> cars;
        
        public CarServices()
        {
            this.cars = SampleData.GetSampleData();
        }

        public void AddCar(Car car)
        {
            if(car != null)
            {
                cars.Add(car);
            }
        }

        public bool DeleteCar(int CarId)
        {
            var carToRemove = cars.Where(x => x.CarID == CarId).FirstOrDefault();
            if(carToRemove != null)
            {
                cars.Remove(carToRemove);
                return true;
            }
            return false;
        }

        public List<Car> GetAllCar()
        {
            return cars;
        }

        public Car SearchCar(string keyword)
        {
            return cars.Where(x => x.Name.Equals(keyword, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
        }

        public List<Car> SortCarsByPrice()
        {
            return cars = cars.OrderByDescending(x => x.Price).ToList();
        }

        public bool UpdateCar(int carId, Car updatedCar)
        {
            Car existingCar = cars.Find(x => x.CarID == carId);
            if(existingCar == null)
            {
                return false;
            }
            existingCar.Name = updatedCar.Name;
            existingCar.Brand = updatedCar.Brand;
            existingCar.Price = updatedCar.Price;
            existingCar.Quantity = updatedCar.Quantity;

            return true;
           
        }

        public int GetLengthOfArray()
        {
            return cars.Count > 0 ? cars.Max(x => x.CarID) + 1 : 1;
        }
    }
}
