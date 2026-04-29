using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_12_Cinema_Booking.Migrations
{
    /// <inheritdoc />
    public partial class addDataToActors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Actors (Name, Img) VALUES ('Actor 1', 'actor1');\r\nINSERT INTO Actors (Name, Img) VALUES ('Actor 2', 'actor2');\r\nINSERT INTO Actors (Name, Img) VALUES ('Actor 3', 'actor3');\r\nINSERT INTO Actors (Name, Img) VALUES ('Actor 4', 'actor4');\r\nINSERT INTO Actors (Name, Img) VALUES ('Actor 5', 'actor5');\r\nINSERT INTO Actors (Name, Img) VALUES ('Actor 6', 'actor6');\r\nINSERT INTO Actors (Name, Img) VALUES ('Actor 7', 'actor7');\r\nINSERT INTO Actors (Name, Img) VALUES ('Actor 8', 'actor8');\r\nINSERT INTO Actors (Name, Img) VALUES ('Actor 9', 'actor9');\r\nINSERT INTO Actors (Name, Img) VALUES ('Actor 10', 'actor10');");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("TRUNCATE TABLE Actors;");
        }
    }
}
