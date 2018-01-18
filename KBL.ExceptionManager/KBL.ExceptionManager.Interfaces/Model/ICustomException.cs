using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace KBL.ExceptionManager.Interfaces.Model
{
    public interface ICustomException
    {
        HttpStatusCode HttpStatusCode { get; }
        string UserFriendlyMessage { get; }
        string GetJson();
    }
}
