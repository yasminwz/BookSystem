// <auto-generated />
using BookSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BookSystem.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BookSystem.Models.Book", b =>
                {
                    b.Property<int>("book_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("book_id"));

                    b.Property<string>("bookName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name_book");

                    b.Property<int>("numberOfPages")
                        .HasColumnType("integer")
                        .HasColumnName("number_pages");

                    b.Property<decimal>("price")
                        .HasColumnType("numeric")
                        .HasColumnName("price");

                    b.HasKey("book_id");

                    b.ToTable("Book");
                });
#pragma warning restore 612, 618
        }
    }
}
