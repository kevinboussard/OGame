using ImieApplication.Models;
using ImieApplication.Utils.Generator;
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

            if(this.Database.CreateIfNotExists())
            {

                EntityGeneratorFakerTyper<OGameCoordinate> coorGen = new EntityGeneratorFakerTyper<OGameCoordinate>();
                EntityGeneratorFakerTyper<OGameFleet> fleetGen = new EntityGeneratorFakerTyper<OGameFleet>();
                EntityGeneratorFakerTyper<OGamePlanet> planetGen = new EntityGeneratorFakerTyper<OGamePlanet>();
                EntityGeneratorFakerTyper<OGameResource> resGen = new EntityGeneratorFakerTyper<OGameResource>();
                EntityGeneratorFakerTyper<OGameSpaceShip> shipGen = new EntityGeneratorFakerTyper<OGameSpaceShip>();
                EntityGeneratorFakerTyper<OGameTypeBuilding> buildingGen = new EntityGeneratorFakerTyper<OGameTypeBuilding>();

                DatabaseManager<OGameCoordinate> coorDB = new DatabaseManager<OGameCoordinate>();
                DatabaseManager<OGameFleet> fleetDB = new DatabaseManager<OGameFleet>();
                DatabaseManager<OGamePlanet> planetDB = new DatabaseManager<OGamePlanet>();
                DatabaseManager<OGameResource> resDB = new DatabaseManager<OGameResource>();
                DatabaseManager<OGameSpaceShip> shipDB = new DatabaseManager<OGameSpaceShip>();
                DatabaseManager<OGameTypeBuilding> buildingDB = new DatabaseManager<OGameTypeBuilding>();

                List<OGameCoordinate> coorList = coorGen.GenerateListItems(10).ToList();
                List<OGameFleet> fleetList = fleetGen.GenerateListItems(1,1).ToList();
                List<OGamePlanet> planetList = planetGen.GenerateListItems(2,2).ToList();
                List<OGameSpaceShip> shipList = shipGen.GenerateListItems(10,10).ToList();
                List<OGameTypeBuilding> buildingList = buildingGen.GenerateListItems(5,5).ToList();

                //List<OGameResource> resList = new List<OGameResource>();
                //OGameResource res1 = new OGameResource();
                //res1.PlanetId = 1;
                //res1.Quantity = 1000;
                //res1.Type = "gold";

                //OGameResource res2 = new OGameResource();
                //res2.PlanetId = 1;
                //res2.Quantity = 4;
                //res2.Type = "bitcoin";

                //List<OGameResource> resList1 = new List<OGameResource>();
                //OGameResource res3 = new OGameResource();
                //res3.PlanetId = 2;
                //res3.Quantity = 200;
                //res3.Type = "gold";

                //OGameResource res4 = new OGameResource();
                //res4.PlanetId = 2;
                //res4.Quantity = 1;
                //res4.Type = "bitcoin";

                //resList.Add(res1); resList.Add(res2);
                //resList1.Add(res3); resList1.Add(res4);

                //fleetList[0].SpaceShips = shipList;


                foreach(var item in shipList)
                {
                    await shipDB.Insert(item);
                }

            }

        }
        #endregion

        #region Events

        #endregion


    }


}