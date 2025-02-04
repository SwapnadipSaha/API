namespace _2_FirstAppQuotesAPIWithDBEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuoteTypeDeleted : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Quotes", "type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Quotes", "type", c => c.String());
        }
    }
}
