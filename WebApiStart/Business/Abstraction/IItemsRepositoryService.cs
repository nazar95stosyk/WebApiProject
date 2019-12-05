using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiStart.Models;

namespace WebApiStart.Business.Abstraction
{
    public interface IItemsRepositoryService
    {
        IEnumerable<Item> Get();
        Item Get(string id);
        void AddRange(IEnumerable<Item> items);
        Item Add(Item item);
        Item Update(string itemId, Item newItem);
        string Remove(string id);
    }
}