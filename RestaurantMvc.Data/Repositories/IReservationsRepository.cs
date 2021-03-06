﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using RestaurantMvc.Model.Models;
using RestaurantMvc.Models.Infrastructure;

namespace RestaurantMvc.Data.Repositories
{
    public interface IReservationsRepository:IRepository<Reservation>
    {
        void Add(Reservation entity, List<Table> tebleList);
        List<Reservation> GetAllTables();
        List<Reservation> GetManyTables(Expression<Func<Reservation, bool>> where);
    }
}