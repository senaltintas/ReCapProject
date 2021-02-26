using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            RentalTest();
        }

        private static void RentalTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

          //  userManager.Add(new User {  FirstName = "Melodi", LastName = "Chris", Email = "melodic@", Password = "012345" });
           // customerManager.Add(new Customer { UserId = 8, CompanyName = "Rose" });
            var result=rentalManager.Add(new Rental {  CarId = 3, CustomerId = 8, RentDate = "16.05.2021" });
            Console.WriteLine(result.Message);
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {

                foreach (var cars in result.Data)
                {
                    Console.WriteLine(cars.Description + "-" + cars.BrandName + "-" + cars.ColorName + "-" + cars.DailyPrice);

                }
            }
            else
                Console.WriteLine(result.Message);
        }
    }
}
