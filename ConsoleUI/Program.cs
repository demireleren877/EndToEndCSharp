

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

//CategoryTest();
ProductTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EFProductDal());
    foreach (var item in productManager.GetProductDetails())
    {
        Console.WriteLine(item.ProductName+ "=="+ item.CategoryName);
    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
    foreach (var item in categoryManager.GetAll())
    {
        Console.WriteLine(item.CategoryName);
    }
}