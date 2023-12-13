using FurnitureApp.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace FurnitureApp.Contexts
{
    public class FurnitureDBContext:DbContext
    {
        public FurnitureDBContext(DbContextOptions<FurnitureDBContext> options) : base(options)
        {
        }

        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Setting> Settings{ get; set; }
        public DbSet<Social> Socials{ get; set; }


	}
}
