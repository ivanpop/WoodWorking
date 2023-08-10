using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using WoodWorking.Contracts;
using WoodWorking.Data;
using WoodWorking.Models;
using WoodWorking.Service;

namespace WoodWorking.Services.Tests
{
    //11.61%
    public class MaterialTest
    {
        private DbContextOptions<WoodWorkingDbContext> dbOptions;
        private WoodWorkingDbContext dbContext;
        private IMaterialService materialService;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            dbOptions = new DbContextOptionsBuilder<WoodWorkingDbContext>()
                .UseInMemoryDatabase("WoodWorkingInMemoryDb" + DateTime.Now.Ticks.ToString())
                .Options;

            dbContext = new WoodWorkingDbContext(dbOptions);

            DatabaseSeeder.SeedDatabase(dbContext);

            this.materialService = new MaterialService(dbContext);
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetAllMaterialsTest()
        {
            var materialsFromService = materialService.GetAllMaterialsAsync();

            var materialsFromDb = dbContext.Materials
                .Select(m => new AllMaterialsViewModel
                {
                    Id = m.Id,
                    Name = m.Name,
                    ANPF = m.ANPF,
                    Price = m.Price,
                    ImageUrl = m.ImageUrl
                }).ToList();

            Assert.That(materialsFromService.Result.Count(), Is.EqualTo(materialsFromDb.Count));

            Assert.That(materialsFromService.Result.First().Name, Is.EqualTo(materialsFromDb.First().Name));
            Assert.That(materialsFromService.Result.First().ANPF, Is.EqualTo(materialsFromDb.First().ANPF));
            Assert.That(materialsFromService.Result.First().Price, Is.EqualTo(materialsFromDb.First().Price));
            Assert.That(materialsFromService.Result.First().ImageUrl, Is.EqualTo(materialsFromDb.First().ImageUrl));
            Assert.That(materialsFromService.Result.First().Id, Is.EqualTo(materialsFromDb.First().Id));

            Assert.That(materialsFromService.Result.Skip(1).First().Name, Is.EqualTo(materialsFromDb.Skip(1).First().Name));
            Assert.That(materialsFromService.Result.Skip(1).First().ANPF, Is.EqualTo(materialsFromDb.Skip(1).First().ANPF));
            Assert.That(materialsFromService.Result.Skip(1).First().Price, Is.EqualTo(materialsFromDb.Skip(1).First().Price));
            Assert.That(materialsFromService.Result.Skip(1).First().ImageUrl, Is.EqualTo(materialsFromDb.Skip(1).First().ImageUrl));
            Assert.That(materialsFromService.Result.Skip(1).First().Id, Is.EqualTo(materialsFromDb.Skip(1).First().Id));

            Assert.That(materialsFromService.Result.Skip(2).First().Name, Is.EqualTo(materialsFromDb.Skip(2).First().Name));
            Assert.That(materialsFromService.Result.Skip(2).First().ANPF, Is.EqualTo(materialsFromDb.Skip(2).First().ANPF));
            Assert.That(materialsFromService.Result.Skip(2).First().Price, Is.EqualTo(materialsFromDb.Skip(2).First().Price));
            Assert.That(materialsFromService.Result.Skip(2).First().ImageUrl, Is.EqualTo(materialsFromDb.Skip(2).First().ImageUrl));
            Assert.That(materialsFromService.Result.Skip(2).First().Id, Is.EqualTo(materialsFromDb.Skip(2).First().Id));

            Assert.That(materialsFromService.Result.Skip(3).First().Name, Is.EqualTo(materialsFromDb.Skip(3).First().Name));
            Assert.That(materialsFromService.Result.Skip(3).First().ANPF, Is.EqualTo(materialsFromDb.Skip(3).First().ANPF));
            Assert.That(materialsFromService.Result.Skip(3).First().Price, Is.EqualTo(materialsFromDb.Skip(3).First().Price));
            Assert.That(materialsFromService.Result.Skip(3).First().ImageUrl, Is.EqualTo(materialsFromDb.Skip(3).First().ImageUrl));
            Assert.That(materialsFromService.Result.Skip(3).First().Id, Is.EqualTo(materialsFromDb.Skip(3).First().Id));

            Assert.That(materialsFromService.Result.Skip(4).First().Name, Is.EqualTo(materialsFromDb.Skip(4).First().Name));
            Assert.That(materialsFromService.Result.Skip(4).First().ANPF, Is.EqualTo(materialsFromDb.Skip(4).First().ANPF));
            Assert.That(materialsFromService.Result.Skip(4).First().Price, Is.EqualTo(materialsFromDb.Skip(4).First().Price));
            Assert.That(materialsFromService.Result.Skip(4).First().ImageUrl, Is.EqualTo(materialsFromDb.Skip(4).First().ImageUrl));
            Assert.That(materialsFromService.Result.Skip(4).First().Id, Is.EqualTo(materialsFromDb.Skip(4).First().Id));

            Assert.That(materialsFromService.Result.Skip(5).First().Name, Is.EqualTo(materialsFromDb.Skip(5).First().Name));
            Assert.That(materialsFromService.Result.Skip(5).First().ANPF, Is.EqualTo(materialsFromDb.Skip(5).First().ANPF));
            Assert.That(materialsFromService.Result.Skip(5).First().Price, Is.EqualTo(materialsFromDb.Skip(5).First().Price));
            Assert.That(materialsFromService.Result.Skip(5).First().ImageUrl, Is.EqualTo(materialsFromDb.Skip(5).First().ImageUrl));
            Assert.That(materialsFromService.Result.Skip(5).First().Id, Is.EqualTo(materialsFromDb.Skip(5).First().Id));

            Assert.That(materialsFromService.Result.Skip(6).First().Name, Is.EqualTo(materialsFromDb.Skip(6).First().Name));
            Assert.That(materialsFromService.Result.Skip(6).First().ANPF, Is.EqualTo(materialsFromDb.Skip(6).First().ANPF));
            Assert.That(materialsFromService.Result.Skip(6).First().Price, Is.EqualTo(materialsFromDb.Skip(6).First().Price));
            Assert.That(materialsFromService.Result.Skip(6).First().ImageUrl, Is.EqualTo(materialsFromDb.Skip(6).First().ImageUrl));
            Assert.That(materialsFromService.Result.Skip(6).First().Id, Is.EqualTo(materialsFromDb.Skip(6).First().Id));

            Assert.That(materialsFromService.Result.Skip(7).First().Name, Is.EqualTo(materialsFromDb.Skip(7).First().Name));
            Assert.That(materialsFromService.Result.Skip(7).First().ANPF, Is.EqualTo(materialsFromDb.Skip(7).First().ANPF));
            Assert.That(materialsFromService.Result.Skip(7).First().Price, Is.EqualTo(materialsFromDb.Skip(7).First().Price));
            Assert.That(materialsFromService.Result.Skip(7).First().ImageUrl, Is.EqualTo(materialsFromDb.Skip(7).First().ImageUrl));
            Assert.That(materialsFromService.Result.Skip(7).First().Id, Is.EqualTo(materialsFromDb.Skip(7).First().Id));

            Assert.That(materialsFromService.Result.Skip(8).First().Name, Is.EqualTo(materialsFromDb.Skip(8).First().Name));
            Assert.That(materialsFromService.Result.Skip(8).First().ANPF, Is.EqualTo(materialsFromDb.Skip(8).First().ANPF));
            Assert.That(materialsFromService.Result.Skip(8).First().Price, Is.EqualTo(materialsFromDb.Skip(8).First().Price));
            Assert.That(materialsFromService.Result.Skip(8).First().ImageUrl, Is.EqualTo(materialsFromDb.Skip(8).First().ImageUrl));
            Assert.That(materialsFromService.Result.Skip(8).First().Id, Is.EqualTo(materialsFromDb.Skip(8).First().Id));

            Assert.That(materialsFromService.Result.Skip(9).First().Name, Is.EqualTo(materialsFromDb.Skip(9).First().Name));
            Assert.That(materialsFromService.Result.Skip(9).First().ANPF, Is.EqualTo(materialsFromDb.Skip(9).First().ANPF));
            Assert.That(materialsFromService.Result.Skip(9).First().Price, Is.EqualTo(materialsFromDb.Skip(9).First().Price));
            Assert.That(materialsFromService.Result.Skip(9).First().ImageUrl, Is.EqualTo(materialsFromDb.Skip(9).First().ImageUrl));
            Assert.That(materialsFromService.Result.Skip(9).First().Id, Is.EqualTo(materialsFromDb.Skip(9).First().Id));

            Assert.That(materialsFromService.Result.Skip(10).First().Name, Is.EqualTo(materialsFromDb.Skip(10).First().Name));
            Assert.That(materialsFromService.Result.Skip(10).First().ANPF, Is.EqualTo(materialsFromDb.Skip(10).First().ANPF));
            Assert.That(materialsFromService.Result.Skip(10).First().Price, Is.EqualTo(materialsFromDb.Skip(10).First().Price));
            Assert.That(materialsFromService.Result.Skip(10).First().ImageUrl, Is.EqualTo(materialsFromDb.Skip(10).First().ImageUrl));
            Assert.That(materialsFromService.Result.Skip(10).First().Id, Is.EqualTo(materialsFromDb.Skip(10).First().Id));

            Assert.That(materialsFromService.Result.Skip(11).First().Name, Is.EqualTo(materialsFromDb.Skip(11).First().Name));
            Assert.That(materialsFromService.Result.Skip(11).First().ANPF, Is.EqualTo(materialsFromDb.Skip(11).First().ANPF));
            Assert.That(materialsFromService.Result.Skip(11).First().Price, Is.EqualTo(materialsFromDb.Skip(11).First().Price));
            Assert.That(materialsFromService.Result.Skip(11).First().ImageUrl, Is.EqualTo(materialsFromDb.Skip(11).First().ImageUrl));
            Assert.That(materialsFromService.Result.Skip(11).First().Id, Is.EqualTo(materialsFromDb.Skip(11).First().Id));

            Assert.That(materialsFromService.Result.Skip(12).First().Name, Is.EqualTo(materialsFromDb.Skip(12).First().Name));
            Assert.That(materialsFromService.Result.Skip(12).First().ANPF, Is.EqualTo(materialsFromDb.Skip(12).First().ANPF));
            Assert.That(materialsFromService.Result.Skip(12).First().Price, Is.EqualTo(materialsFromDb.Skip(12).First().Price));
            Assert.That(materialsFromService.Result.Skip(12).First().ImageUrl, Is.EqualTo(materialsFromDb.Skip(12).First().ImageUrl));
            Assert.That(materialsFromService.Result.Skip(12).First().Id, Is.EqualTo(materialsFromDb.Skip(12).First().Id));

            Assert.That(materialsFromService.Result.Skip(13).First().Name, Is.EqualTo(materialsFromDb.Skip(13).First().Name));
            Assert.That(materialsFromService.Result.Skip(13).First().ANPF, Is.EqualTo(materialsFromDb.Skip(13).First().ANPF));
            Assert.That(materialsFromService.Result.Skip(13).First().Price, Is.EqualTo(materialsFromDb.Skip(13).First().Price));
            Assert.That(materialsFromService.Result.Skip(13).First().ImageUrl, Is.EqualTo(materialsFromDb.Skip(13).First().ImageUrl));
            Assert.That(materialsFromService.Result.Skip(13).First().Id, Is.EqualTo(materialsFromDb.Skip(13).First().Id));

            Assert.That(materialsFromService.Result.Skip(14).First().Name, Is.EqualTo(materialsFromDb.Skip(14).First().Name));
            Assert.That(materialsFromService.Result.Skip(14).First().ANPF, Is.EqualTo(materialsFromDb.Skip(14).First().ANPF));
            Assert.That(materialsFromService.Result.Skip(14).First().Price, Is.EqualTo(materialsFromDb.Skip(14).First().Price));
            Assert.That(materialsFromService.Result.Skip(14).First().ImageUrl, Is.EqualTo(materialsFromDb.Skip(14).First().ImageUrl));
            Assert.That(materialsFromService.Result.Skip(14).First().Id, Is.EqualTo(materialsFromDb.Skip(14).First().Id));

            Assert.That(materialsFromService.Result.Skip(15).First().Name, Is.EqualTo(materialsFromDb.Skip(15).First().Name));
            Assert.That(materialsFromService.Result.Skip(15).First().ANPF, Is.EqualTo(materialsFromDb.Skip(15).First().ANPF));
            Assert.That(materialsFromService.Result.Skip(15).First().Price, Is.EqualTo(materialsFromDb.Skip(15).First().Price));
            Assert.That(materialsFromService.Result.Skip(15).First().ImageUrl, Is.EqualTo(materialsFromDb.Skip(15).First().ImageUrl));
            Assert.That(materialsFromService.Result.Skip(15).First().Id, Is.EqualTo(materialsFromDb.Skip(15).First().Id));

            Assert.That(materialsFromService.Result.Skip(16).First().Name, Is.EqualTo(materialsFromDb.Skip(16).First().Name));
            Assert.That(materialsFromService.Result.Skip(16).First().ANPF, Is.EqualTo(materialsFromDb.Skip(16).First().ANPF));
            Assert.That(materialsFromService.Result.Skip(16).First().Price, Is.EqualTo(materialsFromDb.Skip(16).First().Price));
            Assert.That(materialsFromService.Result.Skip(16).First().ImageUrl, Is.EqualTo(materialsFromDb.Skip(16).First().ImageUrl));
            Assert.That(materialsFromService.Result.Skip(16).First().Id, Is.EqualTo(materialsFromDb.Skip(16).First().Id));

            Assert.That(materialsFromService.Result.Skip(17).First().Name, Is.EqualTo(materialsFromDb.Skip(17).First().Name));
            Assert.That(materialsFromService.Result.Skip(17).First().ANPF, Is.EqualTo(materialsFromDb.Skip(17).First().ANPF));
            Assert.That(materialsFromService.Result.Skip(17).First().Price, Is.EqualTo(materialsFromDb.Skip(17).First().Price));
            Assert.That(materialsFromService.Result.Skip(17).First().ImageUrl, Is.EqualTo(materialsFromDb.Skip(17).First().ImageUrl));
            Assert.That(materialsFromService.Result.Skip(17).First().Id, Is.EqualTo(materialsFromDb.Skip(17).First().Id));

            Assert.That(materialsFromService.Result.Skip(18).First().Name, Is.EqualTo(materialsFromDb.Skip(18).First().Name));
            Assert.That(materialsFromService.Result.Skip(18).First().ANPF, Is.EqualTo(materialsFromDb.Skip(18).First().ANPF));
            Assert.That(materialsFromService.Result.Skip(18).First().Price, Is.EqualTo(materialsFromDb.Skip(18).First().Price));
            Assert.That(materialsFromService.Result.Skip(18).First().ImageUrl, Is.EqualTo(materialsFromDb.Skip(18).First().ImageUrl));
            Assert.That(materialsFromService.Result.Skip(18).First().Id, Is.EqualTo(materialsFromDb.Skip(18).First().Id));

            Assert.That(materialsFromService.Result.Skip(19).First().Name, Is.EqualTo(materialsFromDb.Skip(19).First().Name));
            Assert.That(materialsFromService.Result.Skip(19).First().ANPF, Is.EqualTo(materialsFromDb.Skip(19).First().ANPF));
            Assert.That(materialsFromService.Result.Skip(19).First().Price, Is.EqualTo(materialsFromDb.Skip(19).First().Price));
            Assert.That(materialsFromService.Result.Skip(19).First().ImageUrl, Is.EqualTo(materialsFromDb.Skip(19).First().ImageUrl));
            Assert.That(materialsFromService.Result.Skip(19).First().Id, Is.EqualTo(materialsFromDb.Skip(19).First().Id));

            Assert.That(materialsFromService.Result.Skip(20).First().Name, Is.EqualTo(materialsFromDb.Skip(20).First().Name));
            Assert.That(materialsFromService.Result.Skip(20).First().ANPF, Is.EqualTo(materialsFromDb.Skip(20).First().ANPF));
            Assert.That(materialsFromService.Result.Skip(20).First().Price, Is.EqualTo(materialsFromDb.Skip(20).First().Price));
            Assert.That(materialsFromService.Result.Skip(20).First().ImageUrl, Is.EqualTo(materialsFromDb.Skip(20).First().ImageUrl));
            Assert.That(materialsFromService.Result.Skip(20).First().Id, Is.EqualTo(materialsFromDb.Skip(20).First().Id));

            Assert.That(materialsFromService.Result.Skip(21).First().Name, Is.EqualTo(materialsFromDb.Skip(21).First().Name));
            Assert.That(materialsFromService.Result.Skip(21).First().ANPF, Is.EqualTo(materialsFromDb.Skip(21).First().ANPF));
            Assert.That(materialsFromService.Result.Skip(21).First().Price, Is.EqualTo(materialsFromDb.Skip(21).First().Price));
            Assert.That(materialsFromService.Result.Skip(21).First().ImageUrl, Is.EqualTo(materialsFromDb.Skip(21).First().ImageUrl));
            Assert.That(materialsFromService.Result.Skip(21).First().Id, Is.EqualTo(materialsFromDb.Skip(21).First().Id));

            Assert.That(materialsFromService.Result.Skip(22).First().Name, Is.EqualTo(materialsFromDb.Skip(22).First().Name));
            Assert.That(materialsFromService.Result.Skip(22).First().ANPF, Is.EqualTo(materialsFromDb.Skip(22).First().ANPF));
            Assert.That(materialsFromService.Result.Skip(22).First().Price, Is.EqualTo(materialsFromDb.Skip(22).First().Price));
            Assert.That(materialsFromService.Result.Skip(22).First().ImageUrl, Is.EqualTo(materialsFromDb.Skip(22).First().ImageUrl));
            Assert.That(materialsFromService.Result.Skip(22).First().Id, Is.EqualTo(materialsFromDb.Skip(22).First().Id));

            Assert.That(materialsFromService.Result.Last().Name, Is.EqualTo(materialsFromDb.Last().Name));
            Assert.That(materialsFromService.Result.Last().ANPF, Is.EqualTo(materialsFromDb.Last().ANPF));
            Assert.That(materialsFromService.Result.Last().Price, Is.EqualTo(materialsFromDb.Last().Price));
            Assert.That(materialsFromService.Result.Last().ImageUrl, Is.EqualTo(materialsFromDb.Last().ImageUrl));
            Assert.That(materialsFromService.Result.Last().Id, Is.EqualTo(materialsFromDb.Last().Id));
        }

