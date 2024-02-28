using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sanita.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Vitamin_VitaminPP",
                table: "ProductInfo",
                newName: "VitaminPP");

            migrationBuilder.RenameColumn(
                name: "Vitamin_VitaminK",
                table: "ProductInfo",
                newName: "VitaminK");

            migrationBuilder.RenameColumn(
                name: "Vitamin_VitaminE",
                table: "ProductInfo",
                newName: "VitaminE");

            migrationBuilder.RenameColumn(
                name: "Vitamin_VitaminD",
                table: "ProductInfo",
                newName: "VitaminD");

            migrationBuilder.RenameColumn(
                name: "Vitamin_VitaminC",
                table: "ProductInfo",
                newName: "VitaminC");

            migrationBuilder.RenameColumn(
                name: "Vitamin_VitaminB6",
                table: "ProductInfo",
                newName: "VitaminB6");

            migrationBuilder.RenameColumn(
                name: "Vitamin_VitaminB5",
                table: "ProductInfo",
                newName: "VitaminB5");

            migrationBuilder.RenameColumn(
                name: "Vitamin_VitaminB2",
                table: "ProductInfo",
                newName: "VitaminB2");

            migrationBuilder.RenameColumn(
                name: "Vitamin_VitaminB12",
                table: "ProductInfo",
                newName: "VitaminB12");

            migrationBuilder.RenameColumn(
                name: "Vitamin_VitaminB1",
                table: "ProductInfo",
                newName: "VitaminB1");

            migrationBuilder.RenameColumn(
                name: "Vitamin_VitaminA",
                table: "ProductInfo",
                newName: "VitaminA");

            migrationBuilder.RenameColumn(
                name: "Vitamin_FolidAcid",
                table: "ProductInfo",
                newName: "FolidAcid");

            migrationBuilder.RenameColumn(
                name: "Vitamin_Biotin",
                table: "ProductInfo",
                newName: "Biotin");

            migrationBuilder.RenameColumn(
                name: "Protein_Plant",
                table: "ProductInfo",
                newName: "PlantProtein");

            migrationBuilder.RenameColumn(
                name: "Protein_Animal",
                table: "ProductInfo",
                newName: "AnimalProtein");

            migrationBuilder.RenameColumn(
                name: "Mineral_Zinc",
                table: "ProductInfo",
                newName: "Zinc");

            migrationBuilder.RenameColumn(
                name: "Mineral_Sodium",
                table: "ProductInfo",
                newName: "Sodium");

            migrationBuilder.RenameColumn(
                name: "Mineral_Selenium",
                table: "ProductInfo",
                newName: "Selenium");

            migrationBuilder.RenameColumn(
                name: "Mineral_Potassium",
                table: "ProductInfo",
                newName: "Potassium");

            migrationBuilder.RenameColumn(
                name: "Mineral_Phosphorus",
                table: "ProductInfo",
                newName: "Phosphorus");

            migrationBuilder.RenameColumn(
                name: "Mineral_Magnesium",
                table: "ProductInfo",
                newName: "Magnesium");

            migrationBuilder.RenameColumn(
                name: "Mineral_Iron",
                table: "ProductInfo",
                newName: "Iron");

            migrationBuilder.RenameColumn(
                name: "Mineral_Iodine",
                table: "ProductInfo",
                newName: "Iodine");

            migrationBuilder.RenameColumn(
                name: "Mineral_Copper",
                table: "ProductInfo",
                newName: "Copper");

            migrationBuilder.RenameColumn(
                name: "Mineral_Calcium",
                table: "ProductInfo",
                newName: "Calcium");

            migrationBuilder.RenameColumn(
                name: "Fat_Saturated",
                table: "ProductInfo",
                newName: "Saturated");

            migrationBuilder.RenameColumn(
                name: "Fat_Polyunsaturated",
                table: "ProductInfo",
                newName: "Polyunsaturated");

            migrationBuilder.RenameColumn(
                name: "Fat_Omega6Acid",
                table: "ProductInfo",
                newName: "Omega6Acid");

            migrationBuilder.RenameColumn(
                name: "Fat_Omega3Acid",
                table: "ProductInfo",
                newName: "Omega3Acid");

            migrationBuilder.RenameColumn(
                name: "Fat_Monounsaturated",
                table: "ProductInfo",
                newName: "Monounsaturated");

            migrationBuilder.RenameColumn(
                name: "Carbohydrates_Sugars",
                table: "ProductInfo",
                newName: "Sugars");

            migrationBuilder.RenameColumn(
                name: "Carbohydrates_Salt",
                table: "ProductInfo",
                newName: "Salt");

            migrationBuilder.RenameColumn(
                name: "Carbohydrates_Fiber",
                table: "ProductInfo",
                newName: "Fiber");

            migrationBuilder.RenameColumn(
                name: "Carbohydrates_Choresterol",
                table: "ProductInfo",
                newName: "Choresterol");

            migrationBuilder.RenameColumn(
                name: "Carbohydrates_CarbohydratesNetto",
                table: "ProductInfo",
                newName: "CarbohydratesNetto");

            migrationBuilder.RenameColumn(
                name: "Carbohydrates_Caffeine",
                table: "ProductInfo",
                newName: "Caffeine");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TrainingTypes",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Trainings",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Weight",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "VitaminPP",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "VitaminK",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "VitaminE",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "VitaminD",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "VitaminC",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "VitaminB6",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "VitaminB5",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "VitaminB2",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "VitaminB12",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "VitaminB1",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "VitaminA",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FolidAcid",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Biotin",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Zinc",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Sodium",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Selenium",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Potassium",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Phosphorus",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Magnesium",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Iron",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Iodine",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Copper",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Calcium",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Saturated",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Polyunsaturated",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Omega6Acid",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Omega3Acid",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Monounsaturated",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Sugars",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salt",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Fiber",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Choresterol",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CarbohydratesNetto",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Caffeine",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Muscle",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Meals",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Meals",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Fridges",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ExerciseTypes",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Exercises",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Weigth",
                table: "BodyParameters",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Waist",
                table: "BodyParameters",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Thigh",
                table: "BodyParameters",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Stomach",
                table: "BodyParameters",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Neck",
                table: "BodyParameters",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Hips",
                table: "BodyParameters",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Heigth",
                table: "BodyParameters",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Forearm",
                table: "BodyParameters",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Chest",
                table: "BodyParameters",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Calf",
                table: "BodyParameters",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Biceps",
                table: "BodyParameters",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "BodyParameters",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "StatusId", "UserId" },
                values: new object[] { 1, new DateTime(2024, 2, 23, 3, 35, 57, 662, DateTimeKind.Local).AddTicks(1095), "test", null, "test", null, "test", 0, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BodyParameters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "Zinc",
                table: "ProductInfo",
                newName: "Mineral_Zinc");

            migrationBuilder.RenameColumn(
                name: "VitaminPP",
                table: "ProductInfo",
                newName: "Vitamin_VitaminPP");

            migrationBuilder.RenameColumn(
                name: "VitaminK",
                table: "ProductInfo",
                newName: "Vitamin_VitaminK");

            migrationBuilder.RenameColumn(
                name: "VitaminE",
                table: "ProductInfo",
                newName: "Vitamin_VitaminE");

            migrationBuilder.RenameColumn(
                name: "VitaminD",
                table: "ProductInfo",
                newName: "Vitamin_VitaminD");

            migrationBuilder.RenameColumn(
                name: "VitaminC",
                table: "ProductInfo",
                newName: "Vitamin_VitaminC");

            migrationBuilder.RenameColumn(
                name: "VitaminB6",
                table: "ProductInfo",
                newName: "Vitamin_VitaminB6");

            migrationBuilder.RenameColumn(
                name: "VitaminB5",
                table: "ProductInfo",
                newName: "Vitamin_VitaminB5");

            migrationBuilder.RenameColumn(
                name: "VitaminB2",
                table: "ProductInfo",
                newName: "Vitamin_VitaminB2");

            migrationBuilder.RenameColumn(
                name: "VitaminB12",
                table: "ProductInfo",
                newName: "Vitamin_VitaminB12");

            migrationBuilder.RenameColumn(
                name: "VitaminB1",
                table: "ProductInfo",
                newName: "Vitamin_VitaminB1");

            migrationBuilder.RenameColumn(
                name: "VitaminA",
                table: "ProductInfo",
                newName: "Vitamin_VitaminA");

            migrationBuilder.RenameColumn(
                name: "Sugars",
                table: "ProductInfo",
                newName: "Carbohydrates_Sugars");

            migrationBuilder.RenameColumn(
                name: "Sodium",
                table: "ProductInfo",
                newName: "Mineral_Sodium");

            migrationBuilder.RenameColumn(
                name: "Selenium",
                table: "ProductInfo",
                newName: "Mineral_Selenium");

            migrationBuilder.RenameColumn(
                name: "Saturated",
                table: "ProductInfo",
                newName: "Fat_Saturated");

            migrationBuilder.RenameColumn(
                name: "Salt",
                table: "ProductInfo",
                newName: "Carbohydrates_Salt");

            migrationBuilder.RenameColumn(
                name: "Potassium",
                table: "ProductInfo",
                newName: "Mineral_Potassium");

            migrationBuilder.RenameColumn(
                name: "Polyunsaturated",
                table: "ProductInfo",
                newName: "Fat_Polyunsaturated");

            migrationBuilder.RenameColumn(
                name: "PlantProtein",
                table: "ProductInfo",
                newName: "Protein_Plant");

            migrationBuilder.RenameColumn(
                name: "Phosphorus",
                table: "ProductInfo",
                newName: "Mineral_Phosphorus");

            migrationBuilder.RenameColumn(
                name: "Omega6Acid",
                table: "ProductInfo",
                newName: "Fat_Omega6Acid");

            migrationBuilder.RenameColumn(
                name: "Omega3Acid",
                table: "ProductInfo",
                newName: "Fat_Omega3Acid");

            migrationBuilder.RenameColumn(
                name: "Monounsaturated",
                table: "ProductInfo",
                newName: "Fat_Monounsaturated");

            migrationBuilder.RenameColumn(
                name: "Magnesium",
                table: "ProductInfo",
                newName: "Mineral_Magnesium");

            migrationBuilder.RenameColumn(
                name: "Iron",
                table: "ProductInfo",
                newName: "Mineral_Iron");

            migrationBuilder.RenameColumn(
                name: "Iodine",
                table: "ProductInfo",
                newName: "Mineral_Iodine");

            migrationBuilder.RenameColumn(
                name: "FolidAcid",
                table: "ProductInfo",
                newName: "Vitamin_FolidAcid");

            migrationBuilder.RenameColumn(
                name: "Fiber",
                table: "ProductInfo",
                newName: "Carbohydrates_Fiber");

            migrationBuilder.RenameColumn(
                name: "Copper",
                table: "ProductInfo",
                newName: "Mineral_Copper");

            migrationBuilder.RenameColumn(
                name: "Choresterol",
                table: "ProductInfo",
                newName: "Carbohydrates_Choresterol");

            migrationBuilder.RenameColumn(
                name: "CarbohydratesNetto",
                table: "ProductInfo",
                newName: "Carbohydrates_CarbohydratesNetto");

            migrationBuilder.RenameColumn(
                name: "Calcium",
                table: "ProductInfo",
                newName: "Mineral_Calcium");

            migrationBuilder.RenameColumn(
                name: "Caffeine",
                table: "ProductInfo",
                newName: "Carbohydrates_Caffeine");

            migrationBuilder.RenameColumn(
                name: "Biotin",
                table: "ProductInfo",
                newName: "Vitamin_Biotin");

            migrationBuilder.RenameColumn(
                name: "AnimalProtein",
                table: "ProductInfo",
                newName: "Protein_Animal");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TrainingTypes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Trainings",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<decimal>(
                name: "Weight",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "Mineral_Zinc",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Vitamin_VitaminPP",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Vitamin_VitaminK",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Vitamin_VitaminE",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Vitamin_VitaminD",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Vitamin_VitaminC",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Vitamin_VitaminB6",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Vitamin_VitaminB5",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Vitamin_VitaminB2",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Vitamin_VitaminB12",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Vitamin_VitaminB1",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Vitamin_VitaminA",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Carbohydrates_Sugars",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Mineral_Sodium",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Mineral_Selenium",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Fat_Saturated",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Carbohydrates_Salt",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Mineral_Potassium",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Fat_Polyunsaturated",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Mineral_Phosphorus",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Fat_Omega6Acid",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Fat_Omega3Acid",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Fat_Monounsaturated",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Mineral_Magnesium",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Mineral_Iron",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Mineral_Iodine",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Vitamin_FolidAcid",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Carbohydrates_Fiber",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Mineral_Copper",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Carbohydrates_Choresterol",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Carbohydrates_CarbohydratesNetto",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Mineral_Calcium",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Carbohydrates_Caffeine",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Vitamin_Biotin",
                table: "ProductInfo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Muscle",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Meals",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Meals",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Fridges",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ExerciseTypes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<decimal>(
                name: "Weigth",
                table: "BodyParameters",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Waist",
                table: "BodyParameters",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Thigh",
                table: "BodyParameters",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Stomach",
                table: "BodyParameters",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Neck",
                table: "BodyParameters",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Hips",
                table: "BodyParameters",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Heigth",
                table: "BodyParameters",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Forearm",
                table: "BodyParameters",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Chest",
                table: "BodyParameters",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Calf",
                table: "BodyParameters",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "Biceps",
                table: "BodyParameters",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);
        }
    }
}
