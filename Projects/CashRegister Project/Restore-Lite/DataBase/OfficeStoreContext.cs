using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HardwareStore.Models
{
    public partial class OfficeStoreContext : DbContext
    {
        public OfficeStoreContext()
        {
        }

        public OfficeStoreContext(DbContextOptions<OfficeStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Duties> Duties { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<InvoiceItems> InvoiceItems { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<LastLogin> LastLogin { get; set; }
        public virtual DbSet<Paymentmethod> Paymentmethod { get; set; }
        public virtual DbSet<StoreInfo> StoreInfo { get; set; }
        public virtual DbSet<Towns> Towns { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=3073;database=OfficeStore");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity<Duties>(entity =>
            {
                entity.ToTable("duties", "officestore");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Duty)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.ToTable("employees", "officestore");

                entity.HasIndex(e => e.DutyId)
                    .HasName("Duty_id");

                entity.HasIndex(e => e.TownId)
                    .HasName("Town_Id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.DutyId)
                    .HasColumnName("Duty_id")
                    .HasColumnType("int(11)");

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

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(30)
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

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("invoice", "officestore");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("Employee_Id");

                entity.HasIndex(e => e.PaymentMethodId)
                    .HasName("Payment_Method_Id");

                entity.HasIndex(e => e.StoreInfoId)
                    .HasName("Store_Info_Id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("Employee_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("Order_No")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PaymentMethodId)
                    .HasColumnName("Payment_Method_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StoreInfoId)
                    .HasColumnName("Store_Info_Id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("invoice_ibfk_1");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("invoice_ibfk_2");

                entity.HasOne(d => d.StoreInfo)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.StoreInfoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("invoice_ibfk_3");
            });

            modelBuilder.Entity<InvoiceItems>(entity =>
            {
                entity.ToTable("invoice_items", "officestore");

                entity.HasIndex(e => e.ItemId)
                    .HasName("Item_Id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.InvoiceId)
                    .HasColumnName("Invoice_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ItemId)
                    .IsRequired()
                    .HasColumnName("Item_Id")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("int(11)");

                entity.Property(e => e.SinglePrice).HasColumnName("Single_Price");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.InvoiceItems)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("invoice_items_ibfk_1");
            });

            modelBuilder.Entity<Items>(entity =>
            {
                entity.ToTable("items", "officestore");

                entity.Property(e => e.Id)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.OriginalPrice).HasColumnName("Original_Price");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasColumnName("Product_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("int(11)");

                entity.Property(e => e.SalesPrice).HasColumnName("Sales_Price");

                entity.Property(e => e.Status).HasColumnType("enum('Factory New','Second Hand')");
            });

            modelBuilder.Entity<LastLogin>(entity =>
            {
                entity.ToTable("last_login", "officestore");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("employee_id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("employee_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.LastLogin)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("last_login_ibfk_1");
            });

            modelBuilder.Entity<Paymentmethod>(entity =>
            {
                entity.ToTable("paymentmethod", "officestore");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Method)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StoreInfo>(entity =>
            {
                entity.ToTable("store_info", "officestore");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Towns>(entity =>
            {
                entity.ToTable("towns", "officestore");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });
        }
    }
}
