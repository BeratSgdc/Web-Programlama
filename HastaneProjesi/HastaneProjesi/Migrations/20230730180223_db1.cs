using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HastaneProjesi.Migrations
{
    public partial class db1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hastaneler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hastaneler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KanGrubu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KanGrubuAd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KanGrubu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unvanlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnvanAd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unvanlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Poliniklik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PolinikAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HastanelerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poliniklik", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Poliniklik_Hastaneler_HastanelerId",
                        column: x => x.HastanelerId,
                        principalTable: "Hastaneler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Hastalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MedeniHali = table.Column<int>(type: "int", nullable: false),
                    DogumYeri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Meslek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KanGrubuId = table.Column<int>(type: "int", nullable: true),
                    Cinsiyet = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hastalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hastalar_KanGrubu_KanGrubuId",
                        column: x => x.KanGrubuId,
                        principalTable: "KanGrubu",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Doktorlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumYeri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cinsiyet = table.Column<int>(type: "int", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UnvanlarId = table.Column<int>(type: "int", nullable: true),
                    PoliniklikId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doktorlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doktorlar_Poliniklik_PoliniklikId",
                        column: x => x.PoliniklikId,
                        principalTable: "Poliniklik",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Doktorlar_Unvanlar_UnvanlarId",
                        column: x => x.UnvanlarId,
                        principalTable: "Unvanlar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HastaKabul",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GelisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HastalarId = table.Column<int>(type: "int", nullable: true),
                    DoktorlarId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HastaKabul", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HastaKabul_Doktorlar_DoktorlarId",
                        column: x => x.DoktorlarId,
                        principalTable: "Doktorlar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HastaKabul_Hastalar_HastalarId",
                        column: x => x.HastalarId,
                        principalTable: "Hastalar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HastaSikayeti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HastaSikayet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HastaKabulId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HastaSikayeti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HastaSikayeti_HastaKabul_HastaKabulId",
                        column: x => x.HastaKabulId,
                        principalTable: "HastaKabul",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HastaGecmisi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GecirdigiHastaliklar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GecirdigiAmeliyatlar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HastaSikayetiId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HastaGecmisi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HastaGecmisi_HastaSikayeti_HastaSikayetiId",
                        column: x => x.HastaSikayetiId,
                        principalTable: "HastaSikayeti",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tahliller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TahlilAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TahlilSonucu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HastaGecmisiId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tahliller", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tahliller_HastaGecmisi_HastaGecmisiId",
                        column: x => x.HastaGecmisiId,
                        principalTable: "HastaGecmisi",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Recete",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlacAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TahlillerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recete", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recete_Tahliller_TahlillerId",
                        column: x => x.TahlillerId,
                        principalTable: "Tahliller",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ilaclar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fiyat = table.Column<int>(type: "int", nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: false),
                    ReceteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilaclar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ilaclar_Recete_ReceteId",
                        column: x => x.ReceteId,
                        principalTable: "Recete",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c25676d8-829e-41cb-8a7f-af3d177c8fca", "5282ce18-8d92-4464-864c-b0687afbe92e", "User", "USER" },
                    { "e17291ae-2332-4977-a6bf-e5d6b3bcf356", "b815f8ca-442b-4b81-8f8e-73d5ba2a2271", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SurName", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "36035f22-9c94-42bd-8282-8e2b019b2fd1", 0, "d8e84a25-0ff2-425c-8cc0-c6ed76b60d21", null, false, true, null, "Numan", null, "B191210307@SAKARYA.EDU.TR", "AQAAAAEAACcQAAAAEEHoQ0ViyBmp3yPvMsGBVSrLUiubppv3DnUDJHHp7RnyYwULnf9W5dEiACxRfQVcFA==", null, false, "ST4AAWGZ5UA2RSQGVBI6BHW5JO7JZQYW", "Güngör", false, "b191210307@sakarya.edu.tr" },
                    { "c342b369-ccd2-4648-b187-10c5c655bbb5", 0, "2b47a270-2410-42b1-ad1b-b564966cd6b0", null, false, true, null, "Muhammet", null, "B191210304@SAKARYA.EDU.TR", "AQAAAAEAACcQAAAAEEhgfwI70dzvoYp2RTjqqfw60wbI6kbGq9rQ/uiZPc6RRFwz9uUQmrBHcKjeuwpz4A==", null, false, "RNMOTMWYZL6PRE362MLDKMO2QTCRNLIB", "Sağlam", false, "b191210304@sakarya.edu.tr" }
                });

            migrationBuilder.InsertData(
                table: "Hastaneler",
                columns: new[] { "Id", "Ad" },
                values: new object[,]
                {
                    { 1, "Devlet Hastanesi" },
                    { 2, "Özel Aktıp Hastanesi" },
                    { 3, "Özel Medikar Hastanesi" },
                    { 4, "Atatürk Hastanesi" },
                    { 5, "Araştırma Hastanesi" }
                });

            migrationBuilder.InsertData(
                table: "KanGrubu",
                columns: new[] { "Id", "KanGrubuAd" },
                values: new object[,]
                {
                    { 1, "O Rh-" },
                    { 2, "O Rh+" },
                    { 3, "A Rh+ " },
                    { 4, "A Rh-" },
                    { 5, "B Rh-" },
                    { 6, "B Rh+" },
                    { 7, "AB Rh+" },
                    { 8, "AB Rh-" }
                });

            migrationBuilder.InsertData(
                table: "Unvanlar",
                columns: new[] { "Id", "UnvanAd" },
                values: new object[,]
                {
                    { 1, "Pratisyen Doktor" },
                    { 2, "Uzman Doktor" },
                    { 3, "Operatör Doktor" },
                    { 4, "Yardımcı Doçent" },
                    { 5, " Doçent" },
                    { 6, " Profesör" },
                    { 7, "Ordinaryus " }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { "e17291ae-2332-4977-a6bf-e5d6b3bcf356", "36035f22-9c94-42bd-8282-8e2b019b2fd1", "UserRol" },
                    { "e17291ae-2332-4977-a6bf-e5d6b3bcf356", "c342b369-ccd2-4648-b187-10c5c655bbb5", "UserRol" }
                });

            migrationBuilder.InsertData(
                table: "Hastalar",
                columns: new[] { "Id", "Ad", "Cinsiyet", "DogumTarihi", "DogumYeri", "KanGrubuId", "MedeniHali", "Meslek", "Soyad" },
                values: new object[,]
                {
                    { 1, "Aysu", 1, new DateTime(1981, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bartın", 2, 1, "Öğretmen", "Şirin" },
                    { 2, "Begüm", 1, new DateTime(1983, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yozgat", 3, 0, "Öğretmen", "Yavuz" },
                    { 3, "Arda", 0, new DateTime(1984, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kayseri", 1, 1, "Öğretmen", "Öz" },
                    { 4, "Mert", 0, new DateTime(1988, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Çorum", 5, 1, "Öğretmen", "Şirin" },
                    { 5, "Cihan", 1, new DateTime(1991, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tokat", 2, 1, "Öğretmen", "Yiğit" }
                });

            migrationBuilder.InsertData(
                table: "Poliniklik",
                columns: new[] { "Id", "HastanelerId", "PolinikAd" },
                values: new object[,]
                {
                    { 1, 1, "Dâhiliye Polikliniği" },
                    { 2, 1, "Gastroenteroloji Polikliniği" },
                    { 3, 2, "KBB Polikliniği" },
                    { 4, 3, "Psikiyatri Polikliniği" },
                    { 5, 4, "Ortopedi Polikliniği" }
                });

            migrationBuilder.InsertData(
                table: "Doktorlar",
                columns: new[] { "Id", "Ad", "Cinsiyet", "DogumTarihi", "DogumYeri", "PoliniklikId", "Soyad", "UnvanlarId" },
                values: new object[,]
                {
                    { 1, "Meryem", 1, new DateTime(1996, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Istanbul", 1, "Çetiner", 1 },
                    { 2, "Murat", 0, new DateTime(1995, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ankara", 3, "Gül", 4 },
                    { 3, "Şule", 1, new DateTime(1990, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Burdur", 2, "Piyaz", 5 },
                    { 4, "Yavuz", 0, new DateTime(1986, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sinop", 2, "Selim", 4 },
                    { 5, "Cenk", 0, new DateTime(1989, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsun", 4, "İnce", 5 }
                });

            migrationBuilder.InsertData(
                table: "HastaKabul",
                columns: new[] { "Id", "DoktorlarId", "GelisTarihi", "HastalarId" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 1, new DateTime(2020, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, 4, new DateTime(2020, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, 2, new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 5, 1, new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 }
                });

            migrationBuilder.InsertData(
                table: "HastaSikayeti",
                columns: new[] { "Id", "HastaKabulId", "HastaSikayet" },
                values: new object[,]
                {
                    { 1, 1, "Hemogram Yetmezliği" },
                    { 2, 2, "Alkalen Fosfataz Hastalığı" },
                    { 3, 3, "Kreatinin Klerensi" },
                    { 4, 4, "Asit Fosfataz" },
                    { 5, 5, "Prostat-Spesifik Antijen" }
                });

            migrationBuilder.InsertData(
                table: "HastaGecmisi",
                columns: new[] { "Id", "GecirdigiAmeliyatlar", "GecirdigiHastaliklar", "HastaSikayetiId", "Tarih" },
                values: new object[,]
                {
                    { 1, "Yok", "Yok", 1, new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Yok", "Yok", 2, new DateTime(2020, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Yok", "Yok", 3, new DateTime(2020, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Yok", "Yok", 4, new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Yok", "Yok", 5, new DateTime(2020, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Tahliller",
                columns: new[] { "Id", "HastaGecmisiId", "TahlilAd", "TahlilSonucu" },
                values: new object[,]
                {
                    { 1, 1, "Sedimantasyon", "Kanın çökme hızıdır. İltihabi durumlar, romatizmal hastalıklar, mikrobik durumlar, Kan hastalıklarında, bazı kanserlerde yüksek bulunur. Aşırı kan yapımında (polisitemi) düşük çıkar" },
                    { 2, 2, "Üre-Bun- Kreatinin", "Böbreklerin çalışmasını gösterir. Böbrek yetersizliğinde yüksek bulunur. Ürik asit: Protein yıkımının son ürünüdür.Gut hastalığında ve böbrek yetersizliğinde yüksek çıkar.Aşırı proteinle beslenenlerde ve doku yıkımı olan durumlarda(kan hastalıklarında) da yüksek çıkabilir." },
                    { 3, 3, "AST-ALT", "Karaciğer fonksiyonlarını gösterir. AST ayrıca kalp, kas hastalıklarında ve alkol alanlarda da yüksek bulunabilir" },
                    { 4, 4, "Glukoz", "Kan şekerini gösterir" },
                    { 5, 5, "GGT-ALP", "Karaciğer ve safra yolları hastalıklarında yüksek çıkar. ALP aynı zamanda kemik hastalıklarını da gösterebilir. Çocuklarda ve gebelerde fizyolojik olarak yüksek bulunabilir." }
                });

            migrationBuilder.InsertData(
                table: "Recete",
                columns: new[] { "Id", "IlacAd", "TahlillerId" },
                values: new object[,]
                {
                    { 1, "AFINITOR 10 mg tablet", 1 },
                    { 2, "ALOMIDE %0.1 Steril Göz Damlası", 2 },
                    { 3, "Arzerra 100 mg IV infüzyonluk çözelti konsantresi içeren flakon", 3 },
                    { 4, "AZARGA", 4 },
                    { 5, "BETOPTIC %0.5 Steril Oftalmik Çözelti", 5 }
                });

            migrationBuilder.InsertData(
                table: "Ilaclar",
                columns: new[] { "Id", "Adet", "Fiyat", "ReceteId" },
                values: new object[,]
                {
                    { 1, 2, 10, 1 },
                    { 2, 3, 20, 2 },
                    { 3, 1, 30, 3 },
                    { 4, 2, 50, 4 },
                    { 5, 1, 165, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Doktorlar_PoliniklikId",
                table: "Doktorlar",
                column: "PoliniklikId");

            migrationBuilder.CreateIndex(
                name: "IX_Doktorlar_UnvanlarId",
                table: "Doktorlar",
                column: "UnvanlarId");

            migrationBuilder.CreateIndex(
                name: "IX_HastaGecmisi_HastaSikayetiId",
                table: "HastaGecmisi",
                column: "HastaSikayetiId");

            migrationBuilder.CreateIndex(
                name: "IX_HastaKabul_DoktorlarId",
                table: "HastaKabul",
                column: "DoktorlarId");

            migrationBuilder.CreateIndex(
                name: "IX_HastaKabul_HastalarId",
                table: "HastaKabul",
                column: "HastalarId");

            migrationBuilder.CreateIndex(
                name: "IX_Hastalar_KanGrubuId",
                table: "Hastalar",
                column: "KanGrubuId");

            migrationBuilder.CreateIndex(
                name: "IX_HastaSikayeti_HastaKabulId",
                table: "HastaSikayeti",
                column: "HastaKabulId");

            migrationBuilder.CreateIndex(
                name: "IX_Ilaclar_ReceteId",
                table: "Ilaclar",
                column: "ReceteId");

            migrationBuilder.CreateIndex(
                name: "IX_Poliniklik_HastanelerId",
                table: "Poliniklik",
                column: "HastanelerId");

            migrationBuilder.CreateIndex(
                name: "IX_Recete_TahlillerId",
                table: "Recete",
                column: "TahlillerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tahliller_HastaGecmisiId",
                table: "Tahliller",
                column: "HastaGecmisiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Ilaclar");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Recete");

            migrationBuilder.DropTable(
                name: "Tahliller");

            migrationBuilder.DropTable(
                name: "HastaGecmisi");

            migrationBuilder.DropTable(
                name: "HastaSikayeti");

            migrationBuilder.DropTable(
                name: "HastaKabul");

            migrationBuilder.DropTable(
                name: "Doktorlar");

            migrationBuilder.DropTable(
                name: "Hastalar");

            migrationBuilder.DropTable(
                name: "Poliniklik");

            migrationBuilder.DropTable(
                name: "Unvanlar");

            migrationBuilder.DropTable(
                name: "KanGrubu");

            migrationBuilder.DropTable(
                name: "Hastaneler");
        }
    }
}
