 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstShop.Data.interfaces;
using FirstShop.Data.Models;

namespace FirstShop.Data.mocks
{
    public class mockCars : IAllCars
    {
        private readonly ICarsCategory _carsCategory = new MockCategory();

        public IEnumerable<Car> Cars 
        {
            get
            {
                return new List<Car>
                {
                    new Car 
                    { 
                        name = "Tesla Model S",
                        shortDesc = "Быстрый автомобиль на электрическом двигателе",
                        longDesc = "Быстрый и очень тихий автомобиль от компании Tesla",
                        img = "/img/tesla.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _carsCategory.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Ford Focus",
                        shortDesc = "Красивый и доступный автомобиль",
                        longDesc = "Идеальный автомобиль по низкой цене для передвижения по городу и пригородной среде",
                        img = "/img/ford.jpg",
                        price = 14433,
                        isFavourite = false,
                        available = true,
                        Category = _carsCategory.AllCategories.ElementAtOrDefault(1)
                    },
                    new Car
                    {
                        name = "Mercedes Benz Tourismo Euro V",
                        shortDesc = "Автобус для перевозки людей",
                        longDesc = "Красивый автобус для перевозки большого колличества людей",
                        img = "/img/mercedesbus.jpg",
                        price = 65000,
                        isFavourite = false,
                        available = true,
                        Category = _carsCategory.AllCategories.ElementAtOrDefault(3)
                    },
                    new Car
                    {
                        name = "Ferrari 430",
                        shortDesc = "Один из самых быстрых автомобилей",
                        longDesc = "Красивый и быстрый автомобиль от Ferrari",
                        img = "/img/ferrari.jpg",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = _carsCategory.AllCategories.ElementAtOrDefault(2)
                    },
                    new Car
                    {
                        name = "Mercedes C63 S FL",
                        shortDesc = "Уютный C-класс от компании мерседес",
                        longDesc = "Красивая и быстрая машина, отлично держит дорогу",
                        img = "/img/mercedes.jpg",
                        price = 60000,
                        isFavourite = true,
                        available = true,
                        Category = _carsCategory.AllCategories.ElementAtOrDefault(2)
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
