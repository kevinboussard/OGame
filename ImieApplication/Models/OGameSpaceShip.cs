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
    /// Default class to create specialized space shit.
    /// </summary>
    public class OGameSpaceShip : DBBaseClass
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
        [FakerTyper(TypeEnumCustom.USERFIRSTNAME)]
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Space shit attack.
        /// </summary>
        [FakerTyper(TypeEnumCustom.SHIP_QUANTITY)]
        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }

        /// <summary>
        /// Space shit Defence.
        /// </summary>
        [FakerTyper(TypeEnumCustom.SHIP_QUANTITY)]
        public int Defence
        {
            get { return defence; }
            set { defence = value; }
        }

        /// <summary>
        /// Space shit speed.
        /// </summary>
        [FakerTyper(TypeEnumCustom.SHIP_QUANTITY)]
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        /// <summary>
        /// Quantity of carriable resoucres allowed in a space shit.
        /// </summary>
        [FakerTyper(TypeEnumCustom.SHIP_QUANTITY)]
        public int Bay
        {
            get { return bay; }
            set { bay = value; }
        }

        /// <summary>
        /// Space ship quantity
        /// </summary>
        [FakerTyper(TypeEnumCustom.SHIP_QUANTITY)]
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        /// <summary>
        /// Allow to reconize the different ship type in DB.
        /// </summary>
        [FakerTyper(TypeEnumCustom.SHIP_TYPE)]
        public int ShipType
        {
            get { return shipType; }
            set { shipType = value; }
        }

        #endregion

        #region Methods

        #endregion

        #region Events

        #endregion


    }


}