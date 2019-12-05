using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using WebApiStart.Business.Abstraction;
using WebApiStart.Models;

namespace WebApiStart.Business.Common
{
    public class ExternalApiService : IExternalApiService
    {
        public void Get(string id)  
        {
            var client = new RestClient("https://api.github.com");
            var requ = new RestRequest("search/repositories?q=" + id, Method.GET);
            var responseString = client.Execute(requ).Content;


            //IParser parser = new JsonParser();
            //var parsedResult = parser.Parse<ReposStatItems<Item,dynamic>>(responseString);    //Реалізувати метод, T буде рутовий об'єк джейсонки(Самий батьківський,корінь)  (файл TmpJson класс ReposStatItems)

            //var items = parsedResult.Getitems();

            //IItemsRepositoryService repService = new ItemsRepositoryService() .... 

            //repService.AddRange(items);   // -- Зберегти в бд
            //return items; Вернути результат
        }
    }
}