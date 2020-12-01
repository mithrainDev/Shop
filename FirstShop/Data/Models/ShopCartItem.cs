using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstShop.Data.Models
{
    public class ShopCartItem
    {

        public int id { get; set; } //id самого товара
        public Car car { get; set; } //сам объект
        public int price { get; set; } //цена
        
        public string ShopCartId { get; set; } //id товара в самой карзине 

    }
}
