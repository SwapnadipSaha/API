namespace _2_FirstAppQuotesAPIWithDBEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuoteCreatedDateAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Quotes", "CreatedAt", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Quotes", "CreatedAt");
        }
    }
}
