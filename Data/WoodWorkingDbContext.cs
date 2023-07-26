using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;
using WoodWorking.Data.Models;

namespace WoodWorking.Data
{
    public class WoodWorkingDbContext : IdentityDbContext
    {
        public WoodWorkingDbContext(DbContextOptions<WoodWorkingDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserOrder>().HasKey(x => new { x.UserId, x.OrderId });
            modelBuilder.Entity<Material>().Property(p => p.Price).HasPrecision(18, 2);

            modelBuilder.Entity<IdentityUserEdge>().HasKey(x => new { x.UserId, x.EdgeId });
            modelBuilder.Entity<Edge>().Property(e => e.Price).HasPrecision(18, 2);
            modelBuilder.Entity<Edge>().Property(e => e.Height).HasPrecision(18, 2);
            modelBuilder.Entity<Edge>().Property(e => e.Length).HasPrecision(18, 2);

            modelBuilder.Entity<IdentityUserContact>().HasKey(x => new { x.UserId, x.ContactId });

            modelBuilder.Entity<Order>().Property(e => e.MaterialPrice).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.EdgePrice).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.TotalPrice).HasPrecision(18, 2);

            modelBuilder.Entity<OrderedMaterial>().Property(e => e.MaterialPrice).HasPrecision(18, 2);
            modelBuilder.Entity<OrderedMaterial>().Property(e => e.MaterialLength).HasPrecision(18, 2);
            modelBuilder.Entity<OrderedMaterial>().Property(e => e.MaterialHeight).HasPrecision(18, 2);
            modelBuilder.Entity<OrderedMaterial>().Property(e => e.MaterialQty).HasPrecision(18, 2);
            modelBuilder.Entity<OrderedMaterial>().Property(e => e.MaterialQuadrature).HasPrecision(18, 2);
            modelBuilder.Entity<OrderedMaterial>().Property(e => e.MaterialTotalPrice).HasPrecision(18, 2);
            modelBuilder.Entity<OrderedMaterial>().Property(e => e.MaterialEdgeH1).HasPrecision(18, 2);
            modelBuilder.Entity<OrderedMaterial>().Property(e => e.MaterialEdgeH2).HasPrecision(18, 2);
            modelBuilder.Entity<OrderedMaterial>().Property(e => e.MaterialEdgeL1).HasPrecision(18, 2);
            modelBuilder.Entity<OrderedMaterial>().Property(e => e.MaterialEdgeL2).HasPrecision(18, 2);
            modelBuilder.Entity<OrderedMaterial>().Property(e => e.MaterialEdgeTotalPrice).HasPrecision(18, 2);

