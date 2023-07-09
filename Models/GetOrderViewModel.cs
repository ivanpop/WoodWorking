using System.ComponentModel.DataAnnotations;

namespace WoodWorking.Models
{
    public class GetOrderViewModel
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        [Required]
        public bool IsExpress { get; set; }

        public decimal MaterialPrice { get; set; }

        public decimal EdgePrice { get; set; }

        public decimal TotalPrice { get; set; }

        public string? ClientName { get; set; }

        public string? ClientPhone { get; set; }

        public string? Material1Name { get; set; }
        public decimal Material1Price { get; set; }
        public decimal Material1Length { get; set; }
        public decimal Material1Height { get; set; }
        public decimal Material1Qty { get; set; }
        public decimal Material1Quadrature { get; set; }
        public decimal Material1TotalPrice { get; set; }
        public decimal Material1EdgeH1 { get; set; }
        public decimal Material1EdgeH2 { get; set; }
        public decimal Material1EdgeL1 { get; set; }
        public decimal Material1EdgeL2 { get; set; }
        public decimal Material1EdgeTotalPrice { get; set; }

        public string? Material2Name { get; set; }
        public decimal Material2Price { get; set; }
        public decimal Material2Length { get; set; }
        public decimal Material2Height { get; set; }
        public decimal Material2Qty { get; set; }
        public decimal Material2Quadrature { get; set; }
        public decimal Material2TotalPrice { get; set; }
        public decimal Material2EdgeH1 { get; set; }
        public decimal Material2EdgeH2 { get; set; }
        public decimal Material2EdgeL1 { get; set; }
        public decimal Material2EdgeL2 { get; set; }
        public decimal Material2EdgeTotalPrice { get; set; }

        public string? Material3Name { get; set; }
        public decimal Material3Price { get; set; }
        public decimal Material3Length { get; set; }
        public decimal Material3Height { get; set; }
        public decimal Material3Qty { get; set; }
        public decimal Material3Quadrature { get; set; }
        public decimal Material3TotalPrice { get; set; }
        public decimal Material3EdgeH1 { get; set; }
        public decimal Material3EdgeH2 { get; set; }
        public decimal Material3EdgeL1 { get; set; }
        public decimal Material3EdgeL2 { get; set; }
        public decimal Material3EdgeTotalPrice { get; set; }

        public string? Material4Name { get; set; }
        public decimal Material4Price { get; set; }
        public decimal Material4Length { get; set; }
        public decimal Material4Height { get; set; }
        public decimal Material4Qty { get; set; }
        public decimal Material4Quadrature { get; set; }
        public decimal Material4TotalPrice { get; set; }
        public decimal Material4EdgeH1 { get; set; }
        public decimal Material4EdgeH2 { get; set; }
        public decimal Material4EdgeL1 { get; set; }
        public decimal Material4EdgeL2 { get; set; }
        public decimal Material4EdgeTotalPrice { get; set; }

        public string? Material5Name { get; set; }
        public decimal Material5Price { get; set; }
        public decimal Material5Length { get; set; }
        public decimal Material5Height { get; set; }
        public decimal Material5Qty { get; set; }
        public decimal Material5Quadrature { get; set; }
        public decimal Material5TotalPrice { get; set; }
        public decimal Material5EdgeH1 { get; set; }
        public decimal Material5EdgeH2 { get; set; }
        public decimal Material5EdgeL1 { get; set; }
        public decimal Material5EdgeL2 { get; set; }
        public decimal Material5EdgeTotalPrice { get; set; }

        public string? Material6Name { get; set; }
        public decimal Material6Price { get; set; }
        public decimal Material6Length { get; set; }
        public decimal Material6Height { get; set; }
        public decimal Material6Qty { get; set; }
        public decimal Material6Quadrature { get; set; }
        public decimal Material6TotalPrice { get; set; }
        public decimal Material6EdgeH1 { get; set; }
        public decimal Material6EdgeH2 { get; set; }
        public decimal Material6EdgeL1 { get; set; }
        public decimal Material6EdgeL2 { get; set; }
        public decimal Material6EdgeTotalPrice { get; set; }

