using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantMvc.Data.Infrastructure;
using RestaurantMvc.Model.Models;

namespace RestaurantMvc.Data.Repositories
{
    public class ManuCategoryRepository:RepositoryBase<MenuCategory>, IManuCategoryRepository
    {
        public ManuCategoryRepository(IDbFactory dbFactory):base(dbFactory)
        {
        }

        public MenuCategory GetCategoryById(int id)
        {
            return base.DbContext.MenuCategories.FirstOrDefault(x => x.Id==id);
        }

    }
}
