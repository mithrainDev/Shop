using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstShop.Data.Models
{
    public class ShopCart
    {

        private readonly AppDBContent appDBContent;

        public ShopCart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }


        public string ShopCartId { get; set; }

        public List<ShopCartItem> listShopItems { get; set; } //все товары в карзине

        //метод, проверяет если пользователь добовляет товар в карзину в которой уже есть товар, 
        //если карзины пустая
        //создается новая карзины с первым товаром
        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString(); //если не существует CardId, то создаем новый идентификатор

            session.SetString("CartId", shopCartId);

            return new ShopCart(context) { ShopCartId = shopCartId };
        }

        //матод, позволяющий добавлять какие либо товары в карзину
        public void AddToCart(Car car)
        {
            appDBContent.ShopCartItem.Add(new ShopCartItem 
            { 
                ShopCartId = ShopCartId,
                car = car,
                price = car.price
            });

            appDBContent.SaveChanges();
        }

        //метод, отображающий все товары в карзине
        public List<ShopCartItem> getShopItems()
        {
            return appDBContent.ShopCartItem.Where(c => c.ShopCartId == ShopCartId).Include(s => s.car).ToList();
        }
    }
}
