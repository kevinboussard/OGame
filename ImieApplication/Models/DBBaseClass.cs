using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImieApplication.Models
{


    /// <summary>
    /// Manage id for item DB relations.
    /// </summary>
    public abstract class DBBaseClass
    {


        #region Constantes

        #endregion

        #region Attributs
            private int id;
        #endregion

        #region Conctructors
            /// <summary>
            /// Default constructor.
            /// </summary>
            public DBBaseClass() { }
        #endregion

        #region Properties
            /// <summary>
            /// DB id.
            /// </summary>
            [Key]
            public int Id
            {
                get { return id; }
                set { id = value; }
            }
        #endregion

        #region Methods

        #endregion

        #region Events

        #endregion


    }


}