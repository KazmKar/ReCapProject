using Business.Concrete;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.InMemory;
using Entities.Concrete;
using Entities.Abstract;
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
                System.Console.WriteLine(car.CarId);
            }
        }
    }
}
