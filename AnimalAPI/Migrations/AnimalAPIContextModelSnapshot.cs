// <auto-generated />
using AnimalAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalAPI.Migrations
{
    [DbContext(typeof(AnimalAPIContext))]
    partial class AnimalAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalAPI.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Behavior")
                        .IsRequired();

                    b.Property<string>("DateAdded")
                        .IsRequired();

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Behavior = "Wonderful and sublime. Fantastic around kids.",
                            DateAdded = "April 2, 2009",
                            Gender = "Female",
                            Name = "Malinda",
                            Type = "Dog"
                        },
                        new
                        {
                            AnimalId = 2,
                            Behavior = "Loud and Obnoctus. But a gentel giant.",
                            DateAdded = "June 8, 2012",
                            Gender = "Male",
                            Name = "Boof",
                            Type = "Dog"
                        },
                        new
                        {
                            AnimalId = 3,
                            Behavior = "Little shit. Low energy and calm during night.",
                            DateAdded = "Febuary 28, 2015",
                            Gender = "Male",
                            Name = "Charlie",
                            Type = "Cat"
                        },
                        new
                        {
                            AnimalId = 4,
                            Behavior = "Wonderful and sublime. Does not enjoy the audiunce of childeren.",
                            DateAdded = "April 1, 2018",
                            Gender = "Female",
                            Name = "Spot",
                            Type = "Cat"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
