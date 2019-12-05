using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiStart.Business.Abstraction
{
    public interface IParser
    {
        // Generic`s
        // Constranits
        TRes Parse<TRes, TArgs>(string stringObj, TArgs unknownArgument)  where TArgs: class;
    }
}