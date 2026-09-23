namespace HomeWork5.Task2
{
    public class ProductDisplay
    {
        private IProductDataSource _dataSource;

        public ProductDisplay(IProductDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void DisplayProducts()
        {
            _dataSource.GetProducts();
        }
    }
}
