using Business.Concrete;
using DataAccess.InMemory;
using System;

namespace consoleUI1
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryProductDal());
            foreach (var car in carManager.Getall())
            {
                Console.WriteLine("Araba modeli yılı : "+ car.ModelYear);
                Console.WriteLine("Araba renk numarası : "+ car.ColorId);
                Console.WriteLine("Araba katagorisi : "+ car.CarCategoryId);
                Console.WriteLine("Günlük fiyat tutarı : "+ car.DailyPrice);
                Console.WriteLine("Marka numarası : "+ car.BrandId);
                Console.WriteLine("---------------------");
            }

        }
    }
}
