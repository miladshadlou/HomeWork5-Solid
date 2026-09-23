using HomeWork5.Task2;
using HomeWork5.Task3;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    public static void Main(string[] args)
    {
        // نمونه سازی و کنترل وابستگی خارج از کلاس محصول
        IProductDataSource dataSource1 = new DatabaseProductDataSource();

        ProductDisplay display1 = new ProductDisplay(dataSource1);

        display1.DisplayProducts();

        IProductDataSource dataSource2 = new ApiProductDataSource();

        ProductDisplay display2 = new ProductDisplay(dataSource2);

        display2.DisplayProducts();

        IProductDataSource dataSource3 = new FileProductDataSource();

        ProductDisplay display3 = new ProductDisplay(dataSource3);

        display3.DisplayProducts();

        // نمونه سازی و کنترل وابستگی با استفاده از فکتوری 

        ProductDataSourceFactory factory = new ProductDataSourceFactory();

        IProductDataSource dataSource = factory.Create("API");

        ProductDisplay display = new ProductDisplay(dataSource);

        display.DisplayProducts();

        // تمرین 4 استفاده از کانتینر

        ServiceCollection services = new ServiceCollection();

        // برای تغییر منبع کافیست این خط اصلاح شود
        services.AddTransient<IProductDataSource, FileProductDataSource>();

        services.AddTransient<ProductDisplay>();

        ServiceProvider provider = services.BuildServiceProvider();

        ProductDisplay display4 = provider.GetRequiredService<ProductDisplay>();

        display4.DisplayProducts();
    }
}