using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace KBL.ExceptionManager.Model.Exceptions
{
    public class IncorrectLoginException<T> : BaseException<T>
    {
        #region Fields
        protected static new string _message = "Inccorect login - bad username or password. Or both.";
        protected static string _userFriendlyMessage = "Neplatné přihlášení - špatně zadané jméno nebo heslo.";
        #endregion

        #region Properties
        public override HttpStatusCode HttpStatusCode { get { return HttpStatusCode.Unauthorized; } }

        public override string UserFriendlyMessage
        {
            get
            {
                return _userFriendlyMessage;
            }
        }
        #endregion

        #region Cstors
        public IncorrectLoginException() : base(_message)
        { }

        public IncorrectLoginException(string username) : base(string.Format("{0} Username is {1}.", _message, username))
        { }

        public IncorrectLoginException(Exception innerException) : base(_message, innerException)
        { }
        #endregion

        #region Public methods
        #endregion

        #region Private methods
        #endregion  
    }
}
