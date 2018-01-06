using System;
using System.Collections.Generic;
using System.Text;

namespace KBL.ExceptionManager.Model.Exceptions
{
    public class UpdateEntityException<T> : BaseException<T>
    {
        #region Fields
        #endregion

        #region Properties
        #endregion

        #region Cstors
        public UpdateEntityException(string reason) : base(reason)
        {

        }

        public UpdateEntityException() : base()
        { }
        #endregion

        #region Public methods
        #endregion

        #region Private methods
        #endregion
    }
}
