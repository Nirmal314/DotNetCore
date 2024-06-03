using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core2.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "__MigrationHistory",
                columns: table => new
                {
                    MigrationId = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ContextKey = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Model = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ProductVersion = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.__MigrationHistory", x => new { x.MigrationId, x.ContextKey });
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEndDateUtc = table.Column<DateTime>(type: "datetime", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValue: ""),
                    ContactNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValue: "")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DineInTables",
                columns: table => new
                {
                    TableId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoOFChairs = table.Column<int>(type: "int", nullable: true),
                    CanBeReserved = table.Column<bool>(type: "bit", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DineInTa__7D5F01EEDBC47714", x => x.TableId);
                });

            migrationBuilder.CreateTable(
                name: "Discount",
                columns: table => new
                {
                    DiscountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    From = table.Column<DateTime>(type: "datetime", nullable: true),
                    To = table.Column<DateTime>(type: "datetime", nullable: true),
                    Type = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Value = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    NumberOfTimes = table.Column<int>(type: "int", nullable: true),
                    MaxDiscount = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    CouponName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Discount__E43F6D9628D8E1AE", x => x.DiscountId);
                });

            migrationBuilder.CreateTable(
                name: "dishtype",
                columns: table => new
                {
                    dishid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dishtype = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__dishtype__76DEBE3B60BE8D8C", x => x.dishid);
                });

            migrationBuilder.CreateTable(
                name: "FoodItems",
                columns: table => new
                {
                    foodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    itemName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    itemPrice = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__FoodItem__77EAEA395B9BC284", x => x.foodId);
                });

            migrationBuilder.CreateTable(
                name: "Holiday",
                columns: table => new
                {
                    holidayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    holidayName = table.Column<string>(type: "varchar(70)", unicode: false, maxLength: 70, nullable: true),
                    holidayMonthDay = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Holiday__EB855CEFE7675EC2", x => x.holidayId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Threshold = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    WeightType = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Type = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Visible = table.Column<bool>(type: "bit", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    Isdeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Products__B40CC6CD3D85D67B", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "ProductsData",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Thresold = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    WeightType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    visible = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Products__B40CC6CDE23ECE89", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "productType",
                columns: table => new
                {
                    pid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ptype = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__productT__DD37D91A38695159", x => x.pid);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    roleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    roleName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_roleId", x => x.roleId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ContactNo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Fullname = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Password = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Type = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CratedBy = table.Column<int>(type: "int", nullable: true),
                    Isdeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users__1788CC4CA77ABD05", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserType",
                columns: table => new
                {
                    uid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    uname = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserType__DD701264844504C2", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    VendorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    VendorEmail = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    VendorAddress = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Vendor__FC8618F36961E784", x => x.VendorId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey, x.UserId });
                    table.ForeignKey(
                        name: "FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dish",
                columns: table => new
                {
                    DishId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemID = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Date = table.Column<DateOnly>(type: "date", nullable: true),
                    DishCount = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    Isdeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Dish__18834F506E98DF0A", x => x.DishId);
                    table.ForeignKey(
                        name: "FK__Dish__ItemID__300424B4",
                        column: x => x.ItemID,
                        principalTable: "Products",
                        principalColumn: "ProductId");
                });

            migrationBuilder.CreateTable(
                name: "DishData",
                columns: table => new
                {
                    DishId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Date = table.Column<DateOnly>(type: "date", nullable: true),
                    DishCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DishData__18834F50D5E75A1E", x => x.DishId);
                    table.ForeignKey(
                        name: "FK__DishData__ItemId__18EBB532",
                        column: x => x.ItemId,
                        principalTable: "ProductsData",
                        principalColumn: "ProductId");
                });

            migrationBuilder.CreateTable(
                name: "ProductMenu",
                columns: table => new
                {
                    productMenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    menuName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    menuItem1 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    roleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_prodMenuId", x => x.productMenuId);
                    table.ForeignKey(
                        name: "FK__ProductMe__roleI__7F2BE32F",
                        column: x => x.roleId,
                        principalTable: "Roles",
                        principalColumn: "roleId");
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    CartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    Isdeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Cart__51BCD7B7307899E4", x => x.CartId);
                    table.ForeignKey(
                        name: "FK__Cart__UserId__36B12243",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "CookingSession",
                columns: table => new
                {
                    SessionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TranierId = table.Column<int>(type: "int", nullable: true),
                    SessionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CookingS__C9F49290CCCB4A7F", x => x.SessionId);
                    table.ForeignKey(
                        name: "FK__CookingSe__Trani__628FA481",
                        column: x => x.TranierId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Duration = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    QtyOfDishes = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Event__7944C8102D0A6DA7", x => x.EventId);
                    table.ForeignKey(
                        name: "FK__Event__UserId__2739D489",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Leave",
                columns: table => new
                {
                    LeaveId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    FromDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ToDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    StartDuration = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EndDuration = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Reason = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ResponseComment = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Leave__796DB959A0962DE0", x => x.LeaveId);
                    table.ForeignKey(
                        name: "FK__Leave__UserId__4AB81AF0",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    DateOfOrder = table.Column<DateTime>(type: "datetime", nullable: true),
                    Type = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    Isdeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Orders__C3905BCF5A31C591", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK__Orders__Customer__29572725",
                        column: x => x.CustomerId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Overtime",
                columns: table => new
                {
                    OvertimeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ToDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Overtime__F61430B8D2DBF3BF", x => x.OvertimeId);
                    table.ForeignKey(
                        name: "FK__Overtime__UserId__4D94879B",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "ReservedTable",
                columns: table => new
                {
                    ReservedTableId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    NoOFPeople = table.Column<int>(type: "int", nullable: true),
                    FromDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ToDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Reserved__3E53FB19E8E4D45A", x => x.ReservedTableId);
                    table.ForeignKey(
                        name: "FK__ReservedT__Table__5EBF139D",
                        column: x => x.TableId,
                        principalTable: "DineInTables",
                        principalColumn: "TableId");
                    table.ForeignKey(
                        name: "FK__ReservedT__UserI__5FB337D6",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "RolesUsers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    roleId = table.Column<int>(type: "int", nullable: true),
                    userId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_id", x => x.id);
                    table.ForeignKey(
                        name: "FK__RolesUser__roleI__71D1E811",
                        column: x => x.roleId,
                        principalTable: "Roles",
                        principalColumn: "roleId");
                    table.ForeignKey(
                        name: "FK__RolesUser__userI__72C60C4A",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "UsersData",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Birthdate = table.Column<DateOnly>(type: "date", nullable: true),
                    ContactNo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    FullName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    typeid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UsersDat__1788CC4C6485F45F", x => x.UserId);
                    table.ForeignKey(
                        name: "FK__UsersData__typei__2180FB33",
                        column: x => x.typeid,
                        principalTable: "UserType",
                        principalColumn: "uid");
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    StockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    VendorId = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateOnly>(type: "date", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Stocks__2C83A9C2951272D1", x => x.StockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Users",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK__Stocks__ItemId__47DBAE45",
                        column: x => x.ItemId,
                        principalTable: "Products",
                        principalColumn: "ProductId");
                    table.ForeignKey(
                        name: "FK__Stocks__VendorId__6CD828CA",
                        column: x => x.VendorId,
                        principalTable: "Vendor",
                        principalColumn: "VendorId");
                });

            migrationBuilder.CreateTable(
                name: "VendorProducts",
                columns: table => new
                {
                    VendorProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorId = table.Column<int>(type: "int", nullable: true),
                    ProductName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true),
                    ItemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VendorPr__ABB41163BB377C82", x => x.VendorProductId);
                    table.ForeignKey(
                        name: "FK__VendorPro__ItemI__6AEFE058",
                        column: x => x.ItemId,
                        principalTable: "Products",
                        principalColumn: "ProductId");
                    table.ForeignKey(
                        name: "FK__VendorPro__Vendo__5441852A",
                        column: x => x.VendorId,
                        principalTable: "Vendor",
                        principalColumn: "VendorId");
                });

            migrationBuilder.CreateTable(
                name: "DishItem",
                columns: table => new
                {
                    DishItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DishId = table.Column<int>(type: "int", nullable: true),
                    ItemID = table.Column<int>(type: "int", nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    Isdeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DishItem__F0C0B87CF5C9D245", x => x.DishItemId);
                    table.ForeignKey(
                        name: "FK__DishItem__DishId__32E0915F",
                        column: x => x.DishId,
                        principalTable: "Dish",
                        principalColumn: "DishId");
                    table.ForeignKey(
                        name: "FK__DishItem__ItemID__33D4B598",
                        column: x => x.ItemID,
                        principalTable: "Products",
                        principalColumn: "ProductId");
                });

            migrationBuilder.CreateTable(
                name: "DishItemData",
                columns: table => new
                {
                    DishItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DishId = table.Column<int>(type: "int", nullable: true),
                    ItemId = table.Column<int>(type: "int", nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DishItem__F0C0B87CC86DA0BE", x => x.DishItemId);
                    table.ForeignKey(
                        name: "FK__DishItemD__DishI__1BC821DD",
                        column: x => x.DishId,
                        principalTable: "DishData",
                        principalColumn: "DishId");
                    table.ForeignKey(
                        name: "FK__DishItemD__ItemI__1CBC4616",
                        column: x => x.ItemId,
                        principalTable: "ProductsData",
                        principalColumn: "ProductId");
                });

            migrationBuilder.CreateTable(
                name: "ProductMenuItem",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    itemname = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    itemdesc = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    ProductMenuId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ProductM__3213E83FC24E50EE", x => x.id);
                    table.ForeignKey(
                        name: "FK__ProductMe__Produ__3493CFA7",
                        column: x => x.ProductMenuId,
                        principalTable: "ProductMenu",
                        principalColumn: "productMenuId");
                });

            migrationBuilder.CreateTable(
                name: "RolesProductMenus",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    roleId = table.Column<int>(type: "int", nullable: true),
                    productMenuId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__RolesPro__3213E83FB9C20FD2", x => x.id);
                    table.ForeignKey(
                        name: "FK__RolesProd__produ__45BE5BA9",
                        column: x => x.productMenuId,
                        principalTable: "ProductMenu",
                        principalColumn: "productMenuId");
                    table.ForeignKey(
                        name: "FK__RolesProd__roleI__44CA3770",
                        column: x => x.roleId,
                        principalTable: "Roles",
                        principalColumn: "roleId");
                });

            migrationBuilder.CreateTable(
                name: "CartItemId",
                columns: table => new
                {
                    CartItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: true),
                    ItemID = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    Isdeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CartItem__488B0B0ADB55CCFF", x => x.CartItemId);
                    table.ForeignKey(
                        name: "FK__CartItemI__CartI__398D8EEE",
                        column: x => x.CartId,
                        principalTable: "Cart",
                        principalColumn: "CartId");
                    table.ForeignKey(
                        name: "FK__CartItemI__ItemI__3A81B327",
                        column: x => x.ItemID,
                        principalTable: "Products",
                        principalColumn: "ProductId");
                });

            migrationBuilder.CreateTable(
                name: "CookingSessionAttendee",
                columns: table => new
                {
                    CookingSessionAttendeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionId = table.Column<int>(type: "int", nullable: true),
                    AttendeeId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CookingS__B4CEC63B5F389DAF", x => x.CookingSessionAttendeeId);
                    table.ForeignKey(
                        name: "FK__CookingSe__Atten__66603565",
                        column: x => x.AttendeeId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK__CookingSe__Sessi__656C112C",
                        column: x => x.SessionId,
                        principalTable: "CookingSession",
                        principalColumn: "SessionId");
                });

            migrationBuilder.CreateTable(
                name: "EventItems",
                columns: table => new
                {
                    EventItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(type: "int", nullable: true),
                    ItemId = table.Column<int>(type: "int", nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__EventIte__0369CECFE9E65AE2", x => x.EventItemId);
                    table.ForeignKey(
                        name: "FK__EventItem__Event__59063A47",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "EventId");
                    table.ForeignKey(
                        name: "FK__EventItem__ItemI__59FA5E80",
                        column: x => x.ItemId,
                        principalTable: "Products",
                        principalColumn: "ProductId");
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    ItemID = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    TaxPercentage = table.Column<int>(type: "int", nullable: true),
                    TaxAmount = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Discount = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    DiscountId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    Isdeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__OrderIte__57ED06811B2CEABB", x => x.OrderItemId);
                    table.ForeignKey(
                        name: "FK__OrderItem__ItemI__2D27B809",
                        column: x => x.ItemID,
                        principalTable: "Products",
                        principalColumn: "ProductId");
                    table.ForeignKey(
                        name: "FK__OrderItem__Order__2C3393D0",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId");
                });

            migrationBuilder.CreateTable(
                name: "FoodOrderByTable",
                columns: table => new
                {
                    orderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    foodId = table.Column<int>(type: "int", nullable: true),
                    itemQuantity = table.Column<int>(type: "int", nullable: true),
                    ReservedTableId = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__FoodOrde__0809335DACC87FFF", x => x.orderId);
                    table.ForeignKey(
                        name: "FK__FoodOrder__Reser__72910220",
                        column: x => x.ReservedTableId,
                        principalTable: "ReservedTable",
                        principalColumn: "ReservedTableId");
                    table.ForeignKey(
                        name: "FK__FoodOrder__foodI__719CDDE7",
                        column: x => x.foodId,
                        principalTable: "FoodItems",
                        principalColumn: "foodId");
                });

            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    FeedbackId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    OrderItemId = table.Column<int>(type: "int", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Comments = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Feedback__6A4BEDD6FDB76874", x => x.FeedbackId);
                    table.ForeignKey(
                        name: "FK__Feedback__OrderI__412EB0B6",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId");
                    table.ForeignKey(
                        name: "FK__Feedback__OrderI__4222D4EF",
                        column: x => x.OrderItemId,
                        principalTable: "OrderItems",
                        principalColumn: "OrderItemId");
                });

            migrationBuilder.CreateTable(
                name: "OrderRefund",
                columns: table => new
                {
                    OrderRefundId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    OrderItemId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    RefundDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Percentage = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Status = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__OrderRef__9273F2617E9E0615", x => x.OrderRefundId);
                    table.ForeignKey(
                        name: "FK__OrderRefu__Order__3D5E1FD2",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId");
                    table.ForeignKey(
                        name: "FK__OrderRefu__Order__3E52440B",
                        column: x => x.OrderItemId,
                        principalTable: "OrderItems",
                        principalColumn: "OrderItemId");
                });

            migrationBuilder.CreateTable(
                name: "FeedbackDocs",
                columns: table => new
                {
                    FeedbackDocsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeedbackId = table.Column<int>(type: "int", nullable: true),
                    Path = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    Type = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Feedback__9DBFC3AAA17C81AA", x => x.FeedbackDocsId);
                    table.ForeignKey(
                        name: "FK__FeedbackD__Feedb__44FF419A",
                        column: x => x.FeedbackId,
                        principalTable: "Feedback",
                        principalColumn: "FeedbackId");
                });

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserId",
                table: "AspNetUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cart_UserId",
                table: "Cart",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItemId_CartId",
                table: "CartItemId",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItemId_ItemID",
                table: "CartItemId",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_CookingSession_TranierId",
                table: "CookingSession",
                column: "TranierId");

            migrationBuilder.CreateIndex(
                name: "IX_CookingSessionAttendee_AttendeeId",
                table: "CookingSessionAttendee",
                column: "AttendeeId");

            migrationBuilder.CreateIndex(
                name: "IX_CookingSessionAttendee_SessionId",
                table: "CookingSessionAttendee",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Dish_ItemID",
                table: "Dish",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_DishData_ItemId",
                table: "DishData",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_DishItem_DishId",
                table: "DishItem",
                column: "DishId");

            migrationBuilder.CreateIndex(
                name: "IX_DishItem_ItemID",
                table: "DishItem",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_DishItemData_DishId",
                table: "DishItemData",
                column: "DishId");

            migrationBuilder.CreateIndex(
                name: "IX_DishItemData_ItemId",
                table: "DishItemData",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_UserId",
                table: "Event",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EventItems_EventId",
                table: "EventItems",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventItems_ItemId",
                table: "EventItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_OrderId",
                table: "Feedback",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_OrderItemId",
                table: "Feedback",
                column: "OrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_FeedbackDocs_FeedbackId",
                table: "FeedbackDocs",
                column: "FeedbackId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodOrderByTable_foodId",
                table: "FoodOrderByTable",
                column: "foodId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodOrderByTable_ReservedTableId",
                table: "FoodOrderByTable",
                column: "ReservedTableId");

            migrationBuilder.CreateIndex(
                name: "IX_Leave_UserId",
                table: "Leave",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ItemID",
                table: "OrderItems",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRefund_OrderId",
                table: "OrderRefund",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRefund_OrderItemId",
                table: "OrderRefund",
                column: "OrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Overtime_UserId",
                table: "Overtime",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMenu_roleId",
                table: "ProductMenu",
                column: "roleId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMenuItem_ProductMenuId",
                table: "ProductMenuItem",
                column: "ProductMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservedTable_TableId",
                table: "ReservedTable",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservedTable_UserId",
                table: "ReservedTable",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RolesProductMenus_productMenuId",
                table: "RolesProductMenus",
                column: "productMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_RolesProductMenus_roleId",
                table: "RolesProductMenus",
                column: "roleId");

            migrationBuilder.CreateIndex(
                name: "IX_RolesUsers_roleId",
                table: "RolesUsers",
                column: "roleId");

            migrationBuilder.CreateIndex(
                name: "IX_RolesUsers_userId",
                table: "RolesUsers",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_CreatedBy",
                table: "Stocks",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ItemId",
                table: "Stocks",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_VendorId",
                table: "Stocks",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "UQ__Users__A9D105348210C26B",
                table: "Users",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UsersData_typeid",
                table: "UsersData",
                column: "typeid");

            migrationBuilder.CreateIndex(
                name: "IX_VendorProducts_ItemId",
                table: "VendorProducts",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_VendorProducts_VendorId",
                table: "VendorProducts",
                column: "VendorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "__MigrationHistory");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "CartItemId");

            migrationBuilder.DropTable(
                name: "CookingSessionAttendee");

            migrationBuilder.DropTable(
                name: "Discount");

            migrationBuilder.DropTable(
                name: "DishItem");

            migrationBuilder.DropTable(
                name: "DishItemData");

            migrationBuilder.DropTable(
                name: "dishtype");

            migrationBuilder.DropTable(
                name: "EventItems");

            migrationBuilder.DropTable(
                name: "FeedbackDocs");

            migrationBuilder.DropTable(
                name: "FoodOrderByTable");

            migrationBuilder.DropTable(
                name: "Holiday");

            migrationBuilder.DropTable(
                name: "Leave");

            migrationBuilder.DropTable(
                name: "OrderRefund");

            migrationBuilder.DropTable(
                name: "Overtime");

            migrationBuilder.DropTable(
                name: "ProductMenuItem");

            migrationBuilder.DropTable(
                name: "productType");

            migrationBuilder.DropTable(
                name: "RolesProductMenus");

            migrationBuilder.DropTable(
                name: "RolesUsers");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "UsersData");

            migrationBuilder.DropTable(
                name: "VendorProducts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "CookingSession");

            migrationBuilder.DropTable(
                name: "Dish");

            migrationBuilder.DropTable(
                name: "DishData");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "ReservedTable");

            migrationBuilder.DropTable(
                name: "FoodItems");

            migrationBuilder.DropTable(
                name: "ProductMenu");

            migrationBuilder.DropTable(
                name: "UserType");

            migrationBuilder.DropTable(
                name: "Vendor");

            migrationBuilder.DropTable(
                name: "ProductsData");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "DineInTables");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
