using System;
using System.Collections.Generic;
using System.Text;

namespace KBL.ExceptionManager.Model.Exceptions
{
    public class GetEntityException<T> : BaseException<T>
    {
        #region Fields
        #endregion

        #region Properties
        #endregion

        #region Cstors
        public GetEntityException(string reason) : base(reason)
        {

        }

        public GetEntityException() : base()
        { }
        #endregion

        #region Public methods
        #endregion

        #region Private methods
        #endregion  
    }
}
