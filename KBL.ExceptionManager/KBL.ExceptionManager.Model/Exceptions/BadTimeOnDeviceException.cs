using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace KBL.ExceptionManager.Model.Exceptions
{
    public class BadTimeOnDeviceException<T> : BaseException<T>
    {
        #region Fields
        protected static new string _message = string.Format("Device date and time is different from server date and time.");
        protected string _userFriendlyMessage = string.Format("Na zařízení je nastaven odlišný čas od serverového času. Čas na serveru je {0}", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));
        #endregion

        #region Properties
        public override HttpStatusCode HttpStatusCode { get { return HttpStatusCode.ExpectationFailed; } }

        public override string UserFriendlyMessage
        {
            get
            {
                return _userFriendlyMessage;
            }
        }
        #endregion

        #region Cstors
        public BadTimeOnDeviceException() : base(_message)
        { }

        public BadTimeOnDeviceException(string dateTime) : base(string.Format("{0} You sended time is {1}.", _message, dateTime))
        { }
        #endregion

        #region Public methods
        #endregion

        #region Private methods
        #endregion
    }
}
