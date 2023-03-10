using OpenFood.Domain.Enum;

namespace OpenFood.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public long Code { get; set; }
        public string Barcode { get; set; }
        public Status Status { get; set; }
        public DateTime ImportedT { get; set; }
        public string Url { get; set; }
        public string ProductName { get; set; }
        public string Quantity { get; set; }
        public string Categories { get; set; }
        public string Packaging { get; set; }
        public string Brands { get; set; }
        public string ImageUrl { get; set; }
    }
}
