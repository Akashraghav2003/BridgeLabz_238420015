namespace Dynamic_Online_Marketplace
{
    public abstract class ProductCategory
    {
        public abstract string CategoryName { get; }
    }

    public class BookCategory : ProductCategory
    {
        public override string CategoryName => "Books";
    }

    public class ClothingCategory : ProductCategory
    {
        public override string CategoryName => "Clothing";
    }
}
