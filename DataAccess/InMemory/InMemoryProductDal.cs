using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using System.Linq;

namespace DataAccess.InMemory
{
    public class InMemoryProductDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryProductDal()
        {
            _cars = new List<Car>
            {
                new Car {CarId = 1, CarCategoryId = 1, BrandId = 1, ColorId = 2,ModelYear = 2018, Description ="Temiz 96.000 km de", DailyPrice = 215},
                new Car {CarId = 2, CarCategoryId = 2, BrandId = 1, ColorId = 5,ModelYear = 2008, Description ="Temiz 256.000 km de", DailyPrice = 100},
                new Car {CarId = 3, CarCategoryId = 2, BrandId = 2, ColorId = 1,ModelYear = 2021, Description ="Temiz 35.000 km de", DailyPrice = 325},
                new Car {CarId = 4, CarCategoryId = 3, BrandId = 3, ColorId = 8,ModelYear = 2013, Description ="Temiz 150.000 km de", DailyPrice = 150}

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car cartoDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(cartoDelete);
        }

        

        public List<Car> Getall()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            carToUpdate.CarId = car.CarId;
            carToUpdate.CarCategoryId = car.CarCategoryId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

            
        }
    }
}
