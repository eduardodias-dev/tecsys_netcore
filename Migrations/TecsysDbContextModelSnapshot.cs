// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Website_TecSys_NetCore.Data;

namespace Website_TecSys_NetCore.Migrations
{
    [DbContext(typeof(TecsysDbContext))]
    partial class TecsysDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("Website_TecSys_NetCore.Models.Configuracoes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Chave")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Valor")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Configuracoes");
                });

            modelBuilder.Entity("Website_TecSys_NetCore.Models.Conteudo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<int>("SecaoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titulo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SecaoId");

                    b.ToTable("Conteudos");
                });

            modelBuilder.Entity("Website_TecSys_NetCore.Models.Secao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Secaos");
                });

            modelBuilder.Entity("Website_TecSys_NetCore.Models.Conteudo", b =>
                {
                    b.HasOne("Website_TecSys_NetCore.Models.Secao", "Secao")
                        .WithMany("Conteudos")
                        .HasForeignKey("SecaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Secao");
                });

            modelBuilder.Entity("Website_TecSys_NetCore.Models.Secao", b =>
                {
                    b.Navigation("Conteudos");
                });
#pragma warning restore 612, 618
        }
    }
}
