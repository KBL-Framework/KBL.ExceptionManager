using System;
using System.Collections.Generic;
using System.Text;

namespace KBL.ExceptionManager.Model.Exceptions
{
    public class DeleteEntityException<T> : BaseGenericCustomException<T>
    {
        #region Fields
        #endregion

        #region Properties
        #endregion

        #region Cstors
        public DeleteEntityException(string reason) : base(reason)
        {

        }

        public DeleteEntityException() : base()
        { }
        #endregion

        #region Public methods
        #endregion

        #region Private methods
        #endregion 
    }
}
