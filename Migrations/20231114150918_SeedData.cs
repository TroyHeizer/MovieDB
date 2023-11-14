using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieDB.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "Movie");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movie",
                table: "Movie",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "MovieGenre", "MovieName", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "Crime|Mystery|Thriller", "Sherlock Holmes and the Secret Weapon", "09/29/2004" },
                    { 2, "Animation|Children|Comedy|Romance", "Lady and the Tramp", "09/05/1970" },
                    { 3, "Documentary", "Collision: Christopher Hitchens vs. Douglas Wilson", "12/04/1987" },
                    { 4, "Documentary", "Cooking Up Dreams (De ollas y sueños)", "12/14/2013" },
                    { 5, "Animation", "Merry Madagascar", "04/13/1953" },
                    { 6, "Comedy|Sci-Fi", "Sleeper", "07/02/2022" },
                    { 7, "Comedy|Drama", "Article 99", "05/21/1974" },
                    { 8, "Adventure|Sci-Fi", "Battle in Outer Space", "10/06/1990" },
                    { 9, "Action|Adventure|Comedy", "The Pirates of Blood River", "05/11/2009" },
                    { 10, "Comedy", "Fun Size", "06/30/1966" },
                    { 11, "Drama", "Lenny", "11/19/2011" },
                    { 12, "Crime|Drama", "Sonny", "06/12/1956" },
                    { 13, "Thriller", "The Loft", "06/11/2001" },
                    { 14, "Adventure|Drama|Sci-Fi|Thriller", "Sunshine", "11/16/1978" },
                    { 15, "Comedy", "One Crazy Summer", "07/15/2000" },
                    { 16, "Crime|Documentary", "Prophet's Prey", "11/05/1973" },
                    { 17, "Comedy|Crime|Mystery|Thriller", "Confidentially Yours (Vivement dimanche!)", "03/24/1958" },
                    { 18, "Action|Adventure|Comedy|Fantasy|Romance", "Librarian: Quest for the Spear", "12/05/2004" },
                    { 19, "Drama", "The Power and the Glory", "03/30/1950" },
                    { 20, "Action|Adventure|Comedy", "Lupin the 3rd", "10/08/1966" },
                    { 21, "Drama|Fantasy|Mystery|Romance", "Dream (Bi-mong)", "07/04/1986" },
                    { 22, "Drama", "Neds", "02/17/2020" },
                    { 23, "Drama|Romance|Thriller", "Bodyguard", "11/25/1992" },
                    { 24, "Comedy", "Austin High", "05/07/2010" },
                    { 25, "Drama", "Vision (Vision - Aus dem Leben der Hildegard von Bingen)", "10/12/2013" },
                    { 26, "Crime|Drama", "Reconstruction (Anaparastasi)", "03/19/2022" },
                    { 27, "Comedy|Romance", "Fever Pitch", "09/10/1973" },
                    { 28, "Drama|Romance|War", "Holocaust", "09/06/1958" },
                    { 29, "Horror", "Black Moon", "05/14/1964" },
                    { 30, "Comedy|Fantasy|Horror|Thriller", "Witches of Eastwick", "06/12/1987" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Movie",
                table: "Movie");

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.RenameTable(
                name: "Movie",
                newName: "Movies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "Id");
        }
    }
}
