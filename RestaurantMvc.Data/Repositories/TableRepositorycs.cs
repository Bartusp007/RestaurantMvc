using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using RestaurantMvc.Data.Infrastructure;
using RestaurantMvc.Model.Models;

namespace RestaurantMvc.Data.Repositories
{
    public class TableRepository: RepositoryBase<Table>, ITableRepository
    {
        private readonly IDbSet<Table> _dbSet;
        public TableRepository(IDbFactory dbFactory) : base(dbFactory)
        {
            _dbSet = DbContext.Set<Table>();
        }
        public List<Table> TablesEager()
        {
            var returnList = _dbSet.Include(t => t.Reservation).ToList();

            return returnList;
        }
    }
}
