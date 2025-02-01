using QuotesThreeAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotesThreeAPI.Data
{
    public class QuotesDbContext:DbContext
    //DbContext is an important class in Entity Framework API. It is a bridge between your domain or entity classes and the database.
    {
        public DbSet<Quote> Quotes { get; set; }  // The table Name
    }
}
