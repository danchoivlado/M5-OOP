using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace App1.Models
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<Duties> Duties { get; set; }
        public virtual DbSet<Employeegraph> Employeegraph { get; set; }
        public virtual DbSet<Employeegraphmounght> Employeegraphmounght { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Lastscaned> Lastscaned { get; set; }
        public virtual DbSet<Towns> Towns { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=3073;database=employeemanagement");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Admins>(entity =>
            {
                entity.ToTable("admins", "employeemanagement");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ScannerCardNumber)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Duties>(entity =>
            {
                entity.ToTable("duties", "employeemanagement");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Duty)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employeegraph>(entity =>
            {
                entity.ToTable("employeegraph", "employeemanagement");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("Employee_id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CameWork)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("Employee_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LeaveWork)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Employeegraph)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("employeegraph_ibfk_1");
            });

            modelBuilder.Entity<Employeegraphmounght>(entity =>
            {
                entity.ToTable("employeegraphmounght", "employeemanagement");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("Employee_id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CameWork)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("Employee_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HoursWorked)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveWork)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Employeegraphmounght)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("employeegraphmounght_ibfk_1");
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.ToTable("employees", "employeemanagement");

                entity.HasIndex(e => e.DutyId)
                    .HasName("Duty_id");

                entity.HasIndex(e => e.TownId)
                    .HasName("Town_Id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.DutyId)
                    .HasColumnName("Duty_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Egn)
                    .IsRequired()
                    .HasColumnName("EGN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ScannerCardNumber)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SecondName)
                    .IsRequired()
                    .HasColumnName("Second_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TelephoneNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TownId)
                    .HasColumnName("Town_Id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Duty)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DutyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("employees_ibfk_2");

                entity.HasOne(d => d.Town)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.TownId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("employees_ibfk_1");
            });

            modelBuilder.Entity<Lastscaned>(entity =>
            {
                entity.ToTable("lastscaned", "employeemanagement");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ScannerCardNumber)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Towns>(entity =>
            {
                entity.ToTable("towns", "employeemanagement");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });
        }
    }
}
