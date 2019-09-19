namespace OnlineBankingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Beneficiaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BeneficiaryName = c.String(nullable: false),
                        BeneficiaryAccountNo = c.String(nullable: false),
                        BeneficiaryBankName = c.String(nullable: false),
                        BeneficiaryIFSCode = c.String(nullable: false),
                        TransferLimit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BranchInformations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AccountDetails", "AccountStatus", c => c.String(nullable: false));
            AddColumn("dbo.Administrators", "password", c => c.String(nullable: false));
            AddColumn("dbo.Administrators", "BranchManager_Id", c => c.Int());
            AddColumn("dbo.BranchManagers", "Name", c => c.String(nullable: false));
            AddColumn("dbo.BranchManagers", "Address", c => c.String(nullable: false));
            AddColumn("dbo.BranchManagers", "PhoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.AccountDetails", "CIFNumber", c => c.String(nullable: false));
            AlterColumn("dbo.AccountDetails", "BranchCode", c => c.String(nullable: false));
            CreateIndex("dbo.Administrators", "BranchManager_Id");
            AddForeignKey("dbo.Administrators", "BranchManager_Id", "dbo.BranchManagers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Administrators", "BranchManager_Id", "dbo.BranchManagers");
            DropIndex("dbo.Administrators", new[] { "BranchManager_Id" });
            AlterColumn("dbo.AccountDetails", "BranchCode", c => c.String());
            AlterColumn("dbo.AccountDetails", "CIFNumber", c => c.String());
            DropColumn("dbo.BranchManagers", "PhoneNumber");
            DropColumn("dbo.BranchManagers", "Address");
            DropColumn("dbo.BranchManagers", "Name");
            DropColumn("dbo.Administrators", "BranchManager_Id");
            DropColumn("dbo.Administrators", "password");
            DropColumn("dbo.AccountDetails", "AccountStatus");
            DropTable("dbo.BranchInformations");
            DropTable("dbo.Beneficiaries");
        }
    }
}
