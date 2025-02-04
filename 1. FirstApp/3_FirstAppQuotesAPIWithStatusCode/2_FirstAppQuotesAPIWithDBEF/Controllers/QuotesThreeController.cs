using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuotesThreeAPI.Data;
using QuotesThreeAPI.Models;

namespace QuotesThreeAPI.Controllers
{
    public class QuotesThreeController : ApiController
    {
         
        QuotesDbContext _quotesDbContext = new QuotesDbContext();
        // GET: api/QuotesThree
        public IHttpActionResult Get()
        {
            //This Get method will return all the contents from the DB
            var quote = _quotesDbContext.Quotes;
            return Ok(quote);
        } 

        // GET: api/QuotesThree/5
        public IHttpActionResult Get(int id)
        {
           var quote= _quotesDbContext.Quotes.Find(id);
            //Find(id) method will pick the specific quote from the database against the Id
            if (quote == null)
            {
                return NotFound();
            }
            else
                return Ok(quote);
        }

        // POST: api/QuotesThree
        public IHttpActionResult Post([FromBody] Quote quote)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _quotesDbContext.Quotes.Add(quote);
            _quotesDbContext.SaveChanges();
            return StatusCode(HttpStatusCode.Created);
        }

        // PUT: api/QuotesThree/5
        public IHttpActionResult Put(int id, [FromBody] Quote quote)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var entity = _quotesDbContext.Quotes.FirstOrDefault(q => quote.Id == id);
            if (entity == null)
            {
                // return StatusCode(HttpStatusCode.BadRequest);
                //or
                return BadRequest("ID not found");
            }
            else { 
            entity.Title = quote.Title;
            entity.Author = quote.Author;
            entity.Description = quote.Description;
            _quotesDbContext.SaveChanges();
                // return StatusCode(HttpStatusCode.Accepted);
                //or
                return Ok("ID Updated!");
            }
        }

        // DELETE: api/QuotesThree/5
        public IHttpActionResult Delete(int id)
        {
            var quote =_quotesDbContext.Quotes.Find(id);
            if (quote == null)
            {
                // return StatusCode(HttpStatusCode.BadRequest);
                //or
                return BadRequest("ID not found");
            }
            else
            {
                _quotesDbContext.Quotes.Remove(quote);
                _quotesDbContext.SaveChanges();
                //return StatusCode(HttpStatusCode.OK);
                //or
                return Ok("ID Deleted!");
            }
        }
    }
}
