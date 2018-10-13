namespace Services.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Servicetypeadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Servicetypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Servicekind = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Services", "servicetype_Id", c => c.Int());
            CreateIndex("dbo.Services", "servicetype_Id");
            AddForeignKey("dbo.Services", "servicetype_Id", "dbo.Servicetypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Services", "servicetype_Id", "dbo.Servicetypes");
            DropIndex("dbo.Services", new[] { "servicetype_Id" });
            DropColumn("dbo.Services", "servicetype_Id");
            DropTable("dbo.Servicetypes");
        }
    }
}
