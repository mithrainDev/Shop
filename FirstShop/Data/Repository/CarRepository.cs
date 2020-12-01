using FirstShop.Data.interfaces;
using FirstShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstShop.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent appDBContent;

        public CarRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        //получаем все объекты
        public IEnumerable<Car> Cars => appDBContent.Car.Include(c => c.Category);

        //получаем все объекты где isFavourite == true
        public IEnumerable<Car> getFavCars => appDBContent.Car.Where(p => p.isFavourite).Include(c => c.Category);

        //выбираем объект где id == carid
        public Car getObjectCar(int carId) => appDBContent.Car.FirstOrDefault(p => p.id == carId);
    }
}
