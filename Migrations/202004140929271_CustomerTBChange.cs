namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class CustomerTBChange : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "Surname");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Surname", c => c.String());
        }
    }
}
