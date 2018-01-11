using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace KBL.ExceptionManager.Model.Exceptions
{
    public class NoUserRoleException : BaseCustomException
    {
        #region Fields
        protected static new string _message = "No user role added for user.";
        protected static string _userFriendlyMessage = "Uživatel nemá přiřazenou požadovanou roli pro aplikaci.";
        protected string _username = "";
        #endregion

        #region Properties
        public override HttpStatusCode HttpStatusCode { get { return HttpStatusCode.Unauthorized; } }

        public override string UserFriendlyMessage
        {
            get
            {
                if (string.IsNullOrEmpty(_username))
                {
                    return _userFriendlyMessage;
                }
                return string.Format("{0} Jméno uživatele je {1}.", _userFriendlyMessage, _username);
            }
        }
        #endregion

        #region Cstors
        public NoUserRoleException() : base(_message)
        { }

        public NoUserRoleException(string username) : base(string.Format("{0} Username is {1}.", _message, username))
        {
            _username = username;
        }

        public NoUserRoleException(string username, Exception innerException) : base(string.Format("{0} Username is {1}.", _message, username), innerException)
        { }
        #endregion

        #region Public methods
        #endregion

        #region Private methods
        #endregion
    }
}
