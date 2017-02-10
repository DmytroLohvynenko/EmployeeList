namespace EmployeeList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNullableRateToEmployee : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Rate", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Rate", c => c.Int(nullable: false));
        }
    }
}
