﻿namespace _2_FirstAppQuotesAPIWithDBEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuoteTypeAddedAgainAgain : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Quotes", "type", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Quotes", "type");
        }
    }
}
