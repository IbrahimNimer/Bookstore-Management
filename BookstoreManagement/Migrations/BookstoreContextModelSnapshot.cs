﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookstoreManagement.Migrations
{
    [DbContext(typeof(BookstoreContext))]
    partial class BookstoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookstoreManagement.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "F. Scott Fitzgerald",
                            Genre = "Fiction",
                            Price = 10.99,
                            Title = "The Great Gatsby"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Harper Lee",
                            Genre = "Fiction",
                            Price = 12.99,
                            Title = "To Kill a Mockingbird"
                        },
                        new
                        {
                            Id = 3,
                            Author = "George Orwell",
                            Genre = "Dystopian",
                            Price = 14.99,
                            Title = "1984"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Jane Austen",
                            Genre = "Romance",
                            Price = 9.9900000000000002,
                            Title = "Pride and Prejudice"
                        },
                        new
                        {
                            Id = 5,
                            Author = "J.D. Salinger",
                            Genre = "Fiction",
                            Price = 11.99,
                            Title = "The Catcher in the Rye"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Herman Melville",
                            Genre = "Adventure",
                            Price = 13.5,
                            Title = "Moby Dick"
                        },
                        new
                        {
                            Id = 7,
                            Author = "Leo Tolstoy",
                            Genre = "Historical Fiction",
                            Price = 15.99,
                            Title = "War and Peace"
                        },
                        new
                        {
                            Id = 8,
                            Author = "Homer",
                            Genre = "Classic",
                            Price = 8.9900000000000002,
                            Title = "The Odyssey"
                        },
                        new
                        {
                            Id = 9,
                            Author = "Aldous Huxley",
                            Genre = "Dystopian",
                            Price = 12.5,
                            Title = "Brave New World"
                        },
                        new
                        {
                            Id = 10,
                            Author = "J.R.R. Tolkien",
                            Genre = "Fantasy",
                            Price = 19.989999999999998,
                            Title = "The Lord of the Rings"
                        },
                        new
                        {
                            Id = 11,
                            Author = "Paulo Coelho",
                            Genre = "Fiction",
                            Price = 10.5,
                            Title = "The Alchemist"
                        },
                        new
                        {
                            Id = 12,
                            Author = "Oscar Wilde",
                            Genre = "Fiction",
                            Price = 9.5,
                            Title = "The Picture of Dorian Gray"
                        },
                        new
                        {
                            Id = 13,
                            Author = "Fyodor Dostoevsky",
                            Genre = "Fiction",
                            Price = 14.99,
                            Title = "Crime and Punishment"
                        },
                        new
                        {
                            Id = 14,
                            Author = "J.R.R. Tolkien",
                            Genre = "Fantasy",
                            Price = 10.99,
                            Title = "The Hobbit"
                        },
                        new
                        {
                            Id = 15,
                            Author = "Ray Bradbury",
                            Genre = "Dystopian",
                            Price = 11.5,
                            Title = "Fahrenheit 451"
                        },
                        new
                        {
                            Id = 16,
                            Author = "C.S. Lewis",
                            Genre = "Fantasy",
                            Price = 15.0,
                            Title = "The Chronicles of Narnia"
                        },
                        new
                        {
                            Id = 17,
                            Author = "Margaret Atwood",
                            Genre = "Dystopian",
                            Price = 13.5,
                            Title = "The Handmaid's Tale"
                        },
                        new
                        {
                            Id = 18,
                            Author = "John Steinbeck",
                            Genre = "Fiction",
                            Price = 14.0,
                            Title = "The Grapes of Wrath"
                        },
                        new
                        {
                            Id = 19,
                            Author = "Charles Dickens",
                            Genre = "Historical Fiction",
                            Price = 12.0,
                            Title = "A Tale of Two Cities"
                        },
                        new
                        {
                            Id = 20,
                            Author = "Sylvia Plath",
                            Genre = "Fiction",
                            Price = 10.0,
                            Title = "The Bell Jar"
                        },
                        new
                        {
                            Id = 21,
                            Author = "Yuval Noah Harari",
                            Genre = "Non-fiction",
                            Price = 16.989999999999998,
                            Title = "Sapiens: A Brief History of Humankind"
                        },
                        new
                        {
                            Id = 22,
                            Author = "Michelle Obama",
                            Genre = "Biography",
                            Price = 20.0,
                            Title = "Becoming"
                        },
                        new
                        {
                            Id = 23,
                            Author = "Rebecca Skloot",
                            Genre = "Non-fiction",
                            Price = 15.0,
                            Title = "The Immortal Life of Henrietta Lacks"
                        },
                        new
                        {
                            Id = 24,
                            Author = "Tara Westover",
                            Genre = "Biography",
                            Price = 17.5,
                            Title = "Educated"
                        },
                        new
                        {
                            Id = 25,
                            Author = "Charles Duhigg",
                            Genre = "Self-help",
                            Price = 16.5,
                            Title = "The Power of Habit"
                        },
                        new
                        {
                            Id = 26,
                            Author = "Mark Manson",
                            Genre = "Self-help",
                            Price = 18.989999999999998,
                            Title = "The Subtle Art of Not Giving a F*ck"
                        },
                        new
                        {
                            Id = 27,
                            Author = "Jen Sincero",
                            Genre = "Self-help",
                            Price = 16.989999999999998,
                            Title = "You Are a Badass"
                        },
                        new
                        {
                            Id = 28,
                            Author = "Stephen R. Covey",
                            Genre = "Self-help",
                            Price = 17.989999999999998,
                            Title = "The 7 Habits of Highly Effective People"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
