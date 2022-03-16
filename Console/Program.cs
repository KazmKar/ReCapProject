using Business.Concrete;
using DataAccess.InMemory;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryProductDal());
            foreach (var car in carManager.Getall())
            {
                System.Console.WriteLine(car.CarCategoryId);
            }
        }
    }
}
