using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Case_DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_update_surveyanswer_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Survey1",
                table: "SurveyAnswers",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Survey1",
                table: "SurveyAnswers",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
