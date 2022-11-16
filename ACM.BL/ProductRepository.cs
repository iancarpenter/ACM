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

            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");

            return product;
        }

        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsNew)
                {
                    // call an insert stored procedure
                }
                else
                {
                    // call an update stored procedure
                }
            }
            else
            {
                success = false;
            }
            return success;
        }
    }
}
