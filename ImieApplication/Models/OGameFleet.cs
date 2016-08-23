using ImieApplication.Utils.Generator;
using ImieApplication.Utils.Generator.Attributs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ImieApplication.Models
{


    /// <summary>
    /// Define a fleet landing on a planet or traveling to a planet.
    /// </summary>
    public class OGameFleet : DBBaseClass
    {


        #region Constantes

        #endregion

        #region Attributs
        private String name;
        private DateTime landingAt;
        private OGamePlanet destination;
        #endregion

        #region Conctructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public OGameFleet() { }
        #endregion

        #region Properties
        /// <summary>
        /// Fleet name.
        /// </summary>
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Define when fleet arrive to new planet.
        /// </summary>
        [FakerTyper(TypeEnumCustom.DATETIME)]
        public DateTime LandingAt
        {
            get { return landingAt; }
            set { landingAt = value; }
        }

        /// <summary>
        /// Planet Id.
        /// </summary>
        [Column("DestinationId")]
        public int? DestinationId { get; set; }

        /// <summary>
        /// Destination of the fleet.
        /// </summary>
        [ForeignKey("DestinationId")]
        public OGamePlanet Destination
        {
            get { return destination; }
            set { destination = value; }
        }
        #endregion

        #region Methods

        #endregion

        #region Events

        #endregion


    }


}