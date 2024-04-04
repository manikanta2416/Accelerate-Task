using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Form_DAL_Layer.Models
{
    public partial class FormContext : DbContext
    {
        public FormContext()
        {
        }

        public FormContext(DbContextOptions<FormContext> options)
            : base(options)
        {
        }

        public virtual DbSet<RegisterFormDetail> RegisterFormDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB;Initial Catalog=Form;Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RegisterFormDetail>(entity =>
            {
                entity.HasKey(e => e.RequestorId)
                    .HasName("PK__Register__77EF7D580B896631");

                entity.Property(e => e.RequestorId).HasColumnName("requestorId");

                entity.Property(e => e.AllergapproverEmailies)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("allergapproverEmailies");

                entity.Property(e => e.BaseCurrency)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("baseCurrency");

                entity.Property(e => e.BlendComponents)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("blendComponents");

                entity.Property(e => e.ConstituentsRequired)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("constituentsRequired");

                entity.Property(e => e.Criticality)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.CriticalityReason)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("criticalityReason");

                entity.Property(e => e.DataUsage)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("dataUsage");

                entity.Property(e => e.HistoryRequired)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("historyRequired");

                entity.Property(e => e.HowIndexWillBeUsed)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("howIndexWillBeUsed");

                entity.Property(e => e.IndexCostApproval)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("indexCostApproval");

                entity.Property(e => e.IndexName)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("indexName");

                entity.Property(e => e.IndexProvider)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("indexProvider");

                entity.Property(e => e.IndexType)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("indexType");

                entity.Property(e => e.IsWacidataRequired)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("isWACIDataRequired");

                entity.Property(e => e.RequestingTeam)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("requestingTeam");

                entity.Property(e => e.RequestingTeamLocation)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("requestingTeamLocation");

                entity.Property(e => e.RequestorEmail)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("requestorEmail");

                entity.Property(e => e.RequestorName)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("requestorName");

                entity.Property(e => e.RequiredApplications)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("requiredApplications");

                entity.Property(e => e.RequiredHistoryDate)
                    .HasColumnType("date")
                    .HasColumnName("requiredHistoryDate");

                entity.Property(e => e.RequiredUniverse)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("requiredUniverse");

                entity.Property(e => e.ReturnType)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("returnType");

                entity.Property(e => e.VendorId)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("vendorId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
