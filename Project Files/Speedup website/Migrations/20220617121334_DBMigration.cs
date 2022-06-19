using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Speedup_website.Migrations
{
    public partial class DBMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CashingTypes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cashingType = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    provider = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    link = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    removedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashingTypes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "ntext", nullable: false),
                    discountPercent = table.Column<int>(type: "int", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    removedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Factories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "ntext", nullable: false),
                    removedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    sku = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    removedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ModifyingDetails",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tableName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    columnsChanged = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    row_id = table.Column<int>(type: "int", nullable: false),
                    modifyingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modifier_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModifyingDetails", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mobilephone = table.Column<int>(type: "int", nullable: true),
                    userName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    isOwner = table.Column<bool>(type: "bit", nullable: false),
                    state = table.Column<int>(type: "int", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "GuestShoppingSessions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    guest_id = table.Column<int>(type: "int", nullable: false),
                    total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestShoppingSessions", x => x.id);
                    table.ForeignKey(
                        name: "FK_GuestShoppingSessions_Guests_guest_id",
                        column: x => x.guest_id,
                        principalTable: "Guests",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Users_user_id",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    person_id = table.Column<int>(type: "int", nullable: false),
                    state = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    removedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.id);
                    table.ForeignKey(
                        name: "FK_Owners_Users_person_id",
                        column: x => x.person_id,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingSassions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingSassions", x => x.id);
                    table.ForeignKey(
                        name: "FK_ShoppingSassions_Users_user_id",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAddresses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    City = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    country = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    mobilePhone = table.Column<int>(type: "int", nullable: true),
                    telephone = table.Column<int>(type: "int", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    removedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAddresses", x => x.id);
                    table.ForeignKey(
                        name: "FK_UserAddresses_Users_user_id",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPayments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    paymentType_id = table.Column<int>(type: "int", nullable: false),
                    removedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPayments", x => x.id);
                    table.ForeignKey(
                        name: "FK_UserPayments_CashingTypes_paymentType_id",
                        column: x => x.paymentType_id,
                        principalTable: "CashingTypes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPayments_Users_user_id",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentDetails",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    order_id = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    cashingType_id = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_PaymentDetails_CashingTypes_cashingType_id",
                        column: x => x.cashingType_id,
                        principalTable: "CashingTypes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentDetails_OrderDetails_order_id",
                        column: x => x.order_id,
                        principalTable: "OrderDetails",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Catigories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    catigoryType = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    description = table.Column<string>(type: "ntext", nullable: false),
                    owner_id = table.Column<int>(type: "int", nullable: false),
                    state = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    removedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifieAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catigories", x => x.id);
                    table.ForeignKey(
                        name: "FK_Catigories_Owners_owner_id",
                        column: x => x.owner_id,
                        principalTable: "Owners",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OwnerCashingOuts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    owner_id = table.Column<int>(type: "int", nullable: false),
                    cashingType_id = table.Column<int>(type: "int", nullable: false),
                    removedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnerCashingOuts", x => x.id);
                    table.ForeignKey(
                        name: "FK_OwnerCashingOuts_CashingTypes_cashingType_id",
                        column: x => x.cashingType_id,
                        principalTable: "CashingTypes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OwnerCashingOuts_Owners_owner_id",
                        column: x => x.owner_id,
                        principalTable: "Owners",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "ntext", nullable: false),
                    primaryImage = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    catigory_id = table.Column<int>(type: "int", nullable: false),
                    sku = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    discount_id = table.Column<int>(type: "int", nullable: true),
                    inventory_id = table.Column<int>(type: "int", nullable: true),
                    factory_id = table.Column<int>(type: "int", nullable: true),
                    removedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                    table.ForeignKey(
                        name: "FK_Products_Catigories_catigory_id",
                        column: x => x.catigory_id,
                        principalTable: "Catigories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Discounts_discount_id",
                        column: x => x.discount_id,
                        principalTable: "Discounts",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Products_Factories_factory_id",
                        column: x => x.factory_id,
                        principalTable: "Factories",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Products_Inventories_inventory_id",
                        column: x => x.inventory_id,
                        principalTable: "Inventories",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    session_id = table.Column<int>(type: "int", nullable: false),
                    product_id = table.Column<int>(type: "int", nullable: false),
                    discount_id = table.Column<int>(type: "int", nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.id);
                    table.ForeignKey(
                        name: "FK_CartItems_Discounts_discount_id",
                        column: x => x.discount_id,
                        principalTable: "Discounts",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_CartItems_Products_product_id",
                        column: x => x.product_id,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_ShoppingSassions_session_id",
                        column: x => x.session_id,
                        principalTable: "ShoppingSassions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuestCartItems",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    session_id = table.Column<int>(type: "int", nullable: false),
                    product_id = table.Column<int>(type: "int", nullable: false),
                    discount_id = table.Column<int>(type: "int", nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestCartItems", x => x.id);
                    table.ForeignKey(
                        name: "FK_GuestCartItems_Discounts_discount_id",
                        column: x => x.discount_id,
                        principalTable: "Discounts",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_GuestCartItems_GuestShoppingSessions_session_id",
                        column: x => x.session_id,
                        principalTable: "GuestShoppingSessions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuestCartItems_Products_product_id",
                        column: x => x.product_id,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    order_id = table.Column<int>(type: "int", nullable: false),
                    product_id = table.Column<int>(type: "int", nullable: false),
                    discount_id = table.Column<int>(type: "int", nullable: true),
                    quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Discounts_discount_id",
                        column: x => x.discount_id,
                        principalTable: "Discounts",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_OrderItems_OrderDetails_order_id",
                        column: x => x.order_id,
                        principalTable: "OrderDetails",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_product_id",
                        column: x => x.product_id,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    product_id = table.Column<int>(type: "int", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    addedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    removedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_product_id",
                        column: x => x.product_id,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_discount_id",
                table: "CartItems",
                column: "discount_id");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_product_id",
                table: "CartItems",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_session_id",
                table: "CartItems",
                column: "session_id");

            migrationBuilder.CreateIndex(
                name: "IX_Catigories_owner_id",
                table: "Catigories",
                column: "owner_id");

            migrationBuilder.CreateIndex(
                name: "IX_GuestCartItems_discount_id",
                table: "GuestCartItems",
                column: "discount_id");

            migrationBuilder.CreateIndex(
                name: "IX_GuestCartItems_product_id",
                table: "GuestCartItems",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_GuestCartItems_session_id",
                table: "GuestCartItems",
                column: "session_id");

            migrationBuilder.CreateIndex(
                name: "IX_GuestShoppingSessions_guest_id",
                table: "GuestShoppingSessions",
                column: "guest_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_user_id",
                table: "OrderDetails",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_discount_id",
                table: "OrderItems",
                column: "discount_id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_order_id",
                table: "OrderItems",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_product_id",
                table: "OrderItems",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerCashingOuts_cashingType_id",
                table: "OwnerCashingOuts",
                column: "cashingType_id");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerCashingOuts_owner_id",
                table: "OwnerCashingOuts",
                column: "owner_id");

            migrationBuilder.CreateIndex(
                name: "IX_Owners_person_id",
                table: "Owners",
                column: "person_id");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetails_cashingType_id",
                table: "PaymentDetails",
                column: "cashingType_id");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetails_order_id",
                table: "PaymentDetails",
                column: "order_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_product_id",
                table: "ProductImages",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_catigory_id",
                table: "Products",
                column: "catigory_id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_discount_id",
                table: "Products",
                column: "discount_id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_factory_id",
                table: "Products",
                column: "factory_id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_inventory_id",
                table: "Products",
                column: "inventory_id",
                unique: true,
                filter: "[inventory_id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingSassions_user_id",
                table: "ShoppingSassions",
                column: "user_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserAddresses_user_id",
                table: "UserAddresses",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_UserPayments_paymentType_id",
                table: "UserPayments",
                column: "paymentType_id");

            migrationBuilder.CreateIndex(
                name: "IX_UserPayments_user_id",
                table: "UserPayments",
                column: "user_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "GuestCartItems");

            migrationBuilder.DropTable(
                name: "ModifyingDetails");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "OwnerCashingOuts");

            migrationBuilder.DropTable(
                name: "PaymentDetails");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "UserAddresses");

            migrationBuilder.DropTable(
                name: "UserPayments");

            migrationBuilder.DropTable(
                name: "ShoppingSassions");

            migrationBuilder.DropTable(
                name: "GuestShoppingSessions");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "CashingTypes");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "Catigories");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "Factories");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
