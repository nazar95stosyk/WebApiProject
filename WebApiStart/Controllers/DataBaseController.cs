using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiStart.Business.Abstraction;
using WebApiStart.Business.Common;
using WebApiStart.Models;

namespace WebApiStart.Controllers
{
    public class DataBaseController : ApiController
    {
        private IItemsRepositoryService repository;

        public DataBaseController()
        {
            repository = new ItemsRepositoryService();
        }
        // GET: api/DataBase
        public IHttpActionResult Get()
        {
            return Ok(repository.Get());
        }

        // GET: api/DataBase/5
        public IHttpActionResult Get(string id)
        {
            return Ok(repository.Get(id));
        }

        // POST: api/DataBase
        public IHttpActionResult Post([FromBody]Item item)
        {
            var dbCreatedEntry = repository.Add(item);
            return Ok(dbCreatedEntry);
        }

        // PUT: api/DataBase/5
        public IHttpActionResult Put(string id, [FromBody]Item item)
        {
            var updatedDbEntry = repository.Update(id, item);
            return Ok(updatedDbEntry);
        }

        // DELETE: api/DataBase/5
        public IHttpActionResult Delete(string id)
        {
            var deletedItemId = repository.Remove(id);
            return Ok(deletedItemId);
        }
    }
}
