using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ZooCoursework.DataBase;

public partial class AnimalsZooContext : DbContext
{
    public AnimalsZooContext()
    {
    }

    public AnimalsZooContext(DbContextOptions<AnimalsZooContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Animal> Animals { get; set; }

    public virtual DbSet<AnimalKind> AnimalKinds { get; set; }

    public virtual DbSet<AnimalMaterial> AnimalMaterials { get; set; }

    public virtual DbSet<AnimalProduct> AnimalProducts { get; set; }

    public virtual DbSet<Aviary> Aviaries { get; set; }

    public virtual DbSet<CareMaterial> CareMaterials { get; set; }

    public virtual DbSet<ConditionAccommodation> ConditionAccommodations { get; set; }

    public virtual DbSet<CoolingMethod> CoolingMethods { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Temperature> Temperatures { get; set; }

    public virtual DbSet<TemperatureMethod> TemperatureMethods { get; set; }

    public virtual DbSet<TypeAviary> TypeAviaries { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserAviary> UserAviaries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-80QITHSR\\SQLEXPRES;Initial Catalog=AnimalsZoo;Integrated Security=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.ToTable("Account");

            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("User_Id");

            entity.HasOne(d => d.User).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Account_User");
        });

        modelBuilder.Entity<Animal>(entity =>
        {
            entity.ToTable("Animal");

            entity.Property(e => e.AviaryId).HasColumnName("Aviary_Id");
            entity.Property(e => e.ConditionId).HasColumnName("Condition_Id");
            entity.Property(e => e.Image).HasColumnType("image");
            entity.Property(e => e.KindId).HasColumnName("Kind_Id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Aviary).WithMany(p => p.Animals)
                .HasForeignKey(d => d.AviaryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Animal_Aviary");

            entity.HasOne(d => d.Condition).WithMany(p => p.Animals)
                .HasForeignKey(d => d.ConditionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Animal_ConditionAccommodation");

            entity.HasOne(d => d.Kind).WithMany(p => p.Animals)
                .HasForeignKey(d => d.KindId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Animal_AnimalKind");
        });

        modelBuilder.Entity<AnimalKind>(entity =>
        {
            entity.ToTable("AnimalKind");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AnimalMaterial>(entity =>
        {
            entity.ToTable("Animal_Material");

            entity.Property(e => e.AnimalId).HasColumnName("Animal_Id");
            entity.Property(e => e.MaterialId).HasColumnName("Material_Id");

            entity.HasOne(d => d.Animal).WithMany(p => p.AnimalMaterials)
                .HasForeignKey(d => d.AnimalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Animal_Material_Animal");

            entity.HasOne(d => d.Material).WithMany(p => p.AnimalMaterials)
                .HasForeignKey(d => d.MaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Animal_Material_CareMaterial");
        });

        modelBuilder.Entity<AnimalProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Animal_Meal");

            entity.ToTable("Animal_Product");

            entity.Property(e => e.AnimalId).HasColumnName("Animal_Id");
            entity.Property(e => e.ProductId).HasColumnName("Product_Id");

            entity.HasOne(d => d.Animal).WithMany(p => p.AnimalProducts)
                .HasForeignKey(d => d.AnimalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Animal_Meal_Animal");

            entity.HasOne(d => d.Product).WithMany(p => p.AnimalProducts)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Animal_Product_Product");
        });

        modelBuilder.Entity<Aviary>(entity =>
        {
            entity.ToTable("Aviary");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TemperatureId).HasColumnName("Temperature_Id");
            entity.Property(e => e.TypeId).HasColumnName("Type_Id");

            entity.HasOne(d => d.Temperature).WithMany(p => p.Aviaries)
                .HasForeignKey(d => d.TemperatureId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Aviary_Temperature");

            entity.HasOne(d => d.Type).WithMany(p => p.Aviaries)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Aviary_TypeAviary");
        });

        modelBuilder.Entity<CareMaterial>(entity =>
        {
            entity.ToTable("CareMaterial");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ConditionAccommodation>(entity =>
        {
            entity.ToTable("ConditionAccommodation");

            entity.Property(e => e.MaxTemp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MinTemp)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CoolingMethod>(entity =>
        {
            entity.ToTable("CoolingMethod");

            entity.Property(e => e.CoolingFacility)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Meal");

            entity.ToTable("Product");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.ToTable("Role");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Temperature>(entity =>
        {
            entity.ToTable("Temperature");

            entity.Property(e => e.DayTime)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TemperatureMethod>(entity =>
        {
            entity.ToTable("Temperature_Method");

            entity.Property(e => e.MethodId).HasColumnName("Method_Id");
            entity.Property(e => e.TemperatureId).HasColumnName("Temperature_Id");

            entity.HasOne(d => d.Method).WithMany(p => p.TemperatureMethods)
                .HasForeignKey(d => d.MethodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Temperature_Method_CoolingMethod");

            entity.HasOne(d => d.Temperature).WithMany(p => p.TemperatureMethods)
                .HasForeignKey(d => d.TemperatureId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Temperature_Method_Temperature");
        });

        modelBuilder.Entity<TypeAviary>(entity =>
        {
            entity.ToTable("TypeAviary");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Patronymic)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RoleId).HasColumnName("Role_Id");
            entity.Property(e => e.Surname)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_User_Role1");
        });

        modelBuilder.Entity<UserAviary>(entity =>
        {
            entity.ToTable("User_Aviary");

            entity.Property(e => e.AviaryId).HasColumnName("Aviary_Id");
            entity.Property(e => e.UserId).HasColumnName("User_Id");

            entity.HasOne(d => d.Aviary).WithMany(p => p.UserAviaries)
                .HasForeignKey(d => d.AviaryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Aviary_Aviary");

            entity.HasOne(d => d.User).WithMany(p => p.UserAviaries)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Aviary_User");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
