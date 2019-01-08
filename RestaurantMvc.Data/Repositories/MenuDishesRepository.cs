using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RestaurantMvc.Data.Infrastructure;
using RestaurantMvc.Model.Models;

namespace RestaurantMvc.Data.Repositories
{
    public class MenuDishesRepository: RepositoryBase<MenuDishes>, IMenuDishesRepository
    {
        public MenuDishesRepository(IDbFactory dbFactory):base(dbFactory)
        {
            
        }

        public List<MenuDishes> GetDishes(string category)
        {
            var returnList =
                DbContext.MenuDisheses.Include(a => a.Category)
                    .Where(n => n.Category.Name.ToLower()==category.ToLower())
                    .ToList();
            return returnList;
        }
    }
}
