using HomeWork5.Task2;

namespace HomeWork5.Task3
{
    public class ProductDataSourceFactory
    {
        public IProductDataSource Create(string sourceType)
        {
            switch (sourceType)
            {
                case "Database":
                    return new DatabaseProductDataSource();

                case "API":
                    return new ApiProductDataSource();

                case "File":
                    return new FileProductDataSource();

                default:
                    throw new ArgumentException("Invalid data source.");
            }
        }
    }
}
