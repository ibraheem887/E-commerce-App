using E_Commerce.DAL;
using System;
using System.Data;

namespace E_Commerce.BLL
{
    public class ProductBLL
    {
        private ProductDAL productDAL;

        public ProductBLL(string connectionString)
        {
            productDAL = new ProductDAL(connectionString);
        }

        public DataTable GetProducts()
        {
            return productDAL.GetProducts();
        }

        public void AddProduct(string name, string description, decimal price, string categoryId, int stockQuantity, string imageUrl)
        {
            productDAL.InsertProduct(name, description, price, categoryId, stockQuantity, imageUrl);
        }

        public void RemoveProduct(int productId)
        {
            productDAL.DeleteProduct(productId);
        }

        public void UpdateProduct(int productId, string name, decimal price, int stockQuantity, string categoryId)
        {
            productDAL.UpdateProduct(productId, name, price, stockQuantity, categoryId);
        }

        public DataTable GetCategories()
        {
            return productDAL.GetCategories();
        }
    }
}
