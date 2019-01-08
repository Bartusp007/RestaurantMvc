using System.Collections.Generic;
using RestaurantMvc.Model.Models;
using RestaurantMvc.Models.Infrastructure;

namespace RestaurantMvc.Data.Repositories
{
    public interface ITableRepository:IRepository<Table>
    {
        List<Table> TablesEager();
    }
}