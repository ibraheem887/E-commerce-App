using System;
using System.Data;
using E_Commerce.DAL;

namespace E_Commerce
{
    public class ProductCatalogBLL
    {
        private readonly ProductCatalogDAL productDAL;

        public ProductCatalogBLL()
        {
            productDAL = new ProductCatalogDAL();
        }

        // Get Categories from DAL
        public DataTable GetCategories()
        {
            return productDAL.GetCategories();
        }

        // Get Products from DAL
        public DataTable GetProducts(string searchQuery, string categoryId = "")
        {
            return productDAL.GetProducts(searchQuery, categoryId);
        }
    }
}
