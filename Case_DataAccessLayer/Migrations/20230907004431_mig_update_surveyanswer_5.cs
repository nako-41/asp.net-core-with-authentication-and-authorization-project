using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Case_DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_update_surveyanswer_5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EducationInformation",
                table: "SurveyAnswers");

            migrationBuilder.AlterColumn<bool>(
                name: "Gender",
                table: "SurveyAnswers",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AddColumn<int>(
                name: "educationInformations",
                table: "SurveyAnswers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "educationInformations",
                table: "SurveyAnswers");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "SurveyAnswers",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<string>(
                name: "EducationInformation",
                table: "SurveyAnswers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