            modelBuilder
                .Entity<Contact>()
                .HasData(new Contact()
                {
                    Id = 1,
                    Name = "София Младост",
                    Address = "София бул. „Цариградско шосе”",
                    Phone = "02/9602059",
                    ImageUrl = "https://mr-bricolage.bg/medias/mladost-storefront.png?context=bWFzdGVyfG1sYWRvc3R8MTQ5NzE0fGltYWdlL3BuZ3xoNGEvaGQ1LzkxMzUxODIwODYxNzQvbWxhZG9zdC1zdG9yZWZyb250LnBuZ3xlODQxNjU1OTRmNGEyMWM0ZDEzNzZlOTY4ODQ0Mzc3MmE0ZDc2ZWY4MDhlYTJiNmUzOGYwOTFiNjY0NjQwMjIy"
                },
                new Contact()
                {
                    Id = 2,
                    Name = "София Ринг Мол",
                    Address = "София бул. „Околовръстно шосе”",
                    Phone = "02/4053600",
                    ImageUrl = "https://mr-bricolage.bg/medias/ringmall-storefront.png?context=bWFzdGVyfCByaW5nLW1hbGx8MzUwNTU2fGltYWdlL3BuZ3xoYTEvaGQ1LzkxMzUxODIwNTM0MDYvcmluZ21hbGwtc3RvcmVmcm9udC5wbmd8NjIwZDVjMDFlOTAwM2YzZjAyMzcyYzU2MWEyYWIwYWY2MmRhNzcwZWY3NWY3ZGVlNTZjOTU5MTNlY2E1NjczOQ"
                },
                new Contact()
                {
                    Id = 3,
                    Name = "София Люлин",
                    Address = "София бул. „Европа”",
                    Phone = "02/9216300",
                    ImageUrl = "https://mr-bricolage.bg/medias/lulin-front.PNG?context=bWFzdGVyfGx1bGlufDEyNjkzfGltYWdlL3BuZ3xsdWxpbi9oNTkvaDVhLzg4MTQwNDE2OTQyMzgucG5nfDUxZTBlNmE1Y2E0ZTc5MmI3YWQyNWE5ZGZlZjc2ZTFkN2FlOGE2ODkwNGQzOTIyNjIyOGZiNTExODY2M2ViNjU"
                },
                new Contact()
                {
                    Id = 4,
                    Name = "Перник",
                    Address = "Перник ул. „Юрий Гагарин”",
                    Phone = "0884 43 15 94",
                    ImageUrl = "https://mr-bricolage.bg/medias/pernik-osnovna.jpg?context=bWFzdGVyfHBlcm5pa3w0MDAwNHxpbWFnZS9qcGVnfGg1ZS9oMGYvOTE2MDgwNTcxMTkwMi9wZXJuaWstb3Nub3ZuYS5qcGd8ZmFhNDAyOThkZmM4MzdmYjY3MDA2MGZiNDIwMWE2ZDc0Yzk3NDJjYWFiMWY5NTk0MWM1ZTJiODIxZjY4NmZjNQ"
                },
                new Contact()
                {
                    Id = 5,
                    Name = "Благоевград",
                    Address = "Благоевград жк. „Струмско”, ул. „Яне Сандански”",
                    Phone = "073/829500",
                    ImageUrl = "https://mr-bricolage.bg/medias/blagoevgrad-front.PNG?context=bWFzdGVyfGJsYWdvZXZncmFkfDEwNjUwfGltYWdlL3BuZ3xibGFnb2V2Z3JhZC9oYWMvaDFiLzg4MTQwNDI2MTE3NDIucG5nfGJjOTcxNjgzMGNlNzIxYTBhZmViYzgzNWUyMGMyNDYzNWY3NDY0OTQxZWU5YTU1OTVlNmZlMGY1NmQ5NzAxYTY"
                },
                new Contact()
                {
                    Id = 6,
                    Name = "Пловдив 2",
                    Address = "Пловдив ул. „Македония”",
                    Phone = "032/307779",
                    ImageUrl = "https://mr-bricolage.bg/medias/banner1-980x460.jpg?context=bWFzdGVyfHBsb3ZkaXYtMnw1OTA5ODN8aW1hZ2UvanBlZ3xwbG92ZGl2LTIvaGVhL2gxMy84ODEzOTgyNjEzNTM0LmpwZ3w1MzQ4MTkyMGQyZTIwOGI3MmFmZjYxMDI2ZDhhYmI2OGRmZTdlYTZjNWI3MTkzZWUzNzg5YTI4YzU3NmI1NTc5"
                },
                new Contact()
                {
                    Id = 7,
                    Name = "Пловдив 1",
                    Address = "Пловдив бул. „6 септември”",
                    Phone = "032/605259",
                    ImageUrl = "https://mr-bricolage.bg/medias/Plovdiv-20-03-facade-2.jpg?context=bWFzdGVyfHBsb3ZkaXYtMXwyMjEzMjF8aW1hZ2UvanBlZ3xwbG92ZGl2LTEvaDNhL2g0Ny84OTQ1NDYxMTY2MTEwLmpwZ3w3ZjFiY2VjNDBlZmRmMTE2ZGRlYWJlYWEyZWMxZGE1NjdmYTg2ZjFiZWNhN2Q0ZDVlZDIyMjg5MmUxYWFkOGJi"
                },
                new Contact()
                {
                    Id = 8,
                    Name = "Плевен",
                    Address = "Плевен ул. „Асен Халачев",
                    Phone = "064/884900",
                    ImageUrl = "https://mr-bricolage.bg/medias/pleven-front.PNG?context=bWFzdGVyfHBsZXZlbnwyMTcxODJ8aW1hZ2UvcG5nfHBsZXZlbi9oNzQvaGE3Lzg4MTQwNDM5ODc5OTgucG5nfGNlNDU2MzNiMTE0YTU3MTQxOGJhNmExY2VjYjRmZGE4OGM0ZTIxNWEyZWM5NmQ1ZjY2MDM2NDAxZWM0Y2JkOGE"
                },
                new Contact()
                {
                    Id = 9,
                    Name = "Русе",
                    Address = "Русе бул. „Липник”",
                    Phone = "082/887810",
                    ImageUrl = "https://mr-bricolage.bg/medias/ruse-storefront.png?context=bWFzdGVyfHJ1c2V8NjYyMDJ8aW1hZ2UvcG5nfGhmOC9oZDUvOTEzNTE4MjAyMDYzOC9ydXNlLXN0b3JlZnJvbnQucG5nfGMxODBlY2E2ZDMxOGU2OGRkNTljZThiM2Q4OTI4YTRmYmM2MjYzZTgzZGZiZTNkMDJlZWVlYTBhYTcxMzNlMjU"
                },
                new Contact()
                {
                    Id = 10,
                    Name = "Бургас",
                    Address = "Бургас бул. „Захари Стоянов”",
                    Phone = "056/874760",
                    ImageUrl = "https://mr-bricolage.bg/medias/burgas-front.PNG?context=bWFzdGVyfGJ1cmdhc3w2NDE3OTZ8aW1hZ2UvcG5nfGJ1cmdhcy9oMDcvaDdiLzg4MTQwNDUwMzY1NzQucG5nfGExM2E3ZmM0NDc0MWQ3MmNkYTRmY2VhNmQ4MDkzNDFjMjYwYmUzZmU5ZDUxNGM2YmY1MTNhOWJjMzI5Y2M4YTI"
                },
                new Contact()
                {
                    Id = 11,
                    Name = "Варна",
                    Address = "Варна жк. Младост, ул. „Вяра”",
                    Phone = "052/572559",
                    ImageUrl = "https://mr-bricolage.bg/medias/varna-front.PNG?context=bWFzdGVyfHZhcm5hfDE0NzYxNTF8aW1hZ2UvcG5nfHZhcm5hL2hhNi9oZTQvODgxNDA0NTU2MDg2Mi5wbmd8NjYwOWI4OGNhODBjODlmZGYzNjlkNjM1MDI3NTEyZmM4ZjNmOTI5MTVjODRlZWRiYjU4YjcwN2QzNzFlODhiMQ"
                },
                new Contact()
                {
                    Id = 12,
                    Name = "Добрич",
                    Address = "Добрич Околовръстен път „Добротица”, изхода за Албена",
                    Phone = "058/651680",
                    ImageUrl = "https://mr-bricolage.bg/medias/dobrich-front.PNG?context=bWFzdGVyfGRvYnJpY2h8Nzc1NTEzfGltYWdlL3BuZ3xkb2JyaWNoL2hjYS9oMDQvODgxNDA0NjA4NTE1MC5wbmd8OWZjMjZmM2RjZTVhNTNlNmFjZWIzNjNjOTZlYzA3YmUyZTIxODBhY2I2NjljMWY0NzM2OWY2ZWE3MmY0OTExYw"
                }
                );

