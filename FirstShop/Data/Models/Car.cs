using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstShop.Data.Models
{
    public class Car
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortDesc { get; set; }
        public string longDesc { get; set; }
        public string img { get; set; }
        public ushort price { get; set; }
        public bool isFavourite { get; set; } //если установлен = показываем на главной странице 
        public bool available { get; set; }
        public int categoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
