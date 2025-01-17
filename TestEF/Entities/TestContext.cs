using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TestEF;

namespace TestEF.Entities;

public partial class TestContext : DbContext
{
    public TestContext(DbContextOptions<TestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }

    public virtual DbSet<JsonDataTest> JsonDataTests { get; set; }

    public virtual DbSet<MyDN> MyDNs { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Restaurant> Restaurants { get; set; }

    public virtual DbSet<RestoreDrill> RestoreDrills { get; set; }

    public virtual DbSet<TLOG> TLOGs { get; set; }

    public virtual DbSet<TLOG_Result> TLOG_Results { get; set; }

    public virtual DbSet<TLog1> TLog1s { get; set; }

    public virtual DbSet<TLog2> TLog2s { get; set; }

    public virtual DbSet<TLog3> TLog3s { get; set; }

    public virtual DbSet<TLog4> TLog4s { get; set; }

    public virtual DbSet<TLog5> TLog5s { get; set; }

    public virtual DbSet<TLog6> TLog6s { get; set; }

    public virtual DbSet<TLog7> TLog7s { get; set; }

    public virtual DbSet<TLog8> TLog8s { get; set; }

    public virtual DbSet<TTT> TTTs { get; set; }

    public virtual DbSet<friend> friends { get; set; }

    public virtual DbSet<friendOf> friendOfs { get; set; }

    public virtual DbSet<like> likes { get; set; }

    public virtual DbSet<livesIn> livesIns { get; set; }

    public virtual DbSet<locatedIn> locatedIns { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__City__3214EC27A19FEEAE");

            entity.ToTable("City");

            entity.Property(e => e.ID).ValueGeneratedNever();
            entity.Property(e => e._node_id_4D9A177C68DF432D9E7B3A9804C3CCB1)
                .HasMaxLength(1000)
                .HasColumnName("$node_id_4D9A177C68DF432D9E7B3A9804C3CCB1");
            entity.Property(e => e.name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.stateName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AccountNumber)
                .HasMaxLength(15)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Comment)
                .HasMaxLength(128)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.CreditCardApprovalCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.Freight).HasColumnType("money");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.PurchaseOrderNumber)
                .HasMaxLength(25)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.SalesOrderID).ValueGeneratedOnAdd();
            entity.Property(e => e.SalesOrderNumber)
                .HasMaxLength(25)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ShipDate).HasColumnType("datetime");
            entity.Property(e => e.SubTotal).HasColumnType("money");
            entity.Property(e => e.TaxAmt).HasColumnType("money");
            entity.Property(e => e.TotalDue).HasColumnType("money");
        });

        modelBuilder.Entity<InvoiceDetail>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CarrierTrackingNumber)
                .HasMaxLength(25)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.LineTotal).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SalesOrderDetailID).ValueGeneratedOnAdd();
            entity.Property(e => e.UnitPrice).HasColumnType("money");
            entity.Property(e => e.UnitPriceDiscount).HasColumnType("money");
        });

        modelBuilder.Entity<JsonDataTest>(entity =>
        {
            entity.HasKey(e => e.TID);

            entity.ToTable("JsonDataTest");

            entity.Property(e => e.TDes)
                .HasMaxLength(4000)
                .HasComputedColumnSql("(json_value([JsonData],'$.TDes'))", false);
            entity.Property(e => e.TName)
                .HasMaxLength(4000)
                .HasComputedColumnSql("(json_value([JsonData],'$.TName'))", false);
        });

        modelBuilder.Entity<MyDN>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MyDNS");

            entity.Property(e => e.ServerIP)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ServerName)
                .HasMaxLength(24)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Person__3214EC2740DF6088");

            entity.ToTable("Person");

            entity.Property(e => e.ID).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e._node_id_BBAFC4959A024CDC8EA54F6724DDBBCC)
                .HasMaxLength(1000)
                .HasColumnName("$node_id_BBAFC4959A024CDC8EA54F6724DDBBCC");
        });

        modelBuilder.Entity<Restaurant>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Restaurant");

            entity.Property(e => e._node_id_32F0CD02B1EB4D00A418AD9B57FB5A72)
                .HasMaxLength(1000)
                .HasColumnName("$node_id_32F0CD02B1EB4D00A418AD9B57FB5A72");
            entity.Property(e => e.city)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RestoreDrill>(entity =>
        {
            entity.HasKey(e => e.RID);

            entity.ToTable("RestoreDrill");

            entity.Property(e => e.BackupFile)
                .HasMaxLength(512)
                .IsUnicode(false);
            entity.Property(e => e.DBName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.State).HasDefaultValue(false);
        });

        modelBuilder.Entity<TLOG>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TLOG");

            entity.Property(e => e.Access_Rule_Name).HasMaxLength(50);
            entity.Property(e => e.Action).HasMaxLength(50);
            entity.Property(e => e.Blade).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(1);
            entity.Property(e => e.Destination).HasMaxLength(50);
            entity.Property(e => e.Interface).HasMaxLength(50);
            entity.Property(e => e.Origin).HasMaxLength(50);
            entity.Property(e => e.Policy_Name).HasMaxLength(50);
            entity.Property(e => e.Service).HasMaxLength(50);
            entity.Property(e => e.Source).HasMaxLength(50);
            entity.Property(e => e.Source_User_Name).HasMaxLength(1);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<TLOG_Result>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TLOG_Result");

            entity.Property(e => e.Destination).HasMaxLength(50);
            entity.Property(e => e.RID).ValueGeneratedOnAdd();
            entity.Property(e => e.Source).HasMaxLength(50);
        });

        modelBuilder.Entity<TLog1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TLog1");

            entity.Property(e => e.Access_Rule_Name).HasMaxLength(50);
            entity.Property(e => e.Action).HasMaxLength(50);
            entity.Property(e => e.Blade).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(1);
            entity.Property(e => e.Destination).HasMaxLength(50);
            entity.Property(e => e.Interface).HasMaxLength(50);
            entity.Property(e => e.Origin).HasMaxLength(50);
            entity.Property(e => e.Policy_Name).HasMaxLength(50);
            entity.Property(e => e.Service).HasMaxLength(50);
            entity.Property(e => e.Source).HasMaxLength(50);
            entity.Property(e => e.Source_User_Name).HasMaxLength(1);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<TLog2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TLog2");

            entity.Property(e => e.Access_Rule_Name).HasMaxLength(50);
            entity.Property(e => e.Action).HasMaxLength(50);
            entity.Property(e => e.Blade).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(1);
            entity.Property(e => e.Destination).HasMaxLength(50);
            entity.Property(e => e.Interface).HasMaxLength(50);
            entity.Property(e => e.Origin).HasMaxLength(50);
            entity.Property(e => e.Policy_Name).HasMaxLength(50);
            entity.Property(e => e.Service).HasMaxLength(50);
            entity.Property(e => e.Source).HasMaxLength(50);
            entity.Property(e => e.Source_User_Name).HasMaxLength(1);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<TLog3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TLog3");

            entity.Property(e => e.Access_Rule_Name).HasMaxLength(50);
            entity.Property(e => e.Action).HasMaxLength(50);
            entity.Property(e => e.Blade).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(1);
            entity.Property(e => e.Destination).HasMaxLength(50);
            entity.Property(e => e.Interface).HasMaxLength(50);
            entity.Property(e => e.Origin).HasMaxLength(50);
            entity.Property(e => e.Policy_Name).HasMaxLength(50);
            entity.Property(e => e.Service).HasMaxLength(50);
            entity.Property(e => e.Source).HasMaxLength(50);
            entity.Property(e => e.Source_User_Name).HasMaxLength(1);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<TLog4>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TLog4");

            entity.Property(e => e.Access_Rule_Name).HasMaxLength(50);
            entity.Property(e => e.Action).HasMaxLength(50);
            entity.Property(e => e.Blade).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(1);
            entity.Property(e => e.Destination).HasMaxLength(50);
            entity.Property(e => e.Interface).HasMaxLength(50);
            entity.Property(e => e.Origin).HasMaxLength(50);
            entity.Property(e => e.Policy_Name).HasMaxLength(50);
            entity.Property(e => e.Service).HasMaxLength(50);
            entity.Property(e => e.Source).HasMaxLength(50);
            entity.Property(e => e.Source_User_Name).HasMaxLength(1);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<TLog5>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TLog5");

            entity.Property(e => e.Access_Rule_Name).HasMaxLength(50);
            entity.Property(e => e.Action).HasMaxLength(50);
            entity.Property(e => e.Blade).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(1);
            entity.Property(e => e.Destination).HasMaxLength(50);
            entity.Property(e => e.Interface).HasMaxLength(50);
            entity.Property(e => e.Origin).HasMaxLength(50);
            entity.Property(e => e.Policy_Name).HasMaxLength(50);
            entity.Property(e => e.Service).HasMaxLength(50);
            entity.Property(e => e.Source).HasMaxLength(50);
            entity.Property(e => e.Source_User_Name).HasMaxLength(1);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<TLog6>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TLog6");

            entity.Property(e => e.Access_Rule_Name).HasMaxLength(50);
            entity.Property(e => e.Action).HasMaxLength(50);
            entity.Property(e => e.Blade).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(1);
            entity.Property(e => e.Destination).HasMaxLength(50);
            entity.Property(e => e.Interface).HasMaxLength(50);
            entity.Property(e => e.Origin).HasMaxLength(50);
            entity.Property(e => e.Policy_Name).HasMaxLength(50);
            entity.Property(e => e.Service).HasMaxLength(50);
            entity.Property(e => e.Source).HasMaxLength(50);
            entity.Property(e => e.Source_User_Name).HasMaxLength(1);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<TLog7>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TLog7");

            entity.Property(e => e.Access_Rule_Name).HasMaxLength(50);
            entity.Property(e => e.Action).HasMaxLength(50);
            entity.Property(e => e.Blade).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(1);
            entity.Property(e => e.Destination).HasMaxLength(50);
            entity.Property(e => e.Interface).HasMaxLength(50);
            entity.Property(e => e.Origin).HasMaxLength(50);
            entity.Property(e => e.Policy_Name).HasMaxLength(50);
            entity.Property(e => e.Service).HasMaxLength(50);
            entity.Property(e => e.Source).HasMaxLength(50);
            entity.Property(e => e.Source_User_Name).HasMaxLength(1);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<TLog8>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TLog8");

            entity.Property(e => e.Access_Rule_Name).HasMaxLength(50);
            entity.Property(e => e.Action).HasMaxLength(50);
            entity.Property(e => e.Blade).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(1);
            entity.Property(e => e.Destination).HasMaxLength(50);
            entity.Property(e => e.Interface).HasMaxLength(50);
            entity.Property(e => e.Origin).HasMaxLength(50);
            entity.Property(e => e.Policy_Name).HasMaxLength(50);
            entity.Property(e => e.Service).HasMaxLength(50);
            entity.Property(e => e.Source).HasMaxLength(50);
            entity.Property(e => e.Source_User_Name).HasMaxLength(1);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<TTT>(entity =>
        {
            entity.HasKey(e => e.TID);

            entity.ToTable("TTT");
        });

        modelBuilder.Entity<friend>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e._edge_id_B75FB4408B7349C086619523700698AE)
                .HasMaxLength(1000)
                .HasColumnName("$edge_id_B75FB4408B7349C086619523700698AE");
            entity.Property(e => e._from_id_2EB76BD9E0DE4F5791443314EE7DA090)
                .HasMaxLength(1000)
                .HasColumnName("$from_id_2EB76BD9E0DE4F5791443314EE7DA090");
            entity.Property(e => e._to_id_088A46B44DE6486088F32EEA9FF24BEE)
                .HasMaxLength(1000)
                .HasColumnName("$to_id_088A46B44DE6486088F32EEA9FF24BEE");
        });

        modelBuilder.Entity<friendOf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("friendOf");

            entity.Property(e => e._edge_id_213D9BD9900D40519814ACB883983F10)
                .HasMaxLength(1000)
                .HasColumnName("$edge_id_213D9BD9900D40519814ACB883983F10");
            entity.Property(e => e._from_id_06B74EF8E959416280F9F7E0612C989C)
                .HasMaxLength(1000)
                .HasColumnName("$from_id_06B74EF8E959416280F9F7E0612C989C");
            entity.Property(e => e._to_id_F219BF27FEAD407593937615E726F16A)
                .HasMaxLength(1000)
                .HasColumnName("$to_id_F219BF27FEAD407593937615E726F16A");
        });

        modelBuilder.Entity<like>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e._edge_id_6B64DA779FB141CE8BB1F6E5EFFEB29F)
                .HasMaxLength(1000)
                .HasColumnName("$edge_id_6B64DA779FB141CE8BB1F6E5EFFEB29F");
            entity.Property(e => e._from_id_D1AF033A3FB640198FB246F292D19247)
                .HasMaxLength(1000)
                .HasColumnName("$from_id_D1AF033A3FB640198FB246F292D19247");
            entity.Property(e => e._to_id_8BB8B1611E9048858329202B5827427A)
                .HasMaxLength(1000)
                .HasColumnName("$to_id_8BB8B1611E9048858329202B5827427A");
        });

        modelBuilder.Entity<livesIn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("livesIn");

            entity.Property(e => e._edge_id_C9DB63A4B2FC41FC9D8EEA4696B6F1E0)
                .HasMaxLength(1000)
                .HasColumnName("$edge_id_C9DB63A4B2FC41FC9D8EEA4696B6F1E0");
            entity.Property(e => e._from_id_6EC6397CCB504ABAB877AFF6AED549E9)
                .HasMaxLength(1000)
                .HasColumnName("$from_id_6EC6397CCB504ABAB877AFF6AED549E9");
            entity.Property(e => e._to_id_8FFA3B4304C647A7AB83E587E16DFEDA)
                .HasMaxLength(1000)
                .HasColumnName("$to_id_8FFA3B4304C647A7AB83E587E16DFEDA");
        });

        modelBuilder.Entity<locatedIn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("locatedIn");

            entity.Property(e => e._edge_id_8DC4EC62D76D4580BF7B181D8ADB137C)
                .HasMaxLength(1000)
                .HasColumnName("$edge_id_8DC4EC62D76D4580BF7B181D8ADB137C");
            entity.Property(e => e._from_id_BE1447D291994C959962BB6CF73AA472)
                .HasMaxLength(1000)
                .HasColumnName("$from_id_BE1447D291994C959962BB6CF73AA472");
            entity.Property(e => e._to_id_9A5F232D4CAF4F8980DC6641DC07CA8A)
                .HasMaxLength(1000)
                .HasColumnName("$to_id_9A5F232D4CAF4F8980DC6641DC07CA8A");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
