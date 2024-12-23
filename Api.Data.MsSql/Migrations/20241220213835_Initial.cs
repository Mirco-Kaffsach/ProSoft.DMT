using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProSoft.DMT.Api.Data.MsSql.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "data");

            migrationBuilder.CreateTable(
                name: "DockerHosts",
                schema: "data",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SystemId = table.Column<Guid>(type: "UNIQUEIDENTIFIER", nullable: false),
                    Title = table.Column<string>(type: "VARCHAR(128)", maxLength: 128, nullable: false),
                    FqdnIp = table.Column<string>(type: "VARCHAR(128)", maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(type: "BIT", nullable: false, defaultValue: true),
                    Created = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DockerHosts", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "UIX_data_DockerHosts_SystemId",
                schema: "data",
                table: "DockerHosts",
                column: "SystemId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DockerHosts",
                schema: "data");
        }
    }
}