            modelBuilder
                .Entity<Material>()
                .HasData(new Material()
                {
                    Id = 1,
                    Name = "сурови ПДЧ - 5,80м2/пл.",
                    ANPF = "984754",
                    Price = 25.99m,
                    ImageUrl = "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDEyMzM0fGltYWdlL2pwZWd8cHJvZHVjdHMvaGI5L2g3YS84ODU3NTE4ODMzNjk0LmpwZ3w2ZGIwZmFhMzRjM2UwZDEzOThiYWY1NDk0ZTM1YWJiZWUyYzM0MWNhYzM2N2Y2ODZjMzQwMTY1ZDg3N2FiNzc1"
                },
                new Material()
                {
                    Id = 2,
                    Name = "Натур.HDF - 5,80м2/пл.",
                    ANPF = "984757",
                    Price = 11.49m,
                    ImageUrl = "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDEwNTkxfGltYWdlL2pwZWd8cHJvZHVjdHMvaGEwL2g3YS84ODU3NTE5MjkyNDQ2LmpwZ3xlODQ5NjA3NTY2OTVkODczMzNkMGZlYmEzNjI2OWY1M2EwMjg0MDEzM2I0MmYxN2E0ZDFhZTY5OTNkNjVlYWNk"
                },
                new Material()
                {
                    Id = 3,
                    Name = "0101 PE БЯЛ - 5,80m2/плоча",
                    ANPF = "984763",
                    Price = 12.59m,
                    ImageUrl = "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDE2OTF8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oM2EvaGIyLzg5OTAxOTYwMDY5NDIuanBnfGE1MjBjM2M1ZmYxM2VkN2Y5YWRiMDUxZWQ1YjFiZjAwZDhiNjU3MjY2NjNhYTc5ZWJlNmE5OTRkZGMyODM1NTA"
                },
                new Material()
                {
                    Id = 4,
                    Name = "0381 PE БУК - 5,80m2/плоча",
                    ANPF = "984764",
                    Price = 12.59m,
                    ImageUrl = "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDQ4NjV8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oNDUvaDcwLzg4NTc5Mzk3NzE0MjIuanBnfGYxMjZhNjhmODJkZjZlYmE0YmE4ZjY0YzdhYzVmNDM3OGIyNjU2MTg1ZDk5YmJhY2VkOTNkZjExMGNmNTJiZGQ"
                },
                new Material()
                {
                    Id = 5,
                    Name = "0344 PE ТЪМНА ЧЕРЕША - 5,80m2/плоча",
                    ANPF = "984765",
                    Price = 12.59m,
                    ImageUrl = "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDU3MjZ8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oZDAvaGUyLzg5OTAyMDkwODEzNzQuanBnfDM0OWNjODQzZDZmYjVlMDQyYTBhZDI5Njg5ZTYxMmUxODMyMzU2MzJhZDdmMmM1Nzk0MzdhNjk0OGIyZjFiMzc"
                },
                new Material()
                {
                    Id = 6,
                    Name = "0854 PE ВЕНГЕ - 5,80m2/плоча",
                    ANPF = "984767",
                    Price = 12.59m,
                    ImageUrl = "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDQyMTZ8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oZDEvaDk4Lzg4NTc1MjAyMDk5NTAuanBnfDBhZTU0NDRjOGU3MjcyMTMwYmYwYjBjNDJiNTI0NDFlNjljNzQzM2M1OGI3MDU5NTJiYWMwNTBhYWQ2YTJjMWU"
                },
                new Material()
                {
                    Id = 7,
                    Name = "0110 SM БЯЛО - 5,80м2/плоча",
                    ANPF = "1008418",
                    Price = 25.99m,
                    ImageUrl = "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDE2MTV8aW1hZ2UvanBlZ3xoNjUvaGEyLzkxNzA1NjU4OTAwNzh8YWUyZDhlMzE0NzQxNWQ2NmE1NDg4MjA0NWJjOWUwNDZiZmYyZjAwZTVhZDg0ZmMxYTY1ZWI4NjhhZDkyM2NjOA"
                },
                new Material()
                {
                    Id = 8,
                    Name = "0381 PR БУК - 5,80м2/плоча",
                    ANPF = "984770",
                    Price = 30.99m,
                    ImageUrl = "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDQ2Njh8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oYjIvaDJhLzg4NTc1MjE1ODYyMDYuanBnfGZkZWNhMGQ4MTFmZWIyMDdkYjdkOTQzZjM3M2U0ZmQ2NThhYjA5MzdlZjVlZjUyNjg2NmU4NzMwMjU3YTE5Yzg"
                },
                new Material()
                {
                    Id = 9,
                    Name = "0854 BS ВЕНГЕ - 5,80м2/плоча",
                    ANPF = "984771",
                    Price = 30.99m,
                    ImageUrl = "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDg3NTh8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oZDUvaDdkLzg4NTc1MjIwNDQ5NTguanBnfDM0MjgyYzk2MTkwOWU5YmU0Yzg4ZDkzNjMwOTI5NjU0YjRmNjg2N2Y5MzBiYTExYmRjYzk2ZjUxOWY0ZWY3NzM"
                },
                new Material()
                {
                    Id = 10,
                    Name = "0190 PE ЧЕРНО -5,80м2/плоча",
                    ANPF = "984773",
                    Price = 30.99m,
                    ImageUrl = "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDIyMDR8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oNTMvaDRiLzg4NTc1MjI1MDM3MTAuanBnfDNhMWJkMjlkZmRjZmY4MWQ0ZTI4NTRkY2FhY2M4YjgxMDY1ODY5N2ZjMDc4YjlkYTBjZjdiMWMzMTAyYmI5NTc"
                },
                new Material()
                {
                    Id = 11,
                    Name = "0514 PE СЛОНОВА КОСТ - 5,80м2/плоча",
                    ANPF = "984775",
                    Price = 30.99m,
                    ImageUrl = "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDIxNjh8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oNGUvaDRlLzg4NTc1MjI5NjI0NjIuanBnfDUzYWEyZWE5M2IxODVhMTk0YTk5NGVkY2Y1YTNlODg2MDMxZDY0NjMzMTQ3ZWQ3NzM1OWY2NTFmNzE0Mjk4ZDM"
                },
                new Material()
                {
                    Id = 12,
                    Name = "3025 SU ДЪБ СОНОМА - 5,80м2/плоча",
                    ANPF = "984776",
                    Price = 30.99m,
                    ImageUrl = "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDk2MTd8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oMWQvaDY5Lzg4NTc1MjM0MjEyMTQuanBnfGJmYzk1NTkwMTM5OWM3MmZiMjk5OGFlNWNmNTI0ODMyYzAxZWU4YzU4YTQyNDk2YWRlY2NkMWM5OWMwMWU3NjY"
                },
                new Material()
                {
                    Id = 13,
                    Name = "0112 PЕ СИВО - 5,80м2/плоча",
                    ANPF = "984780",
                    Price = 32.99m,
                    ImageUrl = "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDIwNzF8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oY2QvaDc3Lzg4NTc1MjM4Nzk5NjYuanBnfDM0NjUyZDAyNjBmMjdlOGI2MGNmOGM0NWVkNzFiYjMzNWQxZGY3YmJjMWE5MTQ0ZWQ4MGZkMDg2MzVlMWE0ZDE"
                },
                new Material()
                {
                    Id = 14,
                    Name = "K001 PW БЯЛ ДЪБ - 5,80м2/плоча",
                    ANPF = "984787",
                    Price = 32.99m,
                    ImageUrl = "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDY3MDN8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oMTgvaDViLzg4NTc1MjUyNTYyMjIuanBnfDg3ZWUwNWNmNzUyOGZiOTI5YTc4MjEyOGI0NjIzYjk0YjM1OTc3ZDQxYTQ5YzAwYjUwOTMwNWJjMmY5NGE4NTg"
                },
                new Material()
                {
                    Id = 15,
                    Name = "ПДЧ ДЪБ ЕВОУК КОУСТ 18X2800X2070",
                    ANPF = "1008468",
                    Price = 39.99m,
                    ImageUrl = "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDEwNzE1fGltYWdlL2pwZWd8cHJvZHVjdHMvaDIzL2gwZi84OTg4NDUwODgxNTY2LmpwZ3w1YjU5ZDMzMWRjMDM1OGFjYTY1MGIyZjMwNzY4Mzk5NWExODM5YjE4ZjU0YzgyM2UxMTNjYWViZjIzNzFlZWJm"
                },
                new Material()
                {
                    Id = 16,
                    Name = "ПДЧ КОНЯК КАСТЕЛО 18X2800X2070",
                    ANPF = "1008469",
                    Price = 31.99m,
                    ImageUrl = "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDg2MTJ8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oNmUvaDdlLzg5ODg0NDkwNDY1NTguanBnfDBmNGI1YzE5ZTZlYzQxMTMxMGI4N2FlYTE3MzRiZTA0MjkzMjU3NzIxOGU5MjkyNzFhYzZiMWFlMmE2NTkxOGM"
                },
                new Material()
                {
                    Id = 17,
                    Name = "ПДЧ ДЪБЪРБАН ОЙСТЪР ЛАМИНИРАНО",
                    ANPF = "992002",
                    Price = 33.99m,
                    ImageUrl = "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDEyMjExfGltYWdlL2pwZWd8cHJvZHVjdHMvaDQyL2hmOC84OTkwMjA5OTk4ODc4LmpwZ3w5ZGY4NzkzMTdmMzg0ZDFmZWU0YWYxYzc4NjVmMjE1YjM5ZjMwZDdjYzQ1YTdlZjY1Y2E3MDEzNDQ4ODEzODM5"
                },
                new Material()
                {
                    Id = 18,
                    Name = "MDF НАТУРАЛЕН 18ММ",
                    ANPF = "985511",
                    Price = 39.99m,
                    ImageUrl = "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDEwMzQxfGltYWdlL2pwZWd8cHJvZHVjdHMvaDY5L2hjNS84ODU3NTI4MDA4NzM0LmpwZ3xmZjBkZDQ4YmYzOWNhMGFhMzBkMDg0OGViYWQ5YmUzMTMzZWFiN2U5MGIyMWQ2N2M0NmFiNTIzYzU1YzE2ODE3"
                },
                new Material()
                {
                    Id = 19,
                    Name = "ПДЧ ОРЕХ ЛАМИНИРАНО 2800/2070/18ММ",
                    ANPF = "991128",
                    Price = 33.99m,
                    ImageUrl = "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDc5MjR8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oMzQvaDNjLzg5OTAxOTUwODk0MzguanBnfGY0OTQ5MWQ3MGM5Y2I3NTc4ZGU3OTczZWZmNTE3NGE5YjQ4MWVjYjcwMDZkZmI3NGFhNzlkNzNhNGJlOGRkMjY"
                },
                new Material()
                {
                    Id = 20,
                    Name = "ПДЧ СВЕТЛО ХИКОРИ ЛАМИНИРАНО18X2800X2070",
                    ANPF = "1008461",
                    Price = 39.99m,
                    ImageUrl = "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDgwODl8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oMWIvaDViLzg5ODg2MDQzMDEzNDIuanBnfGFhYzY0MzI4ODNhZjQ0MDJjY2IyOWM4MGMxNDJkYTFjMzBlM2ViYzQzNjQzN2IyZDljMzZiOGU0YWY3ZjQ5OTM"
                },
                new Material()
                {
                    Id = 21,
                    Name = "ПДЧ БРЕЗА ЛАМИНИРАНО 18X2800X2070",
                    ANPF = "1008465",
                    Price = 33.99m,
                    ImageUrl = "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDQxNDR8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oZmYvaGJhLzg5ODg2MzUyNjcxMDIuanBnfGQxMWM1YzBmNzg4NmI4OGI4ZGUyMzA5ZjM4YTY5MjNiOGI2MWQzZTRlYzIzZDY3N2RiYjI1ZTM2NjdmNmE3OGY"
                },
                new Material()
                {
                    Id = 22,
                    Name = "ПДЧ ДЪБ АМБЪР ЪРБЪН 18X2800X2070",
                    ANPF = "1008466",
                    Price = 35.99m,
                    ImageUrl = "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDExNTI0fGltYWdlL2pwZWd8cHJvZHVjdHMvaGJhL2g5OC84OTg4NjMxODI2NDYyLmpwZ3wwMjZlYmNlYjk0NzRmMTI0MzcyM2JiZTM1ZGE5Y2I0ZjMyYjkzMGZlMGYwZjdiMzJiOTVhZjA1NjM3ZmUyZGQ5"
                },
                new Material()
                {
                    Id = 23,
                    Name = "ПДЧ ЗЛАТЕН ДЪБ КРАФТ 18X2800X2070",
                    ANPF = "1008467",
                    Price = 35.99m,
                    ImageUrl = "https://mr-bricolage.bg/medias/?context=bWFzdGVyfHByb2R1Y3RzfDg4NjF8aW1hZ2UvanBlZ3xwcm9kdWN0cy9oMmMvaDM3Lzg5ODg2MjM1Njg5MjYuanBnfGExNTFmODdhMjllN2NjZDRiNzkxZDU3ZWY1MmY0NmY2MGIxMWQ2MzU0OTQ4N2E2M2RjNzZmZmE5OTlmODY4ZTU"
                }
            );

               modelBuilder
                .Entity<Edge>()
                .HasData(new Edge()
                {
                    Id = 1,
                    Height = 0.45m,
                    Length = 0.45m,
                    Price = 1.39m
                },
                new Edge()
                {
                    Id = 2,
                    Height = 0.8m,
                    Length = 0.8m,
                    Price = 3.19m
                },
                new Edge()
                {
                    Id = 3,
                    Height = 2m,
                    Length = 2m,
                    Price = 2.79m
                },
                new Edge()
                {
                    Id = 4,
                    Height = 3m,
                    Length = 3m,
                    Price = 4.99m
                }
            );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Material> Materials { get; set; }

        public DbSet<IdentityUserOrder> IdentityUserOrders { get; set; }

        public DbSet<Edge> Edges { get; set; }

        public DbSet<IdentityUserEdge> IdentityUserEdges { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderedMaterial> OrderedMaterials { get; set; }

        public DbSet<IdentityUserContact> IdentityUserContacts { get; set; }

        public DbSet<Contact> Contacts { get; set; }
    }
}