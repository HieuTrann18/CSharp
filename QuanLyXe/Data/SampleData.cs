using QuanLyXe.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe.Data
{
    class SampleData
    {
        public static List<Car> GetSampleData() {
            return new List<Car>
            {
                new Car(1, "Toyota Corolla", "Toyota", 20000, 10),
                new Car(2, "Honda Civic", "Honda", 22000, 5),
                new Car(3, "Ford Mustang", "Ford", 35000, 2),
                new Car(4, "Tesla Model 3", "Tesla", 40000, 8),
                new Car(5, "BMW X5", "BMW", 60000, 3)
            };
        }
    }
}
