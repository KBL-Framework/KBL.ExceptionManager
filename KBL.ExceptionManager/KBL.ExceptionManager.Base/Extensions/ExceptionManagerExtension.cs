using KBL.ExceptionManager.Base.Middleware;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace KBL.ExceptionManager.Base.Extensions
{
    public static class ExceptionManagerExtensions
    {
        public static IApplicationBuilder UseKBLExceptionManagerJson(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<JsonExceptionManagerMiddleware>();
        }

        public static IApplicationBuilder UseKBLExceptionManagerHtml(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HtmlExceptionManagerMiddleware>();
        }
    }
}
