using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Animal>()
              .HasData(
                  new Animal { AnimalId = 1, Name = "Bobby", Type = "Dog", Age = 7, Gender = "Female" },
                  new Animal { AnimalId = 2, Name = "Mr. Catto", Type = "Cat", Age = 10, Gender = "Female" },
                  new Animal { AnimalId = 3, Name = "Le Doggo", Type = "Dog", Age = 2, Gender = "Female" },
                  new Animal { AnimalId = 4, Name = "Gerard", Type = "Cat", Age = 4, Gender = "Male" },
                  new Animal { AnimalId = 5, Name = "Noodle", Type = "Dog", Age = 22, Gender = "Male" }
              );
        }
        public DbSet<Animal> Animals { get; set; }
    }
}