        public string? Material7Name { get; set; }
        public decimal Material7Price { get; set; }
        public decimal Material7Length { get; set; }
        public decimal Material7Height { get; set; }
        public decimal Material7Qty { get; set; }
        public decimal Material7Quadrature { get; set; }
        public decimal Material7TotalPrice { get; set; }
        public decimal Material7EdgeH1 { get; set; }
        public decimal Material7EdgeH2 { get; set; }
        public decimal Material7EdgeL1 { get; set; }
        public decimal Material7EdgeL2 { get; set; }
        public decimal Material7EdgeTotalPrice { get; set; }

        public string? Material8Name { get; set; }
        public decimal Material8Price { get; set; }
        public decimal Material8Length { get; set; }
        public decimal Material8Height { get; set; }
        public decimal Material8Qty { get; set; }
        public decimal Material8Quadrature { get; set; }
        public decimal Material8TotalPrice { get; set; }
        public decimal Material8EdgeH1 { get; set; }
        public decimal Material8EdgeH2 { get; set; }
        public decimal Material8EdgeL1 { get; set; }
        public decimal Material8EdgeL2 { get; set; }
        public decimal Material8EdgeTotalPrice { get; set; }

        public string? Material9Name { get; set; }
        public decimal Material9Price { get; set; }
        public decimal Material9Length { get; set; }
        public decimal Material9Height { get; set; }
        public decimal Material9Qty { get; set; }
        public decimal Material9Quadrature { get; set; }
        public decimal Material9TotalPrice { get; set; }
        public decimal Material9EdgeH1 { get; set; }
        public decimal Material9EdgeH2 { get; set; }
        public decimal Material9EdgeL1 { get; set; }
        public decimal Material9EdgeL2 { get; set; }
        public decimal Material9EdgeTotalPrice { get; set; }

        public string? Material10Name { get; set; }
        public decimal Material10Price { get; set; }
        public decimal Material10Length { get; set; }
        public decimal Material10Height { get; set; }
        public decimal Material10Qty { get; set; }
        public decimal Material10Quadrature { get; set; }
        public decimal Material10TotalPrice { get; set; }
        public decimal Material10EdgeH1 { get; set; }
        public decimal Material10EdgeH2 { get; set; }
        public decimal Material10EdgeL1 { get; set; }
        public decimal Material10EdgeL2 { get; set; }
        public decimal Material10EdgeTotalPrice { get; set; }

        public string? Material11Name { get; set; }
        public decimal Material11Price { get; set; }
        public decimal Material11Length { get; set; }
        public decimal Material11Height { get; set; }
        public decimal Material11Qty { get; set; }
        public decimal Material11Quadrature { get; set; }
        public decimal Material11TotalPrice { get; set; }
        public decimal Material11EdgeH1 { get; set; }
        public decimal Material11EdgeH2 { get; set; }
        public decimal Material11EdgeL1 { get; set; }
        public decimal Material11EdgeL2 { get; set; }
        public decimal Material11EdgeTotalPrice { get; set; }

        public string? Material12Name { get; set; }
        public decimal Material12Price { get; set; }
        public decimal Material12Length { get; set; }
        public decimal Material12Height { get; set; }
        public decimal Material12Qty { get; set; }
        public decimal Material12Quadrature { get; set; }
        public decimal Material12TotalPrice { get; set; }
        public decimal Material12EdgeH1 { get; set; }
        public decimal Material12EdgeH2 { get; set; }
        public decimal Material12EdgeL1 { get; set; }
        public decimal Material12EdgeL2 { get; set; }
        public decimal Material12EdgeTotalPrice { get; set; }
    }
}