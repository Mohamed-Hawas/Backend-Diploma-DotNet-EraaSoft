using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_12_Cinema_Booking.Migrations
{
    /// <inheritdoc />
    public partial class addDataToCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categories (Name) VALUES ('Action');\r\nINSERT INTO Categories (Name) VALUES ('Comedy');\r\nINSERT INTO Categories (Name) VALUES ('Drama');\r\nINSERT INTO Categories (Name) VALUES ('Horror');\r\nINSERT INTO Categories (Name) VALUES ('Sci-Fi');\r\nINSERT INTO Categories (Name) VALUES ('Romance');\r\nINSERT INTO Categories (Name) VALUES ('Thriller');\r\nINSERT INTO Categories (Name) VALUES ('Documentary');\r\nINSERT INTO Categories (Name) VALUES ('Animation');\r\nINSERT INTO Categories (Name) VALUES ('Adventure');");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categories WHERE Name IN ('Action', 'Comedy', 'Drama', 'Horror', 'Sci-Fi', 'Romance', 'Thriller', 'Documentary', 'Animation', 'Adventure');");
        }
    }
}
