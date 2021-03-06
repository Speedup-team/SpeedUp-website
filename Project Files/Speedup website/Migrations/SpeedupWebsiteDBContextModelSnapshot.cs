// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Speedup_website.Data;

#nullable disable

namespace Speedup_website.Migrations
{
    [DbContext(typeof(SpeedupWebsiteDBContext))]
    partial class SpeedupWebsiteDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Speedup_website.Entitys.ModifyingDetails", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("columnsChanged")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("modifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("modifier_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("modifyingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("row_id")
                        .HasColumnType("int");

                    b.Property<string>("tableName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("id");

                    b.ToTable("ModifyingDetails");
                });

            modelBuilder.Entity("Speedup_website.Entitys.Orders.CartItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("discount_id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("modifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<int>("session_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("discount_id");

                    b.HasIndex("product_id");

                    b.HasIndex("session_id");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("Speedup_website.Entitys.Orders.Discount", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<int>("discountPercent")
                        .HasColumnType("int");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("modifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("removedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("Speedup_website.Entitys.Orders.GuestCartItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("discount_id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("modifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<int>("session_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("discount_id");

                    b.HasIndex("product_id");

                    b.HasIndex("session_id");

                    b.ToTable("GuestCartItems");
                });

            modelBuilder.Entity("Speedup_website.Entitys.Orders.GuestShoppingSession", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("guest_id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("modifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.HasIndex("guest_id")
                        .IsUnique();

                    b.ToTable("GuestShoppingSessions");
                });

            modelBuilder.Entity("Speedup_website.Entitys.Orders.OrderDetails", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("modifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("user_id");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Speedup_website.Entitys.Orders.OrderItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int?>("discount_id")
                        .HasColumnType("int");

                    b.Property<int>("order_id")
                        .HasColumnType("int");

                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.Property<decimal>("quantity")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.HasIndex("discount_id");

                    b.HasIndex("order_id");

                    b.HasIndex("product_id");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Speedup_website.Entitys.Orders.PaymentDetails", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("cashingType_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("modifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("order_id")
                        .HasColumnType("int");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("id");

                    b.HasIndex("cashingType_id");

                    b.HasIndex("order_id")
                        .IsUnique();

                    b.ToTable("PaymentDetails");
                });

            modelBuilder.Entity("Speedup_website.Entitys.Orders.ShoppingSassion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("modifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("user_id")
                        .IsUnique();

                    b.ToTable("ShoppingSassions");
                });

            modelBuilder.Entity("Speedup_website.Entitys.People.CashingType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("cashingType")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("link")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("modifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("provider")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime?>("removedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("CashingTypes");
                });

            modelBuilder.Entity("Speedup_website.Entitys.People.Guest", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("Speedup_website.Entitys.People.Owner", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("modifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("person_id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("removedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("state")
                        .HasMaxLength(15)
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("person_id");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("Speedup_website.Entitys.People.OwnerCashingOut", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("cashingType_id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("modifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("owner_id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("removedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("cashingType_id");

                    b.HasIndex("owner_id");

                    b.ToTable("OwnerCashingOuts");
                });

            modelBuilder.Entity("Speedup_website.Entitys.People.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("isOwner")
                        .HasColumnType("bit");

                    b.Property<int?>("mobilephone")
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("state")
                        .HasMaxLength(15)
                        .HasColumnType("int");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Speedup_website.Entitys.People.UserAddress", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("country")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<int?>("mobilePhone")
                        .HasColumnType("int");

                    b.Property<DateTime>("modifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("removedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("telephone")
                        .HasColumnType("int");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("user_id");

                    b.ToTable("UserAddresses");
                });

            modelBuilder.Entity("Speedup_website.Entitys.People.UserPayment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime?>("modifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("paymentType_id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("removedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("paymentType_id");

                    b.HasIndex("user_id");

                    b.ToTable("UserPayments");
                });

            modelBuilder.Entity("Speedup_website.Entitys.Products.Catigory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<DateTime?>("modifieAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("owner_id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("removedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("state")
                        .HasMaxLength(15)
                        .HasColumnType("int");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("catigoryType");

                    b.HasKey("id");

                    b.HasIndex("owner_id");

                    b.ToTable("Catigories");
                });

            modelBuilder.Entity("Speedup_website.Entitys.Products.Factory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<DateTime?>("modifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("removedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("Factories");
                });

            modelBuilder.Entity("Speedup_website.Entitys.Products.Inventory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime?>("modifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("removedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("sku")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("id");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("Speedup_website.Entitys.Products.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("catigory_id")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<int?>("discount_id")
                        .HasColumnType("int");

                    b.Property<int?>("factory_id")
                        .HasColumnType("int");

                    b.Property<int?>("inventory_id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("modifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("primaryImage")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("removedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("sku")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("id");

                    b.HasIndex("catigory_id");

                    b.HasIndex("discount_id");

                    b.HasIndex("factory_id");

                    b.HasIndex("inventory_id")
                        .IsUnique()
                        .HasFilter("[inventory_id] IS NOT NULL");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Speedup_website.Entitys.Products.ProductImage", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("addedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("modifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("removedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("product_id");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("Speedup_website.Entitys.Orders.CartItem", b =>
                {
                    b.HasOne("Speedup_website.Entitys.Orders.Discount", "discount")
                        .WithMany()
                        .HasForeignKey("discount_id");

                    b.HasOne("Speedup_website.Entitys.Products.Product", "Product")
                        .WithMany()
                        .HasForeignKey("product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Speedup_website.Entitys.Orders.ShoppingSassion", "shoppingSassion")
                        .WithMany("items")
                        .HasForeignKey("session_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("discount");

                    b.Navigation("shoppingSassion");
                });

            modelBuilder.Entity("Speedup_website.Entitys.Orders.GuestCartItem", b =>
                {
                    b.HasOne("Speedup_website.Entitys.Orders.Discount", "discount")
                        .WithMany()
                        .HasForeignKey("discount_id");

                    b.HasOne("Speedup_website.Entitys.Products.Product", "Product")
                        .WithMany()
                        .HasForeignKey("product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Speedup_website.Entitys.Orders.GuestShoppingSession", "shoppingSession")
                        .WithMany("cartItems")
                        .HasForeignKey("session_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("discount");

                    b.Navigation("shoppingSession");
                });

            modelBuilder.Entity("Speedup_website.Entitys.Orders.GuestShoppingSession", b =>
                {
                    b.HasOne("Speedup_website.Entitys.People.Guest", "guest")
                        .WithOne("shoppingSession")
                        .HasForeignKey("Speedup_website.Entitys.Orders.GuestShoppingSession", "guest_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("guest");
                });

            modelBuilder.Entity("Speedup_website.Entitys.Orders.OrderDetails", b =>
                {
                    b.HasOne("Speedup_website.Entitys.People.User", "user")
                        .WithMany()
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("Speedup_website.Entitys.Orders.OrderItem", b =>
                {
                    b.HasOne("Speedup_website.Entitys.Orders.Discount", "discount")
                        .WithMany()
                        .HasForeignKey("discount_id");

                    b.HasOne("Speedup_website.Entitys.Orders.OrderDetails", "orderDetails")
                        .WithMany("orderItems")
                        .HasForeignKey("order_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Speedup_website.Entitys.Products.Product", "Product")
                        .WithMany()
                        .HasForeignKey("product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("discount");

                    b.Navigation("orderDetails");
                });

            modelBuilder.Entity("Speedup_website.Entitys.Orders.PaymentDetails", b =>
                {
                    b.HasOne("Speedup_website.Entitys.People.CashingType", "cashingType")
                        .WithMany()
                        .HasForeignKey("cashingType_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Speedup_website.Entitys.Orders.OrderDetails", "orderDetails")
                        .WithOne("paymentDetails")
                        .HasForeignKey("Speedup_website.Entitys.Orders.PaymentDetails", "order_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cashingType");

                    b.Navigation("orderDetails");
                });

            modelBuilder.Entity("Speedup_website.Entitys.Orders.ShoppingSassion", b =>
                {
                    b.HasOne("Speedup_website.Entitys.People.User", "user")
                        .WithOne("shoppingSassion")
                        .HasForeignKey("Speedup_website.Entitys.Orders.ShoppingSassion", "user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("Speedup_website.Entitys.People.Owner", b =>
                {
                    b.HasOne("Speedup_website.Entitys.People.User", "userDetails")
                        .WithMany()
                        .HasForeignKey("person_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("userDetails");
                });

            modelBuilder.Entity("Speedup_website.Entitys.People.OwnerCashingOut", b =>
                {
                    b.HasOne("Speedup_website.Entitys.People.CashingType", "cashingType")
                        .WithMany()
                        .HasForeignKey("cashingType_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Speedup_website.Entitys.People.Owner", "owner")
                        .WithMany("ownerCashingOuts")
                        .HasForeignKey("owner_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cashingType");

                    b.Navigation("owner");
                });

            modelBuilder.Entity("Speedup_website.Entitys.People.UserAddress", b =>
                {
                    b.HasOne("Speedup_website.Entitys.People.User", "userData")
                        .WithMany()
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("userData");
                });

            modelBuilder.Entity("Speedup_website.Entitys.People.UserPayment", b =>
                {
                    b.HasOne("Speedup_website.Entitys.People.CashingType", "cashingType")
                        .WithMany()
                        .HasForeignKey("paymentType_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Speedup_website.Entitys.People.User", "userDetailes")
                        .WithMany()
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cashingType");

                    b.Navigation("userDetailes");
                });

            modelBuilder.Entity("Speedup_website.Entitys.Products.Catigory", b =>
                {
                    b.HasOne("Speedup_website.Entitys.People.Owner", "owner")
                        .WithMany("categories")
                        .HasForeignKey("owner_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("owner");
                });

            modelBuilder.Entity("Speedup_website.Entitys.Products.Product", b =>
                {
                    b.HasOne("Speedup_website.Entitys.Products.Catigory", "catigory")
                        .WithMany("products")
                        .HasForeignKey("catigory_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Speedup_website.Entitys.Orders.Discount", "discount")
                        .WithMany()
                        .HasForeignKey("discount_id");

                    b.HasOne("Speedup_website.Entitys.Products.Factory", "factory")
                        .WithMany("products")
                        .HasForeignKey("factory_id");

                    b.HasOne("Speedup_website.Entitys.Products.Inventory", "inventory")
                        .WithOne("product")
                        .HasForeignKey("Speedup_website.Entitys.Products.Product", "inventory_id");

                    b.Navigation("catigory");

                    b.Navigation("discount");

                    b.Navigation("factory");

                    b.Navigation("inventory");
                });

            modelBuilder.Entity("Speedup_website.Entitys.Products.ProductImage", b =>
                {
                    b.HasOne("Speedup_website.Entitys.Products.Product", "product")
                        .WithMany("images")
                        .HasForeignKey("product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");
                });

            modelBuilder.Entity("Speedup_website.Entitys.Orders.GuestShoppingSession", b =>
                {
                    b.Navigation("cartItems");
                });

            modelBuilder.Entity("Speedup_website.Entitys.Orders.OrderDetails", b =>
                {
                    b.Navigation("orderItems");

                    b.Navigation("paymentDetails")
                        .IsRequired();
                });

            modelBuilder.Entity("Speedup_website.Entitys.Orders.ShoppingSassion", b =>
                {
                    b.Navigation("items");
                });

            modelBuilder.Entity("Speedup_website.Entitys.People.Guest", b =>
                {
                    b.Navigation("shoppingSession");
                });

            modelBuilder.Entity("Speedup_website.Entitys.People.Owner", b =>
                {
                    b.Navigation("categories");

                    b.Navigation("ownerCashingOuts");
                });

            modelBuilder.Entity("Speedup_website.Entitys.People.User", b =>
                {
                    b.Navigation("shoppingSassion");
                });

            modelBuilder.Entity("Speedup_website.Entitys.Products.Catigory", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("Speedup_website.Entitys.Products.Factory", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("Speedup_website.Entitys.Products.Inventory", b =>
                {
                    b.Navigation("product");
                });

            modelBuilder.Entity("Speedup_website.Entitys.Products.Product", b =>
                {
                    b.Navigation("images");
                });
#pragma warning restore 612, 618
        }
    }
}
