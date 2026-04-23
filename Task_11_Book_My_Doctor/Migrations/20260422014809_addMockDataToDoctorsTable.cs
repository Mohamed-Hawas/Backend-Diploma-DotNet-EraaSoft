using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_11_Book_My_Doctor.Migrations
{
    /// <inheritdoc />
    public partial class addMockDataToDoctorsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Doctors (name, phone, email, specialization, photoName) values ('Jean Giacoppoli', '+351 484 328 8745', 'jgiacoppoli0@mapquest.com', 'Cardiology', 'team1.jpg');\r\ninsert into Doctors (name, phone, email, specialization, photoName) values ('Dynah Pattesall', '+86 469 402 5047', 'dpattesall1@51.la', 'Pediatrics', 'team3.jpg');\r\ninsert into Doctors (name, phone, email, specialization, photoName) values ('Rodrique Tuckerman', '+98 622 326 1625', 'rtuckerman2@google.com.br', 'Cardiology', 'team2.jpg');\r\ninsert into Doctors (name, phone, email, specialization, photoName) values ('Odelle Keune', '+86 286 810 2846', 'okeune3@umich.edu', 'Pediatrics', 'team2.jpg');\r\ninsert into Doctors (name, phone, email, specialization, photoName) values ('Robbie MacAne', '+57 563 610 2578', 'rmacane4@dmoz.org', 'Orthopedics', 'team1.jpg');\r\ninsert into Doctors (name, phone, email, specialization, photoName) values ('Reinhold Padginton', '+996 352 723 3934', 'rpadginton5@about.me', 'Orthopedics', 'team2.jpg');\r\ninsert into Doctors (name, phone, email, specialization, photoName) values ('Ronnie Vanichkov', '+62 723 938 7634', 'rvanichkov6@va.gov', 'Pediatrics', 'team2.jpg');\r\ninsert into Doctors (name, phone, email, specialization, photoName) values ('Rhody Sickamore', '+55 407 552 4386', 'rsickamore7@soundcloud.com', 'Cardiology', 'team1.jpg');\r\ninsert into Doctors (name, phone, email, specialization, photoName) values ('Frasier Pascoe', '+30 894 215 4661', 'fpascoe8@who.int', 'Orthopedics', 'team2.jpg');\r\ninsert into Doctors (name, phone, email, specialization, photoName) values ('Morgan Olczyk', '+86 925 789 0209', 'molczyk9@disqus.com', 'Orthopedics', 'team2.jpg');\r\n");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("trancate table doctors");
        }
    }
}
