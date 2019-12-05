using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiStart.Business.Abstraction;
using WebApiStart.Business.Common;

namespace WebApiStart.Controllers
{
    // ! Розібратись шо робить метод, звідси 
    public class ProductsController : ApiController
    {
        
        [HttpGet]
        public IHttpActionResult GetById(string id)
        {
            IExternalApiService serviceMock = new ExternalApiService();
            serviceMock.Get(id);
            return Ok();
        }
    }
}
