using KBL.ExceptionManager.Interfaces.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace KBL.ExceptionManager.Model.Exceptions
{
    public abstract class BaseGenericCustomException<T> : Exception, IGenericCustomException<T>
    {
        #region Fields
        protected static string _message = "";
        #endregion

        #region Properties
        public virtual HttpStatusCode HttpStatusCode { get; }

        public virtual string UserFriendlyMessage { get; }
        #endregion

        #region Cstors
        public BaseGenericCustomException() : base(_message)
        { }
        public BaseGenericCustomException(string reason) //: base(reason)
        {
            throw new NotImplementedException();
        }

        public BaseGenericCustomException(string message, string reason)
        {
            throw new NotImplementedException();
        }

        public BaseGenericCustomException(Exception innerException) : base(_message, innerException)
        { }

        public BaseGenericCustomException(string message, Exception innerException) : base(message, innerException)
        { }
        #endregion

        #region Public methods
        public HttpResponseMessage GetHttpMessage(HttpRequestMessage request)
        {
            return new HttpResponseMessage(this.HttpStatusCode) { ReasonPhrase = this.UserFriendlyMessage };
        }

        public virtual string GetJson()
        {
            Type t = typeof(T);
            return JsonConvert.SerializeObject(new { error = UserFriendlyMessage, entityType = t.Name });
        }
        #endregion

        #region Private methods
        #endregion

    }
}
