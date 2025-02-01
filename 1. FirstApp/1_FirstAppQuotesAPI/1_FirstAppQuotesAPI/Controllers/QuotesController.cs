using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuotesAPI.Models;

namespace QuotesAPI.Controllers
{
    public class QuotesController : ApiController
    {
        static List<Quote> _quote = new List<Quote>
        {
            new Quote(){Id=0,Author="Swapnadip Saha", Title="Life",Description="Life Zandwa, Zindagi Ghamandwa" },
            new Quote(){Id=1,Author="Unknown Public", Title="Not Life",Description="Be serious"  }
        };


        public IEnumerable<Quote> Get()
        {
            return _quote;
        }

        public void Post([FromBody]Quote quote)
        {
            _quote.Add(quote);
        }

        public void Put(int id,[FromBody] Quote quote)
        {
            _quote[id]=quote;
        }

        public void Delete(int id)
        {
            _quote.RemoveAt(id);
        }
    }
}
