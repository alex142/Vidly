namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class ChangeIdTpye : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Movies WHERE Genre_Id IS NULL");
            DropForeignKey("dbos", "Genre_Id", "dbo.Genres");
            DropIndex("dbos", new[] { "Genre_Id" });
            DropColumn("dbos", "GenreId");
            RenameColumn(table: "dbos", name: "Genre_Id", newName: "GenreId");
            AlterColumn("dbos", "GenreId", c => c.Short(nullable: false));
            AlterColumn("dbos", "GenreId", c => c.Short(nullable: false));
            CreateIndex("dbos", "GenreId");
            AddForeignKey("dbos", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbos", "GenreId", "dbo.Genres");
            DropIndex("dbos", new[] { "GenreId" });
            AlterColumn("dbos", "GenreId", c => c.Short());
            AlterColumn("dbos", "GenreId", c => c.Int(nullable: false));
            RenameColumn(table: "dbos", name: "GenreId", newName: "Genre_Id");
            AddColumn("dbos", "GenreId", c => c.Int(nullable: false));
            CreateIndex("dbos", "Genre_Id");
            AddForeignKey("dbos", "Genre_Id", "dbo.Genres", "Id");
        }
    }
}
