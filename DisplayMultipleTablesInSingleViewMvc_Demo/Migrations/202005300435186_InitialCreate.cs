namespace DisplayMultipleTablesInSingleViewMvc_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Position = c.String(nullable: false, maxLength: 100),
                        Office = c.String(nullable: false, maxLength: 100),
                        Age = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        Salary = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        IncentiveId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Incentives", t => t.IncentiveId, cascadeDelete: true)
                .Index(t => t.DepartmentId)
                .Index(t => t.IncentiveId);
            
            CreateTable(
                "dbo.Incentives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IncentiveAmount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "IncentiveId", "dbo.Incentives");
            DropForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "IncentiveId" });
            DropIndex("dbo.Employees", new[] { "DepartmentId" });
            DropTable("dbo.Incentives");
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
