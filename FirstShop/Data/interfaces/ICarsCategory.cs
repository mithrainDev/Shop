using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstShop.Data.Models;

namespace FirstShop.Data.interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
