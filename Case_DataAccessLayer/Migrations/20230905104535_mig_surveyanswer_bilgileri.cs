using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Case_DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_surveyanswer_bilgileri : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SurveyAnswers_SurveyQuestions_SurveyQuestionId",
                table: "SurveyAnswers");

            migrationBuilder.DropIndex(
                name: "IX_SurveyAnswers_SurveyQuestionId",
                table: "SurveyAnswers");

            migrationBuilder.DropColumn(
                name: "SurveyQuestionId",
                table: "SurveyAnswers");

            migrationBuilder.RenameColumn(
                name: "AnswerText",
                table: "SurveyAnswers",
                newName: "Survey5");

            migrationBuilder.AddColumn<string>(
                name: "Survey1",
                table: "SurveyAnswers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Survey2",
                table: "SurveyAnswers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Survey3",
                table: "SurveyAnswers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Survey4",
                table: "SurveyAnswers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Survey1",
                table: "SurveyAnswers");

            migrationBuilder.DropColumn(
                name: "Survey2",
                table: "SurveyAnswers");

            migrationBuilder.DropColumn(
                name: "Survey3",
                table: "SurveyAnswers");

            migrationBuilder.DropColumn(
                name: "Survey4",
                table: "SurveyAnswers");

            migrationBuilder.RenameColumn(
                name: "Survey5",
                table: "SurveyAnswers",
                newName: "AnswerText");

            migrationBuilder.AddColumn<int>(
                name: "SurveyQuestionId",
                table: "SurveyAnswers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SurveyAnswers_SurveyQuestionId",
                table: "SurveyAnswers",
                column: "SurveyQuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_SurveyAnswers_SurveyQuestions_SurveyQuestionId",
                table: "SurveyAnswers",
                column: "SurveyQuestionId",
                principalTable: "SurveyQuestions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
