namespace TaskManager.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Periods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PeriodTime = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Start = c.DateTime(nullable: false),
                        From = c.String(),
                        To = c.String(),
                        IsDone = c.Boolean(nullable: false),
                        Period_Id = c.Int(),
                        TaskType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Periods", t => t.Period_Id)
                .ForeignKey("dbo.TaskTypes", t => t.TaskType_Id)
                .Index(t => t.Period_Id)
                .Index(t => t.TaskType_Id);
            
            CreateTable(
                "dbo.TaskTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "TaskType_Id", "dbo.TaskTypes");
            DropForeignKey("dbo.Tasks", "Period_Id", "dbo.Periods");
            DropIndex("dbo.Tasks", new[] { "TaskType_Id" });
            DropIndex("dbo.Tasks", new[] { "Period_Id" });
            DropTable("dbo.TaskTypes");
            DropTable("dbo.Tasks");
            DropTable("dbo.Periods");
        }
    }
}
