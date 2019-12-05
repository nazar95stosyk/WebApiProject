using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiStart.Business.Abstraction;
using WebApiStart.Models;

namespace WebApiStart.Business.Common
{

    // ! Стоворити БД з Entity Framework, імплементнути репозиторій
   
    public class ItemsRepositoryService : IItemsRepositoryService
    {
        public Item Add(Item item)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Item> items)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> Get()
        {
            throw new NotImplementedException();
        }

        public Item Get(string id)
        {
            throw new NotImplementedException();
        }

        public string Remove(string id)
        {
            throw new NotImplementedException();
        }

        public Item Update(string itemId, Item newItem)
        {
            throw new NotImplementedException();
        }
    }
}