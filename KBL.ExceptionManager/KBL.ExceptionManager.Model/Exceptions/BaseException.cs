using KBL.ExceptionManager.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace KBL.ExceptionManager.Model.Exceptions
{
    public abstract class BaseException<T> : Exception, ICustomException<T>
    {
        #region Fields
        protected static string _message = "";
        #endregion

        #region Properties
        public virtual HttpStatusCode HttpStatusCode { get; }

        public virtual string UserFriendlyMessage { get; }
        #endregion

        #region Cstors
        public BaseException() : base(_message)
        { }
        public BaseException(string reason) //: base(reason)
        {
            throw new NotImplementedException();
        }

        public BaseException(string message, string reason)
        {
            throw new NotImplementedException();
        }

        public BaseException(Exception innerException) : base(_message, innerException)
        { }

        public BaseException(string message, Exception innerException) : base(message, innerException)
        { }
        #endregion

        #region Public methods
        public HttpResponseMessage GetHttpMessage(HttpRequestMessage request)
        {
            return new HttpResponseMessage(this.HttpStatusCode) { ReasonPhrase = this.UserFriendlyMessage };
        }
        #endregion

        #region Private methods
        #endregion

    }
}
