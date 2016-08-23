using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ImieApplication.Models
{

    /// <summary>
    /// Default class to create specialized space shit.
    /// </summary>
    public abstract class OGameSpaceShip : DBBaseClass
    {


        #region Constantes

        #endregion

        #region Attributs
            private String name;
            private int attack;
            private int defence;
            private int speed;
            private int bay;
            private int quantity;
            private int shipType;
        #endregion

        #region Conctructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public OGameSpaceShip(){}
        #endregion

        #region Properties
            /// <summary>
            /// Space Shit name.
            /// </summary>
            public String Name
            {
                get { return name; }
                set { name = value; }
            }

            /// <summary>
            /// Space shit attack.
            /// </summary>
            public int Attack
            {
                get { return attack; }
                set { attack = value; }
            }

            /// <summary>
            /// Space shit Defence.
            /// </summary>
            public int Defence
            {
                get { return defence; }
                set { defence = value; }
            }

            /// <summary>
            /// Space shit speed.
            /// </summary>
            public int Speed
            {
                get { return speed; }
                set { speed = value; }
            }

            /// <summary>
            /// Quantity of carriable resoucres allowed in a space shit.
            /// </summary>
            public int Bay
            {
                get { return bay; }
                set { bay = value; }
            }

            /// <summary>
            /// Space ship quantity
            /// </summary>
            public int Quantity
            {
                get { return quantity; }
                set { quantity = value; }
            }

            /// <summary>
            /// Allow to reconize the different ship type in DB.
            /// </summary>
            public int ShipType
            {
                get { return shipType; }
                set { shipType = value; }
            }

            /// <summary>
            /// Fleet Id.
            /// </summary>
            public int FleetId { get; set; }

            /// <summary>
            /// Reference OGameFleet for relation mapping.
            /// </summary>
            [ForeignKey("FleetId")]
            public OGameFleet Fleet { get; set; }
        #endregion

        #region Methods

        #endregion

        #region Events

        #endregion


    }


}