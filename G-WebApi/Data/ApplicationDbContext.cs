using Microsoft.EntityFrameworkCore;

namespace G_WebApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<SuperHero> SuperHeroes { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SuperHero>().HasData(
                new SuperHero
                {
                    Id = 1,
                    Name = "Spider Man",
                    FirstName = "Peter",
                    LastName = "Parker",
                    Place = "New York City",
                    CategoryId = 2,
                },
                 new SuperHero
                 {
                     Id = 2,
                     Name = "Iron Man",
                     FirstName = "Tony",
                     LastName = "Stack",
                     Place = "Malibu",
                     CategoryId = 2
                 },
                  new SuperHero
                  {
                      Id = 3,
                      Name = "Thor",
                      FirstName = "Chris",
                      LastName = "B",
                      Place = "Asgaurd",
                      CategoryId = 2,
                  },
                  new SuperHero
                  {
                      Id = 4,
                      Name = "Bat Man",
                      FirstName = "Bruce",
                      LastName = "Wayne",
                      Place = "Gotham City",
                      CategoryId = 1
                  },
                  new SuperHero
                  {
                      Id = 5,
                      Name = "Black Pantar",
                      FirstName = "T",
                      LastName = "Chala",
                      Place = "Wakanda",
                      CategoryId = 2
                  }
                );

            modelBuilder.Entity<Category>().HasData(
                    new Category { Id = 1, Name = "DC Studio"},
                    new Category { Id = 2, Name = "Marvel Studio"}
                );
        }

    }

}
