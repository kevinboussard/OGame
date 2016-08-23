using ImieApplication.Utils.Generator;
using ImieApplication.Utils.Generator.Attributs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ImieApplication.Models
{


    /// <summary>
    /// Define an user planet where landing building.
    /// </summary>
    public class OGamePlanet : DBBaseClass
    {


        #region Constantes

        #endregion

        #region Attributs
        private String name;
        private int slot;
        private String image;
        private OGameCoordinate coordinate;
        private List<OGameTypeBuilding> buildings;
        private List<OGameResource> resources;
        private OGameFleet fleet;
        #endregion

        #region Conctructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public OGamePlanet(){ }
        #endregion

        #region Properties
        /// <summary>
        /// Ovveride default DBBaseClass id to setup new properties.
        /// </summary>
        [Key, ForeignKey("Fleet")]
        public new int Id { get; set; }

        /// <summary>
        /// Define a name to the planet by the player.
        /// </summary>
        [FakerTyper(TypeEnumCustom.USERLASTNAME)]
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Define number of building for the planet.
        /// </summary>
        [FakerTyper(TypeEnumCustom.PLANET_SLOT)]
        public int Slot
        {
            get { return slot; }
            set { slot = value; }
        }

        /// <summary>
        /// Picture of current planet.
        /// </summary>
        public String Image
        {
            get { return image; }
            set { image = value; }
        }

        /// <summary>
        /// Coordinate Id.
        /// </summary>
        public int CoordinateId { get; set; }

        /// <summary>
        /// Planet coordinate.
        /// </summary>
        [ForeignKey("CoordinateId")]
        public OGameCoordinate Coordinate
        {
            get { return coordinate; }
            set { coordinate = value; }
        }

        /// <summary>
        /// List of Planet buildings.
        /// </summary>
        [InverseProperty("Planet")]
        public List<OGameTypeBuilding> Buildings
        {
            get { return buildings; }
            set { buildings = value; }
        }

        /// <summary>
        /// List og Planet resources.
        /// </summary>
        [InverseProperty("Planet")]
        public List<OGameResource> Resources
        {
            get { return resources; }
            set { resources = value; }
        }

        /// <summary>
        /// Planet fleet.
        /// </summary>
        public OGameFleet Fleet
        {
            get { return fleet; }
            set { fleet = value; }
        }
        #endregion

        #region Methods

        #endregion

        #region Events

        #endregion


    }


}