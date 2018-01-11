using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace KBL.ExceptionManager.Model.Exceptions
{
    public class InternalServerException<T> : BaseException<T>
    {
        #region Fields
        protected static new string _message = "Exception in application. More info in inner exception.";
        protected static string _userFriendlyMessage = "V aplikaci došlo k nepovolenému stavu. Při opakování problémů kontaktujte správce aplikace.";
        #endregion

        #region Properties
        public override HttpStatusCode HttpStatusCode { get { return HttpStatusCode.InternalServerError; } }

        public override string UserFriendlyMessage
        {
            get
            {
                return _userFriendlyMessage;
            }
        }
        #endregion

        #region Cstors
        public InternalServerException() : base(_message)
        { }

        public InternalServerException(string message) : base(string.Format("{0} More info: {1}", _message, message))
        { }

        public InternalServerException(Exception innerException) : base(_message, innerException)
        { }
        #endregion

        #region Public methods
        #endregion

        #region Private methods
        #endregion
    }
}
