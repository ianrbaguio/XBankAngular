using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using XBankAngular.DAO.Models;

#nullable disable

namespace XBankAngular.DAO
{
    public partial class XBankContext : DbContext
    {
        public XBankContext()
        {
        }

        public XBankContext(DbContextOptions<XBankContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Accounttype> Accounttypes { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Clienttype> Clienttypes { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<Transactionarchive> Transactionarchives { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Database=XBank;Username=postgres;Password=iTsuna10");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "English_United States.1252");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("accounts");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Accounttypeid).HasColumnName("accounttypeid");

                entity.Property(e => e.Balance)
                    .HasPrecision(12, 2)
                    .HasColumnName("balance");

                entity.Property(e => e.Clientid).HasColumnName("clientid");

                entity.Property(e => e.Datecreated)
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Lasttransaction)
                    .HasColumnName("lasttransaction")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Pin).HasColumnName("pin");

                entity.HasOne(d => d.Accounttype)
                    .WithMany(p => p.Accounts)
                    .HasPrincipalKey(p => p.Accounttypeid)
                    .HasForeignKey(d => d.Accounttypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("accounts_accounttypeid_fkey");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.Clientid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("accounts_clientid_fkey");
            });

            modelBuilder.Entity<Accounttype>(entity =>
            {
                entity.HasKey(e => new { e.Accounttypeid, e.Accounttype1 })
                    .HasName("accounttypes_pkey");

                entity.ToTable("accounttypes");

                entity.HasIndex(e => e.Accounttypeid, "accounttypes_accounttypeid_key")
                    .IsUnique();

                entity.Property(e => e.Accounttypeid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("accounttypeid");

                entity.Property(e => e.Accounttype1)
                    .HasMaxLength(30)
                    .HasColumnName("accounttype");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.Enddate).HasColumnName("enddate");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("clients");

                entity.Property(e => e.Clientid).HasColumnName("clientid");

                entity.Property(e => e.Clienttypeid)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("clienttypeid");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Enddate).HasColumnName("enddate");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(50)
                    .HasColumnName("firstname");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(50)
                    .HasColumnName("lastname");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.Salt)
                    .HasMaxLength(100)
                    .HasColumnName("salt");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.HasOne(d => d.Clienttype)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.Clienttypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clients_clienttypeid_fkey");
            });

            modelBuilder.Entity<Clienttype>(entity =>
            {
                entity.ToTable("clienttypes");

                entity.Property(e => e.Clienttypeid)
                    .HasMaxLength(30)
                    .HasColumnName("clienttypeid");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.Enddate).HasColumnName("enddate");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("transactions");

                entity.Property(e => e.Transactionid).HasColumnName("transactionid");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Accounttypeid).HasColumnName("accounttypeid");

                entity.Property(e => e.Amount)
                    .HasPrecision(12, 2)
                    .HasColumnName("amount");

                entity.Property(e => e.Balance)
                    .HasPrecision(12, 2)
                    .HasColumnName("balance");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Transactiontype)
                    .HasMaxLength(50)
                    .HasColumnName("transactiontype");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.Accountid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("transactions_accountid_fkey");

                entity.HasOne(d => d.Accounttype)
                    .WithMany(p => p.Transactions)
                    .HasPrincipalKey(p => p.Accounttypeid)
                    .HasForeignKey(d => d.Accounttypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("transactions_accounttypeid_fkey");
            });

            modelBuilder.Entity<Transactionarchive>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("transactionarchives");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Accounttypeid).HasColumnName("accounttypeid");

                entity.Property(e => e.Amount)
                    .HasPrecision(12, 2)
                    .HasColumnName("amount");

                entity.Property(e => e.Balance)
                    .HasPrecision(12, 2)
                    .HasColumnName("balance");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Transactionarchiveid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("transactionarchiveid");

                entity.Property(e => e.Transactionid).HasColumnName("transactionid");

                entity.Property(e => e.Transactiontype)
                    .HasMaxLength(50)
                    .HasColumnName("transactiontype");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
