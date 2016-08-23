using ImieApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ImieApplication.Database
{


    /// <summary>
    /// Allow to build DB first time it called.
    /// </summary>
    public class DBInitializer : DbContext
    {


        #region Constantes

        #endregion

        #region Attributs

        #endregion

        #region Conctructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="database">DB to target.</param>
        public DBInitializer(String database) : base(database)
        {
            InitDB();
        }
        #endregion

        #region Properties
            private DbSet<OGameCoordinate> DbSetCoordinate { get; set; }
            private DbSet<OGameFleet> DbSetFleet { get; set; }
            private DbSet<OGamePlanet> DbSetPlanet { get; set; }
            private DbSet<OGameResource> DbSetResource { get; set; }
            private DbSet<OGameSpaceShip> DbSetSpaceShip { get; set; }
            private DbSet<OGameTypeBuilding> DbSetTypeBuilding { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Create database if not already exist.
        /// </summary>
        public async void InitDB()
        {

            if(this.Database.CreateIfNotExists()) { }

        }
        #endregion

        #region Events

        #endregion


    }


}