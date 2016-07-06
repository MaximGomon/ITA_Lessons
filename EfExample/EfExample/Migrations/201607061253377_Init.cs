namespace EfExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Code = c.Int(nullable: false),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        Salary = c.Double(nullable: false),
                        BirthDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Department_Id = c.Guid(nullable: false),
                        Manager_Id = c.Guid(),
                        Position_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.Manager_Id)
                .ForeignKey("dbo.Positions", t => t.Position_Id, cascadeDelete: true)
                .Index(t => t.Department_Id)
                .Index(t => t.Manager_Id)
                .Index(t => t.Position_Id);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Code = c.Int(nullable: false),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Code, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Position_Id", "dbo.Positions");
            DropForeignKey("dbo.Employees", "Manager_Id", "dbo.Employees");
            DropForeignKey("dbo.Employees", "Department_Id", "dbo.Departments");
            DropIndex("dbo.Positions", new[] { "Code" });
            DropIndex("dbo.Employees", new[] { "Position_Id" });
            DropIndex("dbo.Employees", new[] { "Manager_Id" });
            DropIndex("dbo.Employees", new[] { "Department_Id" });
            DropIndex("dbo.Departments", new[] { "Code" });
            DropTable("dbo.Positions");
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
