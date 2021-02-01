using DataAccess.Abstruct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{ BrandId=1,CarId=1,CarModelName="BMW 3.20",ColorId=1,DailyPrice=120,Description="3.20-sport model-Hibrit",ModelYear=2015},
                new Car{ BrandId=1,CarId=2,CarModelName="BMW X5",ColorId=6,DailyPrice=490,Description="3.2-XDRİVE-Dizel",ModelYear=2019},
                new Car{ BrandId=2,CarId=3,CarModelName="AUDİ A5",ColorId=8,DailyPrice=1500,Description="3.2-Sport-Dizel",ModelYear=2020},
                new Car{ BrandId=2,CarId=4,CarModelName="AUDİ QUADRO",ColorId=4,DailyPrice=1600,Description="4.0-Suv model-Benzinli",ModelYear=2021},
                new Car{ BrandId=3,CarId=5,CarModelName="Volkswagen Golf",ColorId=7,DailyPrice=450,Description="1.6-Hight Line Packet-Dizel",ModelYear=2020}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void GetByld(Car car)
        {
            Car carId = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            Console.WriteLine(carId);
        }

       

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.CarModelName = car.CarModelName;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
