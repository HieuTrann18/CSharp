using QuanLyXe.Controllers;
using QuanLyXe.Services;
using QuanLyXe.Validators;

namespace QuanLyXe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarServices carServices = new CarServices();
            CarController carController = new CarController(carServices);

           
         
            
           


            while (true)
            {
                Console.WriteLine("===================Menu==================");
                Console.WriteLine("1.Add new car............................");
                Console.WriteLine("2.Display list car.......................");
                Console.WriteLine("3.Search car by name.....................");
                Console.WriteLine("4.Delete car by id.......................");
                Console.WriteLine("5.Sort the list of car in ascending order");
                Console.WriteLine("6.Edit car information by ID.............");
                Console.WriteLine("7.Exit program...........................");
                Console.WriteLine("=========================================");
                

                string choose = CarValidator.StandardString("Your choose: ", "");

                switch (choose)
                {
                    case "1":
                        carController.AddNewCar();
                        break;
                    case "2":
                        carController.DisplayAllCar();
                        break;
                    case "3":
                        carController.SearchCarByName();
                        break;
                    case "4":
                        carController.DeleteCar();
                        break;
                    case "5":
                        carController.SortCarByPrice();
                        break;
                    case "6":
                        carController.UpdateCar();
                        break;
                    case "7":
                        Console.WriteLine("Exiting........");
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Please select again.");
                        break;

                }
            }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 carController.DisplayAllCar();
        }
    }
}
