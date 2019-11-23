namespace StudentTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "AName", c => c.String());
            AddColumn("dbo.Student", "BirthDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Student", "GradeID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Student", "GradeID");
            DropColumn("dbo.Student", "BirthDate");
            DropColumn("dbo.Student", "AName");
        }
    }
}
