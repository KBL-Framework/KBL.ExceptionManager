using KBL.ExceptionManager.Base.Middleware;
using Microsoft.AspNetCore.Builder;
using System;

namespace KBL.ExceptionManager.Base.Extensions
{
    public static class ExceptionManagerExtensions
    {
        public static IApplicationBuilder UseKBLExceptionManagerJson(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<JsonExceptionManagerMiddleware>();
        }

        [Obsolete("Method1 is deprecated. This method will be removed")]
        public static IApplicationBuilder UseKBLExceptionManagerHtml(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HtmlExceptionManagerMiddleware>();
        }
    }
}
