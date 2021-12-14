namespace GUI_Group_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fifth : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Employers");
            CreateTable(
                "dbo.djs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Customer_Id = c.Int(nullable: false),
                        No_of_hours = c.String(),
                        Meal = c.String(),
                        otherfac = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.hallres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Customer_Id = c.Int(nullable: false),
                        Type = c.String(),
                        Size = c.String(),
                        Floor = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Meetings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Customer_Id = c.Int(nullable: false),
                        No_of_hours = c.String(),
                        Meal = c.String(),
                        no_of_seats = c.String(),
                        otherfac = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.roomres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Customer_Id = c.Int(nullable: false),
                        AC_NONAC = c.String(),
                        Size = c.String(),
                        FloorLevel = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.Employers", "EmployerID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.MenuItems", "Item_Price", c => c.String());
            AddPrimaryKey("dbo.Employers", "EmployerID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Employers");
            AlterColumn("dbo.MenuItems", "Item_Price", c => c.Int(nullable: false));
            AlterColumn("dbo.Employers", "EmployerID", c => c.Double(nullable: false));
            DropTable("dbo.roomres");
            DropTable("dbo.Meetings");
            DropTable("dbo.hallres");
            DropTable("dbo.djs");
            AddPrimaryKey("dbo.Employers", "EmployerID");
        }
    }
}
