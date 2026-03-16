using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace APIEFCoreCRUD.Modelss;

public partial class DbUstBatch2DemosContext : DbContext
{
    public DbUstBatch2DemosContext()
    {
    }

    public DbUstBatch2DemosContext(DbContextOptions<DbUstBatch2DemosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EmployeeAudit> EmployeeAudits { get; set; }

    public virtual DbSet<TblDeveloper> TblDevelopers { get; set; }

    public virtual DbSet<TblEmployee> TblEmployees { get; set; }

    public virtual DbSet<TblEmployeesChennai> TblEmployeesChennais { get; set; }

    public virtual DbSet<TblEmployeesRegional> TblEmployeesRegionals { get; set; }

    public virtual DbSet<TblProject> TblProjects { get; set; }

    public virtual DbSet<TblSample> TblSamples { get; set; }

    public virtual DbSet<TblTask> TblTasks { get; set; }

    public virtual DbSet<TblTrainee> TblTrainees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Db_UST_Batch2_Demos;Trusted_Connection=True;MultipleActiveResultSets=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmployeeAudit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("employee_audit");

            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("action");
            entity.Property(e => e.ActionDate)
                .HasColumnType("datetime")
                .HasColumnName("action_date");
            entity.Property(e => e.Empid).HasColumnName("empid");
        });

        modelBuilder.Entity<TblDeveloper>(entity =>
        {
            entity.HasKey(e => e.Developerid).HasName("pk_developerid");

            entity.ToTable("tbl_developers");

            entity.Property(e => e.Developerid)
                .ValueGeneratedNever()
                .HasColumnName("developerid");
            entity.Property(e => e.DevName)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("dev_name");
            entity.Property(e => e.Experience)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("experience");
            entity.Property(e => e.ProjectId).HasColumnName("project_id");
            entity.Property(e => e.Salary).HasColumnName("salary");

            entity.HasOne(d => d.Project).WithMany(p => p.TblDevelopers)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fk_proj_id");
        });

        modelBuilder.Entity<TblEmployee>(entity =>
        {
            entity.HasKey(e => e.Empid).HasName("pk_id");

            entity.ToTable("tbl_employee", tb =>
                {
                    tb.HasTrigger("trg_after_insert_employee");
                    tb.HasTrigger("trg_instead_of_delete_employee");
                });

            entity.Property(e => e.Empid)
                .ValueGeneratedNever()
                .HasColumnName("empid");
            entity.Property(e => e.Managerid).HasColumnName("managerid");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Salary).HasColumnName("salary");

            entity.HasOne(d => d.Manager).WithMany(p => p.InverseManager)
                .HasForeignKey(d => d.Managerid)
                .HasConstraintName("fk_managerid");
        });

        modelBuilder.Entity<TblEmployeesChennai>(entity =>
        {
            entity.HasKey(e => e.Employeeid).HasName("pk_employeeid");

            entity.ToTable("tbl_employees_chennai");

            entity.Property(e => e.Employeeid)
                .ValueGeneratedNever()
                .HasColumnName("employeeid");
            entity.Property(e => e.Department)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("department");
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("employee_name");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<TblEmployeesRegional>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_employees_regional");

            entity.Property(e => e.Department)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("department");
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("employee_name");
            entity.Property(e => e.Employeeid).HasColumnName("employeeid");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<TblProject>(entity =>
        {
            entity.HasKey(e => e.ProjectId).HasName("pk_proj_id");

            entity.ToTable("tbl_project", tb => tb.HasTrigger("trg_after_insert_project"));

            entity.Property(e => e.ProjectId)
                .ValueGeneratedNever()
                .HasColumnName("project_id");
            entity.Property(e => e.Projectname)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("projectname");
        });

        modelBuilder.Entity<TblSample>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_sample", "UST");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<TblTask>(entity =>
        {
            entity.HasKey(e => e.Taskid).HasName("pk_taskid");

            entity.ToTable("tbl_tasks");

            entity.Property(e => e.Taskid)
                .ValueGeneratedNever()
                .HasColumnName("taskid");
            entity.Property(e => e.AssignedTo).HasColumnName("assigned_to");
            entity.Property(e => e.DueDate).HasColumnName("due_date");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.TaskName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("task_name");

            entity.HasOne(d => d.AssignedToNavigation).WithMany(p => p.TblTasks)
                .HasForeignKey(d => d.AssignedTo)
                .HasConstraintName("fk_devid");
        });

        modelBuilder.Entity<TblTrainee>(entity =>
        {
            entity.HasKey(e => e.Traineeid).HasName("pk_traineeid");

            entity.ToTable("tbl_trainees", tb => tb.HasTrigger("trg_after_insert_trainee"));

            entity.HasIndex(e => new { e.Stream, e.Score }, "idx_stream_score");

            entity.Property(e => e.Traineeid)
                .ValueGeneratedNever()
                .HasColumnName("traineeid");
            entity.Property(e => e.Name)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Score).HasColumnName("score");
            entity.Property(e => e.Stream)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("stream");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
