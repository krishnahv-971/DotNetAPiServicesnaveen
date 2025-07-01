using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace dotData;

public partial class SampleContext : DbContext
{
    public SampleContext()
    {
    }

    public SampleContext(DbContextOptions<SampleContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EmployeDetail> EmployeDetails { get; set; }

    public virtual DbSet<StateMaster> StateMasters { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=NAVEENV\\SQL2016;Initial Catalog=Sample;Trusted_Connection=True;Encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmployeDetail>(entity =>
        {
            entity.HasKey(e => e.EmployeeId);

            entity.HasIndex(e => e.PhoneNumber, "UQ__EmployeD__85FB4E383154A856").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__EmployeD__A9D10534EDC6B771").IsUnique();

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.Designation).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.PhoneNumber).HasMaxLength(15);
            entity.Property(e => e.Salary).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<StateMaster>(entity =>
        {
            entity.HasKey(e => e.StateId);

            entity.ToTable("StateMaster");

            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.Brcode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("BRCode");
            entity.Property(e => e.EmailId)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.EwayUserN)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EwayUserP)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Gstinisd6)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("GSTINISD6");
            entity.Property(e => e.GstinonTds)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("GSTINonTDS");
            entity.Property(e => e.GstinorUin)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("GSTINOrUIN");
            entity.Property(e => e.Gstnisd6userName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GSTNISD6UserName");
            entity.Property(e => e.GstnonTdsuserName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GSTNonTDSUserName");
            entity.Property(e => e.GstnuserName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GSTNUserName");
            entity.Property(e => e.Isdgstin)
                .HasMaxLength(15)
                .HasColumnName("ISDGSTIN");
            entity.Property(e => e.Isdrate)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("ISDRate");
            entity.Property(e => e.LastImsFetchedOn).HasColumnType("smalldatetime");
            entity.Property(e => e.PreviousQuarterTurnOver).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PreviousYearTurnOver).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ShortName)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.StateAddress)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.StateAdminId).HasColumnName("StateAdminID");
            entity.Property(e => e.StateCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.StateName)
                .HasMaxLength(29)
                .IsUnicode(false);
            entity.Property(e => e.StateOrUt)
                .HasDefaultValue(true)
                .HasColumnName("StateOrUT");
            entity.Property(e => e.Statename1)
                .HasMaxLength(29)
                .IsUnicode(false)
                .HasColumnName("statename1");
            entity.Property(e => e.Statename2)
                .HasMaxLength(29)
                .IsUnicode(false)
                .HasColumnName("statename2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
