using KBL.ExceptionManager.Base.Extensions;
using KBL.ExceptionManager.Interfaces.Middleware;
using KBL.ExceptionManager.Interfaces.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KBL.ExceptionManager.Base.Middleware
{
    public class HtmlExceptionManagerMiddleware : IExceptionManagerMiddleware
    {
        //#region Fields
        //private readonly RequestDelegate next;
        //private static readonly NLog.ILogger _logger = LogManager.GetCurrentClassLogger();

        //#endregion

        //#region Properties
        //#endregion

        //#region Cstors
        //public HtmlExceptionManagerMiddleware(RequestDelegate next)
        //{
        //    this.next = next;
        //}

        //#endregion

        //#region Public methods
        //public async Task Invoke(HttpContext context /* other scoped dependencies */)
        //{
        //    try
        //    {
        //        await next(context);
        //    }
        //    catch (Exception ex)
        //    {
        //        await HandleExceptionAsync(context, ex);
        //    }
        //}

        //private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        //{
        //    // log exception
        //    _logger.Error(exception, "ExceptionManagerMiddleware catch ");
        //    var code = HttpStatusCode.InternalServerError; // 500 if unexpected
        //    var message = "An error occurred. Please try again your action.";
            
        //    if (exception is ICustomException)
        //    {
        //        code = (exception as ICustomException).HttpStatusCode;
        //        message = (exception as ICustomException).UserFriendlyMessage;
        //    }

        //    context.Session.Set("exceptionManagerMessage", message.ToCharArray().byte);
        //    return;
        //    //return next(context);
        //}

        //#endregion

        //#region Private methods
        //#endregion  
    }
}
