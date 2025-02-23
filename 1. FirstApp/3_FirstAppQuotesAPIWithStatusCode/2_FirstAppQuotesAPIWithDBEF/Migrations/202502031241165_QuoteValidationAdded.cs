﻿namespace _2_FirstAppQuotesAPIWithDBEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuoteValidationAdded : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Quotes", "Title", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Quotes", "Author", c => c.String(nullable: false));
            AlterColumn("dbo.Quotes", "Description", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Quotes", "type", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Quotes", "type", c => c.String());
            AlterColumn("dbo.Quotes", "Description", c => c.String());
            AlterColumn("dbo.Quotes", "Author", c => c.String());
            AlterColumn("dbo.Quotes", "Title", c => c.String());
        }
    }
}
