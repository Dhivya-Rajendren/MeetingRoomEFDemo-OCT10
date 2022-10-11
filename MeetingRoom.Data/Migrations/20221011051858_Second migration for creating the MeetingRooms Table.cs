using Microsoft.EntityFrameworkCore.Migrations;

namespace MeetingRoom.Data.Migrations
{
    public partial class SecondmigrationforcreatingtheMeetingRoomsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MeetingRooms",
                columns: table => new
                {
                    RoomNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomName = table.Column<string>(type: "char(50)", maxLength: 50, nullable: false),
                    RoomType = table.Column<string>(type: "char(50)", maxLength: 50, nullable: false),
                    Location = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingRooms", x => x.RoomNo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeetingRooms");
        }
    }
}
