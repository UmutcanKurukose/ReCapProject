using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstruct
{
    public interface ICarDal
    {
        List<Car> GetAll();
        void GetByld(Car car);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
