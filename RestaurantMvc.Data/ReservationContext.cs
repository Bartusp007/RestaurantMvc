using System;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using RestaurantMvc.Data.Configurations;
using RestaurantMvc.Model.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace RestaurantMvc.Data
{
    public class ReservationContext : DbContext
    {
        public DbSet<Reservation> Reseervations { get; set; }
        public DbSet<Table> Tableses { get; set; }
        public DbSet<MenuCategory> MenuCategories { get; set; }
        public DbSet<MenuDishes> MenuDisheses { get; set; }

        public ReservationContext()
            : base("name=RestaurantDataBase")
        {
        }
        public virtual void Commit()
        {
            base.SaveChanges();
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ReservationConfiguration());
            modelBuilder.Configurations.Add(new TablesConfigurations());
            modelBuilder.Configurations.Add(new MenuDishesConfigurations());
        }



    }
}
