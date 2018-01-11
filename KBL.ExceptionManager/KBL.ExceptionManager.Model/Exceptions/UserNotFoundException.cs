using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace KBL.ExceptionManager.Model.Exceptions
{
    public class UserNotFoundException : BaseCustomException
    {
        #region Fields
        protected string _username;
        protected static new string _message = "User not found in database of appliaction.";
        protected string _userFriendlyMessage = "Uživatel nebyl nalezen v databázi aplikace.";
        #endregion

        #region Properties
        public override HttpStatusCode HttpStatusCode { get { return HttpStatusCode.Forbidden; } }
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
        public UserNotFoundException() : base(_message)
        { }

        public UserNotFoundException(string username) : base(string.Format("{0} {1}", _message, username))
        {
            _username = username;
        }
        #endregion

        #region Public methods
        #endregion

        #region Private methods
        #endregion
    }
}
