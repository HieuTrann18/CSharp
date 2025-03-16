using QuanLyXe.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe.Interfaces
{
    interface ICarService
    {
        void AddCar(Car car);
        List<Car> GetAllCar();
        Car SearchCar(string keyword);
        bool DeleteCar(int CarId);
        List<Car> SortCarsByPrice();
        bool UpdateCar(int CarId, Car updatedCar);
    }
}
