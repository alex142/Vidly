namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddMoviesDbContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        GenreId = c.Int(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                        NumberInStock = c.Short(nullable: false),
                        Genre_Id = c.Short(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.Genre_Id)
                .Index(t => t.Genre_Id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Short(nullable: false, identity: true),
                        GenreName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbos", "Genre_Id", "dbo.Genres");
            DropIndex("dbos", new[] { "Genre_Id" });
            DropTable("dbo.Genres");
            DropTable("dbos");
        }
    }
}
