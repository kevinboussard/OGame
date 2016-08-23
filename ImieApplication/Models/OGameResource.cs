using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ImieApplication.Models
{


    /// <summary>
    /// Game resources to buy things.
    /// </summary>
    public class OGameResource : DBBaseClass
    {


        #region Constantes

        #endregion

        #region Attributs
            private String type;
            private int quantity;
        #endregion

        #region Conctructors
            /// <summary>
            /// Default constructor.
            /// </summary>
            public OGameResource() { }
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
            /// Resource type name.
            /// </summary>
            public String Type
            {
                get { return type; }
                set { type = value; }
            }

            /// <summary>
            /// Quantity of current resource.
            /// </summary>
            public int Quantity
            {
                get { return quantity; }
                set { quantity = value; }
            }
        #endregion

        #region Methods

        #endregion

        #region Events

        #endregion


    }
}