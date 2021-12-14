namespace GUI_Group_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employers",
                c => new
                    {
                        EmployerID = c.Double(nullable: false),
                        Firstname = c.String(),
                        Lastname = c.String(),
                        NIC = c.String(),
                        Contact = c.String(),
                        EmpRole = c.String(),
                    })
                .PrimaryKey(t => t.EmployerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employers");
        }
    }
}
