namespace OnlineBankingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeSomeChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Administrators", "Username", c => c.String());
            AddColumn("dbo.BranchManagers", "Username", c => c.String(nullable: false));
            AddColumn("dbo.BranchManagers", "Password", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Password");
            DropColumn("dbo.BranchManagers", "Password");
            DropColumn("dbo.BranchManagers", "Username");
            DropColumn("dbo.Administrators", "Username");
        }
    }
}
