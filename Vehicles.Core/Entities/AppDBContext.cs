using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Core.Entities
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Bus> Buses  { get; set; }
        public DbSet<Boat> Boats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car
                {
                    Id = 1,
                    Color = "Red",
                    Wheels = 4,
                    Headlights=true
                }, new Car
                {
                    Id = 2,
                    Color = "Blue",
                    Wheels = 4,
                    Headlights = true
                },
                new Car
                {
                    Id = 3,
                    Color = "Black",
                    Wheels = 4,
                    Headlights = true
                },
                new Car
                {
                    Id = 4,
                    Color = "White",
                    Wheels = 4,
                    Headlights = true
                }, new Car
                {
                    Id = 5,
                    Color = "Black",
                    Wheels = 4,
                    Headlights = true
                }
              );
            modelBuilder.Entity<Bus>().HasData(
                new Bus
                {
                    Id = 1,
                    Color="Red"
                }, new Bus
                {
                    Id = 2,
                    Color = "Blue"
                }, new Bus
                {
                    Id = 3,
                    Color = "Black"
                }, new Bus
                {
                    Id = 4,
                    Color = "White"
                },new Bus
                {
                    Id = 5,
                    Color="Black"
                });
            modelBuilder.Entity<Boat>().HasData(
                new Boat
                {
                    Id = 1,
                    Color = "Red"
                }, new Boat
                {
                    Id = 2,
                    Color = "Blue"
                }, new Boat
                {
                    Id = 3,
                    Color = "Black"
                }, new Boat
                {
                    Id = 4,
                    Color = "White"
                }, new Boat
                {
                    Id = 5,
                    Color = "Black"
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}
