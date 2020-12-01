using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstShop.Data.interfaces;
using FirstShop.Data.Models;

namespace FirstShop.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{ categoryName = "Электромобили", desc = "Современный вид транспорта" },
                    new Category{ categoryName = "Классические автомобили", desc = "Автомобили с двигателем внутреннего сгорания"},
                    new Category{ categoryName = "Спортивные автомобили", desc = "Автомобили для соревнований"},
                    new Category{ categoryName = "Автобусы", desc = "Автомобили для перевозки большого колличества людей"}
                }; 
            }
        }
    }
}
