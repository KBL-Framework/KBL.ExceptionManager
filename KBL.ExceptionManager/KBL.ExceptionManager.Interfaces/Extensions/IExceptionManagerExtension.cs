using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace KBL.ExceptionManager.Interfaces.Extensions
{
    public interface IExceptionManagerExtension
    {
        IApplicationBuilder UseCustomExceptionManager(IApplicationBuilder builder);
    }
}
