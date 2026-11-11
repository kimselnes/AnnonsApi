using AnnonsApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace AnnonsApi.Data
{
    public class DataInitializer
    {
        private readonly ApplicationDbContext _dbContext;

        public DataInitializer(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void MigrateData()
        {
            _dbContext.Database.Migrate();
            SeedData();
            _dbContext.SaveChanges();
        }

        private void SeedData()
        {
            if (!_dbContext.Ads.Any(a => a.Title == "Playstation 5"))
            {
                _dbContext.Add(new Ad
                {
                    Title = "Playstation 5",
                    Desciption = "Sony's senaste konsol, nu med fler polygoner.",
                    Price = 599.99m,
                });
            }

            if (!_dbContext.Ads.Any(a => a.Title == "Trocadero Zero"))
            {
                _dbContext.Add(new Ad
                {
                    Title = "Trocadero Zero",
                    Desciption = "Be a hero, drink Zero!",
                    Price = 5.50m,
                });
            }

            if (!_dbContext.Ads.Any(a => a.Title == "Bok"))
            {
                _dbContext.Add(new Ad
                {
                    Title = "Bok",
                    Desciption = "Bok med text.",
                    Price = 69m,
                });
            }
        }
    }
}
