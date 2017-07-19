namespace TheResistance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removelink : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Posts", "Link");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "Link", c => c.String());
        }
    }
}
