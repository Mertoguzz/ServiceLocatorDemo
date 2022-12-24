namespace Core
{
    public class Product : IProductService
    {
        public string GetProductName(int id)
        {
            return id > 1 ? "TEST" : "";
        }
    }
}
