namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            // create the instance of the product class
            // pass in the requested id
            Product product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "Haribo";

                product.ProductDescription = "Sweets, no good for teeth";

                product.CurrentPrice = 24.99m;

            }

            return product;
        }

        public bool Save(Product product)
        {
            return true;
        }
    }
}
