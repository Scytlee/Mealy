using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mealy.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MealType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DefaultTime = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plan",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    StartDate = table.Column<DateTime>(type: "date", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: false),
                    IsLatestVersion = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plan", x => new { x.Id, x.Version });
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IncludeInShoppingLists = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingList",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    PlanId = table.Column<long>(type: "bigint", nullable: false),
                    PlanVersion = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "date", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meal",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Recipe = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    EnergyAmount = table.Column<decimal>(type: "decimal(9,4)", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: false),
                    IsLatestVersion = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meal", x => new { x.Id, x.Version });
                    table.ForeignKey(
                        name: "FK_Meal_MealType_TypeId",
                        column: x => x.TypeId,
                        principalTable: "MealType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanEnergyDefinition",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    PlanId = table.Column<long>(type: "bigint", nullable: false),
                    PlanVersion = table.Column<int>(type: "int", nullable: false),
                    EnergyIntake = table.Column<int>(type: "int", nullable: false),
                    Weekdays = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "date", nullable: true),
                    EndDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanEnergyDefinition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanEnergyDefinition_Plan_PlanId_PlanVersion",
                        columns: x => new { x.PlanId, x.PlanVersion },
                        principalTable: "Plan",
                        principalColumns: new[] { "Id", "Version" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanMealDefinition",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    PlanId = table.Column<long>(type: "bigint", nullable: false),
                    PlanVersion = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    Time = table.Column<TimeSpan>(type: "time", nullable: false),
                    Weekdays = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "date", nullable: true),
                    EndDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanMealDefinition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanMealDefinition_MealType_TypeId",
                        column: x => x.TypeId,
                        principalTable: "MealType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlanMealDefinition_Plan_PlanId_PlanVersion",
                        columns: x => new { x.PlanId, x.PlanVersion },
                        principalTable: "Plan",
                        principalColumns: new[] { "Id", "Version" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false),
                    EnergyAmountInKcal = table.Column<decimal>(type: "decimal(9,4)", nullable: false),
                    IncludeInShoppingLists = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_ProductCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ProductCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanMeal",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    PlanId = table.Column<long>(type: "bigint", nullable: false),
                    PlanVersion = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    MealId = table.Column<long>(type: "bigint", nullable: false),
                    MealVersion = table.Column<int>(type: "int", nullable: false),
                    EnergyAmount = table.Column<decimal>(type: "decimal(9,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanMeal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanMeal_Meal_MealId_MealVersion",
                        columns: x => new { x.MealId, x.MealVersion },
                        principalTable: "Meal",
                        principalColumns: new[] { "Id", "Version" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlanMeal_Plan_PlanId_PlanVersion",
                        columns: x => new { x.PlanId, x.PlanVersion },
                        principalTable: "Plan",
                        principalColumns: new[] { "Id", "Version" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MealIngredient",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    MealId = table.Column<long>(type: "bigint", nullable: false),
                    MealVersion = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(9,4)", nullable: false),
                    EnergyAmount = table.Column<decimal>(type: "decimal(9,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealIngredient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MealIngredient_Meal_MealId_MealVersion",
                        columns: x => new { x.MealId, x.MealVersion },
                        principalTable: "Meal",
                        principalColumns: new[] { "Id", "Version" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MealIngredient_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingListProduct",
                columns: table => new
                {
                    ShoppingListId = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(9,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingListProduct", x => new { x.ShoppingListId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ShoppingListProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingListProduct_ShoppingList_ShoppingListId",
                        column: x => x.ShoppingListId,
                        principalTable: "ShoppingList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanMealModification",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    PlanMealId = table.Column<long>(type: "bigint", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    MealIngredientId = table.Column<long>(type: "bigint", nullable: false),
                    NewIngredientId = table.Column<long>(type: "bigint", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(9,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanMealModification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanMealModification_PlanMeal_PlanMealId",
                        column: x => x.PlanMealId,
                        principalTable: "PlanMeal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Meal_TypeId",
                table: "Meal",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MealIngredient_MealId_MealVersion",
                table: "MealIngredient",
                columns: new[] { "MealId", "MealVersion" });

            migrationBuilder.CreateIndex(
                name: "IX_MealIngredient_ProductId",
                table: "MealIngredient",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanEnergyDefinition_PlanId_PlanVersion",
                table: "PlanEnergyDefinition",
                columns: new[] { "PlanId", "PlanVersion" });

            migrationBuilder.CreateIndex(
                name: "IX_PlanMeal_MealId_MealVersion",
                table: "PlanMeal",
                columns: new[] { "MealId", "MealVersion" });

            migrationBuilder.CreateIndex(
                name: "IX_PlanMeal_PlanId_PlanVersion",
                table: "PlanMeal",
                columns: new[] { "PlanId", "PlanVersion" });

            migrationBuilder.CreateIndex(
                name: "IX_PlanMealDefinition_PlanId_PlanVersion",
                table: "PlanMealDefinition",
                columns: new[] { "PlanId", "PlanVersion" });

            migrationBuilder.CreateIndex(
                name: "IX_PlanMealDefinition_TypeId",
                table: "PlanMealDefinition",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanMealModification_PlanMealId",
                table: "PlanMealModification",
                column: "PlanMealId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategory_Name",
                table: "ProductCategory",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingListProduct_ProductId",
                table: "ShoppingListProduct",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MealIngredient");

            migrationBuilder.DropTable(
                name: "PlanEnergyDefinition");

            migrationBuilder.DropTable(
                name: "PlanMealDefinition");

            migrationBuilder.DropTable(
                name: "PlanMealModification");

            migrationBuilder.DropTable(
                name: "ShoppingListProduct");

            migrationBuilder.DropTable(
                name: "PlanMeal");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ShoppingList");

            migrationBuilder.DropTable(
                name: "Meal");

            migrationBuilder.DropTable(
                name: "Plan");

            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.DropTable(
                name: "MealType");
        }
    }
}
