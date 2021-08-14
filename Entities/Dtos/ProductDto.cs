namespace Entities.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Color { get; set; }
        public short Stock { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal StandardCost { get; set; }
        public string SubCategoryName { get; set; }
        public string CategoryName { get; set; }
    }
}
