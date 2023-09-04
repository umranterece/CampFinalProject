using Business.CCS;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
    //SOLID
    // Open Closed Project 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Data Transformation Object --- DTO
            // Inversion of Control --- IoC 



            //ProductTest();
            //CategoryTest();
            //ProductDetailsTest();

        }

        //private static void CategoryTest()
        //{
        //    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        //    foreach (var item in categoryManager.GetAll().Data)
        //    {
        //        Console.WriteLine(item.CategoryName);
        //    }
        //}

        //private static void ProductTest()
        //{
        //    ProductManager productManager = new ProductManager(new EfProductDal());

        //    var result = productManager.GetByUnitPrice(50, 100);

        //    if(result.Success == true )
        //    {
        //        foreach (var item in result.Data)
        //        {
        //            Console.WriteLine(item.ProductName);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }
            
        //}

        //private static void ProductDetailsTest()
        //{
        //    ProductManager productManager = new ProductManager(new EfProductDal());

        //    var result = productManager.GetProductDetails();

        //    if(result.Success == true )
        //    {
        //        foreach (var item in result.Data)
        //        {
        //            Console.WriteLine(item.ProductName + " / " + item.CategoryName);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }
        //}
    }
}
