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

            modelBuilder.Entity<Order>().Property(e => e.MaterialPrice).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.EdgePrice).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.TotalPrice).HasPrecision(18, 2);

            modelBuilder.Entity<Order>().Property(e => e.Material1Price).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material1Length).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material1Height).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material1Qty).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material1Quadrature).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material1TotalPrice).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material1EdgeH1).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material1EdgeH2).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material1EdgeL1).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material1EdgeL2).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material1EdgeTotalPrice).HasPrecision(18, 2);

            modelBuilder.Entity<Order>().Property(e => e.Material2Price).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material2Length).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material2Height).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material2Qty).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material2Quadrature).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material2TotalPrice).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material2EdgeH1).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material2EdgeH2).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material2EdgeL1).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material2EdgeL2).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material2EdgeTotalPrice).HasPrecision(18, 2);

            modelBuilder.Entity<Order>().Property(e => e.Material3Price).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material3Length).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material3Height).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material3Qty).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material3Quadrature).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material3TotalPrice).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material3EdgeH1).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material3EdgeH2).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material3EdgeL1).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material3EdgeL2).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material3EdgeTotalPrice).HasPrecision(18, 2);

            modelBuilder.Entity<Order>().Property(e => e.Material4Price).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material4Length).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material4Height).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material4Qty).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material4Quadrature).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material4TotalPrice).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material4EdgeH1).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material4EdgeH2).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material4EdgeL1).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material4EdgeL2).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material4EdgeTotalPrice).HasPrecision(18, 2);

            modelBuilder.Entity<Order>().Property(e => e.Material5Price).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material5Length).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material5Height).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material5Qty).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material5Quadrature).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material5TotalPrice).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material5EdgeH1).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material5EdgeH2).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material5EdgeL1).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material5EdgeL2).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material5EdgeTotalPrice).HasPrecision(18, 2);

            modelBuilder.Entity<Order>().Property(e => e.Material6Price).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material6Length).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material6Height).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material6Qty).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material6Quadrature).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material6TotalPrice).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material6EdgeH1).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material6EdgeH2).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material6EdgeL1).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material6EdgeL2).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material6EdgeTotalPrice).HasPrecision(18, 2);

            modelBuilder.Entity<Order>().Property(e => e.Material7Price).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material7Length).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material7Height).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material7Qty).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material7Quadrature).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material7TotalPrice).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material7EdgeH1).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material7EdgeH2).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material7EdgeL1).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material7EdgeL2).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material7EdgeTotalPrice).HasPrecision(18, 2);

            modelBuilder.Entity<Order>().Property(e => e.Material8Price).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material8Length).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material8Height).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material8Qty).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material8Quadrature).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material8TotalPrice).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material8EdgeH1).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material8EdgeH2).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material8EdgeL1).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material8EdgeL2).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material8EdgeTotalPrice).HasPrecision(18, 2);

            modelBuilder.Entity<Order>().Property(e => e.Material9Price).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material9Length).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material9Height).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material9Qty).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material9Quadrature).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material9TotalPrice).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material9EdgeH1).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material9EdgeH2).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material9EdgeL1).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material9EdgeL2).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material9EdgeTotalPrice).HasPrecision(18, 2);

            modelBuilder.Entity<Order>().Property(e => e.Material10Price).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material10Length).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material10Height).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material10Qty).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material10Quadrature).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material10TotalPrice).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material10EdgeH1).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material10EdgeH2).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material10EdgeL1).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material10EdgeL2).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material10EdgeTotalPrice).HasPrecision(18, 2);

            modelBuilder.Entity<Order>().Property(e => e.Material11Price).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material11Length).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material11Height).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material11Qty).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material11Quadrature).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material11TotalPrice).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material11EdgeH1).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material11EdgeH2).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material11EdgeL1).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material11EdgeL2).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material11EdgeTotalPrice).HasPrecision(18, 2);

            modelBuilder.Entity<Order>().Property(e => e.Material12Price).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material12Length).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material12Height).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material12Qty).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material12Quadrature).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material12TotalPrice).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material12EdgeH1).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material12EdgeH2).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material12EdgeL1).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material12EdgeL2).HasPrecision(18, 2);
            modelBuilder.Entity<Order>().Property(e => e.Material12EdgeTotalPrice).HasPrecision(18, 2);

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
    }
}