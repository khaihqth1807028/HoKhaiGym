namespace WebApplication15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        RollNumber = c.Int(nullable: false, identity: true),
                        Subject = c.Int(nullable: false),
                        StartTime = c.String(unicode: false),
                        ExamDateTime = c.DateTime(nullable: false, precision: 0),
                        Duration = c.Int(nullable: false),
                        Class = c.Int(nullable: false),
                        Faculty = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RollNumber);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Exams");
        }
    }
}
