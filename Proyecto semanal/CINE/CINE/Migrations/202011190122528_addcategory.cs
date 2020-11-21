namespace CINE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcategory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripción = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Categoties");
        }
    }
}
