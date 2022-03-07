namespace Matrimonial_Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class forgot : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.forgots",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Uid = c.String(),
                        Email = c.String(),
                        ReqDateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.forgots");
        }
    }
}
