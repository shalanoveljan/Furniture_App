using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FurnitureApp.Migrations
{
    public partial class AddedDeletedPropertyInTestimonial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Testimonials",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Testimonials");
        }
    }
}
