using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Case_DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_survey_with_user : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "userID",
                table: "SurveyAnswers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SurveyAnswers_userID",
                table: "SurveyAnswers",
                column: "userID");

            migrationBuilder.AddForeignKey(
                name: "FK_SurveyAnswers_User_userID",
                table: "SurveyAnswers",
                column: "userID",
                principalTable: "User",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SurveyAnswers_User_userID",
                table: "SurveyAnswers");

            migrationBuilder.DropIndex(
                name: "IX_SurveyAnswers_userID",
                table: "SurveyAnswers");

            migrationBuilder.DropColumn(
                name: "userID",
                table: "SurveyAnswers");
        }
    }
}
