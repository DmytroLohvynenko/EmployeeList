namespace EmployeeList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeRateToDecimal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Rate", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Rate", c => c.Int());
        }
    }
}
