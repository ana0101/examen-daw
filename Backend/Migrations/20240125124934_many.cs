using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamenDAW.Migrations
{
    /// <inheritdoc />
    public partial class many : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProfesoriMaterii",
                table: "ProfesoriMaterii");

            migrationBuilder.DropIndex(
                name: "IX_ProfesoriMaterii_ProfesorId",
                table: "ProfesoriMaterii");

            migrationBuilder.DropColumn(
                name: "IdProfesor",
                table: "ProfesoriMaterii");

            migrationBuilder.DropColumn(
                name: "IdMaterie",
                table: "ProfesoriMaterii");

            migrationBuilder.AlterColumn<int>(
                name: "ProfesorId",
                table: "ProfesoriMaterii",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 0);

            migrationBuilder.AlterColumn<int>(
                name: "MaterieId",
                table: "ProfesoriMaterii",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProfesoriMaterii",
                table: "ProfesoriMaterii",
                columns: new[] { "ProfesorId", "MaterieId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProfesoriMaterii",
                table: "ProfesoriMaterii");

            migrationBuilder.AlterColumn<int>(
                name: "MaterieId",
                table: "ProfesoriMaterii",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<int>(
                name: "ProfesorId",
                table: "ProfesoriMaterii",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 0);

            migrationBuilder.AddColumn<int>(
                name: "IdProfesor",
                table: "ProfesoriMaterii",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("Relational:ColumnOrder", 0);

            migrationBuilder.AddColumn<int>(
                name: "IdMaterie",
                table: "ProfesoriMaterii",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProfesoriMaterii",
                table: "ProfesoriMaterii",
                columns: new[] { "IdProfesor", "IdMaterie" });

            migrationBuilder.CreateIndex(
                name: "IX_ProfesoriMaterii_ProfesorId",
                table: "ProfesoriMaterii",
                column: "ProfesorId");
        }
    }
}
