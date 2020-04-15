namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class upd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbos", "Name", c => c.String(nullable: false, maxLength: 40));
        }
        
        public override void Down()
        {
            AlterColumn("dbos", "Name", c => c.String());
        }
    }
}
