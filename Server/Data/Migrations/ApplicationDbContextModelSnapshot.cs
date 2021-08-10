﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using messanger.Server.Data;

namespace messanger.Server.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.DeviceFlowCodes", b =>
                {
                    b.Property<string>("UserCode")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DeviceCode")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("Expiration")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("UserCode");

                    b.HasIndex("DeviceCode")
                        .IsUnique();

                    b.HasIndex("Expiration");

                    b.ToTable("DeviceCodes");
                });

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("ConsumedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Key");

                    b.HasIndex("Expiration");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.HasIndex("SubjectId", "SessionId", "Type");

                    b.ToTable("PersistedGrants");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("messanger.Server.Models.Conversation", b =>
                {
                    b.Property<int>("IdConversation")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdAvatar")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("IdConversation")
                        .HasName("Conversation_pk");

                    b.HasIndex("IdAvatar")
                        .IsUnique();

                    b.ToTable("Conversation");
                });

            modelBuilder.Entity("messanger.Server.Models.ConversationMember", b =>
                {
                    b.Property<string>("IdUser")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("IdConversation")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("IdUser", "IdConversation")
                        .HasName("ConversationMember_pk");

                    b.HasIndex("IdConversation");

                    b.ToTable("ConversationMember");
                });

            modelBuilder.Entity("messanger.Server.Models.File", b =>
                {
                    b.Property<int>("IdFile")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdMessage")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("IdFile")
                        .HasName("File_pk");

                    b.HasIndex("IdMessage");

                    b.ToTable("File");
                });

            modelBuilder.Entity("messanger.Server.Models.Friendship", b =>
                {
                    b.Property<string>("IdUser1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IdUser2")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("IdUser1", "IdUser2")
                        .HasName("Friendship_pk");

                    b.HasIndex("IdUser2");

                    b.ToTable("Friendship");
                });

            modelBuilder.Entity("messanger.Server.Models.FriendshipRequest", b =>
                {
                    b.Property<string>("IdSender")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IdReceiver")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("IdSender", "IdReceiver")
                        .HasName("FriendshipRequest_pk");

                    b.HasIndex("IdReceiver");

                    b.ToTable("FriendshipRequest");
                });

            modelBuilder.Entity("messanger.Server.Models.Message", b =>
                {
                    b.Property<int>("IdMessage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdConversation")
                        .HasColumnType("int");

                    b.Property<int?>("IdParentMessage")
                        .HasColumnType("int");

                    b.Property<string>("IdSender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdMessage")
                        .HasName("Message_pk");

                    b.HasIndex("IdConversation");

                    b.HasIndex("IdParentMessage");

                    b.HasIndex("UserId");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("messanger.Server.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int>("IdAvatar")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("IdAvatar")
                        .IsUnique();

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("messanger.Server.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("messanger.Server.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("messanger.Server.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("messanger.Server.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("messanger.Server.Models.Conversation", b =>
                {
                    b.HasOne("messanger.Server.Models.File", "IdAvatarNavigation")
                        .WithOne("IdConversationNavigation")
                        .HasForeignKey("messanger.Server.Models.Conversation", "IdAvatar")
                        .HasConstraintName("Conversation_AvatarFile")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdAvatarNavigation");
                });

            modelBuilder.Entity("messanger.Server.Models.ConversationMember", b =>
                {
                    b.HasOne("messanger.Server.Models.Conversation", "IdConversationNavigation")
                        .WithMany("ConversationMembers")
                        .HasForeignKey("IdConversation")
                        .HasConstraintName("Conversation_ConversationMembers")
                        .IsRequired();

                    b.HasOne("messanger.Server.Models.User", "IdUserNavigation")
                        .WithMany("ConversationsParticipation")
                        .HasForeignKey("IdUser")
                        .HasConstraintName("User_ConversationMembers")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdConversationNavigation");

                    b.Navigation("IdUserNavigation");
                });

            modelBuilder.Entity("messanger.Server.Models.File", b =>
                {
                    b.HasOne("messanger.Server.Models.Message", "IdMessageNavigation")
                        .WithMany("AttachedFiles")
                        .HasForeignKey("IdMessage")
                        .HasConstraintName("Message_AttachedFiles");

                    b.Navigation("IdMessageNavigation");
                });

            modelBuilder.Entity("messanger.Server.Models.Friendship", b =>
                {
                    b.HasOne("messanger.Server.Models.User", "IdUser1Navigation")
                        .WithMany("FriendshipsWhereIsUser1")
                        .HasForeignKey("IdUser1")
                        .HasConstraintName("Friendship_User1")
                        .IsRequired();

                    b.HasOne("messanger.Server.Models.User", "IdUser2Navigation")
                        .WithMany("FriendshipsWhereIsUser2")
                        .HasForeignKey("IdUser2")
                        .HasConstraintName("Friendship_User2")
                        .IsRequired();

                    b.Navigation("IdUser1Navigation");

                    b.Navigation("IdUser2Navigation");
                });

            modelBuilder.Entity("messanger.Server.Models.FriendshipRequest", b =>
                {
                    b.HasOne("messanger.Server.Models.User", "IdReceiverNavigation")
                        .WithMany("ReceivedFriendshipRequests")
                        .HasForeignKey("IdReceiver")
                        .HasConstraintName("FriendshipRequest_Receiver")
                        .IsRequired();

                    b.HasOne("messanger.Server.Models.User", "IdSenderNavigation")
                        .WithMany("SentFriendshipRequests")
                        .HasForeignKey("IdSender")
                        .HasConstraintName("FriendshipRequest_Sender")
                        .IsRequired();

                    b.Navigation("IdReceiverNavigation");

                    b.Navigation("IdSenderNavigation");
                });

            modelBuilder.Entity("messanger.Server.Models.Message", b =>
                {
                    b.HasOne("messanger.Server.Models.Conversation", "IdConversationNavigation")
                        .WithMany("Messages")
                        .HasForeignKey("IdConversation")
                        .HasConstraintName("Conversation_Message")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("messanger.Server.Models.Message", "IdParentMessageNavigation")
                        .WithMany("ChildrenMessages")
                        .HasForeignKey("IdParentMessage")
                        .HasConstraintName("Message_ParentMessage");

                    b.HasOne("messanger.Server.Models.User", null)
                        .WithMany("SentMessages")
                        .HasForeignKey("UserId");

                    b.Navigation("IdConversationNavigation");

                    b.Navigation("IdParentMessageNavigation");
                });

            modelBuilder.Entity("messanger.Server.Models.User", b =>
                {
                    b.HasOne("messanger.Server.Models.File", "IdAvatarNavigation")
                        .WithOne("IdUserNavigation")
                        .HasForeignKey("messanger.Server.Models.User", "IdAvatar")
                        .HasConstraintName("User_AvatarFile")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdAvatarNavigation");
                });

            modelBuilder.Entity("messanger.Server.Models.Conversation", b =>
                {
                    b.Navigation("ConversationMembers");

                    b.Navigation("Messages");
                });

            modelBuilder.Entity("messanger.Server.Models.File", b =>
                {
                    b.Navigation("IdConversationNavigation");

                    b.Navigation("IdUserNavigation");
                });

            modelBuilder.Entity("messanger.Server.Models.Message", b =>
                {
                    b.Navigation("AttachedFiles");

                    b.Navigation("ChildrenMessages");
                });

            modelBuilder.Entity("messanger.Server.Models.User", b =>
                {
                    b.Navigation("ConversationsParticipation");

                    b.Navigation("FriendshipsWhereIsUser1");

                    b.Navigation("FriendshipsWhereIsUser2");

                    b.Navigation("ReceivedFriendshipRequests");

                    b.Navigation("SentFriendshipRequests");

                    b.Navigation("SentMessages");
                });
#pragma warning restore 612, 618
        }
    }
}
