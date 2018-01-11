using KBL.ExceptionManager.Interfaces.Model;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace KBL.ExceptionManager.Model.Exceptions
{
    public abstract class BaseCustomException : Exception, ICustomException
    {
        #region Fields
        protected static string _message = "";
        #endregion

        #region Properties
        public virtual HttpStatusCode HttpStatusCode { get; }

        public virtual string UserFriendlyMessage { get; }
        #endregion

        #region Cstors
        public BaseCustomException() : base(_message)
        { }
        public BaseCustomException(string reason) : base($"Message: {_message} \n Reason: {reason}")
        {
        }

        public BaseCustomException(string message, string reason) : base($"Message: {_message} \n CustomMessage: {message} \n Reason: {reason}")
        {
        }

        public BaseCustomException(Exception innerException) : base(_message, innerException)
        { }

        public BaseCustomException(string message, Exception innerException) : base($"Message: {_message} \n CustomMessage: {message}", innerException)
        { }
        #endregion

        #region Public methods
        public HttpResponseMessage GetHttpMessage(HttpRequestMessage request)
        {
            return new HttpResponseMessage(this.HttpStatusCode) { ReasonPhrase = this.UserFriendlyMessage };
        }

        public virtual string GetJson()
        {
            return JsonConvert.SerializeObject(new { error = UserFriendlyMessage });
        }
        #endregion

        #region Private methods
        #endregion
    }
}
