using KBL.ExceptionManager.Interfaces.Middleware;
using KBL.ExceptionManager.Interfaces.Model;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using NLog;
using System;
using System.Net;
using System.Threading.Tasks;

namespace KBL.ExceptionManager.Base.Middleware
{
    public class JsonExceptionManagerMiddleware : IExceptionManagerMiddleware
    {
        #region Fields
        private readonly RequestDelegate next;
        private static readonly ILogger _logger = LogManager.GetCurrentClassLogger();

        #endregion

        #region Properties
        #endregion

        #region Cstors
        public JsonExceptionManagerMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        #endregion

        #region Public methods
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            _logger.Error(exception, "ExceptionManagerMiddleware catch ");
            var code = HttpStatusCode.InternalServerError; // 500 if unexpected
            var message = JsonConvert.SerializeObject(new { error = exception.Message });

            if (exception is ICustomException)
            {
                code = (exception as ICustomException).HttpStatusCode;
                message = (exception as ICustomException).GetJson();
            }
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;
            return context.Response.WriteAsync(message);
        }

        #endregion

        #region Private methods
        #endregion
    }
}
