using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace KBL.ExceptionManager.Model.Exceptions
{
    public class MissingParameterException : BaseCustomException
    {
        #region Fields
        protected static new string _message = "Missing parameter for request!";
        protected static string _userFriendlyMessage = "Chybějící parametr v požadavku.";
        protected static string _parameterName = "";
        #endregion

        #region Properties
        public override HttpStatusCode HttpStatusCode { get { return HttpStatusCode.BadRequest; } }

        public override string UserFriendlyMessage
        {
            get
            {
                if (string.IsNullOrEmpty(_parameterName))
                {
                    return _userFriendlyMessage;
                }
                return string.Format("{0} Jméno parametru je {1}.", _userFriendlyMessage, _parameterName);
            }
        }
        #endregion

        #region Cstors
        public MissingParameterException() : base(_message)
        { }

        public MissingParameterException(string parameterName) : base(string.Format("{0} Parameter name: {1}", _message, parameterName))
        {
            _parameterName = parameterName;
        }

        public MissingParameterException(Exception innerException) : base(_message, innerException)
        { }
        #endregion

        #region Public methods
        #endregion

        #region Private methods
        #endregion
    }
}
