﻿// <auto-generated />
using System;
using CoolStore.InventoryApi.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoolStore.InventoryApi.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(InventoryDbContext))]
    [Migration("20200501141533_InitInventoryDb")]
    partial class InitInventoryDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoolStore.InventoryApi.Domain.Store", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Store","inv");

                    b.HasData(
                        new
                        {
                            Id = new Guid("90c9479e-a11c-4d6d-aaaa-0405b6c0efcd"),
                            Created = new DateTime(2020, 5, 1, 14, 15, 33, 90, DateTimeKind.Utc).AddTicks(6170),
                            Description = "This store sells electronic gadgets",
                            Location = "Vietnam",
                            Website = "https://coolstore-vn.com"
                        },
                        new
                        {
                            Id = new Guid("b8b62196-6369-409d-b709-11c112dd023f"),
                            Created = new DateTime(2020, 5, 1, 14, 15, 33, 94, DateTimeKind.Utc).AddTicks(4559),
                            Description = "This store sells food and beverage products",
                            Location = "Seattle",
                            Website = "https://coolstore-sea.com"
                        },
                        new
                        {
                            Id = new Guid("ec186ddf-f430-44ec-84e5-205c93d84f14"),
                            Created = new DateTime(2020, 5, 1, 14, 15, 33, 94, DateTimeKind.Utc).AddTicks(4759),
                            Description = "This store sells food and beverage products",
                            Location = "San Francisco",
                            Website = "https://coolstore-san.com"
                        });
                });

            modelBuilder.Entity("CoolStore.InventoryApi.Domain.StoreProductPrice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("Eoq")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Rop")
                        .HasColumnType("int");

                    b.Property<Guid>("StoreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("StoreId");

                    b.ToTable("StoreProductPrice","inv");

                    b.HasData(
                        new
                        {
                            Id = new Guid("785ec0d4-cdb2-480b-b8b3-2f65950ef048"),
                            Created = new DateTime(2020, 5, 1, 14, 15, 33, 121, DateTimeKind.Utc).AddTicks(7773),
                            Eoq = 10,
                            Price = 900.0,
                            ProductId = new Guid("ba16da71-c7dd-4eac-9ead-5c2c2244e69f"),
                            Rop = 5,
                            StoreId = new Guid("90c9479e-a11c-4d6d-aaaa-0405b6c0efcd")
                        },
                        new
                        {
                            Id = new Guid("ce8014b6-e8ed-49e6-a1bf-4a73c62fcbf6"),
                            Created = new DateTime(2020, 5, 1, 14, 15, 33, 121, DateTimeKind.Utc).AddTicks(8390),
                            Eoq = 10,
                            Price = 1000.0,
                            ProductId = new Guid("13d02035-2286-4055-ad2d-6855a60efbbb"),
                            Rop = 5,
                            StoreId = new Guid("90c9479e-a11c-4d6d-aaaa-0405b6c0efcd")
                        },
                        new
                        {
                            Id = new Guid("55434919-47da-411b-a11d-c664650e9565"),
                            Created = new DateTime(2020, 5, 1, 14, 15, 33, 121, DateTimeKind.Utc).AddTicks(8445),
                            Eoq = 10,
                            Price = 4000.0,
                            ProductId = new Guid("b8f0a771-339f-4602-a862-f7a51afd5b79"),
                            Rop = 5,
                            StoreId = new Guid("90c9479e-a11c-4d6d-aaaa-0405b6c0efcd")
                        },
                        new
                        {
                            Id = new Guid("776d9751-2fc3-4aa6-94e5-83ac8c30c0e5"),
                            Created = new DateTime(2020, 5, 1, 14, 15, 33, 121, DateTimeKind.Utc).AddTicks(8483),
                            Eoq = 10,
                            Price = 500.0,
                            ProductId = new Guid("ffd60654-1802-48bd-b4c3-d49831a8ab2c"),
                            Rop = 5,
                            StoreId = new Guid("90c9479e-a11c-4d6d-aaaa-0405b6c0efcd")
                        },
                        new
                        {
                            Id = new Guid("a38c9b35-6b4e-46c1-8864-ea03310e9bb1"),
                            Created = new DateTime(2020, 5, 1, 14, 15, 33, 121, DateTimeKind.Utc).AddTicks(8517),
                            Eoq = 10,
                            Price = 253.0,
                            ProductId = new Guid("a4811778-5070-4d70-8a9c-e6cb70dfcca4"),
                            Rop = 5,
                            StoreId = new Guid("b8b62196-6369-409d-b709-11c112dd023f")
                        },
                        new
                        {
                            Id = new Guid("37f5b3a2-557e-4fe8-b5e3-8d581a237583"),
                            Created = new DateTime(2020, 5, 1, 14, 15, 33, 121, DateTimeKind.Utc).AddTicks(8556),
                            Eoq = 10,
                            Price = 2809.0,
                            ProductId = new Guid("6a0e6d20-8bcc-450f-bc5c-b8f727083dcd"),
                            Rop = 5,
                            StoreId = new Guid("ec186ddf-f430-44ec-84e5-205c93d84f14")
                        },
                        new
                        {
                            Id = new Guid("ba26b27c-1419-4e5c-a0ed-c98c4ec2a1d9"),
                            Created = new DateTime(2020, 5, 1, 14, 15, 33, 121, DateTimeKind.Utc).AddTicks(8589),
                            Eoq = 10,
                            Price = 2147.0,
                            ProductId = new Guid("fee1fc67-7469-4490-b418-47f4732de53f"),
                            Rop = 5,
                            StoreId = new Guid("b8b62196-6369-409d-b709-11c112dd023f")
                        },
                        new
                        {
                            Id = new Guid("f643880d-7153-4ee2-b66b-9bd1e466043c"),
                            Created = new DateTime(2020, 5, 1, 14, 15, 33, 121, DateTimeKind.Utc).AddTicks(8621),
                            Eoq = 10,
                            Price = 2200.0,
                            ProductId = new Guid("2d2245e4-213a-49de-93d3-79e9439400f5"),
                            Rop = 5,
                            StoreId = new Guid("b8b62196-6369-409d-b709-11c112dd023f")
                        },
                        new
                        {
                            Id = new Guid("93c6ba3e-e4cb-40a2-89bc-c8550c672237"),
                            Created = new DateTime(2020, 5, 1, 14, 15, 33, 121, DateTimeKind.Utc).AddTicks(8655),
                            Eoq = 10,
                            Price = 2441.0,
                            ProductId = new Guid("386b04c6-303a-4840-8a51-d92b1ea2d339"),
                            Rop = 5,
                            StoreId = new Guid("ec186ddf-f430-44ec-84e5-205c93d84f14")
                        },
                        new
                        {
                            Id = new Guid("3f4db00c-67c7-43d6-9ffc-736877a7413e"),
                            Created = new DateTime(2020, 5, 1, 14, 15, 33, 121, DateTimeKind.Utc).AddTicks(8751),
                            Eoq = 10,
                            Price = 1731.0,
                            ProductId = new Guid("297c5959-4808-4f40-8d6a-4a899505e1f7"),
                            Rop = 5,
                            StoreId = new Guid("b8b62196-6369-409d-b709-11c112dd023f")
                        },
                        new
                        {
                            Id = new Guid("56a082ac-3e9b-4702-848c-2ba75400ff3a"),
                            Created = new DateTime(2020, 5, 1, 14, 15, 33, 121, DateTimeKind.Utc).AddTicks(8787),
                            Eoq = 10,
                            Price = 975.0,
                            ProductId = new Guid("3a0a0a89-9b3a-4046-bf2b-deee64a764d2"),
                            Rop = 5,
                            StoreId = new Guid("ec186ddf-f430-44ec-84e5-205c93d84f14")
                        },
                        new
                        {
                            Id = new Guid("d8dda9ba-ae9f-4c14-8980-9b6bdf12d66d"),
                            Created = new DateTime(2020, 5, 1, 14, 15, 33, 121, DateTimeKind.Utc).AddTicks(8820),
                            Eoq = 10,
                            Price = 3453.0,
                            ProductId = new Guid("71c46659-9560-4d6a-ac18-893477ed6662"),
                            Rop = 5,
                            StoreId = new Guid("ec186ddf-f430-44ec-84e5-205c93d84f14")
                        },
                        new
                        {
                            Id = new Guid("325436f9-f674-4fbb-bbf5-f2a7c813be2d"),
                            Created = new DateTime(2020, 5, 1, 14, 15, 33, 121, DateTimeKind.Utc).AddTicks(8853),
                            Eoq = 10,
                            Price = 2067.0,
                            ProductId = new Guid("f92bfa6a-2522-4234-a7f1-9004596a4a85"),
                            Rop = 5,
                            StoreId = new Guid("ec186ddf-f430-44ec-84e5-205c93d84f14")
                        },
                        new
                        {
                            Id = new Guid("9e3a2db9-6345-49e6-b22b-3e0aaeec0923"),
                            Created = new DateTime(2020, 5, 1, 14, 15, 33, 121, DateTimeKind.Utc).AddTicks(8886),
                            Eoq = 10,
                            Price = 1769.0,
                            ProductId = new Guid("cbe43158-2010-4cb1-a8de-f00da16a7362"),
                            Rop = 5,
                            StoreId = new Guid("b8b62196-6369-409d-b709-11c112dd023f")
                        },
                        new
                        {
                            Id = new Guid("13dd993e-d979-4e22-a159-f577dffb8062"),
                            Created = new DateTime(2020, 5, 1, 14, 15, 33, 121, DateTimeKind.Utc).AddTicks(8920),
                            Eoq = 10,
                            Price = 642.0,
                            ProductId = new Guid("85b9767c-1a09-4c33-8e77-faa25f1d69e1"),
                            Rop = 5,
                            StoreId = new Guid("ec186ddf-f430-44ec-84e5-205c93d84f14")
                        },
                        new
                        {
                            Id = new Guid("58436d6f-9c16-445f-b70d-b4159ba0fa56"),
                            Created = new DateTime(2020, 5, 1, 14, 15, 33, 121, DateTimeKind.Utc).AddTicks(8953),
                            Eoq = 10,
                            Price = 967.0,
                            ProductId = new Guid("22112bb2-c324-4860-8eb9-9c78853a52a5"),
                            Rop = 5,
                            StoreId = new Guid("b8b62196-6369-409d-b709-11c112dd023f")
                        },
                        new
                        {
                            Id = new Guid("9ba82d65-0830-49e9-8d7d-f309ed42457b"),
                            Created = new DateTime(2020, 5, 1, 14, 15, 33, 121, DateTimeKind.Utc).AddTicks(8987),
                            Eoq = 10,
                            Price = 1124.0,
                            ProductId = new Guid("97ad5bf4-d153-41c5-a6e0-6d0bfbbb4f67"),
                            Rop = 5,
                            StoreId = new Guid("ec186ddf-f430-44ec-84e5-205c93d84f14")
                        },
                        new
                        {
                            Id = new Guid("08eb6d70-b4f7-4eac-8cd5-f4856cc751f3"),
                            Created = new DateTime(2020, 5, 1, 14, 15, 33, 121, DateTimeKind.Utc).AddTicks(9023),
                            Eoq = 10,
                            Price = 1665.0,
                            ProductId = new Guid("cfc5cff8-ab2a-4c70-994d-5ab8ccb7cb0d"),
                            Rop = 5,
                            StoreId = new Guid("b8b62196-6369-409d-b709-11c112dd023f")
                        },
                        new
                        {
                            Id = new Guid("ba855106-3eb1-4be9-a565-ccf2ad5270a1"),
                            Created = new DateTime(2020, 5, 1, 14, 15, 33, 121, DateTimeKind.Utc).AddTicks(9057),
                            Eoq = 10,
                            Price = 3305.0,
                            ProductId = new Guid("fac2ccc6-2c3f-4c1e-acbd-5354ba0873fb"),
                            Rop = 5,
                            StoreId = new Guid("ec186ddf-f430-44ec-84e5-205c93d84f14")
                        },
                        new
                        {
                            Id = new Guid("79292e85-43e2-40a0-969a-da8a9987de8a"),
                            Created = new DateTime(2020, 5, 1, 14, 15, 33, 121, DateTimeKind.Utc).AddTicks(9089),
                            Eoq = 10,
                            Price = 3310.0,
                            ProductId = new Guid("1adbc55a-4354-4205-b96d-c95e2dc806f4"),
                            Rop = 5,
                            StoreId = new Guid("b8b62196-6369-409d-b709-11c112dd023f")
                        },
                        new
                        {
                            Id = new Guid("3dbe06af-c15d-4cfa-9f43-590c001063a6"),
                            Created = new DateTime(2020, 5, 1, 14, 15, 33, 121, DateTimeKind.Utc).AddTicks(9123),
                            Eoq = 10,
                            Price = 3196.0,
                            ProductId = new Guid("c3770b10-dd0f-4b1c-83aa-d424c175c087"),
                            Rop = 5,
                            StoreId = new Guid("ec186ddf-f430-44ec-84e5-205c93d84f14")
                        },
                        new
                        {
                            Id = new Guid("df0db461-720b-4b4d-958e-e1178fdd4fa9"),
                            Created = new DateTime(2020, 5, 1, 14, 15, 33, 121, DateTimeKind.Utc).AddTicks(9156),
                            Eoq = 10,
                            Price = 2236.0,
                            ProductId = new Guid("6b8d0110-e3e8-4727-a51e-06f38864e464"),
                            Rop = 5,
                            StoreId = new Guid("b8b62196-6369-409d-b709-11c112dd023f")
                        },
                        new
                        {
                            Id = new Guid("c294478a-e537-4cf9-b36d-acc3458e5df1"),
                            Created = new DateTime(2020, 5, 1, 14, 15, 33, 121, DateTimeKind.Utc).AddTicks(9223),
                            Eoq = 10,
                            Price = 232.0,
                            ProductId = new Guid("3b69e116-9dd6-400f-96ce-9911f4f6ac8b"),
                            Rop = 5,
                            StoreId = new Guid("ec186ddf-f430-44ec-84e5-205c93d84f14")
                        },
                        new
                        {
                            Id = new Guid("585e4160-ce70-4e78-b1e6-e4a9aa9d91b0"),
                            Created = new DateTime(2020, 5, 1, 14, 15, 33, 121, DateTimeKind.Utc).AddTicks(9257),
                            Eoq = 10,
                            Price = 3318.0,
                            ProductId = new Guid("89b46ea8-b9a6-40e5-8df3-dba1095695f7"),
                            Rop = 5,
                            StoreId = new Guid("b8b62196-6369-409d-b709-11c112dd023f")
                        },
                        new
                        {
                            Id = new Guid("bb9d2a1f-f17d-40a4-b66b-128ec29fff6c"),
                            Created = new DateTime(2020, 5, 1, 14, 15, 33, 121, DateTimeKind.Utc).AddTicks(9290),
                            Eoq = 10,
                            Price = 1504.0,
                            ProductId = new Guid("e88e07f8-358d-48f7-b17c-8a16458f9c0a"),
                            Rop = 5,
                            StoreId = new Guid("ec186ddf-f430-44ec-84e5-205c93d84f14")
                        },
                        new
                        {
                            Id = new Guid("d00b6019-5c1d-4317-8102-9482bc90e3bd"),
                            Created = new DateTime(2020, 5, 1, 14, 15, 33, 121, DateTimeKind.Utc).AddTicks(9323),
                            Eoq = 10,
                            Price = 3294.0,
                            ProductId = new Guid("b243a35d-120a-4db3-ad12-7b3fa80e6391"),
                            Rop = 5,
                            StoreId = new Guid("b8b62196-6369-409d-b709-11c112dd023f")
                        },
                        new
                        {
                            Id = new Guid("832587a7-a37f-4efd-b99f-a89451397d96"),
                            Created = new DateTime(2020, 5, 1, 14, 15, 33, 121, DateTimeKind.Utc).AddTicks(9355),
                            Eoq = 10,
                            Price = 3639.0,
                            ProductId = new Guid("6e3ac253-517d-48e5-96ad-800451f8591c"),
                            Rop = 5,
                            StoreId = new Guid("b8b62196-6369-409d-b709-11c112dd023f")
                        },
                        new
                        {
                            Id = new Guid("726eb225-a323-479c-82b6-4165532d1be4"),
                            Created = new DateTime(2020, 5, 1, 14, 15, 33, 121, DateTimeKind.Utc).AddTicks(9388),
                            Eoq = 10,
                            Price = 1191.0,
                            ProductId = new Guid("4693520a-2b14-4d90-8b64-541575511382"),
                            Rop = 5,
                            StoreId = new Guid("b8b62196-6369-409d-b709-11c112dd023f")
                        });
                });

            modelBuilder.Entity("CoolStore.InventoryApi.Domain.StoreProductPrice", b =>
                {
                    b.HasOne("CoolStore.InventoryApi.Domain.Store", "Store")
                        .WithMany("StoreProductPrices")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}