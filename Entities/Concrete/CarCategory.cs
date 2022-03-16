namespace Entities.Concrete

{
    public class CarCategory : IEntity
    {
        public int CarCategoryId { get; set; }
        public int BrandId { get; set; }
    }
}
