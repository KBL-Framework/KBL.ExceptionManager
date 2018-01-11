using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace KBL.ExceptionManager.Model.Exceptions
{
    public class DifferentClientVersionException : AbstractCustomException
    {
        #region Fields
        protected static new string _message = "Your application has too old version. You have to update the client application to the latest version.";
        protected static string _userFriendlyMessage = "Vaše aplikace je zastaralá a nelze se s ní připojit. Prosím aktualizujte na novou verzi.";
        protected static string _actualVersion = "";
        protected static string _downloadUrl = "";
        #endregion

        #region Properties
        public override HttpStatusCode HttpStatusCode { get { return HttpStatusCode.Forbidden; } }

        public override string UserFriendlyMessage
        {
            get
            {
                if (string.IsNullOrEmpty(_actualVersion))
                {
                    return _userFriendlyMessage;
                }
                return string.Format("{0} Aktuální verze je: {1}", _userFriendlyMessage, _actualVersion);
            }
        }

        public string ActualVersion { get { return _actualVersion; } }
        public string DownloadUrl { get { return _downloadUrl; } }
        #endregion

        #region Cstors
        public DifferentClientVersionException() : base(_message)
        { }

        public DifferentClientVersionException(string actualVersion) : base(string.Format("{0} Latest version is {1}", _message, actualVersion))
        {
            _actualVersion = actualVersion;
        }

        public DifferentClientVersionException(string actualVersion, string downloadUrl) : base(string.Format("{0} Latest version is {1}.\n", _message, actualVersion))
        {
            _actualVersion = actualVersion;
            _downloadUrl = downloadUrl;
        }

        public DifferentClientVersionException(Exception innerException) : base(_message, innerException)
        { }
        #endregion

        #region Public methods
        #endregion

        #region Private methods
        #endregion
    }
}
