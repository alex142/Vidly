namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddingBirthDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthDate", c => c.DateTime(nullable: false));
            Sql("UPDATE MembershipTypes SET Name = 'Quarterly' WHERE Id = 3");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "BirthDate");
        }
    }
}
