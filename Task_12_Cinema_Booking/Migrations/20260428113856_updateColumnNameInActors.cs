using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_12_Cinema_Booking.Migrations
{
    /// <inheritdoc />
    public partial class updateColumnNameInActors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Actors SET Name = 'Leonardo DiCaprio' WHERE Img = 'actor1';");
            migrationBuilder.Sql("UPDATE Actors SET Name = 'Scarlett Johansson' WHERE Img = 'actor2';");
            migrationBuilder.Sql("UPDATE Actors SET Name = 'Robert Downey Jr.' WHERE Img = 'actor3';");
            migrationBuilder.Sql("UPDATE Actors SET Name = 'Morgan Freeman' WHERE Img = 'actor4';");
            migrationBuilder.Sql("UPDATE Actors SET Name = 'Tom Holland' WHERE Img = 'actor5';");
            migrationBuilder.Sql("UPDATE Actors SET Name = 'Emma Watson' WHERE Img = 'actor6';");
            migrationBuilder.Sql("UPDATE Actors SET Name = 'Chris Hemsworth' WHERE Img = 'actor7';");
            migrationBuilder.Sql("UPDATE Actors SET Name = 'Jennifer Lawrence' WHERE Img = 'actor8';");
            migrationBuilder.Sql("UPDATE Actors SET Name = 'Dwayne Johnson' WHERE Img = 'actor9';");
            migrationBuilder.Sql("UPDATE Actors SET Name = 'Natalie Portman' WHERE Img = 'actor10';");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Actors SET Name = 'Actor 1' WHERE Img = 'actor1';");
            migrationBuilder.Sql("UPDATE Actors SET Name = 'Actor 2' WHERE Img = 'actor2';");
            migrationBuilder.Sql("UPDATE Actors SET Name = 'Actor 3' WHERE Img = 'actor3';");
            migrationBuilder.Sql("UPDATE Actors SET Name = 'Actor 4' WHERE Img = 'actor4';");
            migrationBuilder.Sql("UPDATE Actors SET Name = 'Actor 5' WHERE Img = 'actor5';");
            migrationBuilder.Sql("UPDATE Actors SET Name = 'Actor 6' WHERE Img = 'actor6';");
            migrationBuilder.Sql("UPDATE Actors SET Name = 'Actor 7' WHERE Img = 'actor7';");
            migrationBuilder.Sql("UPDATE Actors SET Name = 'Actor 8' WHERE Img = 'actor8';");
            migrationBuilder.Sql("UPDATE Actors SET Name = 'Actor 9' WHERE Img = 'actor9';");
            migrationBuilder.Sql("UPDATE Actors SET Name = 'Actor 10' WHERE Img = 'actor10';");
        }
    }
}
