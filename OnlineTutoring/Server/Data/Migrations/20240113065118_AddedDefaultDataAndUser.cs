using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineTutoring.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "f48d9c77-e7f7-4841-85c2-dedaf5028df9", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEG1ikp9IAP1YeUZaNYdljHQaClbJJhqTaVFlxRX/aIzP0TyiCXHUAtO9RORG53oTOg==", null, false, "52eefd9d-ca29-401e-b6f5-fa1c797a7fd8", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Posters",
                columns: new[] { "Id", "CoursePrice", "CreatedBy", "DateCreated", "DateUpdated", "Description", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 150.99000000000001, "System", new DateTime(2024, 1, 13, 14, 51, 17, 792, DateTimeKind.Local).AddTicks(1528), new DateTime(2024, 1, 13, 14, 51, 17, 792, DateTimeKind.Local).AddTicks(1541), "Math for Meth-Heads", "System" },
                    { 2, 299.99000000000001, "System", new DateTime(2024, 1, 13, 14, 51, 17, 792, DateTimeKind.Local).AddTicks(1544), new DateTime(2024, 1, 13, 14, 51, 17, 792, DateTimeKind.Local).AddTicks(1544), "Science", "System" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "ParentsContact", "StudentAge", "StudentContact", "StudentGender", "StudentName", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 13, 14, 51, 17, 715, DateTimeKind.Local).AddTicks(4500), new DateTime(2024, 1, 13, 14, 51, 17, 715, DateTimeKind.Local).AddTicks(4501), 456, 11, 123, "Male", "John", "System" },
                    { 2, "System", new DateTime(2024, 1, 13, 14, 51, 17, 715, DateTimeKind.Local).AddTicks(4503), new DateTime(2024, 1, 13, 14, 51, 17, 715, DateTimeKind.Local).AddTicks(4504), 456, 18, 123, "Female", "Aliyah", "System" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "SubjectLevel", "SubjectType", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 13, 14, 51, 17, 715, DateTimeKind.Local).AddTicks(4765), new DateTime(2024, 1, 13, 14, 51, 17, 715, DateTimeKind.Local).AddTicks(4766), "Secondary 1", "English", "System" },
                    { 2, "System", new DateTime(2024, 1, 13, 14, 51, 17, 715, DateTimeKind.Local).AddTicks(4768), new DateTime(2024, 1, 13, 14, 51, 17, 715, DateTimeKind.Local).AddTicks(4769), "Secondary 4", "Math", "System" }
                });

            migrationBuilder.InsertData(
                table: "Tutors",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "TutorAge", "TutorGender", "TutorName", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 13, 14, 51, 17, 715, DateTimeKind.Local).AddTicks(4046), new DateTime(2024, 1, 13, 14, 51, 17, 715, DateTimeKind.Local).AddTicks(4063), 33, "Male", "Walid", "System" },
                    { 2, "System", new DateTime(2024, 1, 13, 14, 51, 17, 715, DateTimeKind.Local).AddTicks(4065), new DateTime(2024, 1, 13, 14, 51, 17, 715, DateTimeKind.Local).AddTicks(4066), 33, "Female", "Chantel", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tutors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
