using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiStart.Business.Abstraction;

namespace WebApiStart.Business.Common
{
    public class JsonParser : IParser
    {
        public TRes Parse<TRes, TArgs>(string stringObj, TArgs unknownArgument) where TArgs : class
        {
            throw new NotImplementedException();
        }
    }
}