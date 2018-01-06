using System;
using System.Collections.Generic;
using System.Text;

namespace KBL.ExceptionManager.Model.Exceptions
{
    public class CreateEntityException<T> : BaseException<T>
    {
        #region Fields
        #endregion

        #region Properties
        #endregion

        #region Cstors
        public CreateEntityException(string reason) : base(reason)
        {

        }

        public CreateEntityException() : base()
        { }
        #endregion

        #region Public methods
        #endregion

        #region Private methods
        #endregion
    }
}
    