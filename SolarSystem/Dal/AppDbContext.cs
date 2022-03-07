﻿using Microsoft.EntityFrameworkCore;
using SolarSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        #endregion
    }
}