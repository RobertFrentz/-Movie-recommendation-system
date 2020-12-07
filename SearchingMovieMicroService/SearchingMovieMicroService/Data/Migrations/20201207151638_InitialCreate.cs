using Microsoft.EntityFrameworkCore.Migrations;

namespace SearchingMovieMicroService.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Genres = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieWithTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MovieId = table.Column<int>(type: "INTEGER", nullable: false),
                    Tag = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieWithTags", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 1000, 69526, "better method AI" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 341, 750, "Stanley Kubrick" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 340, 750, "satirical" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 339, 750, "satire" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 338, 750, "Peter Sellers" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 337, 750, "comedy" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 336, 750, "cold war" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 335, 750, "British" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 334, 750, "black comedy" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 333, 608, "crime gone awry" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 332, 356, "vietnam war" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 331, 356, "classic" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 330, 356, "bittersweet" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 329, 318, "revenge" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 328, 318, "redemption" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 327, 318, "prison escape" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 326, 318, "Morgan Freeman" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 325, 318, "masterplan" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 324, 318, "friendship" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 323, 50, "twists & turns" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 322, 50, "twist ending" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 321, 50, "organized crime" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 320, 32, "time travel" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 319, 32, "psychology" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 318, 32, "post-apocalyptic" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 317, 7438, "violent" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 316, 6016, "violent" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 315, 3996, "overrated" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 342, 1079, "British" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 314, 2959, "twist" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 343, 1079, "John Cleese" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 345, 1136, "Monty Python" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 372, 1653, "racism" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 371, 1653, "powerful ending" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 370, 1653, "genetics" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 369, 1653, "genetic engineering" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 368, 1653, "future" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 367, 1653, "eugenics" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 366, 1625, "unrealistic" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 365, 1625, "twist ending" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 364, 1625, "Sean Penn" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 363, 1625, "psychological" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 362, 1625, "plot twist" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 361, 1625, "Mystery" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 360, 1625, "Michael Douglas" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 359, 1252, "twists & turns" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 358, 1252, "mystery" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 357, 1201, "Sergio Leone" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 356, 1201, "music" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 355, 1201, "Italian" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 354, 1201, "Ennio Morricone" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 353, 1201, "Clint Eastwood" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 352, 1193, "psychology" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 351, 1193, "psychological" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 350, 1175, "surreal" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 349, 1175, "post-apocalyptic" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 348, 1175, "atmospheric" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 347, 1136, "satire" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 346, 1136, "parody" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 344, 1079, "quirky" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 313, 2762, "twist" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 312, 2502, "must show" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 311, 2012, "must show" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 278, 916, "love story" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 277, 916, "Italy" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 276, 916, "imdb top 250" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 275, 916, "Gregory Peck" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 274, 916, "classic" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 273, 916, "black and white" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 272, 916, "Audrey Hepburn" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 271, 84772, "Simon Pegg" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 270, 41573, "utterly predictable ensemble flick" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 269, 40819, "whit stillman meets diner" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 268, 27727, "wild and fresh" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 267, 8645, "too upper class" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 266, 8645, "actress too old" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 265, 72, "whit stillman meets Diner" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 264, 1966, "upper class" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 263, 1966, "manhattan" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 262, 2012, "time travel" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 261, 2011, "time travel" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 260, 2011, "sci-fi" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 259, 1270, "time travel" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 258, 1270, "Steven Spielberg" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 257, 7158, "sad but good" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 256, 7158, "intense" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 255, 7158, "heartbreaking" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 254, 7158, "culture clash" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 253, 4973, "whimsical" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 252, 4973, "visually appealing" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 279, 916, "National Film Registry" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 280, 916, "need to own" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 281, 916, "romantic comedy" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 282, 916, "Rome" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 310, 2011, "must show" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 309, 1396, "must show" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 308, 1197, "must show" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 307, 115149, "Willem Dafoe" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 306, 115149, "Revenge" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 305, 115149, "Action" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 304, 260, "sci-fi" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 303, 260, "fantasy" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 302, 260, "1970s" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 301, 45186, "Ethan Hunt Should Stop Hogging The Screen!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 300, 34405, "western" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 299, 34405, "scifi" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 298, 34405, "Firefly" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 373, 1784, "funny" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 297, 55872, "uplifting and compelling" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 295, 55872, "love of music" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 294, 55872, "inspirational" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 293, 55872, "Freddie Highmore" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 292, 8533, "sentimental" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 291, 8533, "chick flick" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 290, 4246, "romantic comedy" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 289, 4246, "Jane Austen" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 288, 4246, "Hugh Grant" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 287, 4246, "British" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 286, 4246, "based on a book" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 285, 916, "zest for life" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 284, 916, "slapstick" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 283, 916, "royalty" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 296, 55872, "power of music" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 251, 4973, "stylized" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 374, 1784, "Jack Nicholson" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 376, 1784, "psychology" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 466, 48043, "Music" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 465, 48043, "multiple storylines" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 464, 48043, "emotional" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 463, 48043, "death" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 462, 48043, "atmospheric" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 461, 47044, "unrealistic plot" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 460, 47044, "unrealistic action" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 459, 47044, "unrealistic" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 458, 47044, "shallow" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 457, 47044, "Miami" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 456, 47044, "characters" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 455, 47044, "action packed" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 454, 44191, "visually appealing" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 453, 44191, "thought-provoking" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 452, 44191, "politics" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 451, 44191, "Natalie Portman" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 450, 44191, "inspirational" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 449, 44191, "England" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 448, 44191, "dystopia" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 447, 44191, "dark" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 446, 44191, "comic book" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 445, 31410, "World War II" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 444, 31410, "historical" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 443, 31410, "excellent performance" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 442, 31410, "disturbing" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 441, 31410, "Biography" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 440, 8914, "time travel" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 467, 48043, "nonlinear" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 439, 8914, "sci-fi" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 468, 48043, "surreal" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 470, 48043, "visually appealing" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 497, 55442, "Middle East" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 496, 55442, "coming of age" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 495, 54372, "twist ending" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 494, 54372, "murder mystery" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 493, 54372, "French" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 492, 52328, "spaceships" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 491, 52328, "slow paced" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 490, 52328, "psychology" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 489, 52328, "psychological" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 488, 52328, "madness" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 487, 52328, "great soundtrack" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 486, 52328, "ending twist" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 485, 52328, "despair" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 484, 52328, "dark" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 483, 52328, "atmospheric" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 482, 51662, "stylized" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 481, 51662, "Frank Miller" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 480, 51662, "blood" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 479, 51662, "based on comic" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 478, 51662, "based on a comic" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 477, 51662, "americanized movie" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 476, 48774, "violence" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 475, 48774, "sci-fi" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 474, 48774, "future" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 473, 48774, "ending" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 472, 48774, "dystopia" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 471, 48774, "disturbing" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 469, 48043, "thought-provoking" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 438, 8914, "plot holes" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 437, 8914, "mindfuck" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 436, 8914, "dialogue driven" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 403, 4978, "characters" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 402, 4973, "slow paced" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 401, 4848, "pretentious" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 400, 4848, "Nudity (Full Frontal)" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 399, 4848, "BORING!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 398, 3363, "friendship" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 397, 3363, "coming of age" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 396, 3363, "classic" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 395, 3359, "cycling" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 394, 3359, "coming-of-age" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 393, 3359, "coming of age" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 392, 3000, "surreal" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 391, 3000, "fantasy world" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 390, 3000, "anime" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 389, 3000, "adventure" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 388, 2571, "virtual reality" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 387, 2571, "sci-fi" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 386, 2571, "post-apocalyptic" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 385, 2329, "thought-provoking" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 384, 2329, "tense" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 383, 2329, "racism" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 382, 2329, "powerful ending" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 381, 2329, "politics" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 380, 2329, "Neo-Nazis" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 379, 2329, "Edward Norton" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 378, 1784, "relationships" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 377, 1784, "quirky" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 404, 4978, "romance" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 405, 4993, "adventure" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 406, 4993, "characters" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 407, 4993, "epic" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 435, 7090, "photography" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 434, 7090, "martial arts" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 433, 7090, "colours" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 432, 7090, "atmospheric" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 431, 6953, "Sean Penn" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 430, 6953, "psychological" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 429, 6953, "multiple storylines" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 428, 6539, "too long" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 427, 6539, "photography" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 426, 6539, "modernism" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 425, 6539, "magic realism" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 424, 6539, "Johnny Depp" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 423, 6539, "cliche" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 375, 1784, "obsessive compulsive disorder" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 422, 6365, "unrealistic characters" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 420, 6365, "action packed" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 419, 6016, "realistic" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 418, 6016, "multiple storylines" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 417, 6016, "drama" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 416, 6016, "disturbing" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 415, 5291, "nonlinear" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 414, 5291, "multiple storylines" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 413, 5282, "military court" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 412, 5282, "lawyers" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 411, 5282, "ending" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 410, 4993, "photography" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 409, 4993, "fighting" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 408, 4993, "fantasy world" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 421, 6365, "dystopia" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 498, 55442, "politics" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 250, 4973, "romance" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 248, 4973, "beautifully filmed" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 91, 35836, "sex comedy" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 90, 35836, "sex" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 89, 35836, "Seth Rogen" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 88, 35836, "Nudity (Topless)" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 87, 35836, "Nudity (Topless - Notable)" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 86, 35836, "crude humor" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 85, 35836, "comedy" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 84, 8641, "Will Ferrell" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 83, 8641, "Vince Vaughn" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 82, 8641, "Steve Carell" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 81, 8641, "seen more than once" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 80, 8641, "One of the worst movies of all time" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 79, 8641, "hilarious" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 78, 8641, "Funniest Movies" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 77, 6188, "Will Ferrell" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 76, 6188, "Vince Vaughn" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 75, 6188, "Seann William Scott" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 74, 6188, "Nudity (Topless)" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 73, 6188, "college" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 72, 5283, "Teen movie" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 71, 5283, "Ryan Reynolds" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 70, 5283, "R" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 69, 5283, "Nudity (Topless)" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 68, 5283, "College Humor" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 67, 4718, "sexuality" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 66, 4718, "Nudity (Topless)" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 65, 2706, "teen comedy" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 92, 35836, "Steve Carell" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 64, 2706, "sexuality" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 93, 36529, "arms dealer" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 95, 36529, "drugs" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 122, 68073, "rock and roll" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 121, 68073, "pirate radio" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 120, 68073, "Philip Seymour Hoffman" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 119, 68073, "meandering" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 118, 68073, "Bill Nighy" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 117, 68073, "1960s" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 116, 60756, "will ferrell" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 115, 60756, "Seth Rogen" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 114, 60756, "comedy" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 113, 59900, "over the top" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 112, 59900, "Israeli/Palestinian conflict" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 111, 59900, "exaggerated" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 110, 59900, "Below R" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 109, 59900, "Adam Sandler" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 108, 54503, "virginity" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 107, 54503, "Teen movie" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 106, 54503, "pornography" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 105, 54503, "Highly quotable" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 104, 54503, "crude humor" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 103, 52973, "Nudity (Topless)" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 102, 52973, "Nudity (Topless - Brief)" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 101, 52973, "drugs" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 100, 46970, "Will Ferrell" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 99, 46970, "Tarantino" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 98, 46970, "Below R" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 97, 36529, "Nudity (Topless)" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 96, 36529, "Nicolas Cage" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 94, 36529, "dark comedy" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 63, 2706, "Nudity (Topless)" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 62, 2706, "Nudity (Topless - Notable)" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 61, 1288, "witty" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 28, 27866, "New Zealand" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 27, 27803, "Oscar (Best Foreign Language Film)" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 26, 8622, "conspiracy theory" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 25, 8529, "stranded" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 24, 7318, "jesus" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 23, 7013, "noir thriller" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 22, 6874, "dark hero" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 21, 6539, "treasure" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 20, 5135, "bollywood" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 19, 3052, "jesus" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 18, 2840, "jesus" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 17, 2726, "noir thriller" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 16, 2662, "mars" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 15, 2353, "conspiracy theory" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 14, 2193, "dragon" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 13, 2022, "jesus" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 12, 1783, "noir thriller" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 11, 1694, "jesus" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 10, 1617, "neo-noir" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 9, 1391, "mars" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 8, 1248, "noir thriller" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 7, 898, "screwball comedy" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 6, 668, "bollywood" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 5, 592, "dark hero" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 4, 521, "noir thriller" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 3, 353, "dark hero" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 2, 208, "dark hero" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 29, 48082, "surreal" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 30, 48082, "unusual" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 31, 51884, "bollywood" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 32, 58652, "cute" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 60, 1288, "satire" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 59, 1288, "rock and roll" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 58, 1288, "music business" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 57, 1288, "comedy" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 56, 1288, "Christopher Guest" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 55, 778, "Nudity (Full Frontal)" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 54, 778, "Nudity (Full Frontal - Notable)" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 53, 778, "drugs" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 52, 778, "dark comedy" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 51, 106696, "writing" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 50, 106696, "voice acting" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 49, 106696, "unnecessary villain" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 48, 106696, "themes" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 123, 68073, "soundtrack" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 47, 106696, "storyline" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 45, 106696, "royalty" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 44, 106696, "pacing" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 43, 106696, "musical" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 42, 106696, "music" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 41, 106696, "Ice" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 40, 106696, "feminist" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 39, 106696, "Disney" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 38, 106696, "characters" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 37, 106696, "beautiful" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 36, 106696, "animation" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 35, 58652, "Stephen Chow" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 34, 58652, "girls who play boys" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 33, 58652, "emotional" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 46, 106696, "siblings" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 249, 4973, "quirky" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 124, 80693, "mental illness" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 126, 104, "Adam Sandler" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 216, 61132, "irreverent" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 215, 61132, "Hollywood" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 214, 61132, "Ben Stiller" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 213, 60756, "will ferrell" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 212, 60756, "Seth Rogen" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 211, 60756, "movie to see" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 210, 60756, "let down" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 209, 60756, "Highly quotable" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 208, 60756, "ending" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 207, 60756, "brother-brother relationship" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 206, 55280, "small town" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 205, 55280, "real doll" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 204, 55280, "mental illness" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 203, 55280, "family affair" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 202, 55280, "emotional" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 201, 55280, "dork people" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 200, 55280, "delusional" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 199, 55280, "delusion" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 198, 52952, "teenager" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 197, 52952, "tattoo" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 196, 52952, "friendship" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 195, 52952, "coming of age" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 194, 33880, "weird" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 193, 33880, "unique" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 192, 33880, "SEXUAL AWAKENING" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 191, 33880, "irreverent" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 190, 33880, "Indie" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 217, 61132, "Jack Black" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 189, 33880, "independent film" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 218, 61132, "Robert Downey Jr." });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 220, 61132, "Tom Cruise" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 247, 81834, "emma watson" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 246, 81834, "camping trip" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 245, 81834, "boring" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 244, 81537, "Zach Galifianakis" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 243, 81537, "Robert Downey Jr." });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 242, 81537, "road trip" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 241, 81537, "drug use" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 240, 80862, "social networking" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 239, 80862, "Not what was expected but still good" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 238, 80862, "makes you think" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 237, 80862, "documentary" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 236, 80846, "plot twist" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 235, 80549, "Unreal reactions" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 234, 80549, "typical" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 233, 80549, "sexuality" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 232, 80549, "plot" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 231, 80549, "funny dialogues" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 230, 80549, "Emma Stone" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 229, 80489, "too much love interest" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 228, 80489, "one dimensional characters except for Affleck. Ending trite." });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 227, 80489, "Criminal = good Police = bad" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 226, 80489, "action" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 225, 80350, "vampires" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 224, 80350, "parody" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 223, 80350, "funny" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 222, 80094, "handcam-real style" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 221, 61132, "Vietnam War" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 219, 61132, "satire" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 188, 33880, "FATHERS AND SONS" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 187, 33880, "deadpan" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 186, 33880, "bittersweet" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 153, 4247, "fuck you it's funny" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 152, 4247, "David Spade" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 151, 3556, "visually appealing" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 150, 3556, "suicide" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 149, 3556, "suburbia" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 148, 3556, "reflective" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 147, 3556, "psychology" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 146, 3556, "melancholy" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 145, 3556, "lyrical" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 144, 3556, "high school" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 143, 3556, "great ending" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 142, 2706, "virginity" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 141, 2706, "Teen movie" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 140, 2706, "teen comedy" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 139, 2706, "sexuality" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 138, 2706, "Nudity (Topless)" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 137, 2706, "Nudity (Topless - Notable)" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 136, 2706, "high school" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 135, 2335, "sport:American football" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 134, 2335, "football" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 133, 2335, "American football" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 132, 2335, "Adam Sandler" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 131, 1359, "Xmas theme(?)" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 130, 1359, "christmas movie" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 129, 1359, "Arnold Schwarzenegger" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 128, 104, "sports" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 127, 104, "golf" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 154, 4247, "movie to see" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 155, 4732, "stupid :)" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 156, 4878, "alternate timeline" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 157, 4878, "cult classic" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 185, 33880, "avante garde" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 184, 8641, "Steve Carrell" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 183, 8641, "Steve Carell" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 182, 8641, "Seth Rogen" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 181, 8641, "Paul Rudd" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 180, 8641, "Judd Apatow movie" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 179, 8641, "Ben Stiller" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 178, 8528, "wasted potential" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 177, 8528, "Vince Vaughn" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 176, 8528, "sports" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 175, 8528, "seen more than once" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 174, 8528, "Idiotic" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 173, 8528, "Funny as hell" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 125, 80693, "Zach Galifianakis" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 172, 8528, "funny" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 170, 8528, "Ben Stiller" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 169, 5449, "Winona Ryder" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 168, 5449, "Al Sharpton" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 167, 5449, "Adam Sandler" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 166, 4878, "time travel" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 165, 4878, "thought-provoking" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 164, 4878, "surreal" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 163, 4878, "sci-fi" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 162, 4878, "psychology" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 161, 4878, "music" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 160, 4878, "mental illness" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 159, 4878, "high school" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 158, 4878, "cult film" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 171, 8528, "comedy" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 499, 55442, "revolution" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 500, 55442, "social commentary" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 501, 55908, "entirely dialogue" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 842, 7143, "'The Ninja Assault Gets A 3peat'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 841, 6963, "...'Livin' In An Amish Paradise'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 840, 6914, "'I Have Never Had Any Foreign Relations With That Woman Hillary Lewinsky'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 839, 6713, "Animated Woody Allen Film...If He Made One" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 838, 6708, "'Alison Lohman Stole The Whole Damn Film'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 837, 6656, "'Why Is Everyone Running Around With Puppets Up Their A**?!'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 836, 6511, "'H Christ!\\" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 835, 6301, "Even Dweebs Go Psycho If You Keep Making Fun Of Their Glasses" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 834, 6294, "With A Name Like Chew Yer Fat A Crossover Is Not Possible" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 833, 6286, "Sometimes Marriage Makes You Wanna Forget Why The Hell You Said YES" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 832, 5995, "'The What?!'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 831, 5992, "even crazy people like to be asked out" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 830, 5956, "'Know Why I Like Butchering Pigs? It's Like Killing Cops But Without The Jail Time'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 829, 5807, "'Yeah The Test Audience Thought That Was A Better Title...More Upbeat'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 828, 5319, "'Don't Watch 'Criminal' Totally Butchered'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 827, 4978, "The Mother Of Connect-The-Dots  Flix (Grand Canyon/Crash/ETC)" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 826, 4975, "Re-Fried For U.S." });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 825, 4719, "The 5-Second Rule Never Applies Near Animals Or In Zoos" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 824, 3755, "'On A Steel Horse I Ride I'm Wanted (waaaanteeddd) Dead Or Alive'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 823, 3709, "Perfect Use Of Johnny & Santo's 1 Hit Wonder" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 822, 3660, "'I Can't Get That Theme Song Out Of My Head'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 821, 3471, "'Stop Banging The Doorbell I'm Landscaping My Kitchen Sink!'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 820, 3192, "Great Anti-Abortion Film" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 819, 3148, "the book was bettah" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 818, 3101, "'Hey Dan Do You Mind Having Rabbit Stew For A Pick-Me-Up?'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 817, 3030, "You Only Got 2 Bullets. I Have A Sword. You Will Miss. I Won't." });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 816, 2745, "Was The Mission About Finding A Position?" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 843, 7442, "Just Great. Now Every1 Knows Ewan Is \\" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 815, 2359, "'Didn't This Already Happen To Bernie?'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 844, 7828, "'And When The Germans Came Over The Ridge They Suddenly Went Blind!'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 846, 8295, "Wasn't That Human Played By Ice-T?" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 873, 34323, "Do People Really Have 2 Pay 10 Bucks To See How Cruel We Are To Each Other? Try Getting Married!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 872, 34271, "We All Gotta Have A Dream" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 871, 33823, "Please Stop Re-Frying Books That Suck Donkey D***!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 870, 33817, "Emily Blunt Is Sooo Very...   She Was Amazing In Irresistable" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 869, 33649, "Wonderful Asian Film That Shows Why We Shouldn't Hide Who We Really Are" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 868, 33592, "Being Prostituted By Your Husband Is Never Romantic!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 867, 33358, "Mrs. Jones Distracted Me The Whole Movie" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 866, 32600, "Tailoring Would Be Back In Style If More Women Appreciated Clothes In THAT Way!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 865, 32582, "A Deadhead With A Parrot Fetish" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 864, 31617, "'This Is My Gun. I Love To Touch My Gun. Touch My Gun.'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 863, 31410, "'You Know What They Say About Short Men With Little Toes'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 862, 27904, "Zoom In & Slo-Mo The Porking Scene With Ridin' Winona" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 861, 27846, "Like Michael Crichton Sez Help Stop Gene Patenting! Or Sooner Than Later You Won't Even Own Your Cells!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 860, 27689, "Merde!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 859, 27664, "A Married Couples Excuse To Shag On Film" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 858, 27432, "Fight For Your Dreams Because People Are Dying For Theirs" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 857, 26840, "Takeshi Definitely Beat This Genre To The Ground" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 856, 26696, "Cynthia(Deborah Rennard) Was The Only Performer To Watch In This Drek! More Like L I O N A S S!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 855, 26688, "He Loses All Credibility When He Runs LOL!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 854, 26464, "Just Another F***ing A-Hole!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 853, 26413, "'That's Where You Enter From Behind After A Running Jump'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 852, 8919, "Hmmm I Wonder How Many Counselors Do Their Jobs Like That!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 851, 8862, "9ine Queens Was A Better Title...& Film" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 850, 8720, "Loved The Mouse Wake-Up" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 849, 8505, "'Is That What She Calls It?'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 848, 8369, "More Like Plothunters Or Why Did I Watch This?" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 847, 8367, "If The Director Doesn't Care 2 Flesh Out A Film Why The Hell Should I Care What Happens 2 The Characters?" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 845, 7925, "'Is That What He Called It?'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 814, 2275, "Guy Pierce With Dweeb Focals" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 813, 2268, "'That's All An Inmate Wants...Simple Pleasures'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 812, 2202, "You Mean It's Over Inflated!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 779, 80584, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 778, 80553, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 777, 80185, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 776, 79357, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 775, 79293, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 774, 79091, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 773, 78746, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 772, 78574, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 771, 78103, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 770, 77854, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 769, 77833, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 768, 77658, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 767, 77421, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 766, 77359, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 765, 77330, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 764, 77307, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 763, 77154, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 762, 76091, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 761, 76079, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 760, 75813, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 759, 74677, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 758, 74504, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 757, 73681, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 756, 73587, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 755, 73344, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 754, 72741, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 753, 72554, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 780, 80586, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 781, 80939, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 782, 81383, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 783, 81456, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 811, 2087, "'And Just What Do You Think You're Doing Mr. Smeee?'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 810, 2076, "'It's Not Where Your Dreams Take You But Who You Take In Your Dreams' hahaha!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 809, 1674, "'I Guess Repression Does Have It's Moments After All'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 808, 1554, "Ewe Mean Sausage McHoody With Eggs" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 807, 1508, "All Of A Sudden You Feel Guilty About Bangin' Yer Own Daughter Why Stop Now?" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 806, 1502, "Of Course It's Rigid! The Dude's In Full Rigor!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 805, 1372, "'Oh Spock! Oh Jim! Oh Bones!' WTF!? Et Tu Herr Doktor? Heil!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 804, 1345, "'Carrie I Don't Wanna Rain On Your Parade But That's Not Fruit Punch'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 803, 1247, "'Wow Mrs. Robinson Your Porridge Is Just Right!'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 802, 1208, "'Oh The Whore-ror!'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 801, 1175, "This Would Have Been Funnier If It Was A Horror Film" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 800, 340, "Kevin Pederast" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 799, 93939, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 874, 34338, "When It Comes Down To It Toilet Humor Always S(m)ells" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 798, 93892, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 796, 90866, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 795, 89039, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 794, 88267, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 793, 86487, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 792, 85438, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 791, 85179, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 790, 84187, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 789, 83531, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 788, 83270, "feminist" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 787, 83270, "feminism" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 786, 82463, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 785, 81804, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 784, 81639, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 797, 91077, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 752, 72395, "new" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 875, 34437, "It's The Journey Not The Destination That We Should Enjoy" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 877, 35957, "Never Trust Euro-Looking A-Holes @ The Airport.Com" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 967, 55282, "30 Daze Of Shite" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 966, 55276, "'I Love You Anna!'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 965, 55272, "'The Other Movie Did It's Job...This Must Be The Wrong Movie'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 964, 55080, "'STFU!'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 963, 54999, "'Why Is My Arm Wet? Oh It's Just A Crushed Baby'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 962, 54775, "The Director Should Be Be Shot...In The Mouth!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 961, 54736, "'Don't Cry Jen I Promise We'll Kill Them All'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 960, 54503, "Super De-Formed" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 959, 54276, "Mostly Martha Will Always Be The Best. Aron Eckhart? Ninja Pleaze!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 958, 54270, "'More Like Skankwalkers'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 957, 54004, "Chuck & Buck..." });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 956, 53894, "'Now If Only Dubya Could Wash Me Whites" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 955, 53550, "'And So The Bear And Little Deiter Went Off Into The Mountains & Lived Like Homosexual Bears'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 954, 53464, "'What I Really Wanna Know Is...Does Alba Get Sooper Nekkid?'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 953, 53318, "'Why Yes I Would So Love To Sketch Nudes In Costco!'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 952, 53123, "'Take This Sinking Boat & Point It Home You Hoover Fixer Sucker Guuuyyy!'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 951, 52867, "'Saving Silverman Part Deux'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 950, 52717, "'I'll Give You 10 Seconds Head Start...10!'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 949, 52604, "Lecter Remarries & Kills His Insulting Wife & Butts Heds With Hotshot D.A." });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 948, 52460, "Karl Urban Needs To Pick Better Projects & He Needs 2 Pick-Up His Sword" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 947, 52458, "Rear Pwnage" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 946, 52456, "'Don't Look Into Berry's Headlights She'll Turn You Into Wood'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 945, 52328, "'Please Tell Me We Brought The Lighter...Please'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 944, 51935, "It's 1 Part Bad Memories  1 Part Double Cross Add  A Twist Of Slime & Lots Of Good Vibrations!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 943, 51709, "After The Reveal The Story Went Back Down And Never Came Up Again" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 942, 51418, "Not Another Mingella Stretcher! We Hates Them!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 941, 51412, "What's Up With The Da Vinci Hair Do" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 968, 55284, "'Show Me The Money! I Can't Hear You Haji Scream Louder!'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 940, 51255, "It Just Keeps Getting Better" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 969, 55391, "A Bad Copy Of Departed Which Was A Re-Hash Of Infernal Affairs" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 971, 55830, "I felt sweded" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 998, 68791, "good first try for MCG" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 997, 68650, "crash re-hashed" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 996, 68554, "angles and deadlines" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 995, 67197, "shame on them!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 994, 64983, "no matter what role it is i will not change my persona everybody worships 'the cruise'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 993, 64957, "you mean he gets to go back inside the...oh lucky" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 992, 64839, "mickey 'the stretch' rourke" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 991, 64575, "P.S.H as a priest? oh you know he's guilty!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 990, 64497, "all your vagine are belong to us!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 989, 63033, "or you'll go...too late'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 988, 63033, "'stop wanking" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 987, 61705, " " });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 986, 61705, "didja know there's a black police ociffer on our block? oh man there goes the neighborhood" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 985, 60937, "it's too bad Brendan can't shake the Encino Man syndrome" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 984, 60760, "...that it's finally over" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 983, 60333, "not another herzog schwarzenneger egomentary" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 982, 60037, "of course you keep seeing dead people...they're all dying!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 981, 59731, "that's what he keeps asking for" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 980, 58103, "brain bang" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 979, 57951, "we can do this easy or we can do this reeal easy it's called magic hour" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 978, 57368, "blair gojira project" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 977, 56801, "'AKA: I Will Never Get Those 2 Hours Back...Ever'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 976, 56775, "'It Should Have Been Kept A Secret'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 975, 56757, "'Oh Edward!  A Mr. Todd Would Like You To Cut His Hair'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 974, 56286, "'Cate Dylan Hmmm...'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 973, 56001, "'I Don't Care If You Have Cholera It's Still Heads Or Tails...Call It'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 972, 55995, "'I Will Give My Kingdom For A Great Piece Of TWAT!'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 970, 55820, "'Heads Or Tails...Call It'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 939, 51037, "'It's Just Hostel 3 With Better Actors'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 938, 50872, "Pixar's Formula Starting To Get Stale" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 937, 50442, "Just In Timber Cake Must Die!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 904, 42723, "Oh No This Film Doesn't Promote Murder & Suffering It Just Encourages It!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 903, 42721, "I Guess Nude Terminators Can't Kill A Really Bad Film" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 902, 42718, "Parkour: Getting Around Obstacles A Great Complement To Being Alive" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 901, 42418, "No Matter What Century It Is Jungle Fever Is Very Contagious!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 900, 42018, "When You're Stressed Out Nudity Works Wonders For Your Nerves" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 899, 42004, "It's Not Just A Phase It's Really A Way Of Life" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 898, 41997, "Stop Killing Each Other You're Neighbors!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 897, 41617, "Even Princesses Want To Have Pig Sex Now & Again...& Again" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 896, 41571, "Years Of Degredation And Humiliation And They Sell Your \\" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 895, 41285, "It Just Goes To Show Ya Once The Ring Goes On It's Just Leftovers" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 894, 40414, "But What Did They Do After New Years: Resolve To Kill ALL My Enemies" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 893, 39427, "I Just Kept Hearing Massive Attack After The Car Accident" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 892, 39414, "Steve Martin Is Scraping The Bottom HARD!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 891, 39183, "Cow Pokin' In Them Thar Hills" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 890, 38992, "Isn't Renee Russo Like 100 Years Old? Matt! What Were You Thinking?" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 889, 38188, "What's Really Scary Is That There's People Like That In Real Life!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 888, 37857, "No Wonder Carneys Love The Life" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 887, 37855, "Brighton Beach Memoirs & Juliana Moore" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 886, 37853, "Millions Of Dollars In Drugs Or One Hot Girlfriend...You Choose" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 885, 37731, "They Made This Already And It Was Titled: Football Factory It's Way Better Than This Re-Hash" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 884, 37729, "Tim Burton Hits Another One Out Of The Cemetery" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 883, 37386, "How Come Charlize Can Play A Serial Killer But She Can't Show More Skin Oh Come On!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 882, 37380, "Half-Assed Productions" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 881, 36537, "Teen Induced Angst Overdose" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 880, 36535, "Where Can I Learn To Speak English Like That?" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 879, 36529, "I Don't Think Arms Dealers Look Anything Like Nick Cage" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 878, 36517, "'There's A Lotta These At Used Book Stores...Hmmm I Wonder Why It Sucks That Bad'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 905, 42725, "Nick Swardson Should Have Been Lead His Timing Was Sic!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 906, 42728, "The Whole Tromeo & Juliet Threw Me Off But Thank Gawd They Didn't Talk Like Bill The Spear Shaker" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 907, 42734, "What If The Big Bad Wolf & Grandma Were Swapping Spit?" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 908, 43556, "An Orifice & A Gentle Hand Refried For '06" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 936, 50068, "It's Biased When Watanabe Uses A 45 And Kills Himself" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 935, 49961, "'I Had No Idea That You Were A F****** Vampire!'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 934, 49347, "'There's Shit In The Meat!'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 933, 49314, "What Happens To Batman When He Loses The Wayne Fortune" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 932, 49278, "Oh The Things I Could Do If Snow White Were A Console" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 931, 49272, "Bond Would Never Ever Be Caught Driving A Frikkin FORD" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 930, 49265, "Rwandan Genocide" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 929, 49265, "Rwanda Genocide" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 928, 48744, "'Double Fudge Bus'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 927, 48698, "my child let me show you how firm my faith is" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 926, 48520, "No Amount Of Silly Cone Can Save A Steaming Pile Of Shitzu Like This" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 925, 48516, "You Know It's Bad If It's Been Reheated...Again" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 924, 48412, "Kevin Cockner & Asstin Goocher Guarding Each Others Happy Holes" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 876, 34542, "Never Ever Discuss Your Lack Of Game To Wild Bears!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 923, 48385, "'I Want To Meke Romance Explosion On Her Stomatch!'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 921, 48043, "You Would Do Anything In The Universe To Get Rachael Weisz Back As Well" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 920, 46967, "A Comedy Version Of Matchpoint" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 919, 46530, "'So How Did Lois Survive Date Nite?'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 918, 46322, "It's Not Size Of Your Stick But Why You Keep On Swingin' It!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 917, 45732, "Not Even Uma Could Save This Dizaster! Wanda Yikes!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 916, 45730, "Believe In Your Ability To See Stoopid Plotlines" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 915, 45442, "The Power Of The P" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 914, 45431, "'Priceline Negotiator!'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 913, 45186, "Ethan Hunt Should Stop Hogging The Screen!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 912, 45062, "Obviously Hillary Had A Different Meaning For \\" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 911, 44759, "If I See One More Roast Beef Sandwich You Will Smell My Reaction" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 910, 44511, "'Lemme Get This Straight. You Have No Idea Who You Are But You Wanna Be Famous?'" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 909, 43928, "Read All The Negative Reviews & Save 2 Hours Of Your Life!" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 922, 48304, "Or How The Last Of The Mohican Killed The Predator Escaping From The Thunderdome" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 751, 72176, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 750, 71745, "new" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 749, 71542, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 591, 108190, "dystopia" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 590, 108190, "based on a book" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 589, 99114, "slavery" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 588, 99114, "Samuel L. Jackson" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 587, 99114, "Quentin Tarantino" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 586, 99114, "Over the top" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 585, 99114, "Leonardo DiCaprio" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 584, 97752, "visually appealing" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 583, 97752, "Tom Hanks" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 582, 97752, "social criticism" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 581, 97752, "social commentary" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 580, 97752, "slow paced" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 579, 97752, "sci-fi" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 578, 97752, "rebellion" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 577, 97752, "philosophy" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 576, 97752, "multiple storylines" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 575, 97752, "based on a book" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 574, 97752, "atmospheric" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 573, 97752, "adapted from:book" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 572, 96610, "visually appealing" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 571, 96610, "violent" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 570, 96610, "time travel" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 569, 96610, "sci-fi" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 568, 96610, "future" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 567, 91077, "Hawaii" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 566, 91077, "George Clooney" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 565, 91077, "family bonds" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 592, 112556, "based on a book" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 564, 91077, "emotional" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 593, 112556, "marriage" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 595, 112556, "mindfuck" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 622, 5525, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 621, 5225, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 620, 4801, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 619, 4741, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 618, 3533, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 617, 3229, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 616, 3134, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 615, 2359, "NOT British" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 614, 2359, "Irish" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 613, 2359, "Ireland" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 612, 2065, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 611, 1942, "Good Book Bad Movie" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 610, 1939, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 609, 1834, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 608, 1412, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 607, 1281, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 606, 1162, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 605, 1123, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 604, 974, "own" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 603, 959, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 602, 930, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 601, 608, "black comedy" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 600, 571, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 599, 302, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 598, 82, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 597, 112556, "unpredictable" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 596, 112556, "Neal Patrick Harris" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 594, 112556, "meticulous" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 563, 91077, "drama" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 562, 91077, "coma" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 561, 90746, "animation" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 528, 68954, "friendship" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 527, 68954, "emotional" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 526, 64614, "redemption" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 525, 64614, "gangs" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 524, 64614, "culture clash" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 523, 64614, "Clint Eastwood" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 522, 63082, "visually appealing" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 521, 63082, "violence" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 520, 63082, "social commentary" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 519, 63082, "shallow plot" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 518, 63082, "romance" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 517, 63082, "photography" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 516, 63082, "Oscar (Best Picture)" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 515, 63082, "love story" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 514, 63082, "India" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 513, 58559, "vigilante" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 512, 58559, "superhero" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 511, 58559, "Heath Ledger" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 510, 58559, "Batman" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 509, 58559, "Atmospheric" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 508, 55908, "unique" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 507, 55908, "Underrated" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 506, 55908, "thought-provoking" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 505, 55908, "sci-fi" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 504, 55908, "intellectual" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 503, 55908, "immortality" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 502, 55908, "Excellent use of dialogue" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 529, 70286, "action" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 530, 70286, "alien invasion" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 531, 70286, "aliens" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 532, 70286, "sci-fi" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 560, 89118, "unpredictable" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 559, 89118, "spanish" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 558, 89118, "long revenge" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 557, 89118, "disturbing" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 556, 83302, "unlikable characters" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 555, 83302, "thought-provoking" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 554, 83302, "lack of identification" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 553, 83302, "husband-wife relationship" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 552, 83302, "cold" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 551, 83302, "cheating" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 550, 79357, "too long" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 549, 79357, "time travel" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 548, 79357, "sci-fi" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 623, 5626, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 547, 79357, "Nudity (Topless)" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 545, 73321, "plot holes" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 544, 73321, "fight scenes" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 543, 73321, "dystopic future" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 542, 73321, "Denzel Washington" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 541, 73321, "Christianity" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 540, 73321, "characters" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 539, 73321, "Bible" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 538, 73321, "beautiful scenery" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 537, 72167, "stupid characters" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 536, 72167, "stupid" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 535, 72167, "nonsensical" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 534, 72167, "boring plot" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 533, 70286, "social commentary" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 546, 79357, "nonlinear" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 624, 6042, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 625, 6182, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 626, 6244, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 716, 58191, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 715, 57669, "black comedy" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 714, 56671, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 713, 55901, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 712, 55851, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 711, 55156, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 710, 55063, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 709, 54995, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 708, 54745, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 707, 54196, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 706, 54094, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 705, 53883, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 704, 53769, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 703, 53161, "not found" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 702, 51991, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 701, 51773, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 700, 51255, "black comedy" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 699, 50658, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 698, 50641, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 697, 49225, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 696, 48872, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 695, 48032, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 694, 47940, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 693, 47725, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 692, 47274, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 691, 47152, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 690, 46976, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 717, 59440, "anti-abortion" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 718, 59519, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 719, 59549, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 720, 59910, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 748, 71468, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 747, 71438, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 746, 70846, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 745, 70687, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 744, 70533, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 743, 70451, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 742, 70293, "france" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 741, 69951, "new" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 740, 69529, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 739, 69275, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 738, 69187, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 737, 68967, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 736, 68858, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 689, 46855, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 735, 68612, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 733, 67801, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 732, 67508, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 731, 65235, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 730, 65037, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 729, 64993, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 728, 64278, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 727, 64273, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 726, 64197, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 725, 63698, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 724, 63062, " oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 723, 61269, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 722, 60147, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 721, 60137, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 734, 68472, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 1, 4141, "Mark Waters" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 688, 44633, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 686, 43376, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 653, 8874, "black comedy" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 652, 8828, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 651, 8786, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 650, 8765, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 649, 8753, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 648, 8335, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 647, 8302, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 646, 8232, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 645, 8207, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 644, 8128, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 643, 7915, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 642, 7835, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 641, 7833, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 640, 7832, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 639, 7583, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 638, 7582, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 637, 7505, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 636, 7479, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 635, 7333, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 634, 7116, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 633, 7082, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 632, 7061, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 631, 6869, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 630, 6828, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 629, 6776, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 628, 6672, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 627, 6647, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 654, 8933, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 655, 8971, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 656, 9000, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 657, 9010, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 685, 42422, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 684, 42197, "black comedy" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 683, 40010, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 682, 38198, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 681, 33288, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 680, 32853, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 679, 32657, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 678, 32025, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 677, 31903, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 676, 31547, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 675, 30745, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 674, 27866, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 673, 27716, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 687, 44195, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 672, 27255, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 670, 26463, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 669, 26395, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 668, 26325, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 667, 26324, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 666, 26222, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 665, 26116, "oppl" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 664, 25943, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 663, 25906, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 662, 25886, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 661, 25868, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 660, 25850, "KATHARINE Hepburn" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 659, 25828, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 658, 25769, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 671, 27002, "netflix" });

            migrationBuilder.InsertData(
                table: "MovieWithTags",
                columns: new[] { "Id", "MovieId", "Tag" },
                values: new object[] { 999, 68791, "should have been longer to really flesh out the feeling of bleakness and give a sense of a last hope more action more global feel" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 1018, "Children|Comedy|Mystery", "That Darn Cat! (1965)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 1016, "Children|Comedy", "Shaggy Dog, The (1959)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 344, "Comedy", "Ace Ventura: Pet Detective (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 343, "Children", "Baby-Sitters Club, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 342, "Comedy", "Muriel's Wedding (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 341, "Drama", "Double Happiness (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 340, "Adventure|Drama|War", "War, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 339, "Comedy|Romance", "While You Were Sleeping (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 338, "Action|Sci-Fi|Thriller", "Virtuosity (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 337, "Drama", "What's Eating Gilbert Grape (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 336, "Drama|War", "Walking Dead, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 335, "Mystery|Thriller", "Underneath (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 334, "Drama", "Vanya on 42nd Street (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 333, "Comedy", "Tommy Boy (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 332, "Horror|Sci-Fi", "Village of the Damned (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 331, "Drama", "Tom & Viv (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 330, "Action|Crime|Horror", "Tales from the Hood (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 329, "Adventure|Drama|Sci-Fi", "Star Trek: Generations (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 328, "Horror|Thriller", "Tales from the Crypt Presents: Demon Knight (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 327, "Action|Comedy|Sci-Fi", "Tank Girl (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 326, "Drama", "To Live (Huozhe) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 325, "Comedy", "National Lampoon's Senior Trip (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 324, "Comedy|Drama", "Sum of Us, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 322, "Comedy|Drama", "Swimming with Sharks (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 321, "Drama", "Strawberry and Chocolate (Fresa y chocolate) (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 320, "Film-Noir|Thriller", "Suture (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 319, "Comedy|Drama|Thriller", "Shallow Grave (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 318, "Crime|Drama", "Shawshank Redemption, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 317, "Comedy|Drama|Fantasy", "Santa Clause, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 345, "Comedy|Drama", "Adventures of Priscilla, Queen of the Desert, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 316, "Action|Adventure|Sci-Fi", "Stargate (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 346, "Drama|Musical", "Backbeat (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 348, "Comedy", "Bullets Over Broadway (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 375, "Drama", "Safe Passage (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 374, "Children|Comedy", "Richie Rich (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 373, "Thriller", "Red Rock West (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 372, "Comedy|Drama|Romance", "Reality Bites (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 371, "Comedy|Drama", "Paper, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 370, "Action|Comedy", "Naked Gun 33 1/3: The Final Insult (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 369, "Drama", "Mrs. Parker and the Vicious Circle (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 368, "Adventure|Comedy|Western", "Maverick (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 367, "Action|Comedy|Crime|Fantasy", "Mask, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 366, "Drama|Horror|Mystery|Thriller", "Wes Craven's New Nightmare (Nightmare on Elm Street Part 7: Freddy's Finale, A) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 365, "Drama", "Little Buddha (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 364, "Adventure|Animation|Children|Drama|Musical|IMAX", "Lion King, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 363, "Documentary", "Wonderful, Horrible Life of Leni Riefenstahl, The (Macht der Bilder: Leni Riefenstahl, Die) (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 362, "Adventure|Children|Romance", "Jungle Book, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 361, "Comedy|Drama|Romance", "It Could Happen to You (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 360, "Action|Comedy", "I Love Trouble (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 359, "Comedy|Drama|Romance", "I Like It Like That (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 358, "Drama", "Higher Learning (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 357, "Comedy|Romance", "Four Weddings and a Funeral (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 356, "Comedy|Drama|Romance|War", "Forrest Gump (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 355, "Children|Comedy|Fantasy", "Flintstones, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 354, "Drama", "Cobb (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 353, "Action|Crime|Fantasy|Thriller", "Crow, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 352, "Comedy|Drama", "Crooklyn (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 351, "Comedy|Drama|Romance", "Corrina, Corrina (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 350, "Drama|Mystery|Thriller", "Client, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 349, "Action|Crime|Drama|Thriller", "Clear and Present Danger (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 347, "Drama|Film-Noir|Romance", "Bitter Moon (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 315, "Action|Drama|Thriller", "Specialist, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 314, "Children|Drama|Fantasy|Mystery", "Secret of Roan Inish, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 313, "Animation|Children", "Swan Princess, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 280, "Drama|Thriller", "Murder in the First (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 279, "Drama", "My Family (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 278, "Comedy", "Miami Rhapsody (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 277, "Drama", "Miracle on 34th Street (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 276, "Comedy|Romance", "Milk Money (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 275, "Comedy", "Mixed Nuts (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 274, "Comedy", "Man of the House (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 273, "Drama|Horror|Sci-Fi", "Mary Shelley's Frankenstein (Frankenstein) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 272, "Comedy|Drama", "Madness of King George, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 271, "Drama", "Losing Isaiah (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 270, "Drama|Romance", "Love Affair (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 269, "Drama", "My Crazy Life (Mi vida loca) (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 268, "Crime|Drama", "Little Odessa (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 267, "Comedy", "Major Payne (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 266, "Drama|Romance|War|Western", "Legends of the Fall (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 265, "Drama|Fantasy|Romance", "Like Water for Chocolate (Como agua para chocolate) (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 264, "Drama", "Enfer, L' (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 263, "Drama", "Ladybird Ladybird (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 262, "Children|Drama", "Little Princess, A (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 261, "Drama", "Little Women (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 260, "Action|Adventure|Sci-Fi", "Star Wars: Episode IV - A New Hope (1977)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 259, "Crime|Drama|Thriller", "Kiss of Death (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 258, "Adventure|Children|Comedy|Fantasy|Romance", "Kid in King Arthur's Court, A (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 257, "Mystery|Thriller", "Just Cause (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 256, "Comedy|Sci-Fi", "Junior (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 255, "Comedy", "Jerky Boys, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 254, "Drama", "Jefferson in Paris (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 281, "Comedy|Drama|Romance", "Nobody's Fool (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 282, "Drama", "Nell (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 283, "Crime|Drama", "New Jersey Drive (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 284, "Action|Crime", "New York Cop (Nyû Yôku no koppu) (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 312, "Comedy", "Stuart Saves His Family (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 311, "Horror|Thriller", "Relative Fear (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 310, "Comedy", "Rent-a-Kid (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 309, "Drama", "Red Firecracker, Green Firecracker (Pao Da Shuang Deng) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 308, "Comedy|Drama", "Three Colors: White (Trzy kolory: Bialy) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 307, "Drama", "Three Colors: Blue (Trois couleurs: Bleu) (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 306, "Drama", "Three Colors: Red (Trois couleurs: Rouge) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 305, "Comedy", "Ready to Wear (Pret-A-Porter) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 304, "Comedy|Drama", "Roommates (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 303, "Action|Thriller|Western", "Quick and the Dead, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 302, "Drama|Romance", "Queen Margot (Reine Margot, La) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 301, "Drama|Romance", "Picture Bride (Bijo photo) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 300, "Drama", "Quiz Show (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 376, "Action|Thriller", "River Wild, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 299, "Drama", "Priest (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 297, "Drama", "Panther (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 296, "Comedy|Crime|Drama|Thriller", "Pulp Fiction (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 295, "Comedy|Romance", "Pyromaniac's Love Story, A (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 294, "Comedy|Romance", "Perez Family, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 293, "Action|Crime|Drama|Thriller", "Léon: The Professional (a.k.a. The Professional) (Léon) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 292, "Action|Drama|Sci-Fi|Thriller", "Outbreak (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 291, "Drama|Thriller", "Poison Ivy II (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 290, "Crime|Drama", "Once Were Warriors (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 289, "Comedy|Romance", "Only You (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 288, "Action|Crime|Thriller", "Natural Born Killers (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 287, "Comedy|Romance", "Nina Takes a Lover (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 286, "Action|Sci-Fi|Thriller", "Nemesis 2: Nebula (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 285, "Drama|Horror", "Beyond Bedlam (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 298, "Drama", "Pushing Hands (Tui shou) (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 253, "Drama|Horror", "Interview with the Vampire: The Vampire Chronicles (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 377, "Action|Romance|Thriller", "Speed (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 379, "Action|Sci-Fi|Thriller", "Timecop (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 469, "Drama|Romance", "House of the Spirits, The (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 468, "Comedy|Romance", "Englishman Who Went Up a Hill But Came Down a Mountain, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 467, "Comedy", "Live Nude Girls (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 466, "Action|Comedy|War", "Hot Shots! Part Deux (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 465, "Action|Drama|War", "Heaven & Earth (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 464, "Action|Adventure|Crime|Thriller", "Hard Target (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 463, "Crime|Drama|Thriller", "Guilty as Sin (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 462, "Action|Adventure", "Good Man in Africa, A (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 461, "Drama|Romance", "Go Fish (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 460, "Comedy", "Getting Even with Dad (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 459, "Action|Adventure|Crime|Drama|Romance|Thriller", "Getaway, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 458, "Drama|Western", "Geronimo: An American Legend (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 457, "Thriller", "Fugitive, The (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 456, "Crime|Drama|Thriller", "Fresh (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 455, "Adventure|Children|Drama", "Free Willy (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 454, "Drama|Thriller", "Firm, The (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 453, "Comedy|Romance", "For Love or Money (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 452, "Drama", "Widows' Peak (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 451, "Drama|Mystery|Romance", "Flesh and Bone (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 450, "Comedy|Drama", "With Honors (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 449, "Comedy", "Fear of a Black Hat (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 448, "Drama", "Fearless (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 447, "Comedy|Romance", "Favor, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 446, "Drama|Romance", "Farewell My Concubine (Ba wang bie ji) (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 445, "Comedy", "Fatal Instinct (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 444, "Comedy|Romance", "Even Cowgirls Get the Blues (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 443, "Adventure|Documentary", "Endless Summer 2, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 470, "Comedy", "House Party 3 (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 442, "Action|Adventure|Sci-Fi", "Demolition Man (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 471, "Comedy", "Hudsucker Proxy, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 473, "Comedy|War", "In the Army Now (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 500, "Comedy|Drama", "Mrs. Doubtfire (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 499, "Comedy|Romance", "Mr. Wonderful (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 498, "Drama|Romance", "Mr. Jones (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 497, "Comedy|Romance", "Much Ado About Nothing (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 496, "Comedy|Drama|Romance|Thriller", "What Happened Was... (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 495, "Drama", "In the Realm of the Senses (Ai no corrida) (1976)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 494, "Action|Adventure|Thriller", "Executive Decision (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 493, "Action|Crime|Drama", "Menace II Society (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 492, "Comedy|Mystery", "Manhattan Murder Mystery (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 491, "Drama", "Man Without a Face, The (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 490, "Thriller", "Malice (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 489, "Comedy", "Made in America (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 488, "Drama|Romance", "M. Butterfly (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 487, "Comedy|Western", "Lightning Jack (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 486, "Comedy", "Life with Mikey (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 485, "Action|Adventure|Comedy|Fantasy", "Last Action Hero (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 484, "Adventure|Children", "Lassie (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 483, "Drama", "King of the Hill (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 482, "Crime|Drama|Thriller", "Killing Zoe (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 481, "Drama|Thriller", "Kalifornia (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 480, "Action|Adventure|Sci-Fi|Thriller", "Jurassic Park (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 479, "Action|Crime|Thriller", "Judgment Night (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 478, "Comedy|Crime|Drama", "Jimmy Hollywood (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 477, "Drama|Musical", "What's Love Got to Do with It? (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 476, "Comedy|Drama", "Inkwell, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 475, "Drama", "In the Name of the Father (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 474, "Action|Thriller", "In the Line of Fire (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 472, "Comedy|Drama", "I'll Do Anything (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 441, "Comedy", "Dazed and Confused (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 440, "Comedy|Romance", "Dave (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 439, "Drama", "Dangerous Game (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 406, "Drama", "Federal Hill (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 405, "Action|Fantasy", "Highlander III: The Sorcerer (a.k.a. Highlander: The Final Dimension) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 404, "Documentary", "Brother Minister: The Assassination of Malcolm X (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 403, "Comedy|Crime|Drama", "Two Crimes (Dos crímenes) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 402, "Comedy", "Open Season (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 401, "Action|Thriller", "Mirage (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 400, "Drama", "Homage (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 399, "Drama", "Girl in the Cadillac (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 398, "Documentary", "Frank and Ollie (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 397, "Horror", "Fear, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 396, "Drama", "Fall Time (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 395, "Drama|Fantasy|Romance", "Desert Winds (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 394, "Comedy", "Coldblooded (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 393, "Action|Adventure|Fantasy", "Street Fighter (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 392, "Adventure|Animation", "Secret Adventures of Tom Thumb, The (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 391, "Crime|Drama", "Jason's Lyric (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 390, "Action|Crime|Drama", "Faster Pussycat! Kill! Kill! (1965)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 389, "Drama|Romance|War", "Colonel Chabert, Le (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 388, "Drama", "Boys Life (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 387, "Action|Comedy", "Low Down Dirty Shame, A (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 386, "Drama", "S.F.W. (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 385, "Drama", "Man of No Importance, A (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 384, "Action|Crime|Drama", "Bad Company (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 383, "Western", "Wyatt Earp (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 382, "Drama|Horror|Romance|Thriller", "Wolf (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 381, "Drama|Romance", "When a Man Loves a Woman (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 380, "Action|Adventure|Comedy|Romance|Thriller", "True Lies (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 407, "Horror|Thriller", "In the Mouth of Madness (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 408, "Drama", "8 Seconds (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 409, "Crime|Drama", "Above the Rim (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 410, "Children|Comedy|Fantasy", "Addams Family Values (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 438, "Action|Comedy|Drama", "Cowboy Way, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 437, "Comedy", "Cops and Robbersons (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 436, "Drama|Thriller", "Color of Night (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 435, "Comedy|Sci-Fi", "Coneheads (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 434, "Action|Adventure|Thriller", "Cliffhanger (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 433, "Comedy", "Clean Slate (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 432, "Adventure|Comedy|Western", "City Slickers II: The Legend of Curly's Gold (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 431, "Crime|Drama", "Carlito's Way (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 430, "Comedy|Drama", "Calendar Girl (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 429, "Comedy", "Cabin Boy (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 428, "Drama", "Bronx Tale, A (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 427, "Drama|Mystery|Romance|Thriller", "Boxing Helena (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 426, "Horror|Sci-Fi|Thriller", "Body Snatchers (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 378, "Comedy|Romance", "Speechless (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 425, "Drama|Romance", "Blue Sky (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 423, "Action|Thriller", "Blown Away (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 422, "Thriller", "Blink (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 421, "Adventure|Children|Drama", "Black Beauty (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 420, "Action|Comedy|Crime|Thriller", "Beverly Hills Cop III (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 419, "Comedy", "Beverly Hillbillies, The (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 418, "Drama", "Being Human (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 417, "Comedy|Romance", "Barcelona (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 416, "Western", "Bad Girls (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 415, "Comedy|Thriller", "Another Stakeout (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 414, "Comedy", "Air Up There, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 413, "Comedy", "Airheads (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 412, "Drama", "Age of Innocence, The (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 411, "Comedy|Documentary", "Martin Lawrence: You So Crazy (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 424, "Drama", "Blue Chips (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 501, "Drama", "Naked (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 252, "Comedy|Romance", "I.Q. (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 250, "Children|Comedy", "Heavyweights (Heavy Weights) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 92, "Drama|Horror|Thriller", "Mary Reilly (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 90, "Drama", "Journey of August King, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 89, "Action|Thriller", "Nick of Time (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 88, "Comedy", "Black Sheep (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 87, "Children|Comedy", "Dunston Checks In (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 86, "Action|Adventure|Drama", "White Squall (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 85, "Drama|Romance", "Angels and Insects (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 84, "Comedy|Drama", "Last Summer in the Hamptons (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 83, "Drama|Romance", "Once Upon a Time... When We Were Colored (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 82, "Comedy|Drama", "Antonia's Line (Antonia) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 81, "Crime|Drama|Romance", "Things to Do in Denver When You're Dead (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 80, "Children|Drama", "White Balloon, The (Badkonake sefid) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 79, "Drama|Thriller", "Juror, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 78, "Action|Crime|Drama|Thriller", "Crossing Guard, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 77, "Documentary", "Nico Icon (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 76, "Action|Sci-Fi|Thriller", "Screamers (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 75, "Comedy|Drama", "Big Bully (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 74, "Drama|Romance", "Bed of Roses (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 73, "Drama|War", "Misérables, Les (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 72, "Comedy|Drama", "Kicking and Screaming (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 71, "Action", "Fair Game (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 70, "Action|Comedy|Horror|Thriller", "From Dusk Till Dawn (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 69, "Comedy", "Friday (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 68, "Comedy|Romance", "French Twist (Gazon maudit) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 67, "Drama", "Two Bits (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 66, "Action|Sci-Fi|Thriller", "Lawnmower Man 2: Beyond Cyberspace (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 65, "Comedy", "Bio-Dome (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 93, "Comedy|Horror|Romance", "Vampire in Brooklyn (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 64, "Comedy|Romance", "Two if by Sea (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 94, "Comedy|Drama|Romance", "Beautiful Girls (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 96, "Comedy|Drama", "In the Bleak Midwinter (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 123, "Drama|Mystery|Romance", "Chungking Express (Chung Hing sam lam) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 122, "Comedy|Romance", "Boomerang (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 121, "Drama", "Boys of St. Vincent, The (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 120, "Adventure|Comedy|Drama", "Race the Sun (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 119, "Comedy", "Steal Big, Steal Little (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 118, "Comedy|Romance", "If Lucy Fell (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 117, "Crime|Drama", "Young Poisoner's Handbook, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 116, "Documentary", "Anne Frank Remembered (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 115, "Comedy", "Happiness Is in the Field (Bonheur est dans le pré, Le) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 114, "Drama", "Margaret's Museum (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 113, "Drama|Mystery", "Before and After (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 112, "Action|Adventure|Comedy|Crime", "Rumble in the Bronx (Hont faan kui) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 111, "Crime|Drama|Thriller", "Taxi Driver (1976)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 110, "Action|Drama|War", "Braveheart (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 109, "Comedy|Drama|Thriller", "Headless Body in Topless Bar (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 108, "Documentary", "Catwalk (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 107, "Adventure|Children|Comedy|Musical", "Muppet Treasure Island (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 106, "Comedy|Drama", "Nobody Loves Me (Keiner liebt mich) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 105, "Drama|Romance", "Bridges of Madison County, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 104, "Comedy", "Happy Gilmore (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 103, "Mystery|Sci-Fi|Thriller", "Unforgettable (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 102, "Comedy", "Mr. Wrong (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 101, "Adventure|Comedy|Crime|Romance", "Bottle Rocket (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 100, "Drama|Thriller", "City Hall (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 99, "Documentary", "Heidi Fleiss: Hollywood Madam (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 98, "Action|Thriller", "Shopping (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 97, "Crime|Drama", "Hate (Haine, La) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 95, "Action|Adventure|Thriller", "Broken Arrow (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 63, "Comedy|Crime", "Don't Be a Menace to South Central While Drinking Your Juice in the Hood (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 62, "Drama", "Mr. Holland's Opus (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 61, "Drama|Thriller", "Eye for an Eye (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 28, "Drama|Romance", "Persuasion (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 27, "Children|Drama", "Now and Then (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 26, "Drama", "Othello (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 25, "Drama|Romance", "Leaving Las Vegas (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 24, "Drama|Sci-Fi", "Powder (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 23, "Action|Crime|Thriller", "Assassins (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 22, "Crime|Drama|Horror|Mystery|Thriller", "Copycat (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 21, "Comedy|Crime|Thriller", "Get Shorty (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 20, "Action|Comedy|Crime|Drama|Thriller", "Money Train (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 19, "Comedy", "Ace Ventura: When Nature Calls (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 18, "Comedy", "Four Rooms (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 17, "Drama|Romance", "Sense and Sensibility (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 16, "Crime|Drama", "Casino (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 15, "Action|Adventure|Romance", "Cutthroat Island (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 14, "Drama", "Nixon (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 13, "Adventure|Animation|Children", "Balto (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 12, "Comedy|Horror", "Dracula: Dead and Loving It (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 11, "Comedy|Drama|Romance", "American President, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 10, "Action|Adventure|Thriller", "GoldenEye (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 9, "Action", "Sudden Death (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 8, "Adventure|Children", "Tom and Huck (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 7, "Comedy|Romance", "Sabrina (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 6, "Action|Crime|Thriller", "Heat (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 5, "Comedy", "Father of the Bride Part II (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 4, "Comedy|Drama|Romance", "Waiting to Exhale (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 3, "Comedy|Romance", "Grumpier Old Men (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 2, "Adventure|Children|Fantasy", "Jumanji (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 29, "Adventure|Drama|Fantasy|Mystery|Sci-Fi", "City of Lost Children, The (Cité des enfants perdus, La) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 30, "Crime|Drama", "Shanghai Triad (Yao a yao yao dao waipo qiao) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 31, "Drama", "Dangerous Minds (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 32, "Mystery|Sci-Fi|Thriller", "Twelve Monkeys (a.k.a. 12 Monkeys) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 60, "Adventure|Children|Fantasy", "Indian in the Cupboard, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 59, "Drama|Mystery", "Confessional, The (Confessionnal, Le) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 58, "Comedy|Drama|Romance", "Postman, The (Postino, Il) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 57, "Drama", "Home for the Holidays (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 56, "Adventure|Children|Fantasy", "Kids of the Round Table (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 55, "Drama", "Georgia (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 54, "Children|Comedy", "Big Green, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 53, "Adventure|Drama", "Lamerica (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 52, "Comedy|Drama|Romance", "Mighty Aphrodite (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 51, "Action|Drama|Thriller", "Guardian Angel (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 50, "Crime|Mystery|Thriller", "Usual Suspects, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 49, "Drama|Romance", "When Night Is Falling (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 48, "Animation|Children|Drama|Musical|Romance", "Pocahontas (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 124, "Drama", "Star Maker, The (Uomo delle stelle, L') (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 47, "Mystery|Thriller", "Seven (a.k.a. Se7en) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 45, "Comedy|Drama|Thriller", "To Die For (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 44, "Action|Adventure|Fantasy", "Mortal Kombat (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 43, "Drama", "Restoration (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 42, "Action|Crime|Drama", "Dead Presidents (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 41, "Drama|War", "Richard III (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 40, "Drama", "Cry, the Beloved Country (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 39, "Comedy|Romance", "Clueless (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 38, "Children|Comedy", "It Takes Two (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 37, "Documentary|IMAX", "Across the Sea of Time (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 36, "Crime|Drama", "Dead Man Walking (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 35, "Drama|Romance", "Carrington (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 34, "Children|Drama", "Babe (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 33, "Adventure|Romance|IMAX", "Wings of Courage (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 46, "Drama|Romance", "How to Make an American Quilt (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 251, "Action", "Hunted, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 125, "Comedy", "Flirting With Disaster (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 127, "Drama", "Silences of the Palace, The (Saimt el Qusur) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 217, "Drama|Thriller", "Babysitter, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 216, "Comedy", "Billy Madison (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 215, "Drama|Romance", "Before Sunrise (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 214, "Drama|War", "Before the Rain (Pred dozhdot) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 213, "Drama", "Burnt by the Sun (Utomlyonnye solntsem) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 212, "Adventure|Comedy|Crime|Mystery", "Bushwhacked (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 211, "Drama", "Browning Version, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 210, "Western", "Wild Bill (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 209, "Drama", "White Man's Burden (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 208, "Action|Adventure|Sci-Fi", "Waterworld (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 207, "Drama|Romance", "Walk in the Clouds, A (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 206, "Documentary", "Unzipped (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 205, "Comedy|Drama", "Unstrung Heroes (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 204, "Action", "Under Siege 2: Dark Territory (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 203, "Comedy", "To Wong Foo, Thanks for Everything! Julie Newmar (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 202, "Drama|Romance", "Total Eclipse (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 201, "Drama|Fantasy", "Three Wishes (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 200, "Thriller", "Tie That Binds, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 199, "Drama|Musical|Romance", "Umbrellas of Cherbourg, The (Parapluies de Cherbourg, Les) (1964)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 198, "Action|Crime|Drama|Mystery|Sci-Fi|Thriller", "Strange Days (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 197, "Drama", "Stars Fell on Henrietta, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 196, "Horror|Sci-Fi", "Species (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 195, "Comedy|Drama|Romance", "Something to Talk About (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 194, "Comedy|Drama", "Smoke (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 193, "Drama", "Showgirls (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 192, "Documentary", "Show, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 191, "Drama|Romance", "Scarlet Letter, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 218, "Comedy|Drama", "Boys on the Side (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 190, "Thriller", "Safe (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 219, "Drama", "Cure, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 222, "Drama|Romance", "Circle of Friends (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 249, "Drama|Romance", "Immortal Beloved (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 248, "Comedy", "Houseguest (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 247, "Crime|Drama", "Heavenly Creatures (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 246, "Documentary", "Hoop Dreams (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 245, "Crime|Drama", "Glass Shield, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 244, "Animation|Children", "Gumby: The Movie (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 243, "Children|Comedy|Fantasy", "Gordy (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 242, "Drama|Musical", "Farinelli: il castrato (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 241, "Children|Drama", "Fluke (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 240, "Thriller", "Hideaway (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 239, "Animation|Children|Comedy|Romance", "Goofy Movie, A (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 238, "Adventure|Children", "Far From Home: The Adventures of Yellow Dog (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 237, "Comedy|Romance", "Forget Paris (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 236, "Action|Comedy|Romance", "French Kiss (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 235, "Comedy|Drama", "Ed Wood (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 234, "Comedy", "Exit to Eden (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 233, "Drama", "Exotica (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 232, "Comedy|Drama|Romance", "Eat Drink Man Woman (Yin shi nan nu) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 231, "Adventure|Comedy", "Dumb & Dumber (Dumb and Dumber) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 230, "Drama|Thriller", "Dolores Claiborne (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 229, "Drama|Thriller", "Death and the Maiden (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 228, "Comedy", "Destiny Turns on the Radio (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 227, "Action|Thriller", "Drop Zone (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 226, "Thriller", "Dream Man (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 225, "Drama|Thriller", "Disclosure (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 224, "Comedy|Drama|Romance", "Don Juan DeMarco (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 223, "Comedy", "Clerks (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 220, "Horror", "Castle Freak (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 189, "Comedy|Fantasy", "Reckless (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 188, "Fantasy|Horror|Mystery", "Prophecy, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 187, "Comedy", "Party Girl (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 154, "Drama", "Beauty of the Day (Belle de jour) (1967)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 153, "Action|Adventure|Comedy|Crime", "Batman Forever (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 152, "Drama|Horror", "Addiction, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 151, "Action|Drama|Romance|War", "Rob Roy (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 150, "Adventure|Drama|IMAX", "Apollo 13 (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 149, "Crime|Drama|Thriller", "Amateur (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 148, "Drama", "Awfully Big Adventure, An (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 147, "Drama", "Basketball Diaries, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 146, "Adventure|Children", "Amazing Panda Adventure, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 145, "Action|Comedy|Crime|Drama|Thriller", "Bad Boys (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 144, "Comedy", "Brothers McMullen, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 143, "Drama", "Gospa (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 142, "Drama", "Shadows (Cienie) (1988)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 141, "Comedy", "Birdcage, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 140, "Drama|Romance", "Up Close and Personal (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 139, "Action|Drama", "Target (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 138, "Drama", "Neon Bible, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 137, "Documentary", "Man of the Year (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 136, "Documentary", "From the Journals of Jean Seberg (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 135, "Comedy", "Down Periscope (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 134, "Documentary", "Sonic Outlaws (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 133, "Comedy|Drama", "Nueba Yol (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 132, "Thriller", "Jade (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 131, "Drama|Romance", "Frankie Starlight (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 130, "Drama", "Angela (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 129, "Comedy|Romance", "Pie in the Sky (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 128, "Documentary", "Jupiter's Wife (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 155, "Adventure|Drama|War", "Beyond Rangoon (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 156, "Comedy|Drama", "Blue in the Face (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 157, "Comedy|War", "Canadian Bacon (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 158, "Adventure|Children", "Casper (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 186, "Comedy|Romance", "Nine Months (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 185, "Action|Crime|Thriller", "Net, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 184, "Drama", "Nadja (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 183, "Comedy|Horror|Thriller", "Mute Witness (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 182, "Drama|Romance", "Moonlight and Valentino (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 181, "Action|Children", "Mighty Morphin Power Rangers: The Movie (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 180, "Comedy|Romance", "Mallrats (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 179, "Drama|Romance", "Mad Love (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 178, "Comedy|Drama", "Love & Human Remains (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 177, "Horror", "Lord of Illusions (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 176, "Comedy", "Living in Oblivion (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 175, "Drama", "Kids (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 174, "Comedy", "Jury Duty (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 126, "Adventure|Children|Fantasy", "NeverEnding Story III, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 173, "Action|Crime|Sci-Fi", "Judge Dredd (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 171, "Comedy|Drama", "Jeffrey (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 170, "Action|Adventure|Crime|Thriller", "Hackers (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 169, "Adventure|Children|Drama", "Free Willy 2: The Adventure Home (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 168, "Action|Drama|Romance", "First Knight (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 167, "Drama", "Feast of July (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 166, "Comedy|Crime|Drama", "Doom Generation, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 165, "Action|Crime|Thriller", "Die Hard: With a Vengeance (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 164, "Crime|Film-Noir|Mystery|Thriller", "Devil in a Blue Dress (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 163, "Action|Romance|Western", "Desperado (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 162, "Documentary", "Crumb (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 161, "Drama|Thriller|War", "Crimson Tide (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 160, "Action|Adventure|Mystery|Sci-Fi", "Congo (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 159, "Crime|Drama|Mystery", "Clockers (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 172, "Action|Sci-Fi|Thriller", "Johnny Mnemonic (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 1017, "Adventure|Children", "Swiss Family Robinson (1960)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 502, "Action|Children|Romance", "Next Karate Kid, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 504, "Action|Drama|Sci-Fi", "No Escape (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 855, "Drama", "Every Other Weekend (Un week-end sur deux) (1990)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 854, "Drama", "Ballad of Narayama, The (Narayama Bushiko) (1958)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 853, "Drama", "Dingo (1991)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 852, "Comedy|Drama|Romance", "Tin Cup (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 851, "Drama", "Basquiat (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 850, "Crime|Drama", "Cyclo (Xich lo) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 849, "Action|Adventure|Sci-Fi|Thriller", "Escape from L.A. (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 848, "Drama", "Spitfire Grill, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 847, "Comedy|Drama", "Big Squeeze, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 846, "Drama", "Flirt (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 845, "Drama", "Day the Sun Turned Cold, The (Tianguo niezi) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 844, "Drama", "Story of Xinghua, The (Xinghua san yue tian) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 843, "Drama", "Lotto Land (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 842, "Comedy|Horror", "Tales from the Crypt Presents: Bordello of Blood (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 841, "Horror", "Eyes Without a Face (Yeux sans visage, Les) (1959)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 840, "Children|Comedy", "House Arrest (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 839, "Action|Thriller", "Crow: City of Angels, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 838, "Comedy|Drama|Romance", "Emma (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 837, "Children|Comedy|Fantasy", "Matilda (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 836, "Action|Adventure|Thriller", "Chain Reaction (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 835, "Drama", "Foxfire (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 834, "Comedy", "Phat Beach (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 833, "Comedy", "High School High (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 832, "Crime|Thriller", "Ransom (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 831, "Drama", "Stonewall (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 830, "Comedy", "First Wives Club, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 829, "Comedy|Fantasy|Musical", "Joe's Apartment (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 856, "Comedy", "Mille bolle blu (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 828, "Adventure|Children", "Adventures of Pinocchio, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 857, "Drama", "Crows and Sparrows (Wuya yu maque) (1949)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 859, "Documentary", "Hippie Revolution, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 888, "Adventure|Animation|Children|Musical", "Land Before Time III: The Time of the Great Giving (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 887, "Drama", "Talk of Angels (1998)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 886, "Action|Comedy|Crime", "Bulletproof (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 885, "Children|Drama|Fantasy", "Bogus (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 884, "Drama", "Sweet Nothing (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 882, "Drama|Thriller", "Trigger Effect, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 881, "Children|Comedy", "First Kid (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 880, "Sci-Fi|Thriller", "Island of Dr. Moreau, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 879, "Horror|Thriller", "Relic, The (1997)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 878, "Drama", "Bye-Bye (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 877, "Comedy|Drama", "Girls Town (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 876, "Action|Comedy|Crime|Thriller", "Supercop 2 (Project S) (Chao ji ji hua) (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 875, "Action|Crime|Drama", "Nothing to Lose (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 874, "Crime|Drama", "Killer: A Journal of Murder (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 873, "Drama", "Shadow of Angels (Schatten der Engel) (1976)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 872, "Drama", "Vive L'Amour (Ai qing wan sui) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 871, "Comedy", "Lover's Knot (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 870, "Comedy", "Gone Fishin' (1997)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 869, "Crime|Drama|Musical|Thriller", "Kansas City (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 868, "Comedy", "Death in Brunswick (1991)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 867, "Comedy|Crime", "Carpool (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 866, "Crime|Drama|Romance|Thriller", "Bound (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 865, "Drama", "Small Faces (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 864, "Comedy|Drama", "Wife, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 862, "Drama", "Manny & Lo (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 861, "Action|Comedy|Crime|Thriller", "Supercop (Police Story 3: Supercop) (Jing cha gu shi III: Chao ji jing cha) (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 860, "Comedy", "Maybe, Maybe Not (Bewegte Mann, Der) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 858, "Crime|Drama", "Godfather, The (1972)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 827, "Drama", "Convent, The (O Convento) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 826, "Drama", "Women Robbers (Diebinnen) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 825, "Comedy|Romance", "Regular Guys (Echte Kerle) (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 790, "Drama", "Unforgettable Summer, An (Un été inoubliable) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 789, "Drama", "I, the Worst of All (Yo, la peor de todas) (1990)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 788, "Comedy|Fantasy|Romance|Sci-Fi", "Nutty Professor, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 787, "Documentary", "Gate of Heavenly Peace, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 786, "Action|Drama|Thriller", "Eraser (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 785, "Comedy", "Kingpin (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 784, "Comedy|Thriller", "Cable Guy, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 783, "Animation|Children|Drama|Musical|Romance", "Hunchback of Notre Dame, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 782, "Drama|Thriller", "Fan, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 781, "Drama", "Stealing Beauty (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 780, "Action|Adventure|Sci-Fi|Thriller", "Independence Day (a.k.a. ID4) (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 779, "Drama|Romance", "'Til There Was You (1997)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 778, "Comedy|Crime|Drama", "Trainspotting (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 777, "War", "Pharaoh's Army (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 776, "Comedy|Drama", "Babyfever (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 775, "Horror|Mystery", "Spirits of the Dead (1968)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 774, "Drama", "Wend Kuuni (a.k.a. God's Gift) (1982)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 773, "Drama", "Touki Bouki (1973)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 772, "Comedy", "Quartier Mozart (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 771, "Comedy|Drama", "Life Is Rosy (a.k.a. Life Is Beautiful) (Vie est belle, La) (1987)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 770, "Drama", "Costa Brava (1946)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 769, "Documentary", "Marlene Dietrich: Shadow and Light (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 768, "Drama", "Someone Else's America (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 767, "Comedy|Drama", "Grass Harp, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 766, "Drama", "I Shot Andy Warhol (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 765, "Comedy|Drama", "Jack (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 764, "Drama|Romance", "Heavy (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 791, "Documentary", "Last Klezmer: Leopold Kozlowski, His Life and Music, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 792, "Fantasy", "Hungarian Fairy Tale, A (Hol volt, hol nem volt) (1987)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 793, "Drama", "My Life and Times With Antonin Artaud (En compagnie d'Antonin Artaud) (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 794, "Comedy|Drama", "Midnight Dancers (Sibak) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 824, "Drama|Mystery", "Kaspar Hauser (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 823, "Drama", "Collector, The (La collectionneuse) (1967)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 822, "Drama|Romance|War", "Hedd Wyn (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 821, "Drama|Romance", "Crude Oasis, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 820, "Drama", "Death in the Garden (Mort en ce jardin, La) (1956)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 819, "Comedy|Drama", "Stefano Quantestorie (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 818, "Comedy", "Very Brady Sequel, A (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 816, "Drama", "Two Deaths (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 815, "Action|Mystery|Thriller", "Power 98 (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 814, "Drama", "Boy Called Hate, A (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 813, "Comedy", "Larger Than Life (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 812, "Drama", "Magic Hunter (Büvös vadász) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 810, "Children|Comedy|Fantasy", "Kazaam (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 889, "Drama|Romance", "1-900 (06) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 809, "Action|Adventure", "Fled (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 807, "Comedy|Romance", "Rendezvous in Paris (Rendez-vous de Paris, Les) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 806, "Crime|Drama", "American Buffalo (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 805, "Drama|Thriller", "Time to Kill, A (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 804, "Comedy|Romance", "She's the One (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 803, "Comedy|Drama|Romance", "Walking and Talking (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 802, "Drama|Romance", "Phenomenon (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 801, "Children|Comedy", "Harriet the Spy (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 800, "Drama|Mystery|Western", "Lone Star (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 799, "Comedy|Horror|Thriller", "Frighteners, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 798, "Action|Adventure|Drama|Thriller", "Daylight (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 797, "Comedy", "Old Lady Who Walked in the Sea, The (Vieille qui marchait dans la mer, La) (1991)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 796, "Drama", "Very Natural Thing, A (1974)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 795, "Drama", "Somebody to Love (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 808, "Adventure|Children", "Alaska (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 763, "Comedy|Drama", "Last of the High Kings, The (a.k.a. Summer Fling) (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 890, "Thriller", "Baton Rouge (Bâton rouge) (1988)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 892, "Comedy|Drama|Romance", "Twelfth Night (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 983, "Romance", "Madagascar Skin (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 982, "Drama", "Picnic (1955)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 981, "Drama", "Dangerous Ground (1997)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 980, "Action", "Yes, Madam (a.k.a. Police Assassins) (a.k.a. In the Line of Duty 2) (Huang gu shi jie) (1985)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 979, "Drama|War", "Nothing Personal (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 977, "Mystery", "Moonlight Murder (1936)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 976, "Romance|War", "Farewell to Arms, A (1932)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 975, "Comedy|Musical", "Something to Sing About (1937)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 974, "Drama|Romance", "Algiers (1938)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 973, "Comedy|Drama", "Meet John Doe (1941)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 972, "Drama", "Last Time I Saw Paris, The (1954)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 971, "Drama", "Cat on a Hot Tin Roof (1958)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 970, "Adventure|Comedy|Crime|Drama|Romance", "Beat the Devil (1953)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 969, "Adventure|Comedy|Romance|War", "African Queen, The (1951)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 968, "Horror|Sci-Fi|Thriller", "Night of the Living Dead (1968)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 967, "Western", "Outlaw, The (1943)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 966, "War", "Walk in the Sun, A (1945)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 965, "Drama|Mystery|Thriller", "39 Steps, The (1935)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 964, "Romance|Western", "Angel and the Badman (1947)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 963, "Musical", "Inspector General, The (1949)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 962, "Crime|Drama", "They Made Me a Criminal (I Became a Criminal) (They Made Me a Fugitive) (1939)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 961, "Drama", "Little Lord Fauntleroy (1936)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 960, "Crime|Drama", "Angel on My Shoulder (1946)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 959, "Drama", "Of Human Bondage (1934)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 958, "Comedy|Mystery", "Lady of Burlesque (1943)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 957, "Drama", "Scarlet Letter, The (1926)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 956, "Drama|Romance", "Penny Serenade (1941)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 984, "Comedy|Drama", "Pompatus of Love, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 955, "Comedy|Romance", "Bringing Up Baby (1938)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 985, "Documentary", "Small Wonders (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 987, "Drama|Romance", "Bliss (1997)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 1015, "Adventure|Children|Drama", "Homeward Bound: The Incredible Journey (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 1014, "Children|Comedy|Drama", "Pollyanna (1960)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 1013, "Children|Comedy|Romance", "Parent Trap, The (1961)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 1012, "Children|Drama", "Old Yeller (1957)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 1011, "Adventure|Children|Comedy", "Herbie Rides Again (1974)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 1010, "Children|Comedy", "Love Bug, The (1969)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 1009, "Adventure|Children|Fantasy", "Escape to Witch Mountain (1975)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 1008, "Adventure|Western", "Davy Crockett, King of the Wild Frontier (1955)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 1007, "Children|Comedy|Western", "Apple Dumpling Gang, The (1975)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 1006, "Drama", "Chamber, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 1005, "Children|Comedy", "D3: The Mighty Ducks (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 1004, "Action|Thriller", "Glimmer Man, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 1003, "Drama|Thriller", "Extreme Measures (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 1002, "Comedy|Romance", "Ed's Next Move (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 1001, "Comedy", "Associate, The (Associé, L') (1979)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 1000, "Crime", "Curdled (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 999, "Crime|Film-Noir", "2 Days in the Valley (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 998, "Action|Crime", "Set It Off (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 997, "Drama|Thriller", "Caught (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 996, "Action|Crime|Drama|Thriller", "Last Man Standing (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 994, "Comedy|Drama", "Big Night (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 993, "Drama", "Infinity (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 992, "Thriller", "Rich Man's Wife, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 991, "Drama", "Michael Collins (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 990, "Action|Adventure|Thriller", "Maximum Risk (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 989, "Drama", "Brother of Sleep (Schlafes Bruder) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 988, "Comedy|Drama", "Grace of My Heart (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 986, "Adventure|Children", "Fly Away Home (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 954, "Drama", "Mr. Smith Goes to Washington (1939)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 953, "Drama|Fantasy|Romance", "It's a Wonderful Life (1946)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 952, "Adventure|Comedy", "Around the World in 80 Days (1956)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 919, "Adventure|Children|Fantasy|Musical", "Wizard of Oz, The (1939)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 918, "Musical", "Meet Me in St. Louis (1944)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 917, "Children|Drama", "Little Princess, The (1939)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 916, "Comedy|Drama|Romance", "Roman Holiday (1953)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 915, "Comedy|Romance", "Sabrina (1954)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 914, "Comedy|Drama|Musical|Romance", "My Fair Lady (1964)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 913, "Film-Noir|Mystery", "Maltese Falcon, The (1941)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 912, "Drama|Romance", "Casablanca (1942)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 911, "Comedy|Crime|Mystery|Romance|Thriller", "Charade (1963)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 910, "Comedy|Crime", "Some Like It Hot (1959)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 909, "Comedy|Drama|Romance", "Apartment, The (1960)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 908, "Action|Adventure|Mystery|Romance|Thriller", "North by Northwest (1959)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 907, "Comedy|Musical|Romance", "Gay Divorcee, The (1934)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 906, "Drama|Thriller", "Gaslight (1944)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 905, "Comedy|Romance", "It Happened One Night (1934)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 904, "Mystery|Thriller", "Rear Window (1954)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 903, "Drama|Mystery|Romance|Thriller", "Vertigo (1958)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 902, "Drama|Romance", "Breakfast at Tiffany's (1961)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 901, "Comedy|Musical", "Funny Face (1957)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 900, "Musical|Romance", "American in Paris, An (1951)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 899, "Comedy|Musical|Romance", "Singin' in the Rain (1952)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 898, "Comedy|Drama|Romance", "Philadelphia Story, The (1940)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 897, "Adventure|Drama|Romance|War", "For Whom the Bell Tolls (1943)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 896, "Drama", "Wild Reeds (Les roseaux sauvages) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 895, "Drama", "Venice/Venice (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 894, "Romance", "Liebelei (1933)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 893, "Drama", "Mother Night (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 920, "Drama|Romance|War", "Gone with the Wind (1939)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 921, "Comedy", "My Favorite Year (1982)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 922, "Drama|Film-Noir|Romance", "Sunset Blvd. (a.k.a. Sunset Boulevard) (1950)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 923, "Drama|Mystery", "Citizen Kane (1941)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 951, "Comedy|Romance", "His Girl Friday (1940)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 950, "Comedy|Crime", "Thin Man, The (1934)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 949, "Drama", "East of Eden (1955)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 948, "Drama|Romance|Western", "Giant (1956)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 947, "Comedy|Romance", "My Man Godfrey (1936)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 946, "Comedy|Drama|War", "To Be or Not to Be (1942)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 945, "Comedy|Musical|Romance", "Top Hat (1935)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 944, "Drama", "Lost Horizon (1937)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 943, "Drama|Fantasy|Romance", "Ghost and Mrs. Muir, The (1947)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 942, "Crime|Film-Noir|Mystery", "Laura (1944)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 941, "Adventure", "Mark of Zorro, The (1940)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 940, "Action|Adventure|Romance", "Adventures of Robin Hood, The (1938)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 939, "Comedy|Drama", "Reluctant Debutante, The (1958)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 891, "Horror|Thriller", "Halloween: The Curse of Michael Myers (Halloween 6: The Curse of Michael Myers) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 938, "Musical", "Gigi (1958)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 936, "Comedy|Romance", "Ninotchka (1939)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 935, "Comedy|Musical", "Band Wagon, The (1953)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 934, "Comedy", "Father of the Bride (1950)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 933, "Crime|Mystery|Romance|Thriller", "To Catch a Thief (1955)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 932, "Drama|Romance", "Affair to Remember, An (1957)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 931, "Mystery|Romance|Thriller", "Spellbound (1945)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 930, "Film-Noir|Romance|Thriller", "Notorious (1946)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 929, "Drama|Film-Noir|Mystery|Thriller", "Foreign Correspondent (1940)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 928, "Drama|Mystery|Romance|Thriller", "Rebecca (1940)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 927, "Comedy", "Women, The (1939)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 926, "Drama", "All About Eve (1950)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 925, "Adventure|Romance|War", "Golden Earrings (1947)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 924, "Adventure|Drama|Sci-Fi", "2001: A Space Odyssey (1968)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 937, "Comedy|Romance", "Love in the Afternoon (1957)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 503, "Drama", "New Age, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 762, "Comedy|Crime", "Striptease (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 760, "Drama|War", "Stalingrad (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 596, "Animation|Children|Fantasy|Musical", "Pinocchio (1940)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 595, "Animation|Children|Fantasy|Musical|Romance|IMAX", "Beauty and the Beast (1991)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 594, "Animation|Children|Drama|Fantasy|Musical", "Snow White and the Seven Dwarfs (1937)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 593, "Crime|Horror|Thriller", "Silence of the Lambs, The (1991)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 592, "Action|Crime|Thriller", "Batman (1989)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 591, "Action|Drama|Thriller", "Tough and Deadly (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 590, "Adventure|Drama|Western", "Dances with Wolves (1990)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 589, "Action|Sci-Fi", "Terminator 2: Judgment Day (1991)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 588, "Adventure|Animation|Children|Comedy|Musical", "Aladdin (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 587, "Comedy|Drama|Fantasy|Romance|Thriller", "Ghost (1990)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 586, "Children|Comedy", "Home Alone (1990)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 585, "Comedy", "Brady Bunch Movie, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 584, "Drama|Romance", "I Don't Want to Talk About It (De eso no se habla) (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 583, "Comedy|Drama", "Dear Diary (Caro Diario) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 582, "Comedy|Drama", "Métisse (Café au Lait) (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 581, "Documentary", "Celluloid Closet, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 580, "Drama", "Princess Caraboo (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 579, "Crime|Thriller", "Escort, The (Scorta, La) (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 577, "Adventure|Children|Drama", "Andre (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 576, "Comedy", "Fausto (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 575, "Children|Comedy", "Little Rascals, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 574, "Comedy|Drama", "Spanking the Monkey (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 573, "Drama", "Ciao, Professore! (Io speriamo che me la cavo) (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 572, "Drama", "Foreign Student (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 571, "Drama|Romance", "Wedding Gift, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 570, "Comedy|Drama", "Slingshot, The (Kådisbellan) (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 569, "Comedy|Drama", "Little Big League (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 597, "Comedy|Romance", "Pretty Woman (1990)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 568, "Comedy|Drama", "Bhaji on the Beach (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 598, "Comedy|Fantasy", "Window to Paris (Okno v Parizh) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 600, "Action|Comedy|Crime", "Love and a .45 (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 628, "Crime|Drama|Mystery|Thriller", "Primal Fear (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 627, "Drama|Thriller", "Last Supper, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 626, "Comedy", "Thin Line Between Love and Hate, A (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 625, "Drama", "Asfour Stah (1990)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 624, "Action|Drama|Thriller", "Condition Red (Beyond the Law) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 623, "Romance", "Modern Affair, A (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 621, "Drama", "My Favorite Season (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 620, "Drama", "Scream of Stone (Cerro Torre: Schrei aus Stein) (1991)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 619, "Comedy", "Ed (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 618, "Comedy|Romance", "Two Much (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 617, "Comedy|Drama", "Flower of My Secret, The (La flor de mi secreto) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 616, "Animation|Children", "Aristocats, The (1970)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 615, "Comedy|Drama", "Bread and Chocolate (Pane e cioccolata) (1973)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 614, "Drama|Thriller", "Loaded (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 613, "Drama|Romance", "Jane Eyre (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 612, "Comedy", "Pallbearer, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 611, "Action|Horror|Sci-Fi", "Hellraiser: Bloodline (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 610, "Action|Adventure|Animation|Horror|Sci-Fi", "Heavy Metal (1981)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 609, "Adventure|Children", "Homeward Bound II: Lost in San Francisco (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 608, "Comedy|Crime|Drama|Thriller", "Fargo (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 607, "Drama", "Century (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 606, "Fantasy|Horror", "Candyman: Farewell to the Flesh (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 605, "Drama|Romance", "One Fine Day (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 604, "Documentary", "Criminals (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 603, "Comedy", "Bye Bye, Love (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 602, "Documentary", "Great Day in Harlem, A (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 601, "Drama", "Wooden Man's Bride, The (Yan shen) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 599, "Adventure|Western", "Wild Bunch, The (1969)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 567, "Comedy|Drama", "Kika (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 566, "Comedy|Romance", "Naked in New York (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 565, "Drama|Horror", "Cronos (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 531, "Children|Drama", "Secret Garden, The (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 530, "Drama", "Second Best (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 529, "Drama", "Searching for Bobby Fischer (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 528, "Comedy|Drama", "Scout, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 527, "Drama|War", "Schindler's List (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 526, "Drama", "Savage Nights (Nuits fauves, Les) (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 525, "Drama", "Saint of Fort Washington, The (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 524, "Drama", "Rudy (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 523, "Drama", "Ruby in Paradise (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 522, "Action|Drama", "Romper Stomper (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 521, "Crime|Thriller", "Romeo Is Bleeding (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 520, "Comedy", "Robin Hood: Men in Tights (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 519, "Action|Crime|Drama|Sci-Fi|Thriller", "RoboCop 3 (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 518, "Comedy", "Road to Wellville, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 517, "Action|Drama|Mystery", "Rising Sun (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 516, "Comedy|Drama", "Renaissance Man (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 515, "Drama|Romance", "Remains of the Day, The (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 514, "Comedy", "Ref, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 513, "Comedy|Mystery|Romance", "Radioland Murders (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 512, "Horror|Sci-Fi", "Puppet Masters, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 511, "Action|Drama", "Program, The (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 510, "Drama", "Poetic Justice (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 509, "Drama|Romance", "Piano, The (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 508, "Drama", "Philadelphia (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 507, "Crime|Drama|Thriller", "Perfect World, A (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 506, "Drama|Fantasy|Romance", "Orlando (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 505, "Comedy", "North (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 532, "Comedy|Crime|Horror", "Serial Mom (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 533, "Action|Adventure|Fantasy|Mystery", "Shadow, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 534, "Drama|Romance", "Shadowlands (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 535, "Drama", "Short Cuts (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 564, "Comedy", "Chasers (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 563, "Drama|Romance", "Germinal (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 562, "Comedy|Drama", "Welcome to the Dollhouse (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 561, "Drama|Thriller", "Killer (Bulletproof Heart) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 560, "Drama", "Beans of Egypt, Maine, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 559, "Comedy", "Paris, France (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 558, "Action|Adventure|Animation|Children|Fantasy", "Pagemaster, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 556, "Documentary", "War Room, The (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 555, "Crime|Thriller", "True Romance (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 554, "Crime|Drama|Thriller", "Trial by Jury (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 553, "Action|Drama|Western", "Tombstone (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 552, "Action|Adventure|Comedy|Romance", "Three Musketeers, The (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 551, "Animation|Children|Fantasy|Musical", "Nightmare Before Christmas, The (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 629, "Drama", "Rude (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 550, "Comedy|Romance", "Threesome (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 548, "Action|Mystery|Thriller", "Terminal Velocity (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 547, "Action|Adventure|Thriller", "Surviving the Game (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 546, "Action|Adventure|Children|Comedy|Fantasy|Sci-Fi", "Super Mario Bros. (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 545, "Drama", "Harem (1985)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 544, "Action|Crime", "Striking Distance (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 543, "Comedy|Romance|Thriller", "So I Married an Axe Murderer (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 542, "Comedy|Drama|Romance", "Son in Law (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 541, "Action|Sci-Fi|Thriller", "Blade Runner (1982)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 540, "Thriller", "Sliver (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 539, "Comedy|Drama|Romance", "Sleepless in Seattle (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 538, "Drama", "Six Degrees of Separation (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 537, "Drama", "Sirens (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 536, "Drama", "Simple Twist of Fate, A (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 549, "Drama|Musical", "Thirty-Two Short Films About Glenn Gould (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 761, "Action|Adventure", "Phantom, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 630, "Drama|Romance", "Carried Away (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 632, "Drama|War", "Land and Freedom (Tierra y libertad) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 727, "Documentary", "War Stories (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 726, "Drama", "Last Dance (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 725, "Comedy", "Great White Hype, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 724, "Drama|Fantasy|Horror|Thriller", "Craft, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 723, "Drama", "Two Friends (1986)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 722, "Documentary", "Haunted World of Edward D. Wood Jr., The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 721, "Drama", "Halfmoon (Paul Bowles - Halbmond) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 720, "Adventure|Animation|Comedy", "Wallace & Gromit: The Best of Aardman Animation (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 719, "Comedy", "Multiplicity (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 718, "Comedy|Fantasy|Sci-Fi", "Visitors, The (Visiteurs, Les) (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 717, "Comedy", "Mouth to Mouth (Boca a boca) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 716, "Crime", "Switchblade Sisters (1975)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 715, "Drama|Romance", "Horseman on the Roof, The (Hussard sur le toit, Le) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 714, "Drama|Mystery|Western", "Dead Man (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 713, "Drama", "Of Love and Shadows (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 712, "Crime|Drama|Romance|Thriller", "Captives (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 711, "Adventure|Children", "Flipper (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 710, "Comedy", "Celtic Pride (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 709, "Adventure|Animation|Children|Comedy|Musical", "Oliver & Company (1988)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 708, "Comedy|Romance", "Truth About Cats & Dogs, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 707, "Crime|Drama|Thriller", "Mulholland Falls (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 706, "Drama", "Sunset Park (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 705, "Comedy", "Cosi (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 704, "Action|Adventure", "Quest, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 703, "Drama", "Boys (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 702, "Drama", "Faces (1968)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 701, "Drama", "Daens (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 728, "Comedy", "Cold Comfort Farm (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 700, "Comedy", "Angus (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 729, "Drama", "Institute Benjamenta, or This Dream People Call Human Life (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 731, "Crime|Thriller", "Heaven's Prisoners (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 759, "Documentary", "Maya Lin: A Strong Clear Vision (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 758, "Drama", "Jar, The (Khomreh) (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 757, "Drama", "Ashes of Time (Dung che sai duk) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 756, "Documentary", "Carmen Miranda: Bananas Is My Business (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 755, "Children|Drama", "Kim (1950)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 754, "Adventure|Children", "Gold Diggers: The Secret of Bear Mountain (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 753, "Comedy|Drama|Romance", "Month by the Lake, A (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 752, "Comedy|Documentary|Romance", "Vermont Is For Lovers (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 751, "Comedy|Horror", "Careful (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 750, "Comedy|War", "Dr. Strangelove or: How I Learned to Stop Worrying and Love the Bomb (1964)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 749, "Drama", "Man from Down Under, The (1943)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 748, "Action|Sci-Fi|Thriller", "Arrival, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 747, "Comedy", "Stupids, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 746, "Film-Noir", "Force of Evil (1948)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 745, "Animation|Children|Comedy", "Wallace & Gromit: A Close Shave (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 744, "Drama", "Brothers in Trouble (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 743, "Comedy", "Spy Hard (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 742, "Horror|Thriller", "Thinner (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 741, "Animation|Sci-Fi", "Ghost in the Shell (Kôkaku kidôtai) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 739, "Comedy", "Honey Moon (Honigmond) (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 738, "Drama", "Garçu, Le (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 737, "Action|Sci-Fi", "Barb Wire (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 736, "Action|Adventure|Romance|Thriller", "Twister (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 735, "Horror", "Cemetery Man (Dellamorte Dellamore) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 734, "Comedy", "Getting Away With Murder (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 733, "Action|Adventure|Thriller", "Rock, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 732, "Crime", "Original Gangstas (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 730, "Drama", "Low Life (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 699, "Drama", "To Cross the Rubicon (1991)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 698, "Drama", "Delta of Venus (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 697, "Drama|Romance", "Feeling Minnesota (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 660, "Drama", "August (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 659, "Crime|Drama|Thriller", "Purple Noon (Plein soleil) (1960)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 658, "Drama|Musical", "Billy's Holiday (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 657, "Comedy|Drama", "Yankee Zulu (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 656, "Comedy", "Eddie (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 655, "Comedy", "My Mother's Courage (Mutters Courage) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 654, "Drama|Romance", "And Nobody Weeps for Me (Und keiner weint mir nach) (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 653, "Action|Adventure|Fantasy", "Dragonheart (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 652, "Horror|Mystery|Thriller", "301, 302 (301/302) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 651, "Comedy", "Superweib, Das (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 650, "Drama", "Moll Flanders (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 649, "Comedy|Drama", "Cold Fever (Á köldum klaka) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 648, "Action|Adventure|Mystery|Thriller", "Mission: Impossible (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 647, "Action|Crime|Drama|War", "Courage Under Fire (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 645, "Drama", "Nelly & Monsieur Arnaud (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 644, "Comedy", "Happy Weekend (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 643, "Comedy", "Peanuts - Die Bank zahlt alles (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 642, "Drama", "Roula (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 641, "Adventure|Children|Comedy", "Little Indian, Big City (Un indien dans la ville) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 640, "Drama|Thriller", "Diabolique (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 639, "Comedy|Drama", "Girl 6 (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 638, "Romance", "Jack and Sarah (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 637, "Comedy", "Sgt. Bilko (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 636, "Drama", "Frisk (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 635, "Comedy|Drama", "Family Thing, A (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 634, "Comedy", "Theodore Rex (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 633, "Comedy", "Denise Calls Up (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 661, "Adventure|Animation|Children|Fantasy|Musical", "James and the Giant Peach (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 662, "Thriller", "Fear (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 663, "Comedy", "Kids in the Hall: Brain Candy (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 664, "Comedy", "Faithful (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 696, "Drama|Thriller", "Butterfly Kiss (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 695, "Mystery|Thriller", "True Crime (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 694, "Action|Crime|Drama", "Substitute, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 693, "Drama", "Under the Domim Tree (Etz Hadomim Tafus) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 692, "Action|Sci-Fi|Thriller", "Solo (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 691, "Comedy|Romance", "Mrs. Winterbourne (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 690, "Drama|Romance", "Promise, The (Versprechen, Das) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 688, "Action|Adventure|Comedy|War", "Operation Dumbo Drop (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 687, "Drama|Romance", "Country Life (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 685, "Drama", "It's My Party (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 684, "Drama", "Windows (1980)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 683, "Documentary", "Eye of Vichy, The (Oeil de Vichy, L') (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 682, "Documentary|Drama", "Tigrero: A Film That Was Never Made (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 631, "Adventure|Animation|Children|Fantasy|Musical|Romance", "All Dogs Go to Heaven 2 (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 681, "Crime", "Coup de torchon (Clean Slate) (1981)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 679, "Drama", "Run of the Country, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 678, "Drama|Thriller", "Some Folks Call It a Sling Blade (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 676, "Comedy|Horror|Sci-Fi", "They Bite (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 675, "Action|Drama|Thriller", "Hostile Intentions (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 674, "Adventure|Comedy|Sci-Fi", "Barbarella (1968)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 673, "Adventure|Animation|Children|Comedy|Fantasy|Sci-Fi", "Space Jam (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 672, "Drama", "Tarantella (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 671, "Comedy|Sci-Fi", "Mystery Science Theater 3000: The Movie (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 670, "Drama", "World of Apu, The (Apur Sansar) (1959)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 668, "Drama", "Song of the Little Road (Pather Panchali) (1955)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 667, "Action", "Bloodsport 2 (a.k.a. Bloodsport II: The Next Kumite) (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 666, "Drama|Romance|War", "All Things Fair (Lust och fägring stor) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 665, "Comedy|Drama|War", "Underground (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 680, "Drama|Mystery|Romance|Sci-Fi|Thriller", "Alphaville (Alphaville, une étrange aventure de Lemmy Caution) (1965)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Title" },
                values: new object[] { 1, "Adventure|Animation|Children|Comedy|Fantasy", "Toy Story (1995)" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "MovieWithTags");
        }
    }
}
