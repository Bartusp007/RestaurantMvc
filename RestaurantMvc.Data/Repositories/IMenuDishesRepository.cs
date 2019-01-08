using System.Collections.Generic;
using RestaurantMvc.Model.Models;
using RestaurantMvc.Models.Infrastructure;

namespace RestaurantMvc.Data.Repositories
{
    public interface IMenuDishesRepository:IRepository<MenuDishes>
    {
         List<MenuDishes> GetDishes(string category);
    }
}