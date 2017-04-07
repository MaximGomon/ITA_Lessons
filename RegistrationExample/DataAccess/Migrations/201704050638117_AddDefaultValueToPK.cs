namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDefaultValueToPK : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "Role_Id", "dbo.Roles");
            DropPrimaryKey("dbo.Roles");
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Roles", "Id", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.Users", "Id", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.Roles", "Id");
            AddPrimaryKey("dbo.Users", "Id");
            AddForeignKey("dbo.Users", "Role_Id", "dbo.Roles", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Role_Id", "dbo.Roles");
            DropPrimaryKey("dbo.Users");
            DropPrimaryKey("dbo.Roles");
            AlterColumn("dbo.Users", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.Roles", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Users", "Id");
            AddPrimaryKey("dbo.Roles", "Id");
            AddForeignKey("dbo.Users", "Role_Id", "dbo.Roles", "Id", cascadeDelete: true);
        }
    }
}
