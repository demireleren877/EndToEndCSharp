

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

ProductManager productManager = new ProductManager(new EFProductDal());
foreach (var item in productManager.GetAllByUnitPrice(50,100))
{
    Console.WriteLine(item.ProductName);
}

