using BusinessObject.Models;
using DataAccess.DAO;

class Program
{
    static void AddProduct()
    {
        ProductDAO productDAO = new ProductDAO();

        productDAO.Create(new Product("", "", "", 1, 25, "Trending", "images/product/"));
        productDAO.Create(new Product("", "", "", 1, 25, "Trending", "images/product/"));
        productDAO.Create(new Product("", "", "", 1, 25, "Trending", "images/product/"));
        productDAO.Create(new Product("", "", "", 1, 25, "Trending", "images/product/"));
        productDAO.Create(new Product("", "", "", 1, 25, "Trending", "images/product/"));

        productDAO.Create(new Product("", "", "", 1, 25, "Trending", "images/product/"));
        productDAO.Create(new Product("", "", "", 1, 25, "Trending", "images/product/"));
        productDAO.Create(new Product("", "", "", 1, 25, "Trending", "images/product/"));
        productDAO.Create(new Product("", "", "", 1, 25, "Trending", "images/product/"));
        productDAO.Create(new Product("", "", "", 1, 25, "Trending", "images/product/"));

        productDAO.Create(new Product("", "", "", 1, 25, "Trending", "images/product/"));
        productDAO.Create(new Product("", "", "", 1, 25, "Trending", "images/product/"));
        productDAO.Create(new Product("", "", "", 1, 25, "Trending", "images/product/"));
        productDAO.Create(new Product("", "", "", 1, 25, "Trending", "images/product/"));
        productDAO.Create(new Product("", "", "", 1, 25, "Trending", "images/product/"));

    }
    static void AddUser()
    {
        UserDAO userDAO = new UserDAO();
        userDAO.Create(new User { UserName = "MeoMeo", Email = "Meo@gmail.com", PasswordHash = "123456" });
        userDAO.Create(new User { UserName = "GauGau", Email = "Gau@gmail.com", PasswordHash = "123456" });
    }

    static void Main(string[] args)
    {
        AddProduct();
        Console.WriteLine("add thanh cong");
    }
}