using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuotesTwoAPI.Data;
using QuotesTwoAPI.Models;

namespace QuotesTwoAPI.Controllers
{
    public class QuotesTwoController : ApiController
    {
         
        QuotesDbContext _quotesDbContext = new QuotesDbContext();
        // GET: api/QuotesTwo
        public IEnumerable<Quote> Get()
        {
            //This Get method will return all the contents from the DB
            return _quotesDbContext.Quotes;
        }

        // GET: api/QuotesTwo/5
        public Quote Get(int id)
        {
           var quote= _quotesDbContext.Quotes.Find(id);
            //Find(id) method will pick the specific quote from the database against the Id
            return quote;
        }

        // POST: api/QuotesTwo
        public void Post([FromBody] Quote quote)
        {
            _quotesDbContext.Quotes.Add(quote);
            _quotesDbContext.SaveChanges();
        }

        // PUT: api/QuotesTwo/5
        public void Put(int id, [FromBody] Quote quote)
        {
            var entity = _quotesDbContext.Quotes.FirstOrDefault(q => quote.Id==id);
            entity.Title = quote.Title;
            entity.Author = quote.Author;
            entity.Description = quote.Description;
            _quotesDbContext.SaveChanges();
        }

        // DELETE: api/QuotesTwo/5
        public void Delete(int id)
        {
            var quote =_quotesDbContext.Quotes.Find(id);           
            _quotesDbContext.Quotes.Remove(quote);
            _quotesDbContext.SaveChanges();
        }
    }
}
