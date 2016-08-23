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
    /// Define base building functionnalities.
    /// </summary>
    public class OGameTypeBuilding : DBBaseClass
    {


        #region Constantes

        #endregion

        #region Attributs
        private String name;
        private int level;
        private int buildingType;
        #endregion

        #region Conctructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public OGameTypeBuilding(){}
        #endregion

        #region Properties
        /// <summary>
        /// PLanet Id.
        /// </summary>
        public int PlanetId { get; set; }

        /// <summary>
        /// Reference OGamePlanet for relation mapping.
        /// </summary>
        [ForeignKey("PlanetId")]
        public OGamePlanet Planet { get; set; }

        /// <summary>
        /// Reference building identity.
        /// </summary>
        [FakerTyper(TypeEnumCustom.LOREUMONEWORD)]
        public String Name
            {
                get { return name; }
                set { name = value; }
            }

        /// <summary>
        /// Define current building level.
        /// </summary>
        [FakerTyper(TypeEnumCustom.LEVEL)]
        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        /// <summary>
        /// Allow to reconize the different building type in DB.
        /// </summary>
        [FakerTyper(TypeEnumCustom.BUILDING_TYPE)]
        public int BuildingType
        {
            get { return buildingType; }
            set { buildingType = value; }
        }
        #endregion

        #region Methods

        #endregion

        #region Events

        #endregion


    }


}