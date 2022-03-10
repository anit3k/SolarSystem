using Microsoft.EntityFrameworkCore;
using SolarSystem.Models;
using SolarSystem.ViewModels;

namespace SolarSystem.Dal
{
    /// <summary>
    /// This class is responsible for getting the values from the database,
    /// its inherits from DbContext that is used with EF core basics.
    /// </summary>
    public class AppDbContext : DbContext
    {
        #region fields
        private DbSet<Language> _languages;
        private DbSet<StringResources> _stringResources;
        private DbSet<Planet> _planets;
        #endregion

        #region Constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        #endregion

        #region Methods
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("name=DefaultConnection");
            }
        }
        #endregion

        #region Properties
        public DbSet<Language>  Languages
        {
            get { return _languages; }
            set { _languages = value; }
        }            
        public DbSet<StringResources> StringResources
        {
            get { return _stringResources; }
            set { _stringResources = value; }
        }
        public DbSet<Planet> Planets
        {
            get { return _planets; }
            set { _planets = value; }
        }
        #endregion
    }
}
