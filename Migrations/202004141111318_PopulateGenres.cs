namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (GenreName) VALUES ('Comedy')");
            Sql("INSERT INTO Genres (GenreName) VALUES ('Action')");
            Sql("INSERT INTO Genres (GenreName) VALUES ('Adventure')");
            Sql("INSERT INTO Genres (GenreName) VALUES ('Drama')");
            Sql("INSERT INTO Genres (GenreName) VALUES ('Horror')");
            Sql("INSERT INTO Genres (GenreName) VALUES ('Historical')");
            Sql("INSERT INTO Genres (GenreName) VALUES ('Musical')");
            Sql("INSERT INTO Genres (GenreName) VALUES ('Family')");
            Sql("INSERT INTO Genres (GenreName) VALUES ('Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
