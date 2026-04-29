using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_12_Cinema_Booking.Migrations
{
    /// <inheritdoc />
    public partial class addDataToCinemas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
             migrationBuilder.Sql("INSERT INTO Cinemas (Name, Img) VALUES ('Cinema One', 'cinema1');\r\nINSERT INTO Cinemas (Name, Img) VALUES ('Grand Cinema', 'cinema2');\r\nINSERT INTO Cinemas (Name, Img) VALUES ('Galaxy Cinema', 'cinema3');\r\nINSERT INTO Cinemas (Name, Img) VALUES ('Cineplex Downtown', 'cinema4');\r\nINSERT INTO Cinemas (Name, Img) VALUES ('Silver Screen', 'cinema5');\r\nINSERT INTO Cinemas (Name, Img) VALUES ('Star Cinema', 'cinema6');\r\nINSERT INTO Cinemas (Name, Img) VALUES ('Movie Palace', 'cinema7');\r\nINSERT INTO Cinemas (Name, Img) VALUES ('Dream Cinema', 'cinema8');\r\nINSERT INTO Cinemas (Name, Img) VALUES ('IMAX Experience', 'cinema9');\r\nINSERT INTO Cinemas (Name, Img) VALUES ('City Lights Cinema', 'cinema10');");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("TRUNCATE TABLE Cinemas;");
        }
    }
}
