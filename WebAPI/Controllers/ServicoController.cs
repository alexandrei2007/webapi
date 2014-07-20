using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Framework;

namespace WebAPI.Controllers
{
    public class ServicoController : ApiController
    {
        [HttpGet]
        [AllowAnonymous]
        public IEnumerable<Item> Rodar()
        {
            List<Item> itens = new List<Item>();

            itens.Add(new Item() { NewValue = "Value Novo", OldValue = "Value Antigo" });
            itens.Add(new Item() { NewValue = "A", OldValue = "B" });

            return itens;
        }

        // must use fiddler for test (china:123)
        // Authorization: Basic Y2hpbmE6MTIz
        [HttpGet]
        public string Logado()
        {
            return "OK";
        }
    }

    public class Item
    {

        public string OldValue { get; set; }
        public string NewValue { get; set; }

    }
}
