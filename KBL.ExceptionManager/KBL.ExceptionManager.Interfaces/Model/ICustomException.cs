using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace KBL.ExceptionManager.Interfaces.Model
{
    public interface ICustomException<T> //where T : IEntity
    {
        HttpStatusCode HttpStatusCode { get; }
        string UserFriendlyMessage { get; }
    }
}
