using ATM_DEMO_API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ATM_DEMO_API.Data;

public class BankContext : DbContext
{
    public DbSet<BankUserInfo> BankUserInfo { get; set; }

    public DbSet<BankUserLoginInfo> BankUserLoginInfo { get; set; }

    public BankContext(DbContextOptions<BankContext> options) : base(options: options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        /* Configure Tables */
        modelBuilder
            .Entity<BankUserLoginInfo>(builder =>
            {
                const string VARCHAR_19 = "VARCHAR(19)";
                const string VARCHAR_6 = "VARCHAR(6)";

                builder.HasKey(keyExpression: userLoginInfo => userLoginInfo.CardID);

                builder
                    .Property(propertyExpression: userLoginInfo => userLoginInfo.CardID)
                    .HasColumnType(typeName: VARCHAR_19)
                    .IsRequired();

                builder
                    .Property(propertyExpression: userLoginInfo => userLoginInfo.PIN)
                    .HasColumnType(typeName: VARCHAR_6)
                    .IsRequired();

                builder
                    .HasOne(navigationExpression: userLoginInfo => userLoginInfo.BankUserInfo)
                    .WithOne(navigationExpression: userInfo => userInfo.BankUserLoginInfo)
                    .HasForeignKey<BankUserLoginInfo>(userLoginInfo => userLoginInfo.CardID)
                    .OnDelete(deleteBehavior: DeleteBehavior.Cascade)
                    .IsRequired();
            })
            .Entity<BankUserInfo>(builder =>
            {
                const string VARCHAR_19 = "VARCHAR(19)";
                const string NVARCHAR_50 = "NVARCHAR(50)";
                const string DECIMAL_12_0 = "DECIMAL(12, 0)";

                builder.HasKey(keyExpression: userInfo => userInfo.CardID);

                builder
                    .Property(propertyExpression: userInfo => userInfo.CardID)
                    .HasColumnType(typeName: VARCHAR_19)
                    .IsRequired();

                builder
                    .Property(propertyExpression: userInfo => userInfo.Name)
                    .HasColumnType(typeName: NVARCHAR_50)
                    .IsRequired();

                builder
                    .Property(propertyExpression: userInfo => userInfo.Money)
                    .HasColumnType(typeName: DECIMAL_12_0)
                    .IsRequired();
            });

        /* Data Seeding */
        ICollection<BankUserInfo> userInfoList = new List<BankUserInfo>()
        {
            new()
            {
                CardID = "4122-8934-5678-9010",
                Name = "Le Thanh",
                Money = 10_000_000
            }
        };

        ICollection<BankUserLoginInfo> userLoginInfoList = new List<BankUserLoginInfo>()
        {
            new()
            {
                CardID = "4122-8934-5678-9010",
                PIN = "654321",
            }
        };

        modelBuilder
            .Entity<BankUserLoginInfo>(buildAction: builder => builder.HasData(data: userLoginInfoList))
            .Entity<BankUserInfo>(buildAction: builder => builder.HasData(data: userInfoList));
    }
}
