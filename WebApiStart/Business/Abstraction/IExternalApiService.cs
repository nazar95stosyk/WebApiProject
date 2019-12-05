using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiStart.Business.Abstraction
{
    public interface IExternalApiService
    {
        void Get(string id);
    }
}
