using Microsoft.EntityFrameworkCore.Migrations;

namespace SearchingMovieMicroservice.Data.Migrations
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
                    Genres = table.Column<string>(type: "TEXT", nullable: true),
                    Tag = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 1, "Adventure|Animation|Children|Comedy|Fantasy", null, "Toy Story (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 666, "Drama|Romance|War", null, "All Things Fair (Lust och fägring stor) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 667, "Action", null, "Bloodsport 2 (a.k.a. Bloodsport II: The Next Kumite) (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 668, "Drama", null, "Song of the Little Road (Pather Panchali) (1955)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 670, "Drama", null, "World of Apu, The (Apur Sansar) (1959)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 671, "Comedy|Sci-Fi", null, "Mystery Science Theater 3000: The Movie (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 672, "Drama", null, "Tarantella (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 673, "Adventure|Animation|Children|Comedy|Fantasy|Sci-Fi", null, "Space Jam (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 674, "Adventure|Comedy|Sci-Fi", null, "Barbarella (1968)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 675, "Action|Drama|Thriller", null, "Hostile Intentions (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 676, "Comedy|Horror|Sci-Fi", null, "They Bite (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 678, "Drama|Thriller", null, "Some Folks Call It a Sling Blade (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 679, "Drama", null, "Run of the Country, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 680, "Drama|Mystery|Romance|Sci-Fi|Thriller", null, "Alphaville (Alphaville, une étrange aventure de Lemmy Caution) (1965)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 681, "Crime", null, "Coup de torchon (Clean Slate) (1981)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 682, "Documentary|Drama", null, "Tigrero: A Film That Was Never Made (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 683, "Documentary", null, "Eye of Vichy, The (Oeil de Vichy, L') (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 684, "Drama", null, "Windows (1980)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 685, "Drama", null, "It's My Party (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 687, "Drama|Romance", null, "Country Life (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 688, "Action|Adventure|Comedy|War", null, "Operation Dumbo Drop (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 690, "Drama|Romance", null, "Promise, The (Versprechen, Das) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 691, "Comedy|Romance", null, "Mrs. Winterbourne (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 692, "Action|Sci-Fi|Thriller", null, "Solo (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 693, "Drama", null, "Under the Domim Tree (Etz Hadomim Tafus) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 694, "Action|Crime|Drama", null, "Substitute, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 695, "Mystery|Thriller", null, "True Crime (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 696, "Drama|Thriller", null, "Butterfly Kiss (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 665, "Comedy|Drama|War", null, "Underground (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 697, "Drama|Romance", null, "Feeling Minnesota (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 664, "Comedy", null, "Faithful (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 662, "Thriller", null, "Fear (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 634, "Comedy", null, "Theodore Rex (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 635, "Comedy|Drama", null, "Family Thing, A (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 636, "Drama", null, "Frisk (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 637, "Comedy", null, "Sgt. Bilko (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 638, "Romance", null, "Jack and Sarah (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 639, "Comedy|Drama", null, "Girl 6 (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 640, "Drama|Thriller", null, "Diabolique (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 641, "Adventure|Children|Comedy", null, "Little Indian, Big City (Un indien dans la ville) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 642, "Drama", null, "Roula (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 643, "Comedy", null, "Peanuts - Die Bank zahlt alles (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 644, "Comedy", null, "Happy Weekend (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 645, "Drama", null, "Nelly & Monsieur Arnaud (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 647, "Action|Crime|Drama|War", null, "Courage Under Fire (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 648, "Action|Adventure|Mystery|Thriller", null, "Mission: Impossible (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 649, "Comedy|Drama", null, "Cold Fever (Á köldum klaka) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 650, "Drama", null, "Moll Flanders (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 651, "Comedy", null, "Superweib, Das (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 652, "Horror|Mystery|Thriller", null, "301, 302 (301/302) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 653, "Action|Adventure|Fantasy", null, "Dragonheart (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 654, "Drama|Romance", null, "And Nobody Weeps for Me (Und keiner weint mir nach) (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 655, "Comedy", null, "My Mother's Courage (Mutters Courage) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 656, "Comedy", null, "Eddie (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 657, "Comedy|Drama", null, "Yankee Zulu (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 658, "Drama|Musical", null, "Billy's Holiday (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 659, "Crime|Drama|Thriller", null, "Purple Noon (Plein soleil) (1960)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 660, "Drama", null, "August (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 661, "Adventure|Animation|Children|Fantasy|Musical", null, "James and the Giant Peach (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 663, "Comedy", null, "Kids in the Hall: Brain Candy (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 698, "Drama", null, "Delta of Venus (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 699, "Drama", null, "To Cross the Rubicon (1991)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 700, "Comedy", null, "Angus (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 733, "Action|Adventure|Thriller", null, "Rock, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 734, "Comedy", null, "Getting Away With Murder (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 735, "Horror", null, "Cemetery Man (Dellamorte Dellamore) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 736, "Action|Adventure|Romance|Thriller", null, "Twister (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 737, "Action|Sci-Fi", null, "Barb Wire (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 738, "Drama", null, "Garçu, Le (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 739, "Comedy", null, "Honey Moon (Honigmond) (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 741, "Animation|Sci-Fi", null, "Ghost in the Shell (Kôkaku kidôtai) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 742, "Horror|Thriller", null, "Thinner (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 743, "Comedy", null, "Spy Hard (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 744, "Drama", null, "Brothers in Trouble (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 745, "Animation|Children|Comedy", null, "Wallace & Gromit: A Close Shave (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 746, "Film-Noir", null, "Force of Evil (1948)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 747, "Comedy", null, "Stupids, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 748, "Action|Sci-Fi|Thriller", null, "Arrival, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 749, "Drama", null, "Man from Down Under, The (1943)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 750, "Comedy|War", null, "Dr. Strangelove or: How I Learned to Stop Worrying and Love the Bomb (1964)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 751, "Comedy|Horror", null, "Careful (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 752, "Comedy|Documentary|Romance", null, "Vermont Is For Lovers (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 753, "Comedy|Drama|Romance", null, "Month by the Lake, A (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 754, "Adventure|Children", null, "Gold Diggers: The Secret of Bear Mountain (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 755, "Children|Drama", null, "Kim (1950)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 756, "Documentary", null, "Carmen Miranda: Bananas Is My Business (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 757, "Drama", null, "Ashes of Time (Dung che sai duk) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 758, "Drama", null, "Jar, The (Khomreh) (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 759, "Documentary", null, "Maya Lin: A Strong Clear Vision (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 760, "Drama|War", null, "Stalingrad (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 732, "Crime", null, "Original Gangstas (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 731, "Crime|Thriller", null, "Heaven's Prisoners (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 730, "Drama", null, "Low Life (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 729, "Drama", null, "Institute Benjamenta, or This Dream People Call Human Life (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 701, "Drama", null, "Daens (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 702, "Drama", null, "Faces (1968)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 703, "Drama", null, "Boys (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 704, "Action|Adventure", null, "Quest, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 705, "Comedy", null, "Cosi (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 706, "Drama", null, "Sunset Park (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 707, "Crime|Drama|Thriller", null, "Mulholland Falls (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 708, "Comedy|Romance", null, "Truth About Cats & Dogs, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 709, "Adventure|Animation|Children|Comedy|Musical", null, "Oliver & Company (1988)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 710, "Comedy", null, "Celtic Pride (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 711, "Adventure|Children", null, "Flipper (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 712, "Crime|Drama|Romance|Thriller", null, "Captives (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 713, "Drama", null, "Of Love and Shadows (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 633, "Comedy", null, "Denise Calls Up (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 714, "Drama|Mystery|Western", null, "Dead Man (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 716, "Crime", null, "Switchblade Sisters (1975)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 717, "Comedy", null, "Mouth to Mouth (Boca a boca) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 718, "Comedy|Fantasy|Sci-Fi", null, "Visitors, The (Visiteurs, Les) (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 719, "Comedy", null, "Multiplicity (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 720, "Adventure|Animation|Comedy", null, "Wallace & Gromit: The Best of Aardman Animation (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 721, "Drama", null, "Halfmoon (Paul Bowles - Halbmond) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 722, "Documentary", null, "Haunted World of Edward D. Wood Jr., The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 723, "Drama", null, "Two Friends (1986)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 724, "Drama|Fantasy|Horror|Thriller", null, "Craft, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 725, "Comedy", null, "Great White Hype, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 726, "Drama", null, "Last Dance (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 727, "Documentary", null, "War Stories (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 728, "Comedy", null, "Cold Comfort Farm (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 715, "Drama|Romance", null, "Horseman on the Roof, The (Hussard sur le toit, Le) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 761, "Action|Adventure", null, "Phantom, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 632, "Drama|War", null, "Land and Freedom (Tierra y libertad) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 630, "Drama|Romance", null, "Carried Away (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 537, "Drama", null, "Sirens (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 538, "Drama", null, "Six Degrees of Separation (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 539, "Comedy|Drama|Romance", null, "Sleepless in Seattle (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 540, "Thriller", null, "Sliver (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 541, "Action|Sci-Fi|Thriller", null, "Blade Runner (1982)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 542, "Comedy|Drama|Romance", null, "Son in Law (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 543, "Comedy|Romance|Thriller", null, "So I Married an Axe Murderer (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 544, "Action|Crime", null, "Striking Distance (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 545, "Drama", null, "Harem (1985)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 546, "Action|Adventure|Children|Comedy|Fantasy|Sci-Fi", null, "Super Mario Bros. (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 547, "Action|Adventure|Thriller", null, "Surviving the Game (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 548, "Action|Mystery|Thriller", null, "Terminal Velocity (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 549, "Drama|Musical", null, "Thirty-Two Short Films About Glenn Gould (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 550, "Comedy|Romance", null, "Threesome (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 551, "Animation|Children|Fantasy|Musical", null, "Nightmare Before Christmas, The (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 552, "Action|Adventure|Comedy|Romance", null, "Three Musketeers, The (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 553, "Action|Drama|Western", null, "Tombstone (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 554, "Crime|Drama|Thriller", null, "Trial by Jury (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 555, "Crime|Thriller", null, "True Romance (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 556, "Documentary", null, "War Room, The (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 558, "Action|Adventure|Animation|Children|Fantasy", null, "Pagemaster, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 559, "Comedy", null, "Paris, France (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 560, "Drama", null, "Beans of Egypt, Maine, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 561, "Drama|Thriller", null, "Killer (Bulletproof Heart) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 562, "Comedy|Drama", null, "Welcome to the Dollhouse (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 563, "Drama|Romance", null, "Germinal (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 564, "Comedy", null, "Chasers (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 536, "Drama", null, "Simple Twist of Fate, A (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 565, "Drama|Horror", null, "Cronos (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 535, "Drama", null, "Short Cuts (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 533, "Action|Adventure|Fantasy|Mystery", null, "Shadow, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 506, "Drama|Fantasy|Romance", null, "Orlando (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 507, "Crime|Drama|Thriller", null, "Perfect World, A (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 508, "Drama", null, "Philadelphia (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 509, "Drama|Romance", null, "Piano, The (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 510, "Drama", null, "Poetic Justice (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 511, "Action|Drama", null, "Program, The (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 512, "Horror|Sci-Fi", null, "Puppet Masters, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 513, "Comedy|Mystery|Romance", null, "Radioland Murders (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 514, "Comedy", null, "Ref, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 515, "Drama|Romance", null, "Remains of the Day, The (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 516, "Comedy|Drama", null, "Renaissance Man (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 517, "Action|Drama|Mystery", null, "Rising Sun (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 518, "Comedy", null, "Road to Wellville, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 519, "Action|Crime|Drama|Sci-Fi|Thriller", null, "RoboCop 3 (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 520, "Comedy", null, "Robin Hood: Men in Tights (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 521, "Crime|Thriller", null, "Romeo Is Bleeding (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 522, "Action|Drama", null, "Romper Stomper (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 523, "Drama", null, "Ruby in Paradise (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 524, "Drama", null, "Rudy (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 525, "Drama", null, "Saint of Fort Washington, The (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 526, "Drama", null, "Savage Nights (Nuits fauves, Les) (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 527, "Drama|War", null, "Schindler's List (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 528, "Comedy|Drama", null, "Scout, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 529, "Drama", null, "Searching for Bobby Fischer (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 530, "Drama", null, "Second Best (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 531, "Children|Drama", null, "Secret Garden, The (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 532, "Comedy|Crime|Horror", null, "Serial Mom (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 534, "Drama|Romance", null, "Shadowlands (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 566, "Comedy|Romance", null, "Naked in New York (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 567, "Comedy|Drama", null, "Kika (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 568, "Comedy|Drama", null, "Bhaji on the Beach (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 602, "Documentary", null, "Great Day in Harlem, A (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 603, "Comedy", null, "Bye Bye, Love (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 604, "Documentary", null, "Criminals (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 605, "Drama|Romance", null, "One Fine Day (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 606, "Fantasy|Horror", null, "Candyman: Farewell to the Flesh (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 607, "Drama", null, "Century (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 608, "Comedy|Crime|Drama|Thriller", null, "Fargo (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 609, "Adventure|Children", null, "Homeward Bound II: Lost in San Francisco (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 610, "Action|Adventure|Animation|Horror|Sci-Fi", null, "Heavy Metal (1981)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 611, "Action|Horror|Sci-Fi", null, "Hellraiser: Bloodline (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 612, "Comedy", null, "Pallbearer, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 613, "Drama|Romance", null, "Jane Eyre (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 614, "Drama|Thriller", null, "Loaded (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 615, "Comedy|Drama", null, "Bread and Chocolate (Pane e cioccolata) (1973)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 616, "Animation|Children", null, "Aristocats, The (1970)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 617, "Comedy|Drama", null, "Flower of My Secret, The (La flor de mi secreto) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 618, "Comedy|Romance", null, "Two Much (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 619, "Comedy", null, "Ed (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 620, "Drama", null, "Scream of Stone (Cerro Torre: Schrei aus Stein) (1991)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 621, "Drama", null, "My Favorite Season (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 623, "Romance", null, "Modern Affair, A (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 624, "Action|Drama|Thriller", null, "Condition Red (Beyond the Law) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 625, "Drama", null, "Asfour Stah (1990)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 626, "Comedy", null, "Thin Line Between Love and Hate, A (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 627, "Drama|Thriller", null, "Last Supper, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 628, "Crime|Drama|Mystery|Thriller", null, "Primal Fear (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 629, "Drama", null, "Rude (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 601, "Drama", null, "Wooden Man's Bride, The (Yan shen) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 600, "Action|Comedy|Crime", null, "Love and a .45 (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 599, "Adventure|Western", null, "Wild Bunch, The (1969)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 598, "Comedy|Fantasy", null, "Window to Paris (Okno v Parizh) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 569, "Comedy|Drama", null, "Little Big League (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 570, "Comedy|Drama", null, "Slingshot, The (Kådisbellan) (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 571, "Drama|Romance", null, "Wedding Gift, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 572, "Drama", null, "Foreign Student (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 573, "Drama", null, "Ciao, Professore! (Io speriamo che me la cavo) (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 574, "Comedy|Drama", null, "Spanking the Monkey (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 575, "Children|Comedy", null, "Little Rascals, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 576, "Comedy", null, "Fausto (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 577, "Adventure|Children|Drama", null, "Andre (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 579, "Crime|Thriller", null, "Escort, The (Scorta, La) (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 580, "Drama", null, "Princess Caraboo (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 581, "Documentary", null, "Celluloid Closet, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 582, "Comedy|Drama", null, "Métisse (Café au Lait) (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 631, "Adventure|Animation|Children|Fantasy|Musical|Romance", null, "All Dogs Go to Heaven 2 (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 583, "Comedy|Drama", null, "Dear Diary (Caro Diario) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 585, "Comedy", null, "Brady Bunch Movie, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 586, "Children|Comedy", null, "Home Alone (1990)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 587, "Comedy|Drama|Fantasy|Romance|Thriller", null, "Ghost (1990)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 588, "Adventure|Animation|Children|Comedy|Musical", null, "Aladdin (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 589, "Action|Sci-Fi", null, "Terminator 2: Judgment Day (1991)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 590, "Adventure|Drama|Western", null, "Dances with Wolves (1990)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 591, "Action|Drama|Thriller", null, "Tough and Deadly (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 592, "Action|Crime|Thriller", null, "Batman (1989)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 593, "Crime|Horror|Thriller", null, "Silence of the Lambs, The (1991)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 594, "Animation|Children|Drama|Fantasy|Musical", null, "Snow White and the Seven Dwarfs (1937)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 595, "Animation|Children|Fantasy|Musical|Romance|IMAX", null, "Beauty and the Beast (1991)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 596, "Animation|Children|Fantasy|Musical", null, "Pinocchio (1940)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 597, "Comedy|Romance", null, "Pretty Woman (1990)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 584, "Drama|Romance", null, "I Don't Want to Talk About It (De eso no se habla) (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 505, "Comedy", null, "North (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 762, "Comedy|Crime", null, "Striptease (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 764, "Drama|Romance", null, "Heavy (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 925, "Adventure|Romance|War", null, "Golden Earrings (1947)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 926, "Drama", null, "All About Eve (1950)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 927, "Comedy", null, "Women, The (1939)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 928, "Drama|Mystery|Romance|Thriller", null, "Rebecca (1940)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 929, "Drama|Film-Noir|Mystery|Thriller", null, "Foreign Correspondent (1940)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 930, "Film-Noir|Romance|Thriller", null, "Notorious (1946)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 931, "Mystery|Romance|Thriller", null, "Spellbound (1945)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 932, "Drama|Romance", null, "Affair to Remember, An (1957)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 933, "Crime|Mystery|Romance|Thriller", null, "To Catch a Thief (1955)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 934, "Comedy", null, "Father of the Bride (1950)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 935, "Comedy|Musical", null, "Band Wagon, The (1953)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 936, "Comedy|Romance", null, "Ninotchka (1939)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 937, "Comedy|Romance", null, "Love in the Afternoon (1957)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 938, "Musical", null, "Gigi (1958)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 939, "Comedy|Drama", null, "Reluctant Debutante, The (1958)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 940, "Action|Adventure|Romance", null, "Adventures of Robin Hood, The (1938)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 941, "Adventure", null, "Mark of Zorro, The (1940)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 942, "Crime|Film-Noir|Mystery", null, "Laura (1944)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 943, "Drama|Fantasy|Romance", null, "Ghost and Mrs. Muir, The (1947)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 944, "Drama", null, "Lost Horizon (1937)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 945, "Comedy|Musical|Romance", null, "Top Hat (1935)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 946, "Comedy|Drama|War", null, "To Be or Not to Be (1942)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 947, "Comedy|Romance", null, "My Man Godfrey (1936)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 948, "Drama|Romance|Western", null, "Giant (1956)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 949, "Drama", null, "East of Eden (1955)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 950, "Comedy|Crime", null, "Thin Man, The (1934)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 951, "Comedy|Romance", null, "His Girl Friday (1940)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 924, "Adventure|Drama|Sci-Fi", null, "2001: A Space Odyssey (1968)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 952, "Adventure|Comedy", null, "Around the World in 80 Days (1956)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 923, "Drama|Mystery", null, "Citizen Kane (1941)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 921, "Comedy", null, "My Favorite Year (1982)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 894, "Romance", null, "Liebelei (1933)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 895, "Drama", null, "Venice/Venice (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 896, "Drama", null, "Wild Reeds (Les roseaux sauvages) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 897, "Adventure|Drama|Romance|War", null, "For Whom the Bell Tolls (1943)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 898, "Comedy|Drama|Romance", null, "Philadelphia Story, The (1940)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 899, "Comedy|Musical|Romance", null, "Singin' in the Rain (1952)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 900, "Musical|Romance", null, "American in Paris, An (1951)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 901, "Comedy|Musical", null, "Funny Face (1957)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 902, "Drama|Romance", null, "Breakfast at Tiffany's (1961)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 903, "Drama|Mystery|Romance|Thriller", null, "Vertigo (1958)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 904, "Mystery|Thriller", null, "Rear Window (1954)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 905, "Comedy|Romance", null, "It Happened One Night (1934)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 906, "Drama|Thriller", null, "Gaslight (1944)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 907, "Comedy|Musical|Romance", null, "Gay Divorcee, The (1934)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 908, "Action|Adventure|Mystery|Romance|Thriller", null, "North by Northwest (1959)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 909, "Comedy|Drama|Romance", null, "Apartment, The (1960)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 910, "Comedy|Crime", null, "Some Like It Hot (1959)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 911, "Comedy|Crime|Mystery|Romance|Thriller", null, "Charade (1963)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 912, "Drama|Romance", null, "Casablanca (1942)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 913, "Film-Noir|Mystery", null, "Maltese Falcon, The (1941)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 914, "Comedy|Drama|Musical|Romance", null, "My Fair Lady (1964)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 915, "Comedy|Romance", null, "Sabrina (1954)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 916, "Comedy|Drama|Romance", null, "Roman Holiday (1953)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 917, "Children|Drama", null, "Little Princess, The (1939)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 918, "Musical", null, "Meet Me in St. Louis (1944)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 919, "Adventure|Children|Fantasy|Musical", null, "Wizard of Oz, The (1939)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 920, "Drama|Romance|War", null, "Gone with the Wind (1939)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 922, "Drama|Film-Noir|Romance", null, "Sunset Blvd. (a.k.a. Sunset Boulevard) (1950)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 953, "Drama|Fantasy|Romance", null, "It's a Wonderful Life (1946)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 954, "Drama", null, "Mr. Smith Goes to Washington (1939)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 955, "Comedy|Romance", null, "Bringing Up Baby (1938)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 989, "Drama", null, "Brother of Sleep (Schlafes Bruder) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 990, "Action|Adventure|Thriller", null, "Maximum Risk (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 991, "Drama", null, "Michael Collins (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 992, "Thriller", null, "Rich Man's Wife, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 993, "Drama", null, "Infinity (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 994, "Comedy|Drama", null, "Big Night (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 996, "Action|Crime|Drama|Thriller", null, "Last Man Standing (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 997, "Drama|Thriller", null, "Caught (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 998, "Action|Crime", null, "Set It Off (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 999, "Crime|Film-Noir", null, "2 Days in the Valley (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 1000, "Crime", null, "Curdled (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 1001, "Comedy", null, "Associate, The (Associé, L') (1979)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 1002, "Comedy|Romance", null, "Ed's Next Move (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 1003, "Drama|Thriller", null, "Extreme Measures (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 1004, "Action|Thriller", null, "Glimmer Man, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 1005, "Children|Comedy", null, "D3: The Mighty Ducks (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 1006, "Drama", null, "Chamber, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 1007, "Children|Comedy|Western", null, "Apple Dumpling Gang, The (1975)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 1008, "Adventure|Western", null, "Davy Crockett, King of the Wild Frontier (1955)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 1009, "Adventure|Children|Fantasy", null, "Escape to Witch Mountain (1975)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 1010, "Children|Comedy", null, "Love Bug, The (1969)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 1011, "Adventure|Children|Comedy", null, "Herbie Rides Again (1974)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 1012, "Children|Drama", null, "Old Yeller (1957)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 1013, "Children|Comedy|Romance", null, "Parent Trap, The (1961)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 1014, "Children|Comedy|Drama", null, "Pollyanna (1960)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 1015, "Adventure|Children|Drama", null, "Homeward Bound: The Incredible Journey (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 1016, "Children|Comedy", null, "Shaggy Dog, The (1959)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 988, "Comedy|Drama", null, "Grace of My Heart (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 987, "Drama|Romance", null, "Bliss (1997)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 986, "Adventure|Children", null, "Fly Away Home (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 985, "Documentary", null, "Small Wonders (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 956, "Drama|Romance", null, "Penny Serenade (1941)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 957, "Drama", null, "Scarlet Letter, The (1926)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 958, "Comedy|Mystery", null, "Lady of Burlesque (1943)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 959, "Drama", null, "Of Human Bondage (1934)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 960, "Crime|Drama", null, "Angel on My Shoulder (1946)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 961, "Drama", null, "Little Lord Fauntleroy (1936)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 962, "Crime|Drama", null, "They Made Me a Criminal (I Became a Criminal) (They Made Me a Fugitive) (1939)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 963, "Musical", null, "Inspector General, The (1949)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 964, "Romance|Western", null, "Angel and the Badman (1947)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 965, "Drama|Mystery|Thriller", null, "39 Steps, The (1935)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 966, "War", null, "Walk in the Sun, A (1945)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 967, "Western", null, "Outlaw, The (1943)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 968, "Horror|Sci-Fi|Thriller", null, "Night of the Living Dead (1968)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 893, "Drama", null, "Mother Night (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 969, "Adventure|Comedy|Romance|War", null, "African Queen, The (1951)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 971, "Drama", null, "Cat on a Hot Tin Roof (1958)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 972, "Drama", null, "Last Time I Saw Paris, The (1954)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 973, "Comedy|Drama", null, "Meet John Doe (1941)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 974, "Drama|Romance", null, "Algiers (1938)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 975, "Comedy|Musical", null, "Something to Sing About (1937)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 976, "Romance|War", null, "Farewell to Arms, A (1932)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 977, "Mystery", null, "Moonlight Murder (1936)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 979, "Drama|War", null, "Nothing Personal (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 980, "Action", null, "Yes, Madam (a.k.a. Police Assassins) (a.k.a. In the Line of Duty 2) (Huang gu shi jie) (1985)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 981, "Drama", null, "Dangerous Ground (1997)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 982, "Drama", null, "Picnic (1955)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 983, "Romance", null, "Madagascar Skin (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 984, "Comedy|Drama", null, "Pompatus of Love, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 970, "Adventure|Comedy|Crime|Drama|Romance", null, "Beat the Devil (1953)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 763, "Comedy|Drama", null, "Last of the High Kings, The (a.k.a. Summer Fling) (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 892, "Comedy|Drama|Romance", null, "Twelfth Night (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 890, "Thriller", null, "Baton Rouge (Bâton rouge) (1988)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 796, "Drama", null, "Very Natural Thing, A (1974)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 797, "Comedy", null, "Old Lady Who Walked in the Sea, The (Vieille qui marchait dans la mer, La) (1991)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 798, "Action|Adventure|Drama|Thriller", null, "Daylight (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 799, "Comedy|Horror|Thriller", null, "Frighteners, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 800, "Drama|Mystery|Western", null, "Lone Star (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 801, "Children|Comedy", null, "Harriet the Spy (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 802, "Drama|Romance", null, "Phenomenon (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 803, "Comedy|Drama|Romance", null, "Walking and Talking (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 804, "Comedy|Romance", null, "She's the One (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 805, "Drama|Thriller", null, "Time to Kill, A (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 806, "Crime|Drama", null, "American Buffalo (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 807, "Comedy|Romance", null, "Rendezvous in Paris (Rendez-vous de Paris, Les) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 808, "Adventure|Children", null, "Alaska (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 809, "Action|Adventure", null, "Fled (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 810, "Children|Comedy|Fantasy", null, "Kazaam (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 812, "Drama", null, "Magic Hunter (Büvös vadász) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 813, "Comedy", null, "Larger Than Life (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 814, "Drama", null, "Boy Called Hate, A (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 815, "Action|Mystery|Thriller", null, "Power 98 (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 816, "Drama", null, "Two Deaths (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 818, "Comedy", null, "Very Brady Sequel, A (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 819, "Comedy|Drama", null, "Stefano Quantestorie (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 820, "Drama", null, "Death in the Garden (Mort en ce jardin, La) (1956)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 821, "Drama|Romance", null, "Crude Oasis, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 822, "Drama|Romance|War", null, "Hedd Wyn (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 823, "Drama", null, "Collector, The (La collectionneuse) (1967)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 824, "Drama|Mystery", null, "Kaspar Hauser (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 795, "Drama", null, "Somebody to Love (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 825, "Comedy|Romance", null, "Regular Guys (Echte Kerle) (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 794, "Comedy|Drama", null, "Midnight Dancers (Sibak) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 792, "Fantasy", null, "Hungarian Fairy Tale, A (Hol volt, hol nem volt) (1987)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 765, "Comedy|Drama", null, "Jack (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 766, "Drama", null, "I Shot Andy Warhol (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 767, "Comedy|Drama", null, "Grass Harp, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 768, "Drama", null, "Someone Else's America (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 769, "Documentary", null, "Marlene Dietrich: Shadow and Light (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 770, "Drama", null, "Costa Brava (1946)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 771, "Comedy|Drama", null, "Life Is Rosy (a.k.a. Life Is Beautiful) (Vie est belle, La) (1987)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 772, "Comedy", null, "Quartier Mozart (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 773, "Drama", null, "Touki Bouki (1973)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 774, "Drama", null, "Wend Kuuni (a.k.a. God's Gift) (1982)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 775, "Horror|Mystery", null, "Spirits of the Dead (1968)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 776, "Comedy|Drama", null, "Babyfever (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 777, "War", null, "Pharaoh's Army (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 778, "Comedy|Crime|Drama", null, "Trainspotting (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 779, "Drama|Romance", null, "'Til There Was You (1997)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 780, "Action|Adventure|Sci-Fi|Thriller", null, "Independence Day (a.k.a. ID4) (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 781, "Drama", null, "Stealing Beauty (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 782, "Drama|Thriller", null, "Fan, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 783, "Animation|Children|Drama|Musical|Romance", null, "Hunchback of Notre Dame, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 784, "Comedy|Thriller", null, "Cable Guy, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 785, "Comedy", null, "Kingpin (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 786, "Action|Drama|Thriller", null, "Eraser (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 787, "Documentary", null, "Gate of Heavenly Peace, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 788, "Comedy|Fantasy|Romance|Sci-Fi", null, "Nutty Professor, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 789, "Drama", null, "I, the Worst of All (Yo, la peor de todas) (1990)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 790, "Drama", null, "Unforgettable Summer, An (Un été inoubliable) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 791, "Documentary", null, "Last Klezmer: Leopold Kozlowski, His Life and Music, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 793, "Drama", null, "My Life and Times With Antonin Artaud (En compagnie d'Antonin Artaud) (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 826, "Drama", null, "Women Robbers (Diebinnen) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 827, "Drama", null, "Convent, The (O Convento) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 828, "Adventure|Children", null, "Adventures of Pinocchio, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 861, "Action|Comedy|Crime|Thriller", null, "Supercop (Police Story 3: Supercop) (Jing cha gu shi III: Chao ji jing cha) (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 862, "Drama", null, "Manny & Lo (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 864, "Comedy|Drama", null, "Wife, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 865, "Drama", null, "Small Faces (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 866, "Crime|Drama|Romance|Thriller", null, "Bound (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 867, "Comedy|Crime", null, "Carpool (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 868, "Comedy", null, "Death in Brunswick (1991)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 869, "Crime|Drama|Musical|Thriller", null, "Kansas City (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 870, "Comedy", null, "Gone Fishin' (1997)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 871, "Comedy", null, "Lover's Knot (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 872, "Drama", null, "Vive L'Amour (Ai qing wan sui) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 873, "Drama", null, "Shadow of Angels (Schatten der Engel) (1976)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 874, "Crime|Drama", null, "Killer: A Journal of Murder (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 875, "Action|Crime|Drama", null, "Nothing to Lose (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 876, "Action|Comedy|Crime|Thriller", null, "Supercop 2 (Project S) (Chao ji ji hua) (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 877, "Comedy|Drama", null, "Girls Town (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 878, "Drama", null, "Bye-Bye (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 879, "Horror|Thriller", null, "Relic, The (1997)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 880, "Sci-Fi|Thriller", null, "Island of Dr. Moreau, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 881, "Children|Comedy", null, "First Kid (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 882, "Drama|Thriller", null, "Trigger Effect, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 884, "Drama", null, "Sweet Nothing (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 885, "Children|Drama|Fantasy", null, "Bogus (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 886, "Action|Comedy|Crime", null, "Bulletproof (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 887, "Drama", null, "Talk of Angels (1998)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 888, "Adventure|Animation|Children|Musical", null, "Land Before Time III: The Time of the Great Giving (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 889, "Drama|Romance", null, "1-900 (06) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 860, "Comedy", null, "Maybe, Maybe Not (Bewegte Mann, Der) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 859, "Documentary", null, "Hippie Revolution, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 858, "Crime|Drama", null, "Godfather, The (1972)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 857, "Drama", null, "Crows and Sparrows (Wuya yu maque) (1949)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 829, "Comedy|Fantasy|Musical", null, "Joe's Apartment (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 830, "Comedy", null, "First Wives Club, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 831, "Drama", null, "Stonewall (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 832, "Crime|Thriller", null, "Ransom (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 833, "Comedy", null, "High School High (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 834, "Comedy", null, "Phat Beach (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 835, "Drama", null, "Foxfire (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 836, "Action|Adventure|Thriller", null, "Chain Reaction (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 837, "Children|Comedy|Fantasy", null, "Matilda (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 838, "Comedy|Drama|Romance", null, "Emma (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 839, "Action|Thriller", null, "Crow: City of Angels, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 840, "Children|Comedy", null, "House Arrest (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 841, "Horror", null, "Eyes Without a Face (Yeux sans visage, Les) (1959)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 891, "Horror|Thriller", null, "Halloween: The Curse of Michael Myers (Halloween 6: The Curse of Michael Myers) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 842, "Comedy|Horror", null, "Tales from the Crypt Presents: Bordello of Blood (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 844, "Drama", null, "Story of Xinghua, The (Xinghua san yue tian) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 845, "Drama", null, "Day the Sun Turned Cold, The (Tianguo niezi) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 846, "Drama", null, "Flirt (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 847, "Comedy|Drama", null, "Big Squeeze, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 848, "Drama", null, "Spitfire Grill, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 849, "Action|Adventure|Sci-Fi|Thriller", null, "Escape from L.A. (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 850, "Crime|Drama", null, "Cyclo (Xich lo) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 851, "Drama", null, "Basquiat (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 852, "Comedy|Drama|Romance", null, "Tin Cup (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 853, "Drama", null, "Dingo (1991)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 854, "Drama", null, "Ballad of Narayama, The (Narayama Bushiko) (1958)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 855, "Drama", null, "Every Other Weekend (Un week-end sur deux) (1990)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 856, "Comedy", null, "Mille bolle blu (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 843, "Drama", null, "Lotto Land (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 504, "Action|Drama|Sci-Fi", null, "No Escape (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 503, "Drama", null, "New Age, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 502, "Action|Children|Romance", null, "Next Karate Kid, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 159, "Crime|Drama|Mystery", null, "Clockers (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 160, "Action|Adventure|Mystery|Sci-Fi", null, "Congo (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 161, "Drama|Thriller|War", null, "Crimson Tide (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 162, "Documentary", null, "Crumb (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 163, "Action|Romance|Western", null, "Desperado (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 164, "Crime|Film-Noir|Mystery|Thriller", null, "Devil in a Blue Dress (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 165, "Action|Crime|Thriller", null, "Die Hard: With a Vengeance (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 166, "Comedy|Crime|Drama", null, "Doom Generation, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 167, "Drama", null, "Feast of July (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 168, "Action|Drama|Romance", null, "First Knight (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 169, "Adventure|Children|Drama", null, "Free Willy 2: The Adventure Home (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 170, "Action|Adventure|Crime|Thriller", null, "Hackers (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 171, "Comedy|Drama", null, "Jeffrey (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 172, "Action|Sci-Fi|Thriller", null, "Johnny Mnemonic (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 173, "Action|Crime|Sci-Fi", null, "Judge Dredd (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 174, "Comedy", null, "Jury Duty (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 175, "Drama", null, "Kids (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 176, "Comedy", null, "Living in Oblivion (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 177, "Horror", null, "Lord of Illusions (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 178, "Comedy|Drama", null, "Love & Human Remains (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 179, "Drama|Romance", null, "Mad Love (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 180, "Comedy|Romance", null, "Mallrats (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 181, "Action|Children", null, "Mighty Morphin Power Rangers: The Movie (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 182, "Drama|Romance", null, "Moonlight and Valentino (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 183, "Comedy|Horror|Thriller", null, "Mute Witness (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 184, "Drama", null, "Nadja (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 185, "Action|Crime|Thriller", null, "Net, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 158, "Adventure|Children", null, "Casper (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 186, "Comedy|Romance", null, "Nine Months (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 157, "Comedy|War", null, "Canadian Bacon (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 155, "Adventure|Drama|War", null, "Beyond Rangoon (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 128, "Documentary", null, "Jupiter's Wife (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 129, "Comedy|Romance", null, "Pie in the Sky (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 130, "Drama", null, "Angela (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 131, "Drama|Romance", null, "Frankie Starlight (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 132, "Thriller", null, "Jade (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 133, "Comedy|Drama", null, "Nueba Yol (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 134, "Documentary", null, "Sonic Outlaws (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 135, "Comedy", null, "Down Periscope (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 136, "Documentary", null, "From the Journals of Jean Seberg (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 137, "Documentary", null, "Man of the Year (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 138, "Drama", null, "Neon Bible, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 139, "Action|Drama", null, "Target (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 140, "Drama|Romance", null, "Up Close and Personal (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 141, "Comedy", null, "Birdcage, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 142, "Drama", null, "Shadows (Cienie) (1988)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 143, "Drama", null, "Gospa (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 144, "Comedy", null, "Brothers McMullen, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 145, "Action|Comedy|Crime|Drama|Thriller", null, "Bad Boys (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 146, "Adventure|Children", null, "Amazing Panda Adventure, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 147, "Drama", null, "Basketball Diaries, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 148, "Drama", null, "Awfully Big Adventure, An (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 149, "Crime|Drama|Thriller", null, "Amateur (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 150, "Adventure|Drama|IMAX", null, "Apollo 13 (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 151, "Action|Drama|Romance|War", null, "Rob Roy (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 152, "Drama|Horror", null, "Addiction, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 153, "Action|Adventure|Comedy|Crime", null, "Batman Forever (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 154, "Drama", null, "Beauty of the Day (Belle de jour) (1967)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 156, "Comedy|Drama", null, "Blue in the Face (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 187, "Comedy", null, "Party Girl (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 188, "Fantasy|Horror|Mystery", null, "Prophecy, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 189, "Comedy|Fantasy", null, "Reckless (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 223, "Comedy", null, "Clerks (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 224, "Comedy|Drama|Romance", null, "Don Juan DeMarco (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 225, "Drama|Thriller", null, "Disclosure (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 226, "Thriller", null, "Dream Man (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 227, "Action|Thriller", null, "Drop Zone (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 228, "Comedy", null, "Destiny Turns on the Radio (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 229, "Drama|Thriller", null, "Death and the Maiden (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 230, "Drama|Thriller", null, "Dolores Claiborne (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 231, "Adventure|Comedy", null, "Dumb & Dumber (Dumb and Dumber) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 232, "Comedy|Drama|Romance", null, "Eat Drink Man Woman (Yin shi nan nu) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 233, "Drama", null, "Exotica (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 234, "Comedy", null, "Exit to Eden (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 235, "Comedy|Drama", null, "Ed Wood (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 236, "Action|Comedy|Romance", null, "French Kiss (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 237, "Comedy|Romance", null, "Forget Paris (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 238, "Adventure|Children", null, "Far From Home: The Adventures of Yellow Dog (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 239, "Animation|Children|Comedy|Romance", null, "Goofy Movie, A (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 240, "Thriller", null, "Hideaway (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 241, "Children|Drama", null, "Fluke (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 242, "Drama|Musical", null, "Farinelli: il castrato (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 243, "Children|Comedy|Fantasy", null, "Gordy (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 244, "Animation|Children", null, "Gumby: The Movie (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 245, "Crime|Drama", null, "Glass Shield, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 246, "Documentary", null, "Hoop Dreams (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 247, "Crime|Drama", null, "Heavenly Creatures (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 248, "Comedy", null, "Houseguest (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 249, "Drama|Romance", null, "Immortal Beloved (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 222, "Drama|Romance", null, "Circle of Friends (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 220, "Horror", null, "Castle Freak (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 219, "Drama", null, "Cure, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 218, "Comedy|Drama", null, "Boys on the Side (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 190, "Thriller", null, "Safe (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 191, "Drama|Romance", null, "Scarlet Letter, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 192, "Documentary", null, "Show, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 193, "Drama", null, "Showgirls (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 194, "Comedy|Drama", null, "Smoke (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 195, "Comedy|Drama|Romance", null, "Something to Talk About (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 196, "Horror|Sci-Fi", null, "Species (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 197, "Drama", null, "Stars Fell on Henrietta, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 198, "Action|Crime|Drama|Mystery|Sci-Fi|Thriller", null, "Strange Days (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 199, "Drama|Musical|Romance", null, "Umbrellas of Cherbourg, The (Parapluies de Cherbourg, Les) (1964)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 200, "Thriller", null, "Tie That Binds, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 201, "Drama|Fantasy", null, "Three Wishes (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 202, "Drama|Romance", null, "Total Eclipse (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 127, "Drama", null, "Silences of the Palace, The (Saimt el Qusur) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 203, "Comedy", null, "To Wong Foo, Thanks for Everything! Julie Newmar (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 205, "Comedy|Drama", null, "Unstrung Heroes (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 206, "Documentary", null, "Unzipped (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 207, "Drama|Romance", null, "Walk in the Clouds, A (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 208, "Action|Adventure|Sci-Fi", null, "Waterworld (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 209, "Drama", null, "White Man's Burden (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 210, "Western", null, "Wild Bill (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 211, "Drama", null, "Browning Version, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 212, "Adventure|Comedy|Crime|Mystery", null, "Bushwhacked (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 213, "Drama", null, "Burnt by the Sun (Utomlyonnye solntsem) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 214, "Drama|War", null, "Before the Rain (Pred dozhdot) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 215, "Drama|Romance", null, "Before Sunrise (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 216, "Comedy", null, "Billy Madison (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 217, "Drama|Thriller", null, "Babysitter, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 204, "Action", null, "Under Siege 2: Dark Territory (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 250, "Children|Comedy", null, "Heavyweights (Heavy Weights) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 126, "Adventure|Children|Fantasy", null, "NeverEnding Story III, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 124, "Drama", null, "Star Maker, The (Uomo delle stelle, L') (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 33, "Adventure|Romance|IMAX", null, "Wings of Courage (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 34, "Children|Drama", null, "Babe (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 35, "Drama|Romance", null, "Carrington (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 36, "Crime|Drama", null, "Dead Man Walking (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 37, "Documentary|IMAX", null, "Across the Sea of Time (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 38, "Children|Comedy", null, "It Takes Two (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 39, "Comedy|Romance", null, "Clueless (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 40, "Drama", null, "Cry, the Beloved Country (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 41, "Drama|War", null, "Richard III (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 42, "Action|Crime|Drama", null, "Dead Presidents (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 43, "Drama", null, "Restoration (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 44, "Action|Adventure|Fantasy", null, "Mortal Kombat (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 45, "Comedy|Drama|Thriller", null, "To Die For (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 46, "Drama|Romance", null, "How to Make an American Quilt (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 47, "Mystery|Thriller", null, "Seven (a.k.a. Se7en) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 48, "Animation|Children|Drama|Musical|Romance", null, "Pocahontas (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 49, "Drama|Romance", null, "When Night Is Falling (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 50, "Crime|Mystery|Thriller", null, "Usual Suspects, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 51, "Action|Drama|Thriller", null, "Guardian Angel (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 52, "Comedy|Drama|Romance", null, "Mighty Aphrodite (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 53, "Adventure|Drama", null, "Lamerica (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 54, "Children|Comedy", null, "Big Green, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 55, "Drama", null, "Georgia (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 56, "Adventure|Children|Fantasy", null, "Kids of the Round Table (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 57, "Drama", null, "Home for the Holidays (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 58, "Comedy|Drama|Romance", null, "Postman, The (Postino, Il) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 59, "Drama|Mystery", null, "Confessional, The (Confessionnal, Le) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 32, "Mystery|Sci-Fi|Thriller", null, "Twelve Monkeys (a.k.a. 12 Monkeys) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 60, "Adventure|Children|Fantasy", null, "Indian in the Cupboard, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 31, "Drama", null, "Dangerous Minds (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 29, "Adventure|Drama|Fantasy|Mystery|Sci-Fi", null, "City of Lost Children, The (Cité des enfants perdus, La) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 2, "Adventure|Children|Fantasy", null, "Jumanji (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 3, "Comedy|Romance", null, "Grumpier Old Men (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 4, "Comedy|Drama|Romance", null, "Waiting to Exhale (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 5, "Comedy", null, "Father of the Bride Part II (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 6, "Action|Crime|Thriller", null, "Heat (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 7, "Comedy|Romance", null, "Sabrina (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 8, "Adventure|Children", null, "Tom and Huck (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 9, "Action", null, "Sudden Death (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 10, "Action|Adventure|Thriller", null, "GoldenEye (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 11, "Comedy|Drama|Romance", null, "American President, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 12, "Comedy|Horror", null, "Dracula: Dead and Loving It (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 13, "Adventure|Animation|Children", null, "Balto (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 14, "Drama", null, "Nixon (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 15, "Action|Adventure|Romance", null, "Cutthroat Island (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 16, "Crime|Drama", null, "Casino (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 17, "Drama|Romance", null, "Sense and Sensibility (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 18, "Comedy", null, "Four Rooms (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 19, "Comedy", null, "Ace Ventura: When Nature Calls (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 20, "Action|Comedy|Crime|Drama|Thriller", null, "Money Train (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 21, "Comedy|Crime|Thriller", null, "Get Shorty (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 22, "Crime|Drama|Horror|Mystery|Thriller", null, "Copycat (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 23, "Action|Crime|Thriller", null, "Assassins (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 24, "Drama|Sci-Fi", null, "Powder (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 25, "Drama|Romance", null, "Leaving Las Vegas (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 26, "Drama", null, "Othello (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 27, "Children|Drama", null, "Now and Then (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 28, "Drama|Romance", null, "Persuasion (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 30, "Crime|Drama", null, "Shanghai Triad (Yao a yao yao dao waipo qiao) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 61, "Drama|Thriller", null, "Eye for an Eye (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 62, "Drama", null, "Mr. Holland's Opus (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 63, "Comedy|Crime", null, "Don't Be a Menace to South Central While Drinking Your Juice in the Hood (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 97, "Crime|Drama", null, "Hate (Haine, La) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 98, "Action|Thriller", null, "Shopping (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 99, "Documentary", null, "Heidi Fleiss: Hollywood Madam (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 100, "Drama|Thriller", null, "City Hall (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 101, "Adventure|Comedy|Crime|Romance", null, "Bottle Rocket (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 102, "Comedy", null, "Mr. Wrong (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 103, "Mystery|Sci-Fi|Thriller", null, "Unforgettable (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 104, "Comedy", null, "Happy Gilmore (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 105, "Drama|Romance", null, "Bridges of Madison County, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 106, "Comedy|Drama", null, "Nobody Loves Me (Keiner liebt mich) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 107, "Adventure|Children|Comedy|Musical", null, "Muppet Treasure Island (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 108, "Documentary", null, "Catwalk (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 109, "Comedy|Drama|Thriller", null, "Headless Body in Topless Bar (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 110, "Action|Drama|War", null, "Braveheart (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 111, "Crime|Drama|Thriller", null, "Taxi Driver (1976)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 112, "Action|Adventure|Comedy|Crime", null, "Rumble in the Bronx (Hont faan kui) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 113, "Drama|Mystery", null, "Before and After (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 114, "Drama", null, "Margaret's Museum (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 115, "Comedy", null, "Happiness Is in the Field (Bonheur est dans le pré, Le) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 116, "Documentary", null, "Anne Frank Remembered (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 117, "Crime|Drama", null, "Young Poisoner's Handbook, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 118, "Comedy|Romance", null, "If Lucy Fell (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 119, "Comedy", null, "Steal Big, Steal Little (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 120, "Adventure|Comedy|Drama", null, "Race the Sun (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 121, "Drama", null, "Boys of St. Vincent, The (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 122, "Comedy|Romance", null, "Boomerang (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 123, "Drama|Mystery|Romance", null, "Chungking Express (Chung Hing sam lam) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 96, "Comedy|Drama", null, "In the Bleak Midwinter (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 95, "Action|Adventure|Thriller", null, "Broken Arrow (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 94, "Comedy|Drama|Romance", null, "Beautiful Girls (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 93, "Comedy|Horror|Romance", null, "Vampire in Brooklyn (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 64, "Comedy|Romance", null, "Two if by Sea (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 65, "Comedy", null, "Bio-Dome (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 66, "Action|Sci-Fi|Thriller", null, "Lawnmower Man 2: Beyond Cyberspace (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 67, "Drama", null, "Two Bits (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 68, "Comedy|Romance", null, "French Twist (Gazon maudit) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 69, "Comedy", null, "Friday (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 70, "Action|Comedy|Horror|Thriller", null, "From Dusk Till Dawn (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 71, "Action", null, "Fair Game (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 72, "Comedy|Drama", null, "Kicking and Screaming (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 73, "Drama|War", null, "Misérables, Les (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 74, "Drama|Romance", null, "Bed of Roses (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 75, "Comedy|Drama", null, "Big Bully (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 76, "Action|Sci-Fi|Thriller", null, "Screamers (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 125, "Comedy", null, "Flirting With Disaster (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 77, "Documentary", null, "Nico Icon (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 79, "Drama|Thriller", null, "Juror, The (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 80, "Children|Drama", null, "White Balloon, The (Badkonake sefid) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 81, "Crime|Drama|Romance", null, "Things to Do in Denver When You're Dead (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 82, "Comedy|Drama", null, "Antonia's Line (Antonia) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 83, "Drama|Romance", null, "Once Upon a Time... When We Were Colored (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 84, "Comedy|Drama", null, "Last Summer in the Hamptons (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 85, "Drama|Romance", null, "Angels and Insects (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 86, "Action|Adventure|Drama", null, "White Squall (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 87, "Children|Comedy", null, "Dunston Checks In (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 88, "Comedy", null, "Black Sheep (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 89, "Action|Thriller", null, "Nick of Time (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 90, "Drama", null, "Journey of August King, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 92, "Drama|Horror|Thriller", null, "Mary Reilly (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 78, "Action|Crime|Drama|Thriller", null, "Crossing Guard, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 251, "Action", null, "Hunted, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 252, "Comedy|Romance", null, "I.Q. (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 253, "Drama|Horror", null, "Interview with the Vampire: The Vampire Chronicles (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 412, "Drama", null, "Age of Innocence, The (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 413, "Comedy", null, "Airheads (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 414, "Comedy", null, "Air Up There, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 415, "Comedy|Thriller", null, "Another Stakeout (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 416, "Western", null, "Bad Girls (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 417, "Comedy|Romance", null, "Barcelona (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 418, "Drama", null, "Being Human (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 419, "Comedy", null, "Beverly Hillbillies, The (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 420, "Action|Comedy|Crime|Thriller", null, "Beverly Hills Cop III (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 421, "Adventure|Children|Drama", null, "Black Beauty (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 422, "Thriller", null, "Blink (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 423, "Action|Thriller", null, "Blown Away (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 424, "Drama", null, "Blue Chips (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 425, "Drama|Romance", null, "Blue Sky (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 426, "Horror|Sci-Fi|Thriller", null, "Body Snatchers (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 427, "Drama|Mystery|Romance|Thriller", null, "Boxing Helena (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 428, "Drama", null, "Bronx Tale, A (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 429, "Comedy", null, "Cabin Boy (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 430, "Comedy|Drama", null, "Calendar Girl (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 431, "Crime|Drama", null, "Carlito's Way (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 432, "Adventure|Comedy|Western", null, "City Slickers II: The Legend of Curly's Gold (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 433, "Comedy", null, "Clean Slate (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 434, "Action|Adventure|Thriller", null, "Cliffhanger (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 435, "Comedy|Sci-Fi", null, "Coneheads (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 436, "Drama|Thriller", null, "Color of Night (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 437, "Comedy", null, "Cops and Robbersons (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 438, "Action|Comedy|Drama", null, "Cowboy Way, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 411, "Comedy|Documentary", null, "Martin Lawrence: You So Crazy (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 439, "Drama", null, "Dangerous Game (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 410, "Children|Comedy|Fantasy", null, "Addams Family Values (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 408, "Drama", null, "8 Seconds (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 381, "Drama|Romance", null, "When a Man Loves a Woman (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 382, "Drama|Horror|Romance|Thriller", null, "Wolf (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 383, "Western", null, "Wyatt Earp (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 384, "Action|Crime|Drama", null, "Bad Company (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 385, "Drama", null, "Man of No Importance, A (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 386, "Drama", null, "S.F.W. (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 387, "Action|Comedy", null, "Low Down Dirty Shame, A (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 388, "Drama", null, "Boys Life (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 389, "Drama|Romance|War", null, "Colonel Chabert, Le (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 390, "Action|Crime|Drama", null, "Faster Pussycat! Kill! Kill! (1965)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 391, "Crime|Drama", null, "Jason's Lyric (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 392, "Adventure|Animation", null, "Secret Adventures of Tom Thumb, The (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 393, "Action|Adventure|Fantasy", null, "Street Fighter (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 394, "Comedy", null, "Coldblooded (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 395, "Drama|Fantasy|Romance", null, "Desert Winds (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 396, "Drama", null, "Fall Time (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 397, "Horror", null, "Fear, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 398, "Documentary", null, "Frank and Ollie (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 399, "Drama", null, "Girl in the Cadillac (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 400, "Drama", null, "Homage (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 401, "Action|Thriller", null, "Mirage (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 402, "Comedy", null, "Open Season (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 403, "Comedy|Crime|Drama", null, "Two Crimes (Dos crímenes) (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 404, "Documentary", null, "Brother Minister: The Assassination of Malcolm X (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 405, "Action|Fantasy", null, "Highlander III: The Sorcerer (a.k.a. Highlander: The Final Dimension) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 406, "Drama", null, "Federal Hill (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 407, "Horror|Thriller", null, "In the Mouth of Madness (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 409, "Crime|Drama", null, "Above the Rim (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 440, "Comedy|Romance", null, "Dave (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 441, "Comedy", null, "Dazed and Confused (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 442, "Action|Adventure|Sci-Fi", null, "Demolition Man (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 475, "Drama", null, "In the Name of the Father (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 476, "Comedy|Drama", null, "Inkwell, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 477, "Drama|Musical", null, "What's Love Got to Do with It? (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 478, "Comedy|Crime|Drama", null, "Jimmy Hollywood (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 479, "Action|Crime|Thriller", null, "Judgment Night (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 480, "Action|Adventure|Sci-Fi|Thriller", null, "Jurassic Park (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 481, "Drama|Thriller", null, "Kalifornia (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 482, "Crime|Drama|Thriller", null, "Killing Zoe (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 483, "Drama", null, "King of the Hill (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 484, "Adventure|Children", null, "Lassie (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 485, "Action|Adventure|Comedy|Fantasy", null, "Last Action Hero (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 486, "Comedy", null, "Life with Mikey (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 487, "Comedy|Western", null, "Lightning Jack (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 488, "Drama|Romance", null, "M. Butterfly (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 489, "Comedy", null, "Made in America (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 490, "Thriller", null, "Malice (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 491, "Drama", null, "Man Without a Face, The (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 492, "Comedy|Mystery", null, "Manhattan Murder Mystery (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 493, "Action|Crime|Drama", null, "Menace II Society (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 494, "Action|Adventure|Thriller", null, "Executive Decision (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 495, "Drama", null, "In the Realm of the Senses (Ai no corrida) (1976)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 496, "Comedy|Drama|Romance|Thriller", null, "What Happened Was... (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 497, "Comedy|Romance", null, "Much Ado About Nothing (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 498, "Drama|Romance", null, "Mr. Jones (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 499, "Comedy|Romance", null, "Mr. Wonderful (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 500, "Comedy|Drama", null, "Mrs. Doubtfire (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 501, "Drama", null, "Naked (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 474, "Action|Thriller", null, "In the Line of Fire (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 473, "Comedy|War", null, "In the Army Now (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 472, "Comedy|Drama", null, "I'll Do Anything (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 471, "Comedy", null, "Hudsucker Proxy, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 443, "Adventure|Documentary", null, "Endless Summer 2, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 444, "Comedy|Romance", null, "Even Cowgirls Get the Blues (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 445, "Comedy", null, "Fatal Instinct (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 446, "Drama|Romance", null, "Farewell My Concubine (Ba wang bie ji) (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 447, "Comedy|Romance", null, "Favor, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 448, "Drama", null, "Fearless (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 449, "Comedy", null, "Fear of a Black Hat (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 450, "Comedy|Drama", null, "With Honors (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 451, "Drama|Mystery|Romance", null, "Flesh and Bone (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 452, "Drama", null, "Widows' Peak (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 453, "Comedy|Romance", null, "For Love or Money (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 454, "Drama|Thriller", null, "Firm, The (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 455, "Adventure|Children|Drama", null, "Free Willy (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 380, "Action|Adventure|Comedy|Romance|Thriller", null, "True Lies (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 456, "Crime|Drama|Thriller", null, "Fresh (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 458, "Drama|Western", null, "Geronimo: An American Legend (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 459, "Action|Adventure|Crime|Drama|Romance|Thriller", null, "Getaway, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 460, "Comedy", null, "Getting Even with Dad (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 461, "Drama|Romance", null, "Go Fish (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 462, "Action|Adventure", null, "Good Man in Africa, A (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 463, "Crime|Drama|Thriller", null, "Guilty as Sin (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 464, "Action|Adventure|Crime|Thriller", null, "Hard Target (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 465, "Action|Drama|War", null, "Heaven & Earth (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 466, "Action|Comedy|War", null, "Hot Shots! Part Deux (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 467, "Comedy", null, "Live Nude Girls (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 468, "Comedy|Romance", null, "Englishman Who Went Up a Hill But Came Down a Mountain, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 469, "Drama|Romance", null, "House of the Spirits, The (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 470, "Comedy", null, "House Party 3 (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 457, "Thriller", null, "Fugitive, The (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 379, "Action|Sci-Fi|Thriller", null, "Timecop (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 378, "Comedy|Romance", null, "Speechless (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 377, "Action|Romance|Thriller", null, "Speed (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 286, "Action|Sci-Fi|Thriller", null, "Nemesis 2: Nebula (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 287, "Comedy|Romance", null, "Nina Takes a Lover (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 288, "Action|Crime|Thriller", null, "Natural Born Killers (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 289, "Comedy|Romance", null, "Only You (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 290, "Crime|Drama", null, "Once Were Warriors (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 291, "Drama|Thriller", null, "Poison Ivy II (1996)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 292, "Action|Drama|Sci-Fi|Thriller", null, "Outbreak (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 293, "Action|Crime|Drama|Thriller", null, "Léon: The Professional (a.k.a. The Professional) (Léon) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 294, "Comedy|Romance", null, "Perez Family, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 295, "Comedy|Romance", null, "Pyromaniac's Love Story, A (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 296, "Comedy|Crime|Drama|Thriller", null, "Pulp Fiction (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 297, "Drama", null, "Panther (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 298, "Drama", null, "Pushing Hands (Tui shou) (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 299, "Drama", null, "Priest (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 300, "Drama", null, "Quiz Show (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 301, "Drama|Romance", null, "Picture Bride (Bijo photo) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 302, "Drama|Romance", null, "Queen Margot (Reine Margot, La) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 303, "Action|Thriller|Western", null, "Quick and the Dead, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 304, "Comedy|Drama", null, "Roommates (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 305, "Comedy", null, "Ready to Wear (Pret-A-Porter) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 306, "Drama", null, "Three Colors: Red (Trois couleurs: Rouge) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 307, "Drama", null, "Three Colors: Blue (Trois couleurs: Bleu) (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 308, "Comedy|Drama", null, "Three Colors: White (Trzy kolory: Bialy) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 309, "Drama", null, "Red Firecracker, Green Firecracker (Pao Da Shuang Deng) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 310, "Comedy", null, "Rent-a-Kid (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 311, "Horror|Thriller", null, "Relative Fear (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 312, "Comedy", null, "Stuart Saves His Family (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 285, "Drama|Horror", null, "Beyond Bedlam (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 284, "Action|Crime", null, "New York Cop (Nyû Yôku no koppu) (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 283, "Crime|Drama", null, "New Jersey Drive (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 282, "Drama", null, "Nell (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 254, "Drama", null, "Jefferson in Paris (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 255, "Comedy", null, "Jerky Boys, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 256, "Comedy|Sci-Fi", null, "Junior (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 257, "Mystery|Thriller", null, "Just Cause (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 258, "Adventure|Children|Comedy|Fantasy|Romance", null, "Kid in King Arthur's Court, A (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 259, "Crime|Drama|Thriller", null, "Kiss of Death (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 260, "Action|Adventure|Sci-Fi", null, "Star Wars: Episode IV - A New Hope (1977)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 261, "Drama", null, "Little Women (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 262, "Children|Drama", null, "Little Princess, A (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 263, "Drama", null, "Ladybird Ladybird (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 264, "Drama", null, "Enfer, L' (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 265, "Drama|Fantasy|Romance", null, "Like Water for Chocolate (Como agua para chocolate) (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 266, "Drama|Romance|War|Western", null, "Legends of the Fall (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 313, "Animation|Children", null, "Swan Princess, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 267, "Comedy", null, "Major Payne (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 269, "Drama", null, "My Crazy Life (Mi vida loca) (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 270, "Drama|Romance", null, "Love Affair (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 271, "Drama", null, "Losing Isaiah (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 272, "Comedy|Drama", null, "Madness of King George, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 273, "Drama|Horror|Sci-Fi", null, "Mary Shelley's Frankenstein (Frankenstein) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 274, "Comedy", null, "Man of the House (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 275, "Comedy", null, "Mixed Nuts (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 276, "Comedy|Romance", null, "Milk Money (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 277, "Drama", null, "Miracle on 34th Street (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 278, "Comedy", null, "Miami Rhapsody (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 279, "Drama", null, "My Family (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 280, "Drama|Thriller", null, "Murder in the First (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 281, "Comedy|Drama|Romance", null, "Nobody's Fool (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 268, "Crime|Drama", null, "Little Odessa (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 1017, "Adventure|Children", null, "Swiss Family Robinson (1960)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 314, "Children|Drama|Fantasy|Mystery", null, "Secret of Roan Inish, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 316, "Action|Adventure|Sci-Fi", null, "Stargate (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 350, "Drama|Mystery|Thriller", null, "Client, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 351, "Comedy|Drama|Romance", null, "Corrina, Corrina (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 352, "Comedy|Drama", null, "Crooklyn (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 353, "Action|Crime|Fantasy|Thriller", null, "Crow, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 354, "Drama", null, "Cobb (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 355, "Children|Comedy|Fantasy", null, "Flintstones, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 356, "Comedy|Drama|Romance|War", null, "Forrest Gump (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 357, "Comedy|Romance", null, "Four Weddings and a Funeral (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 358, "Drama", null, "Higher Learning (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 359, "Comedy|Drama|Romance", null, "I Like It Like That (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 360, "Action|Comedy", null, "I Love Trouble (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 361, "Comedy|Drama|Romance", null, "It Could Happen to You (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 362, "Adventure|Children|Romance", null, "Jungle Book, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 363, "Documentary", null, "Wonderful, Horrible Life of Leni Riefenstahl, The (Macht der Bilder: Leni Riefenstahl, Die) (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 364, "Adventure|Animation|Children|Drama|Musical|IMAX", null, "Lion King, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 365, "Drama", null, "Little Buddha (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 366, "Drama|Horror|Mystery|Thriller", null, "Wes Craven's New Nightmare (Nightmare on Elm Street Part 7: Freddy's Finale, A) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 367, "Action|Comedy|Crime|Fantasy", null, "Mask, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 368, "Adventure|Comedy|Western", null, "Maverick (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 369, "Drama", null, "Mrs. Parker and the Vicious Circle (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 370, "Action|Comedy", null, "Naked Gun 33 1/3: The Final Insult (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 371, "Comedy|Drama", null, "Paper, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 372, "Comedy|Drama|Romance", null, "Reality Bites (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 373, "Thriller", null, "Red Rock West (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 374, "Children|Comedy", null, "Richie Rich (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 375, "Drama", null, "Safe Passage (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 376, "Action|Thriller", null, "River Wild, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 349, "Action|Crime|Drama|Thriller", null, "Clear and Present Danger (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 348, "Comedy", null, "Bullets Over Broadway (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 347, "Drama|Film-Noir|Romance", null, "Bitter Moon (1992)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 346, "Drama|Musical", null, "Backbeat (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 317, "Comedy|Drama|Fantasy", null, "Santa Clause, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 318, "Crime|Drama", null, "Shawshank Redemption, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 319, "Comedy|Drama|Thriller", null, "Shallow Grave (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 320, "Film-Noir|Thriller", null, "Suture (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 321, "Drama", null, "Strawberry and Chocolate (Fresa y chocolate) (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 322, "Comedy|Drama", null, "Swimming with Sharks (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 324, "Comedy|Drama", null, "Sum of Us, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 325, "Comedy", null, "National Lampoon's Senior Trip (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 326, "Drama", null, "To Live (Huozhe) (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 327, "Action|Comedy|Sci-Fi", null, "Tank Girl (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 328, "Horror|Thriller", null, "Tales from the Crypt Presents: Demon Knight (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 329, "Adventure|Drama|Sci-Fi", null, "Star Trek: Generations (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 330, "Action|Crime|Horror", null, "Tales from the Hood (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 315, "Action|Drama|Thriller", null, "Specialist, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 331, "Drama", null, "Tom & Viv (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 333, "Comedy", null, "Tommy Boy (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 334, "Drama", null, "Vanya on 42nd Street (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 335, "Mystery|Thriller", null, "Underneath (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 336, "Drama|War", null, "Walking Dead, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 337, "Drama", null, "What's Eating Gilbert Grape (1993)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 338, "Action|Sci-Fi|Thriller", null, "Virtuosity (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 339, "Comedy|Romance", null, "While You Were Sleeping (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 340, "Adventure|Drama|War", null, "War, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 341, "Drama", null, "Double Happiness (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 342, "Comedy", null, "Muriel's Wedding (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 343, "Children", null, "Baby-Sitters Club, The (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 344, "Comedy", null, "Ace Ventura: Pet Detective (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 345, "Comedy|Drama", null, "Adventures of Priscilla, Queen of the Desert, The (1994)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 332, "Horror|Sci-Fi", null, "Village of the Damned (1995)" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genres", "Tag", "Title" },
                values: new object[] { 1018, "Children|Comedy|Mystery", null, "That Darn Cat! (1965)" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
