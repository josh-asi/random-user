using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RandomUser.Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: false),
                    PhoneNumber = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 1, new DateTime(2020, 2, 22, 12, 45, 40, 843, DateTimeKind.Local).AddTicks(5330), "Phillip.Gilbert@email.com", "Phillip", "https://randomuser.me/api/portraits/men/1.jpg", "Gilbert", 9692596, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 269, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(3490), "Percy.Perkins@email.com", "Percy", "https://randomuser.me/api/portraits/men/269.jpg", "Perkins", 1092246, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 268, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(3420), "Leroy.Evans@email.com", "Leroy", "https://randomuser.me/api/portraits/men/268.jpg", "Evans", 5485460, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 267, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(3320), "Julia.Banks@email.com", "Julia", "https://randomuser.me/api/portraits/women/267.jpg", "Banks", 1954960, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 266, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(3250), "Wilbert.Jennings@email.com", "Wilbert", "https://randomuser.me/api/portraits/men/266.jpg", "Jennings", 8982294, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 265, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(3180), "Ward.Vazquez@email.com", "Ward", "https://randomuser.me/api/portraits/men/265.jpg", "Vazquez", 5648871, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 264, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(3110), "Walter.Pierce@email.com", "Walter", "https://randomuser.me/api/portraits/men/264.jpg", "Pierce", 3174423, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 263, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(3040), "Eda.Garcia@email.com", "Eda", "https://randomuser.me/api/portraits/women/263.jpg", "Garcia", 3919067, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 262, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(2710), "Ann.Dean@email.com", "Ann", "https://randomuser.me/api/portraits/women/262.jpg", "Dean", 6282810, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 261, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(2630), "Millard.Benson@email.com", "Millard", "https://randomuser.me/api/portraits/men/261.jpg", "Benson", 4158613, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 270, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(3560), "Missouri.Hart@email.com", "Missouri", "https://randomuser.me/api/portraits/women/270.jpg", "Hart", 1057233, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 260, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(2560), "Harry.West@email.com", "Harry", "https://randomuser.me/api/portraits/men/260.jpg", "West", 5157390, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 258, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(2420), "Harvey.Allen@email.com", "Harvey", "https://randomuser.me/api/portraits/men/258.jpg", "Allen", 9686842, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 257, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(2290), "Blanch.Walters@email.com", "Blanch", "https://randomuser.me/api/portraits/women/257.jpg", "Walters", 5710188, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 256, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(2220), "Meta.Hawkins@email.com", "Meta", "https://randomuser.me/api/portraits/women/256.jpg", "Hawkins", 7880392, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 255, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(2150), "Floy.Adams@email.com", "Floy", "https://randomuser.me/api/portraits/women/255.jpg", "Adams", 9673694, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 254, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(2070), "Maggie.Marquez@email.com", "Maggie", "https://randomuser.me/api/portraits/women/254.jpg", "Marquez", 7065706, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 253, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(1960), "Albert.Bryant@email.com", "Albert", "https://randomuser.me/api/portraits/men/253.jpg", "Bryant", 2308066, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 252, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(1890), "Sadie.Carr@email.com", "Sadie", "https://randomuser.me/api/portraits/women/252.jpg", "Carr", 4237800, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 251, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(1820), "Lafayette.Vazquez@email.com", "Lafayette", "https://randomuser.me/api/portraits/men/251.jpg", "Vazquez", 7172996, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 250, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(1750), "Sanford.Graham@email.com", "Sanford", "https://randomuser.me/api/portraits/men/250.jpg", "Graham", 6073859, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 259, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(2490), "Asa.Snyder@email.com", "Asa", "https://randomuser.me/api/portraits/men/259.jpg", "Snyder", 4193435, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 271, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(3630), "Docia.Jensen@email.com", "Docia", "https://randomuser.me/api/portraits/women/271.jpg", "Jensen", 2251548, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 272, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(3700), "Johanna.Gonzales@email.com", "Johanna", "https://randomuser.me/api/portraits/women/272.jpg", "Gonzales", 8787858, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 273, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(3780), "Juanita.Klein@email.com", "Juanita", "https://randomuser.me/api/portraits/women/273.jpg", "Klein", 2964911, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 294, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(5400), "Lydia.Sanders@email.com", "Lydia", "https://randomuser.me/api/portraits/women/294.jpg", "Sanders", 1158296, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 293, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(5330), "Floy.Hughes@email.com", "Floy", "https://randomuser.me/api/portraits/women/293.jpg", "Hughes", 4513158, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 292, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(5260), "Elva.Morrison@email.com", "Elva", "https://randomuser.me/api/portraits/women/292.jpg", "Morrison", 2665708, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 291, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(5160), "Georgianna.Henry@email.com", "Georgianna", "https://randomuser.me/api/portraits/women/291.jpg", "Henry", 7928142, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 290, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(5090), "Alma.Sandoval@email.com", "Alma", "https://randomuser.me/api/portraits/women/290.jpg", "Sandoval", 6105729, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 289, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(5020), "Caroline.Bush@email.com", "Caroline", "https://randomuser.me/api/portraits/women/289.jpg", "Bush", 5479184, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 288, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(4950), "Lettie.Fletcher@email.com", "Lettie", "https://randomuser.me/api/portraits/women/288.jpg", "Fletcher", 8044379, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 287, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(4880), "Gordon.Cortez@email.com", "Gordon", "https://randomuser.me/api/portraits/men/287.jpg", "Cortez", 1988223, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 286, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(4810), "Warren.Simpson@email.com", "Warren", "https://randomuser.me/api/portraits/men/286.jpg", "Simpson", 3727647, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 285, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(4700), "Emily.Hunt@email.com", "Emily", "https://randomuser.me/api/portraits/women/285.jpg", "Hunt", 3809908, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 284, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(4620), "Lonnie.Robertson@email.com", "Lonnie", "https://randomuser.me/api/portraits/men/284.jpg", "Robertson", 3708498, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 283, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(4550), "Alexander.Ramos@email.com", "Alexander", "https://randomuser.me/api/portraits/men/283.jpg", "Ramos", 6195308, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 282, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(4480), "Barney.Hayes@email.com", "Barney", "https://randomuser.me/api/portraits/men/282.jpg", "Hayes", 5558072, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 281, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(4410), "Claudia.Perez@email.com", "Claudia", "https://randomuser.me/api/portraits/women/281.jpg", "Perez", 4205054, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 280, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(4340), "Myra.Lowe@email.com", "Myra", "https://randomuser.me/api/portraits/women/280.jpg", "Lowe", 9378791, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 279, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(4230), "Miles.Warren@email.com", "Miles", "https://randomuser.me/api/portraits/men/279.jpg", "Warren", 2571826, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 278, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(4160), "Alexander.Herrera@email.com", "Alexander", "https://randomuser.me/api/portraits/men/278.jpg", "Herrera", 1414637, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 277, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(4090), "Dan.Nunez@email.com", "Dan", "https://randomuser.me/api/portraits/men/277.jpg", "Nunez", 8018309, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 276, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(4020), "Calvin.Steele@email.com", "Calvin", "https://randomuser.me/api/portraits/men/276.jpg", "Steele", 1801843, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 275, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(3950), "Isaiah.Dixon@email.com", "Isaiah", "https://randomuser.me/api/portraits/men/275.jpg", "Dixon", 6935261, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 274, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(3870), "Helena.Cummings@email.com", "Helena", "https://randomuser.me/api/portraits/women/274.jpg", "Cummings", 1697204, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 249, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(1680), "Hanna.Parks@email.com", "Hanna", "https://randomuser.me/api/portraits/women/249.jpg", "Parks", 1855263, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 248, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(1610), "Bess.Barrett@email.com", "Bess", "https://randomuser.me/api/portraits/women/248.jpg", "Barrett", 8082317, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 247, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(1500), "Florence.Gomez@email.com", "Florence", "https://randomuser.me/api/portraits/women/247.jpg", "Gomez", 4582200, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 246, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(1430), "Alta.Mclaughlin@email.com", "Alta", "https://randomuser.me/api/portraits/women/246.jpg", "Mclaughlin", 1746852, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 220, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(9450), "Joshua.May@email.com", "Joshua", "https://randomuser.me/api/portraits/men/220.jpg", "May", 3250542, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 219, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(9380), "Melissa.Scott@email.com", "Melissa", "https://randomuser.me/api/portraits/women/219.jpg", "Scott", 5590501, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 218, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(9280), "Irvin.Tucker@email.com", "Irvin", "https://randomuser.me/api/portraits/men/218.jpg", "Tucker", 9593561, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 217, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(9210), "Dick.May@email.com", "Dick", "https://randomuser.me/api/portraits/men/217.jpg", "May", 5487544, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 216, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(9140), "Antonio.Hudson@email.com", "Antonio", "https://randomuser.me/api/portraits/men/216.jpg", "Hudson", 9748843, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 215, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(9060), "Clifton.Graves@email.com", "Clifton", "https://randomuser.me/api/portraits/men/215.jpg", "Graves", 8966108, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 214, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(8990), "Ollie.Phillips@email.com", "Ollie", "https://randomuser.me/api/portraits/men/214.jpg", "Phillips", 3517139, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 213, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(8920), "Lillian.Bennett@email.com", "Lillian", "https://randomuser.me/api/portraits/women/213.jpg", "Bennett", 3792727, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 212, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(8790), "Columbus.Doyle@email.com", "Columbus", "https://randomuser.me/api/portraits/men/212.jpg", "Doyle", 2019606, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 211, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(8710), "Alex.Watkins@email.com", "Alex", "https://randomuser.me/api/portraits/men/211.jpg", "Watkins", 2226316, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 210, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(8640), "Mathilda.Dennis@email.com", "Mathilda", "https://randomuser.me/api/portraits/women/210.jpg", "Dennis", 9716072, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 209, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(8570), "Letha.Baldwin@email.com", "Letha", "https://randomuser.me/api/portraits/women/209.jpg", "Baldwin", 7450797, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 208, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(8500), "Daisy.Nichols@email.com", "Daisy", "https://randomuser.me/api/portraits/women/208.jpg", "Nichols", 3295894, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 207, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(8430), "Neil.Pearson@email.com", "Neil", "https://randomuser.me/api/portraits/men/207.jpg", "Pearson", 2435161, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 206, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(8330), "Dick.Hardy@email.com", "Dick", "https://randomuser.me/api/portraits/men/206.jpg", "Hardy", 5056797, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 205, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(8260), "Katherine.Bowen@email.com", "Katherine", "https://randomuser.me/api/portraits/women/205.jpg", "Bowen", 7587404, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 204, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(8190), "Lura.Hicks@email.com", "Lura", "https://randomuser.me/api/portraits/women/204.jpg", "Hicks", 2907538, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 203, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(8120), "Samuel.Romero@email.com", "Samuel", "https://randomuser.me/api/portraits/men/203.jpg", "Romero", 5270662, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 202, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(8040), "Horace.Kim@email.com", "Horace", "https://randomuser.me/api/portraits/men/202.jpg", "Kim", 7113274, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 201, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(7930), "Gilbert.Boyd@email.com", "Gilbert", "https://randomuser.me/api/portraits/men/201.jpg", "Boyd", 2229058, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 200, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(7860), "Cecilia.Elliott@email.com", "Cecilia", "https://randomuser.me/api/portraits/women/200.jpg", "Elliott", 4641211, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 221, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(9520), "Barbara.Chandler@email.com", "Barbara", "https://randomuser.me/api/portraits/women/221.jpg", "Chandler", 5884264, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 295, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(5470), "Roxie.Barber@email.com", "Roxie", "https://randomuser.me/api/portraits/women/295.jpg", "Barber", 3087348, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 222, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(9590), "Missouri.Carr@email.com", "Missouri", "https://randomuser.me/api/portraits/women/222.jpg", "Carr", 7790809, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 224, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(9730), "Benjiman.Peters@email.com", "Benjiman", "https://randomuser.me/api/portraits/men/224.jpg", "Peters", 3281222, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 245, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(1360), "Don.Castillo@email.com", "Don", "https://randomuser.me/api/portraits/men/245.jpg", "Castillo", 8116809, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 244, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(1290), "Rosie.Elliott@email.com", "Rosie", "https://randomuser.me/api/portraits/women/244.jpg", "Elliott", 8147820, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 243, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(1220), "Myrtie.Shelton@email.com", "Myrtie", "https://randomuser.me/api/portraits/women/243.jpg", "Shelton", 9191693, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 242, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(1150), "Dennis.Murray@email.com", "Dennis", "https://randomuser.me/api/portraits/men/242.jpg", "Murray", 4750413, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 241, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(1040), "Ernest.James@email.com", "Ernest", "https://randomuser.me/api/portraits/men/241.jpg", "James", 3626038, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 240, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(970), "Russell.Ward@email.com", "Russell", "https://randomuser.me/api/portraits/men/240.jpg", "Ward", 7581861, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 239, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(900), "Bessie.Campbell@email.com", "Bessie", "https://randomuser.me/api/portraits/women/239.jpg", "Campbell", 6417873, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 238, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(820), "Verna.Crawford@email.com", "Verna", "https://randomuser.me/api/portraits/women/238.jpg", "Crawford", 5335095, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 237, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(750), "Elisha.Montgomery@email.com", "Elisha", "https://randomuser.me/api/portraits/men/237.jpg", "Montgomery", 7395032, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 236, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(680), "Clem.Freeman@email.com", "Clem", "https://randomuser.me/api/portraits/men/236.jpg", "Freeman", 8330136, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 235, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(580), "Nell.Mcdaniel@email.com", "Nell", "https://randomuser.me/api/portraits/women/235.jpg", "Mcdaniel", 4710560, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 234, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(510), "Laura.Fernandez@email.com", "Laura", "https://randomuser.me/api/portraits/women/234.jpg", "Fernandez", 2200860, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 233, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(440), "Claudia.Shelton@email.com", "Claudia", "https://randomuser.me/api/portraits/women/233.jpg", "Shelton", 4949624, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 232, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(370), "Eula.Simpson@email.com", "Eula", "https://randomuser.me/api/portraits/women/232.jpg", "Simpson", 8265241, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 231, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(300), "Selma.Sutton@email.com", "Selma", "https://randomuser.me/api/portraits/women/231.jpg", "Sutton", 7467826, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 230, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(190), "Lyda.Thompson@email.com", "Lyda", "https://randomuser.me/api/portraits/women/230.jpg", "Thompson", 2824468, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 229, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(120), "Mayme.Rojas@email.com", "Mayme", "https://randomuser.me/api/portraits/women/229.jpg", "Rojas", 6593144, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 228, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(50), "Alvin.Navarro@email.com", "Alvin", "https://randomuser.me/api/portraits/men/228.jpg", "Navarro", 3806218, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 227, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(9980), "Dallas.Murphy@email.com", "Dallas", "https://randomuser.me/api/portraits/men/227.jpg", "Murphy", 4721488, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 226, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(9910), "Eliza.Castro@email.com", "Eliza", "https://randomuser.me/api/portraits/women/226.jpg", "Castro", 3297079, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 225, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(9830), "Mack.Carpenter@email.com", "Mack", "https://randomuser.me/api/portraits/men/225.jpg", "Carpenter", 4270226, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 223, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(9660), "Christopher.Ruiz@email.com", "Christopher", "https://randomuser.me/api/portraits/men/223.jpg", "Ruiz", 6638317, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 199, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(7790), "Ophelia.Carlson@email.com", "Ophelia", "https://randomuser.me/api/portraits/women/199.jpg", "Carlson", 2291864, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 296, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(5540), "Wayne.Rice@email.com", "Wayne", "https://randomuser.me/api/portraits/men/296.jpg", "Rice", 4465885, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 298, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(5800), "Delbert.Turner@email.com", "Delbert", "https://randomuser.me/api/portraits/men/298.jpg", "Turner", 2904703, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 368, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(1190), "Emil.Fisher@email.com", "Emil", "https://randomuser.me/api/portraits/men/368.jpg", "Fisher", 8945109, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 367, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(1120), "Lilly.Alvarez@email.com", "Lilly", "https://randomuser.me/api/portraits/women/367.jpg", "Alvarez", 3453704, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 366, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(1030), "Rosie.Reynolds@email.com", "Rosie", "https://randomuser.me/api/portraits/women/366.jpg", "Reynolds", 4003544, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 365, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(960), "Ambrose.Carpenter@email.com", "Ambrose", "https://randomuser.me/api/portraits/men/365.jpg", "Carpenter", 2020610, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 364, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(890), "Julia.Frazier@email.com", "Julia", "https://randomuser.me/api/portraits/women/364.jpg", "Frazier", 7282112, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 363, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(820), "Wilbert.Graham@email.com", "Wilbert", "https://randomuser.me/api/portraits/men/363.jpg", "Graham", 2419920, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 362, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(750), "Cornelius.Guzman@email.com", "Cornelius", "https://randomuser.me/api/portraits/men/362.jpg", "Guzman", 3107227, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 361, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(680), "Everett.Klein@email.com", "Everett", "https://randomuser.me/api/portraits/men/361.jpg", "Klein", 4818857, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 360, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(570), "Dollie.Campbell@email.com", "Dollie", "https://randomuser.me/api/portraits/women/360.jpg", "Campbell", 3164869, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 369, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(1260), "Elwood.Vazquez@email.com", "Elwood", "https://randomuser.me/api/portraits/men/369.jpg", "Vazquez", 5179081, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 359, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(500), "Dee.Hoffman@email.com", "Dee", "https://randomuser.me/api/portraits/men/359.jpg", "Hoffman", 4185152, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 357, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(360), "Moses.Silva@email.com", "Moses", "https://randomuser.me/api/portraits/men/357.jpg", "Silva", 7208675, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 356, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(290), "Stephen.Shelton@email.com", "Stephen", "https://randomuser.me/api/portraits/men/356.jpg", "Shelton", 3364234, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 355, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(220), "Zora.Boyd@email.com", "Zora", "https://randomuser.me/api/portraits/women/355.jpg", "Boyd", 4403616, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 354, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(110), "Idella.Moran@email.com", "Idella", "https://randomuser.me/api/portraits/women/354.jpg", "Moran", 1614131, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 353, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(40), "Nelle.Joseph@email.com", "Nelle", "https://randomuser.me/api/portraits/women/353.jpg", "Joseph", 1820367, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 352, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(9970), "Abbie.Ruiz@email.com", "Abbie", "https://randomuser.me/api/portraits/women/352.jpg", "Ruiz", 5260726, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 351, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(9900), "Roy.Hamilton@email.com", "Roy", "https://randomuser.me/api/portraits/men/351.jpg", "Hamilton", 9237151, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 350, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(9830), "Winfield.Pena@email.com", "Winfield", "https://randomuser.me/api/portraits/men/350.jpg", "Pena", 1946334, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 349, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(9700), "Curtis.Murphy@email.com", "Curtis", "https://randomuser.me/api/portraits/men/349.jpg", "Murphy", 2404689, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 358, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(430), "Lue.Oliver@email.com", "Lue", "https://randomuser.me/api/portraits/women/358.jpg", "Oliver", 2269964, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 370, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(1330), "Sam.Perkins@email.com", "Sam", "https://randomuser.me/api/portraits/men/370.jpg", "Perkins", 5206003, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 371, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(1400), "Walter.Edwards@email.com", "Walter", "https://randomuser.me/api/portraits/men/371.jpg", "Edwards", 8703335, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 372, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(1470), "Leonard.Butler@email.com", "Leonard", "https://randomuser.me/api/portraits/men/372.jpg", "Butler", 2329416, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 393, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(3090), "Lawson.Cox@email.com", "Lawson", "https://randomuser.me/api/portraits/men/393.jpg", "Cox", 5893120, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 392, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(3020), "Tony.Cook@email.com", "Tony", "https://randomuser.me/api/portraits/men/392.jpg", "Cook", 1823409, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 391, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(2950), "Leola.Erickson@email.com", "Leola", "https://randomuser.me/api/portraits/women/391.jpg", "Erickson", 7994255, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 390, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(2880), "Eleanor.Hoffman@email.com", "Eleanor", "https://randomuser.me/api/portraits/women/390.jpg", "Hoffman", 6080129, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 389, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(2770), "Jack.Payne@email.com", "Jack", "https://randomuser.me/api/portraits/men/389.jpg", "Payne", 6203606, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 388, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(2700), "Ned.Mills@email.com", "Ned", "https://randomuser.me/api/portraits/men/388.jpg", "Mills", 4159275, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 387, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(2630), "Lucy.Mendoza@email.com", "Lucy", "https://randomuser.me/api/portraits/women/387.jpg", "Mendoza", 6276247, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 386, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(2560), "Hubert.Moran@email.com", "Hubert", "https://randomuser.me/api/portraits/men/386.jpg", "Moran", 6200139, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 385, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(2490), "Agnes.Ellis@email.com", "Agnes", "https://randomuser.me/api/portraits/women/385.jpg", "Ellis", 1251867, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 384, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(2420), "Lonnie.Schmidt@email.com", "Lonnie", "https://randomuser.me/api/portraits/men/384.jpg", "Schmidt", 2261718, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 383, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(2320), "Wayne.Moreno@email.com", "Wayne", "https://randomuser.me/api/portraits/men/383.jpg", "Moreno", 5154287, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 382, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(2250), "Mina.Blair@email.com", "Mina", "https://randomuser.me/api/portraits/women/382.jpg", "Blair", 4508403, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 381, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(2170), "Marietta.Baker@email.com", "Marietta", "https://randomuser.me/api/portraits/women/381.jpg", "Baker", 3582705, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 380, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(2100), "Marie.Burton@email.com", "Marie", "https://randomuser.me/api/portraits/women/380.jpg", "Burton", 1963777, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 379, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(2040), "Joanna.Dixon@email.com", "Joanna", "https://randomuser.me/api/portraits/women/379.jpg", "Dixon", 3974090, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 378, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(1930), "Maude.Dixon@email.com", "Maude", "https://randomuser.me/api/portraits/women/378.jpg", "Dixon", 6993130, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 377, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(1860), "Michael.Cunningham@email.com", "Michael", "https://randomuser.me/api/portraits/men/377.jpg", "Cunningham", 5051236, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 376, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(1790), "Ella.Mann@email.com", "Ella", "https://randomuser.me/api/portraits/women/376.jpg", "Mann", 7517354, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 375, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(1720), "Sophia.Greene@email.com", "Sophia", "https://randomuser.me/api/portraits/women/375.jpg", "Greene", 7284547, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 374, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(1650), "Leota.Alvarez@email.com", "Leota", "https://randomuser.me/api/portraits/women/374.jpg", "Alvarez", 6783847, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 373, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(1580), "Francis.White@email.com", "Francis", "https://randomuser.me/api/portraits/women/373.jpg", "White", 5827465, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 348, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(9640), "Barney.Guerrero@email.com", "Barney", "https://randomuser.me/api/portraits/men/348.jpg", "Guerrero", 4304149, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 347, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(9570), "Madeline.White@email.com", "Madeline", "https://randomuser.me/api/portraits/women/347.jpg", "White", 7725354, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 346, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(9490), "Helen.Burton@email.com", "Helen", "https://randomuser.me/api/portraits/women/346.jpg", "Burton", 1610942, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 345, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(9420), "Lelia.Washington@email.com", "Lelia", "https://randomuser.me/api/portraits/women/345.jpg", "Washington", 9514446, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 319, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(7410), "Nick.Day@email.com", "Nick", "https://randomuser.me/api/portraits/men/319.jpg", "Day", 1983738, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 318, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(7340), "Jannie.Matthews@email.com", "Jannie", "https://randomuser.me/api/portraits/women/318.jpg", "Matthews", 6030783, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 317, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(7270), "Taylor.Jackson@email.com", "Taylor", "https://randomuser.me/api/portraits/men/317.jpg", "Jackson", 3747859, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 316, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(7200), "Marcus.Harrison@email.com", "Marcus", "https://randomuser.me/api/portraits/men/316.jpg", "Harrison", 6788721, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 315, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(7130), "Leota.Oconnor@email.com", "Leota", "https://randomuser.me/api/portraits/women/315.jpg", "Oconnor", 1083006, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 314, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(7020), "Lessie.Snyder@email.com", "Lessie", "https://randomuser.me/api/portraits/women/314.jpg", "Snyder", 8890751, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 313, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(6950), "Pete.Salazar@email.com", "Pete", "https://randomuser.me/api/portraits/men/313.jpg", "Salazar", 6582114, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 312, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(6880), "Spencer.Luna@email.com", "Spencer", "https://randomuser.me/api/portraits/men/312.jpg", "Luna", 7871443, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 311, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(6810), "Calvin.Lambert@email.com", "Calvin", "https://randomuser.me/api/portraits/men/311.jpg", "Lambert", 6046194, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 310, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(6740), "Eunice.Ramirez@email.com", "Eunice", "https://randomuser.me/api/portraits/women/310.jpg", "Ramirez", 5717918, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 309, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(6670), "Isabel.Powell@email.com", "Isabel", "https://randomuser.me/api/portraits/women/309.jpg", "Powell", 7210783, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 308, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(6570), "Zula.Rogers@email.com", "Zula", "https://randomuser.me/api/portraits/women/308.jpg", "Rogers", 3924277, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 307, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(6500), "Louie.Miles@email.com", "Louie", "https://randomuser.me/api/portraits/men/307.jpg", "Miles", 9086724, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 306, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(6430), "Rosetta.Elliott@email.com", "Rosetta", "https://randomuser.me/api/portraits/women/306.jpg", "Elliott", 9723140, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 305, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(6360), "Bud.Spencer@email.com", "Bud", "https://randomuser.me/api/portraits/men/305.jpg", "Spencer", 2150655, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 304, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(6290), "Nannie.Park@email.com", "Nannie", "https://randomuser.me/api/portraits/women/304.jpg", "Park", 5441199, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 303, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(6220), "Rosetta.Bryant@email.com", "Rosetta", "https://randomuser.me/api/portraits/women/303.jpg", "Bryant", 2234095, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 302, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(6080), "Warren.Rhodes@email.com", "Warren", "https://randomuser.me/api/portraits/men/302.jpg", "Rhodes", 2395945, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 301, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(6010), "Lenora.Cross@email.com", "Lenora", "https://randomuser.me/api/portraits/women/301.jpg", "Cross", 7221968, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 300, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(5940), "Barbara.Robertson@email.com", "Barbara", "https://randomuser.me/api/portraits/women/300.jpg", "Robertson", 3436004, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 299, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(5870), "Austin.Vasquez@email.com", "Austin", "https://randomuser.me/api/portraits/men/299.jpg", "Vasquez", 2547391, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 320, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(7480), "Malinda.Burton@email.com", "Malinda", "https://randomuser.me/api/portraits/women/320.jpg", "Burton", 5163989, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 297, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(5730), "Jessie.May@email.com", "Jessie", "https://randomuser.me/api/portraits/men/297.jpg", "May", 7563044, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 321, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(7590), "Caleb.Hughes@email.com", "Caleb", "https://randomuser.me/api/portraits/men/321.jpg", "Hughes", 7245403, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 323, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(7730), "Catherine.Douglas@email.com", "Catherine", "https://randomuser.me/api/portraits/women/323.jpg", "Douglas", 7108233, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 344, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(9360), "Silas.Dixon@email.com", "Silas", "https://randomuser.me/api/portraits/men/344.jpg", "Dixon", 1885790, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 343, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(9240), "Herman.Ramsey@email.com", "Herman", "https://randomuser.me/api/portraits/men/343.jpg", "Ramsey", 2481374, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 342, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(9170), "Millie.Sullivan@email.com", "Millie", "https://randomuser.me/api/portraits/women/342.jpg", "Sullivan", 3118898, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 341, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(9100), "Ellis.Campbell@email.com", "Ellis", "https://randomuser.me/api/portraits/men/341.jpg", "Campbell", 6828890, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 340, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(9030), "Agnes.Lewis@email.com", "Agnes", "https://randomuser.me/api/portraits/women/340.jpg", "Lewis", 9147005, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 339, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(8970), "Julius.Terry@email.com", "Julius", "https://randomuser.me/api/portraits/men/339.jpg", "Terry", 9049760, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 338, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(8900), "Elwood.Erickson@email.com", "Elwood", "https://randomuser.me/api/portraits/men/338.jpg", "Erickson", 1269701, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 337, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(8800), "Corinne.Bishop@email.com", "Corinne", "https://randomuser.me/api/portraits/women/337.jpg", "Bishop", 7372647, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 336, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(8730), "Rosetta.Powell@email.com", "Rosetta", "https://randomuser.me/api/portraits/women/336.jpg", "Powell", 5641135, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 335, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(8660), "Melissa.Soto@email.com", "Melissa", "https://randomuser.me/api/portraits/women/335.jpg", "Soto", 8637391, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 334, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(8590), "Matthew.Maldonado@email.com", "Matthew", "https://randomuser.me/api/portraits/men/334.jpg", "Maldonado", 8621291, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 333, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(8520), "Jim.Ward@email.com", "Jim", "https://randomuser.me/api/portraits/men/333.jpg", "Ward", 4801074, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 332, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(8440), "Ophelia.Walker@email.com", "Ophelia", "https://randomuser.me/api/portraits/women/332.jpg", "Walker", 3024645, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 331, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(8330), "Belle.Jordan@email.com", "Belle", "https://randomuser.me/api/portraits/women/331.jpg", "Jordan", 4279474, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 330, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(8260), "Silas.Tran@email.com", "Silas", "https://randomuser.me/api/portraits/men/330.jpg", "Tran", 6608987, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 329, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(8190), "Ruth.Jenkins@email.com", "Ruth", "https://randomuser.me/api/portraits/women/329.jpg", "Jenkins", 9908674, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 328, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(8120), "Lawson.Harris@email.com", "Lawson", "https://randomuser.me/api/portraits/men/328.jpg", "Harris", 7844739, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 327, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(8050), "Sudie.Martinez@email.com", "Sudie", "https://randomuser.me/api/portraits/women/327.jpg", "Martinez", 6606533, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 326, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(7980), "Reuben.Craig@email.com", "Reuben", "https://randomuser.me/api/portraits/men/326.jpg", "Craig", 3193054, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 325, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(7870), "Juanita.Edwards@email.com", "Juanita", "https://randomuser.me/api/portraits/women/325.jpg", "Edwards", 1669474, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 324, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(7800), "Archibald.Reed@email.com", "Archibald", "https://randomuser.me/api/portraits/men/324.jpg", "Reed", 3591011, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 322, new DateTime(2020, 2, 22, 12, 45, 40, 851, DateTimeKind.Local).AddTicks(7660), "Kathryn.Peters@email.com", "Kathryn", "https://randomuser.me/api/portraits/women/322.jpg", "Peters", 5909867, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 394, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(3170), "Betty.Boyd@email.com", "Betty", "https://randomuser.me/api/portraits/women/394.jpg", "Boyd", 2516075, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 198, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(7720), "Luther.Sullivan@email.com", "Luther", "https://randomuser.me/api/portraits/men/198.jpg", "Sullivan", 8579905, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 196, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(7580), "Wesley.Graves@email.com", "Wesley", "https://randomuser.me/api/portraits/men/196.jpg", "Graves", 3514691, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 71, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(7750), "Claude.Gutierrez@email.com", "Claude", "https://randomuser.me/api/portraits/men/71.jpg", "Gutierrez", 3705121, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 70, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(7680), "Annetta.Frazier@email.com", "Annetta", "https://randomuser.me/api/portraits/women/70.jpg", "Frazier", 8368735, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 69, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(7610), "Floyd.Flores@email.com", "Floyd", "https://randomuser.me/api/portraits/men/69.jpg", "Flores", 5215345, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 68, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(7500), "Ollie.Terry@email.com", "Ollie", "https://randomuser.me/api/portraits/men/68.jpg", "Terry", 4961292, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 67, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(7430), "Nelle.Wilson@email.com", "Nelle", "https://randomuser.me/api/portraits/women/67.jpg", "Wilson", 3703854, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 66, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(7360), "Margaret.Lyons@email.com", "Margaret", "https://randomuser.me/api/portraits/women/66.jpg", "Lyons", 2193108, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 65, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(7280), "Amy.Luna@email.com", "Amy", "https://randomuser.me/api/portraits/women/65.jpg", "Luna", 8858653, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 64, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(7210), "Julia.Parker@email.com", "Julia", "https://randomuser.me/api/portraits/women/64.jpg", "Parker", 1705985, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 63, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(7110), "Hardy.Price@email.com", "Hardy", "https://randomuser.me/api/portraits/men/63.jpg", "Price", 3655974, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 72, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(7820), "Sam.Ramsey@email.com", "Sam", "https://randomuser.me/api/portraits/men/72.jpg", "Ramsey", 5322005, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 62, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(7040), "Isabelle.Hale@email.com", "Isabelle", "https://randomuser.me/api/portraits/women/62.jpg", "Hale", 9357347, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 60, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(6890), "Anderson.Dominguez@email.com", "Anderson", "https://randomuser.me/api/portraits/men/60.jpg", "Dominguez", 6369984, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 59, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(6820), "Eliza.Hicks@email.com", "Eliza", "https://randomuser.me/api/portraits/women/59.jpg", "Hicks", 9910752, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 58, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(6700), "James.Schultz@email.com", "James", "https://randomuser.me/api/portraits/women/58.jpg", "Schultz", 2824597, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 57, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(6630), "Rosa.Olson@email.com", "Rosa", "https://randomuser.me/api/portraits/women/57.jpg", "Olson", 7865013, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 56, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(6560), "Marcus.Doyle@email.com", "Marcus", "https://randomuser.me/api/portraits/men/56.jpg", "Doyle", 9772615, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 55, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(6490), "Clayton.Harris@email.com", "Clayton", "https://randomuser.me/api/portraits/men/55.jpg", "Harris", 8868627, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 54, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(6420), "Flossie.Barnett@email.com", "Flossie", "https://randomuser.me/api/portraits/women/54.jpg", "Barnett", 3109975, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 53, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(6340), "Mose.Luna@email.com", "Mose", "https://randomuser.me/api/portraits/men/53.jpg", "Luna", 2034926, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 52, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(6230), "Simon.Lopez@email.com", "Simon", "https://randomuser.me/api/portraits/men/52.jpg", "Lopez", 7317138, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 61, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(6960), "Nathaniel.Wheeler@email.com", "Nathaniel", "https://randomuser.me/api/portraits/men/61.jpg", "Wheeler", 7576465, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 73, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(7900), "Cora.Nguyen@email.com", "Cora", "https://randomuser.me/api/portraits/women/73.jpg", "Nguyen", 6105355, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 74, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(7970), "Porter.Richards@email.com", "Porter", "https://randomuser.me/api/portraits/men/74.jpg", "Richards", 2558418, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 75, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(8110), "Isaac.Cohen@email.com", "Isaac", "https://randomuser.me/api/portraits/men/75.jpg", "Cohen", 2441094, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 96, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(9730), "Georgia.Kennedy@email.com", "Georgia", "https://randomuser.me/api/portraits/women/96.jpg", "Kennedy", 2782765, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 95, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(9660), "Ward.Vazquez@email.com", "Ward", "https://randomuser.me/api/portraits/men/95.jpg", "Vazquez", 3243845, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 94, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(9590), "Olivia.Vaughn@email.com", "Olivia", "https://randomuser.me/api/portraits/women/94.jpg", "Vaughn", 8590908, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 93, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(9520), "Judge.Bates@email.com", "Judge", "https://randomuser.me/api/portraits/men/93.jpg", "Bates", 7661506, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 92, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(9410), "Virgil.Murphy@email.com", "Virgil", "https://randomuser.me/api/portraits/men/92.jpg", "Murphy", 6177468, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 91, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(9340), "Loren.Mann@email.com", "Loren", "https://randomuser.me/api/portraits/men/91.jpg", "Mann", 7180788, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 90, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(9270), "Isabel.Edwards@email.com", "Isabel", "https://randomuser.me/api/portraits/women/90.jpg", "Edwards", 6368273, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 89, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(9200), "Dan.Howell@email.com", "Dan", "https://randomuser.me/api/portraits/men/89.jpg", "Howell", 6160130, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 88, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(9120), "Jannie.Robertson@email.com", "Jannie", "https://randomuser.me/api/portraits/women/88.jpg", "Robertson", 8485192, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 87, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(9050), "Hester.King@email.com", "Hester", "https://randomuser.me/api/portraits/women/87.jpg", "King", 3463119, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 86, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(8930), "Edwin.Garza@email.com", "Edwin", "https://randomuser.me/api/portraits/men/86.jpg", "Garza", 2372048, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 85, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(8860), "Lon.Cook@email.com", "Lon", "https://randomuser.me/api/portraits/men/85.jpg", "Cook", 6495248, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 84, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(8790), "Lela.Moreno@email.com", "Lela", "https://randomuser.me/api/portraits/women/84.jpg", "Moreno", 5048610, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 83, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(8720), "Lucius.Jennings@email.com", "Lucius", "https://randomuser.me/api/portraits/men/83.jpg", "Jennings", 4094835, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 82, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(8650), "James.Caldwell@email.com", "James", "https://randomuser.me/api/portraits/men/82.jpg", "Caldwell", 4824195, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 81, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(8580), "Clifford.Long@email.com", "Clifford", "https://randomuser.me/api/portraits/men/81.jpg", "Long", 8496180, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 80, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(8470), "Theresa.Spencer@email.com", "Theresa", "https://randomuser.me/api/portraits/women/80.jpg", "Spencer", 3578449, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 79, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(8400), "Dick.Lynch@email.com", "Dick", "https://randomuser.me/api/portraits/men/79.jpg", "Lynch", 4313022, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 78, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(8320), "Christine.Taylor@email.com", "Christine", "https://randomuser.me/api/portraits/women/78.jpg", "Taylor", 3865088, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 77, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(8250), "Cynthia.Howell@email.com", "Cynthia", "https://randomuser.me/api/portraits/women/77.jpg", "Howell", 5728679, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 76, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(8180), "Garfield.Duncan@email.com", "Garfield", "https://randomuser.me/api/portraits/men/76.jpg", "Duncan", 5333527, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 51, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(6160), "Goldie.Johnston@email.com", "Goldie", "https://randomuser.me/api/portraits/women/51.jpg", "Johnston", 7588792, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 50, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(6080), "Jay.Myers@email.com", "Jay", "https://randomuser.me/api/portraits/men/50.jpg", "Myers", 6928885, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 49, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(6010), "Alonzo.Carroll@email.com", "Alonzo", "https://randomuser.me/api/portraits/men/49.jpg", "Carroll", 8504032, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 48, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(5940), "Agnes.Vega@email.com", "Agnes", "https://randomuser.me/api/portraits/women/48.jpg", "Vega", 9220841, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 22, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(3790), "Cassie.Craig@email.com", "Cassie", "https://randomuser.me/api/portraits/women/22.jpg", "Craig", 2546492, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 21, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(3720), "Scott.Porter@email.com", "Scott", "https://randomuser.me/api/portraits/men/21.jpg", "Porter", 7003965, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 20, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(3640), "Olivia.Ramsey@email.com", "Olivia", "https://randomuser.me/api/portraits/women/20.jpg", "Ramsey", 3342191, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 19, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(3570), "Lafayette.Carlson@email.com", "Lafayette", "https://randomuser.me/api/portraits/men/19.jpg", "Carlson", 2371182, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 18, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(3490), "Lewis.Schultz@email.com", "Lewis", "https://randomuser.me/api/portraits/men/18.jpg", "Schultz", 2552012, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 17, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(3370), "Lucie.Curtis@email.com", "Lucie", "https://randomuser.me/api/portraits/women/17.jpg", "Curtis", 8912532, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 16, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(3300), "Mittie.Cruz@email.com", "Mittie", "https://randomuser.me/api/portraits/women/16.jpg", "Cruz", 6524425, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 15, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(3220), "Clarence.Harvey@email.com", "Clarence", "https://randomuser.me/api/portraits/men/15.jpg", "Harvey", 9148772, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 14, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(3150), "Miles.Mendoza@email.com", "Miles", "https://randomuser.me/api/portraits/men/14.jpg", "Mendoza", 5113668, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 13, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(3070), "Neal.Hart@email.com", "Neal", "https://randomuser.me/api/portraits/men/13.jpg", "Hart", 6119743, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 12, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(2950), "Millard.Evans@email.com", "Millard", "https://randomuser.me/api/portraits/men/12.jpg", "Evans", 4544312, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 11, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(2870), "Tony.Ford@email.com", "Tony", "https://randomuser.me/api/portraits/men/11.jpg", "Ford", 3359739, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 10, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(2790), "Manuel.Reid@email.com", "Manuel", "https://randomuser.me/api/portraits/men/10.jpg", "Reid", 2552231, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 9, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(2710), "Lulu.Tucker@email.com", "Lulu", "https://randomuser.me/api/portraits/women/9.jpg", "Tucker", 9858149, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 8, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(2630), "Augusta.Ray@email.com", "Augusta", "https://randomuser.me/api/portraits/women/8.jpg", "Ray", 3059791, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 7, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(2550), "Mark.Richardson@email.com", "Mark", "https://randomuser.me/api/portraits/men/7.jpg", "Richardson", 1938115, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 6, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(2410), "Claud.Parker@email.com", "Claud", "https://randomuser.me/api/portraits/men/6.jpg", "Parker", 3545004, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 5, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(2330), "Lydia.Mason@email.com", "Lydia", "https://randomuser.me/api/portraits/women/5.jpg", "Mason", 1959242, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 4, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(2250), "Jimmie.Woods@email.com", "Jimmie", "https://randomuser.me/api/portraits/men/4.jpg", "Woods", 3931607, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 3, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(2160), "Felix.Burns@email.com", "Felix", "https://randomuser.me/api/portraits/men/3.jpg", "Burns", 9748614, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 2, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(1980), "Viola.Moran@email.com", "Viola", "https://randomuser.me/api/portraits/women/2.jpg", "Moran", 1611218, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 23, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(3860), "Virgie.Fowler@email.com", "Virgie", "https://randomuser.me/api/portraits/women/23.jpg", "Fowler", 1588067, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 97, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(9810), "Taylor.Fields@email.com", "Taylor", "https://randomuser.me/api/portraits/men/97.jpg", "Fields", 4405823, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 24, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(3970), "Lilly.Turner@email.com", "Lilly", "https://randomuser.me/api/portraits/women/24.jpg", "Turner", 5117493, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 26, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(4120), "Magdalena.Hale@email.com", "Magdalena", "https://randomuser.me/api/portraits/women/26.jpg", "Hale", 1977037, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 47, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(5870), "Sanford.Hoffman@email.com", "Sanford", "https://randomuser.me/api/portraits/men/47.jpg", "Hoffman", 1983955, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 46, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(5760), "Simeon.Sims@email.com", "Simeon", "https://randomuser.me/api/portraits/men/46.jpg", "Sims", 4520796, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 45, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(5690), "Mildred.Murphy@email.com", "Mildred", "https://randomuser.me/api/portraits/women/45.jpg", "Murphy", 6629359, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 44, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(5610), "Silas.Quinn@email.com", "Silas", "https://randomuser.me/api/portraits/men/44.jpg", "Quinn", 1075703, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 43, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(5540), "Max.Owens@email.com", "Max", "https://randomuser.me/api/portraits/men/43.jpg", "Owens", 6624593, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 42, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(5470), "Sarah.Rodgers@email.com", "Sarah", "https://randomuser.me/api/portraits/women/42.jpg", "Rodgers", 8602193, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 41, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(5390), "Amos.Kelly@email.com", "Amos", "https://randomuser.me/api/portraits/men/41.jpg", "Kelly", 6385438, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 40, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(5280), "Alma.Curtis@email.com", "Alma", "https://randomuser.me/api/portraits/women/40.jpg", "Curtis", 2124579, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 39, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(5210), "Hubert.Park@email.com", "Hubert", "https://randomuser.me/api/portraits/men/39.jpg", "Park", 1193355, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 38, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(5140), "James.Hayes@email.com", "James", "https://randomuser.me/api/portraits/women/38.jpg", "Hayes", 6756694, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 37, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(5070), "Charlotte.Acosta@email.com", "Charlotte", "https://randomuser.me/api/portraits/women/37.jpg", "Acosta", 2601775, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 36, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(4990), "Hubert.Watson@email.com", "Hubert", "https://randomuser.me/api/portraits/men/36.jpg", "Watson", 4794914, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 35, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(4920), "Cal.Bowman@email.com", "Cal", "https://randomuser.me/api/portraits/men/35.jpg", "Bowman", 2761511, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 34, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(4810), "William.Schmidt@email.com", "William", "https://randomuser.me/api/portraits/women/34.jpg", "Schmidt", 7915885, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 33, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(4730), "Leola.Banks@email.com", "Leola", "https://randomuser.me/api/portraits/women/33.jpg", "Banks", 1844914, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 32, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(4660), "Jay.Vasquez@email.com", "Jay", "https://randomuser.me/api/portraits/men/32.jpg", "Vasquez", 5507179, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 31, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(4580), "Esther.Singh@email.com", "Esther", "https://randomuser.me/api/portraits/women/31.jpg", "Singh", 4365470, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 30, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(4510), "Willie.Norris@email.com", "Willie", "https://randomuser.me/api/portraits/women/30.jpg", "Norris", 6569020, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 29, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(4350), "Helen.Harvey@email.com", "Helen", "https://randomuser.me/api/portraits/women/29.jpg", "Harvey", 9844588, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 28, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(4270), "Marietta.Hicks@email.com", "Marietta", "https://randomuser.me/api/portraits/women/28.jpg", "Hicks", 2539905, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 27, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(4200), "Grace.Hernandez@email.com", "Grace", "https://randomuser.me/api/portraits/women/27.jpg", "Hernandez", 9802346, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 25, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(4040), "Owen.Boyd@email.com", "Owen", "https://randomuser.me/api/portraits/men/25.jpg", "Boyd", 9481540, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 197, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(7650), "Clem.Diaz@email.com", "Clem", "https://randomuser.me/api/portraits/men/197.jpg", "Diaz", 2797047, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 98, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(9880), "Mose.Hunter@email.com", "Mose", "https://randomuser.me/api/portraits/men/98.jpg", "Hunter", 7090147, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 100, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(60), "Ophelia.Greene@email.com", "Ophelia", "https://randomuser.me/api/portraits/women/100.jpg", "Greene", 1410549, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 170, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(5560), "Carolyn.Flores@email.com", "Carolyn", "https://randomuser.me/api/portraits/women/170.jpg", "Flores", 4889473, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 169, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(5480), "Rhoda.Becker@email.com", "Rhoda", "https://randomuser.me/api/portraits/women/169.jpg", "Becker", 1449289, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 168, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(5410), "Irma.Evans@email.com", "Irma", "https://randomuser.me/api/portraits/women/168.jpg", "Evans", 6409990, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 167, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(5340), "Ina.Simon@email.com", "Ina", "https://randomuser.me/api/portraits/women/167.jpg", "Simon", 5147068, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 166, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(5210), "Arch.Valdez@email.com", "Arch", "https://randomuser.me/api/portraits/men/166.jpg", "Valdez", 9119542, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 165, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(5140), "Berta.Hall@email.com", "Berta", "https://randomuser.me/api/portraits/women/165.jpg", "Hall", 9931418, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 164, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(5070), "Ada.Griffin@email.com", "Ada", "https://randomuser.me/api/portraits/women/164.jpg", "Griffin", 2413545, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 163, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(5000), "Hallie.Wilson@email.com", "Hallie", "https://randomuser.me/api/portraits/women/163.jpg", "Wilson", 3313715, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 162, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(4920), "Floyd.Stevens@email.com", "Floyd", "https://randomuser.me/api/portraits/men/162.jpg", "Stevens", 3789933, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 171, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(5630), "Clifford.Fernandez@email.com", "Clifford", "https://randomuser.me/api/portraits/men/171.jpg", "Fernandez", 3510861, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 161, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(4850), "Hardy.Ortega@email.com", "Hardy", "https://randomuser.me/api/portraits/men/161.jpg", "Ortega", 7274357, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 159, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(4670), "Ora.Ortega@email.com", "Ora", "https://randomuser.me/api/portraits/men/159.jpg", "Ortega", 7919556, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 158, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(4600), "Fredrick.Cooper@email.com", "Fredrick", "https://randomuser.me/api/portraits/men/158.jpg", "Cooper", 6185324, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 157, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(4540), "Meda.Lyons@email.com", "Meda", "https://randomuser.me/api/portraits/women/157.jpg", "Lyons", 3590774, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 156, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(4470), "George.Wagner@email.com", "George", "https://randomuser.me/api/portraits/men/156.jpg", "Wagner", 5506670, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 155, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(4400), "Clem.Greene@email.com", "Clem", "https://randomuser.me/api/portraits/men/155.jpg", "Greene", 3449789, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 154, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(4280), "Lemuel.Santiago@email.com", "Lemuel", "https://randomuser.me/api/portraits/men/154.jpg", "Santiago", 5110955, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 153, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(4210), "Felix.Hamilton@email.com", "Felix", "https://randomuser.me/api/portraits/men/153.jpg", "Hamilton", 4511061, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 152, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(4140), "Mark.Clark@email.com", "Mark", "https://randomuser.me/api/portraits/men/152.jpg", "Clark", 1708423, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 151, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(4070), "Clark.Bishop@email.com", "Clark", "https://randomuser.me/api/portraits/men/151.jpg", "Bishop", 3172291, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 160, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(4740), "Chas.Frazier@email.com", "Chas", "https://randomuser.me/api/portraits/men/160.jpg", "Frazier", 8728568, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 172, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(5700), "Delbert.Chambers@email.com", "Delbert", "https://randomuser.me/api/portraits/men/172.jpg", "Chambers", 8158018, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 173, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(5810), "Lou.Lawrence@email.com", "Lou", "https://randomuser.me/api/portraits/women/173.jpg", "Lawrence", 9689009, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 174, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(5880), "Lemuel.Murray@email.com", "Lemuel", "https://randomuser.me/api/portraits/men/174.jpg", "Murray", 4863451, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 195, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(7470), "Harold.Castro@email.com", "Harold", "https://randomuser.me/api/portraits/men/195.jpg", "Castro", 6383442, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 194, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(7400), "Chauncey.Aguilar@email.com", "Chauncey", "https://randomuser.me/api/portraits/men/194.jpg", "Aguilar", 4853231, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 193, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(7330), "Jean.Rodgers@email.com", "Jean", "https://randomuser.me/api/portraits/women/193.jpg", "Rodgers", 9133660, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 192, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(7250), "Christina.Woods@email.com", "Christina", "https://randomuser.me/api/portraits/women/192.jpg", "Woods", 7022689, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 191, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(7180), "Flossie.Schneider@email.com", "Flossie", "https://randomuser.me/api/portraits/women/191.jpg", "Schneider", 6835895, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 190, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(7110), "Nelson.Holmes@email.com", "Nelson", "https://randomuser.me/api/portraits/men/190.jpg", "Holmes", 9925313, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 189, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(7000), "Mae.Beck@email.com", "Mae", "https://randomuser.me/api/portraits/women/189.jpg", "Beck", 7995926, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 188, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(6930), "Ann.Shaw@email.com", "Ann", "https://randomuser.me/api/portraits/women/188.jpg", "Shaw", 6180410, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 187, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(6860), "Henry.Alexander@email.com", "Henry", "https://randomuser.me/api/portraits/men/187.jpg", "Alexander", 6124476, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 186, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(6800), "Isaiah.Hudson@email.com", "Isaiah", "https://randomuser.me/api/portraits/men/186.jpg", "Hudson", 7239805, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 185, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(6730), "Orville.Haynes@email.com", "Orville", "https://randomuser.me/api/portraits/men/185.jpg", "Haynes", 6383611, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 184, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(6660), "Adelaide.Price@email.com", "Adelaide", "https://randomuser.me/api/portraits/women/184.jpg", "Price", 5897740, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 183, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(6550), "Louise.Powers@email.com", "Louise", "https://randomuser.me/api/portraits/women/183.jpg", "Powers", 2318637, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 182, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(6480), "Mariah.Carter@email.com", "Mariah", "https://randomuser.me/api/portraits/women/182.jpg", "Carter", 1472274, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 181, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(6410), "Elwood.Simmons@email.com", "Elwood", "https://randomuser.me/api/portraits/men/181.jpg", "Simmons", 9218684, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 180, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(6340), "Sallie.Austin@email.com", "Sallie", "https://randomuser.me/api/portraits/women/180.jpg", "Austin", 1311384, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 179, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(6270), "Maurice.Wells@email.com", "Maurice", "https://randomuser.me/api/portraits/men/179.jpg", "Wells", 7578038, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 178, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(6200), "Allan.Page@email.com", "Allan", "https://randomuser.me/api/portraits/men/178.jpg", "Page", 3323424, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 177, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(6090), "Charley.Edwards@email.com", "Charley", "https://randomuser.me/api/portraits/men/177.jpg", "Edwards", 8363126, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 176, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(6020), "Bess.Perkins@email.com", "Bess", "https://randomuser.me/api/portraits/women/176.jpg", "Perkins", 6155798, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 175, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(5950), "Emery.Hansen@email.com", "Emery", "https://randomuser.me/api/portraits/men/175.jpg", "Hansen", 4558064, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 150, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(4000), "Roscoe.Howell@email.com", "Roscoe", "https://randomuser.me/api/portraits/men/150.jpg", "Howell", 8926032, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 149, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(3930), "Orville.Hamilton@email.com", "Orville", "https://randomuser.me/api/portraits/men/149.jpg", "Hamilton", 7579454, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 148, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(3820), "Edmond.Hale@email.com", "Edmond", "https://randomuser.me/api/portraits/men/148.jpg", "Hale", 8220047, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 147, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(3750), "Isabella.Tucker@email.com", "Isabella", "https://randomuser.me/api/portraits/women/147.jpg", "Tucker", 5625646, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 121, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(1690), "Evan.Banks@email.com", "Evan", "https://randomuser.me/api/portraits/men/121.jpg", "Banks", 6007427, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 120, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(1620), "Washington.Guzman@email.com", "Washington", "https://randomuser.me/api/portraits/men/120.jpg", "Guzman", 5986215, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 119, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(1550), "Lyman.Ruiz@email.com", "Lyman", "https://randomuser.me/api/portraits/men/119.jpg", "Ruiz", 4138550, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 118, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(1480), "Clifford.Gilbert@email.com", "Clifford", "https://randomuser.me/api/portraits/men/118.jpg", "Gilbert", 7095375, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 117, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(1410), "Minnie.Armstrong@email.com", "Minnie", "https://randomuser.me/api/portraits/women/117.jpg", "Armstrong", 5707454, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 116, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(1330), "Fannie.Watts@email.com", "Fannie", "https://randomuser.me/api/portraits/women/116.jpg", "Watts", 3747257, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 115, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(1220), "Dennis.Watson@email.com", "Dennis", "https://randomuser.me/api/portraits/men/115.jpg", "Watson", 8410575, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 114, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(1150), "Zelma.Chavez@email.com", "Zelma", "https://randomuser.me/api/portraits/women/114.jpg", "Chavez", 4292164, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 113, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(1080), "Dock.Gordon@email.com", "Dock", "https://randomuser.me/api/portraits/men/113.jpg", "Gordon", 3770955, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 112, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(1010), "Sylvester.Nelson@email.com", "Sylvester", "https://randomuser.me/api/portraits/men/112.jpg", "Nelson", 2762074, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 111, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(940), "Lucie.Chandler@email.com", "Lucie", "https://randomuser.me/api/portraits/women/111.jpg", "Chandler", 7069944, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 110, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(860), "Wallace.Hernandez@email.com", "Wallace", "https://randomuser.me/api/portraits/men/110.jpg", "Hernandez", 4233011, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 109, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(750), "Bernice.Dominguez@email.com", "Bernice", "https://randomuser.me/api/portraits/women/109.jpg", "Dominguez", 2210963, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 108, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(680), "Edd.Guzman@email.com", "Edd", "https://randomuser.me/api/portraits/men/108.jpg", "Guzman", 6158631, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 107, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(610), "Ward.Romero@email.com", "Ward", "https://randomuser.me/api/portraits/men/107.jpg", "Romero", 3736413, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 106, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(540), "Pearl.Horton@email.com", "Pearl", "https://randomuser.me/api/portraits/men/106.jpg", "Horton", 3720675, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 105, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(460), "Wilbur.Hunt@email.com", "Wilbur", "https://randomuser.me/api/portraits/men/105.jpg", "Hunt", 3941333, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 104, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(390), "Marcus.Bowman@email.com", "Marcus", "https://randomuser.me/api/portraits/men/104.jpg", "Bowman", 9824932, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 103, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(280), "Enoch.Haynes@email.com", "Enoch", "https://randomuser.me/api/portraits/men/103.jpg", "Haynes", 7542742, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 102, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(200), "Christine.Banks@email.com", "Christine", "https://randomuser.me/api/portraits/women/102.jpg", "Banks", 5849293, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 101, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(130), "Ray.Dominguez@email.com", "Ray", "https://randomuser.me/api/portraits/men/101.jpg", "Dominguez", 7088112, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 122, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(1820), "Lessie.Mason@email.com", "Lessie", "https://randomuser.me/api/portraits/women/122.jpg", "Mason", 7221701, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 99, new DateTime(2020, 2, 22, 12, 45, 40, 849, DateTimeKind.Local).AddTicks(9980), "Garfield.Bush@email.com", "Garfield", "https://randomuser.me/api/portraits/men/99.jpg", "Bush", 9850108, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 123, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(1890), "Mollie.Alvarado@email.com", "Mollie", "https://randomuser.me/api/portraits/women/123.jpg", "Alvarado", 5998601, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 125, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(2030), "Winifred.Ortega@email.com", "Winifred", "https://randomuser.me/api/portraits/women/125.jpg", "Ortega", 2473252, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 146, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(3680), "Matie.Hall@email.com", "Matie", "https://randomuser.me/api/portraits/women/146.jpg", "Hall", 3697754, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 145, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(3610), "Charlie.Burton@email.com", "Charlie", "https://randomuser.me/api/portraits/men/145.jpg", "Burton", 5169094, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 144, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(3540), "Anderson.Harrison@email.com", "Anderson", "https://randomuser.me/api/portraits/men/144.jpg", "Harrison", 8925027, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 143, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(3440), "Thomas.Jackson@email.com", "Thomas", "https://randomuser.me/api/portraits/men/143.jpg", "Jackson", 3107249, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 142, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(3370), "Elliott.Fleming@email.com", "Elliott", "https://randomuser.me/api/portraits/men/142.jpg", "Fleming", 9976857, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 141, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(3300), "Alpha.Castro@email.com", "Alpha", "https://randomuser.me/api/portraits/women/141.jpg", "Castro", 4454257, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 140, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(3220), "Nora.Simmons@email.com", "Nora", "https://randomuser.me/api/portraits/women/140.jpg", "Simmons", 7080612, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 139, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(3150), "Jessie.Lane@email.com", "Jessie", "https://randomuser.me/api/portraits/women/139.jpg", "Lane", 7988276, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 138, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(3080), "Lida.Baldwin@email.com", "Lida", "https://randomuser.me/api/portraits/women/138.jpg", "Baldwin", 5496150, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 137, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(2970), "Nathaniel.Warner@email.com", "Nathaniel", "https://randomuser.me/api/portraits/men/137.jpg", "Warner", 3509999, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 136, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(2900), "Georgia.Martin@email.com", "Georgia", "https://randomuser.me/api/portraits/women/136.jpg", "Martin", 9890357, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 135, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(2830), "Glenn.Lawrence@email.com", "Glenn", "https://randomuser.me/api/portraits/men/135.jpg", "Lawrence", 2889218, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 134, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(2760), "May.May@email.com", "May", "https://randomuser.me/api/portraits/women/134.jpg", "May", 8565358, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 133, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(2680), "Emmet.Marshall@email.com", "Emmet", "https://randomuser.me/api/portraits/men/133.jpg", "Marshall", 6494767, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 132, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(2610), "Pink.Castro@email.com", "Pink", "https://randomuser.me/api/portraits/men/132.jpg", "Castro", 8937188, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 131, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(2500), "Rudolph.Ford@email.com", "Rudolph", "https://randomuser.me/api/portraits/men/131.jpg", "Ford", 1145218, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 130, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(2430), "Addison.Phillips@email.com", "Addison", "https://randomuser.me/api/portraits/men/130.jpg", "Phillips", 4445172, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 129, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(2360), "Percy.Edwards@email.com", "Percy", "https://randomuser.me/api/portraits/men/129.jpg", "Edwards", 5801259, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 128, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(2290), "Isaiah.Holt@email.com", "Isaiah", "https://randomuser.me/api/portraits/men/128.jpg", "Holt", 9553026, "Mr" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 127, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(2180), "Alberta.Cummings@email.com", "Alberta", "https://randomuser.me/api/portraits/women/127.jpg", "Cummings", 9011932, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 126, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(2110), "Anne.Moreno@email.com", "Anne", "https://randomuser.me/api/portraits/women/126.jpg", "Moreno", 8085051, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 124, new DateTime(2020, 2, 22, 12, 45, 40, 850, DateTimeKind.Local).AddTicks(1960), "Vesta.Vasquez@email.com", "Vesta", "https://randomuser.me/api/portraits/women/124.jpg", "Vasquez", 3987694, "Ms" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DOB", "Email", "FirstName", "Image", "LastName", "PhoneNumber", "Title" },
                values: new object[] { 395, new DateTime(2020, 2, 22, 12, 45, 40, 852, DateTimeKind.Local).AddTicks(3240), "Hannah.Cooper@email.com", "Hannah", "https://randomuser.me/api/portraits/women/395.jpg", "Cooper", 6182365, "Ms" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
