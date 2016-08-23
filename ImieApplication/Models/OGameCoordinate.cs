﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImieApplication.Models
{


    /// <summary>
    /// Define position of an element in our univers.
    /// </summary>
    public class OGameCoordinate : DBBaseClass
    {


        #region Constantes

        #endregion

        #region Attributs
            private int x;
            private int y;
        #endregion

        #region Conctructors
            /// <summary>
            /// Default constructor.
            /// </summary>
            public OGameCoordinate(){ }
        #endregion

        #region Properties
            /// <summary>
            /// X coordinate.
            /// </summary>
            public int X
            {
                get { return x; }
                set { x = value; }
            }

            /// <summary>
            /// Y coordinate.
            /// </summary>
            public int Y
            {
                get { return y; }
                set { y = value; }
            }
        #endregion

        #region Methods

        #endregion

        #region Events

        #endregion


    }


}