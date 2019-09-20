namespace OnlineBankingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RegistrationAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BranchInformations", "BranchCode", c => c.String(nullable: false));
            AddColumn("dbo.BranchInformations", "State", c => c.String(nullable: false));
            AddColumn("dbo.BranchInformations", "City", c => c.String(nullable: false));
            AddColumn("dbo.BranchInformations", "PinCode", c => c.String(nullable: false));
            AddColumn("dbo.BranchInformations", "IFSCode", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "Email", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "PhoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "LastName", c => c.String(nullable: false));
            DropColumn("dbo.BranchInformations", "Address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BranchInformations", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "LastName", c => c.String());
            AlterColumn("dbo.Customers", "FirstName", c => c.String());
            DropColumn("dbo.Customers", "PhoneNumber");
            DropColumn("dbo.Customers", "Email");
            DropColumn("dbo.BranchInformations", "IFSCode");
            DropColumn("dbo.BranchInformations", "PinCode");
            DropColumn("dbo.BranchInformations", "City");
            DropColumn("dbo.BranchInformations", "State");
            DropColumn("dbo.BranchInformations", "BranchCode");
        }
    }
}
