using FirstShop.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstShop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            //получаем все объекты и если их нету = добавляем
            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if(!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "Tesla Model S",
                        shortDesc = "Быстрый автомобиль на электрическом двигателе",
                        longDesc = "Быстрый и очень тихий автомобиль от компании Tesla",
                        img = "/img/tesla.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобили"]
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
                        Category = Categories["Классические автомобили"]
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
                        Category = Categories["Автобусы"]
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
                        Category = Categories["Спортивные автомобили"]
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
                        Category = Categories["Спортивные автомобили"]
                    }
                );
            }

            content.SaveChanges();

        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                //Если категории пустые, то добавляем, если категории уже есть то просто возвращаем
                if(category == null)
                {
                    var list = new Category[]
                    {
                         new Category{ categoryName = "Электромобили", desc = "Современный вид транспорта" },
                        new Category{ categoryName = "Классические автомобили", desc = "Автомобили с двигателем внутреннего сгорания"},
                        new Category{ categoryName = "Спортивные автомобили", desc = "Автомобили для соревнований"},
                        new Category{ categoryName = "Автобусы", desc = "Автомобили для перевозки большого колличества людей"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach(Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }
                }

                //если категории уже есть то просто возвращаем
                return category;
            }
        }
    }
}