        [Test]
        public void GetMaterialForEditTest()
        {            
            var materialFromService = materialService.GetMaterialForEditAsync(1);

            var materialFromDb = dbContext.Materials
                .Where(m => m.Id == 1)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            materialFromService = materialService.GetMaterialForEditAsync(2);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 2)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(3);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 3)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(4);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 4)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(5);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 5)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(6);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 6)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(7);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 7)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(8);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 8)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(9);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 9)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(10);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 10)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(11);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 11)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(12);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 12)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(13);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 13)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(14);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 14)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(15);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 15)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(16);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 16)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(17);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 17)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(18);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 18)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(19);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 19)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(20);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 20)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(21);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 21)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(22);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 22)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(23);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 23)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();

            Assert.That(materialFromService.Result.Name, Is.EqualTo(materialFromDb.Name));
            Assert.That(materialFromService.Result.ANPF, Is.EqualTo(materialFromDb.ANPF));
            Assert.That(materialFromService.Result.Price, Is.EqualTo(materialFromDb.Price));
            Assert.That(materialFromService.Result.ImageUrl, Is.EqualTo(materialFromDb.ImageUrl));

            materialFromService = materialService.GetMaterialForEditAsync(24);

            materialFromDb = dbContext.Materials
                .Where(m => m.Id == 24)
                .Select(m => new AddEditMaterialViewModel
                {
                    Name = m.Name,
                    ANPF = m.ANPF,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price.ToString()
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator),
                }).FirstOrDefault();
        }

        [Test]
        public void EditMaterialAsyncTest()
        {
            AddEditMaterialViewModel model = new AddEditMaterialViewModel();

            model.Name = "Name";
            model.ANPF = "ANPF";
            model.Price = "1";
            model.ImageUrl = "Url";

            var originalMaterial = materialService.GetMaterialForEditAsync(5);

            Assert.That(originalMaterial.Result.Name, !Is.EqualTo(model.Name));
            Assert.That(originalMaterial.Result.ANPF, !Is.EqualTo(model.ANPF));
            Assert.That(originalMaterial.Result.Price, !Is.EqualTo(model.Price));
            Assert.That(originalMaterial.Result.ImageUrl, !Is.EqualTo(model.ImageUrl));

            var isTrue = materialService.EditMaterialAsync(model, 5);

            var modifiedMaterial = materialService.GetMaterialForEditAsync(5);

            Assert.That(modifiedMaterial.Result.Name, Is.EqualTo(model.Name));
            Assert.That(modifiedMaterial.Result.ANPF, Is.EqualTo(model.ANPF));
            Assert.That(modifiedMaterial.Result.Price, Is.EqualTo(model.Price));
            Assert.That(modifiedMaterial.Result.ImageUrl, Is.EqualTo(model.ImageUrl));

        }
    }
}