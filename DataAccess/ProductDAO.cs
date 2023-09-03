using DataAccess.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDAO
    {
        public static List<Product> GetProducts()
        {
            List<Product> products;
            try
            {
                using (var context = new SaleManagementDBContext())
                {
                    products = context.Products.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return products;
        }

        public static Product GetProductById(int id)
        {
            Product product = null;
            try
            {
                using (var context = new SaleManagementDBContext())
                {
                    product = context.Products.SingleOrDefault(p => p.ProductId == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;
        }

        public static void InsertProduct(Product product)
        {
            try
            {
                Product p = GetProductById(product.ProductId);
                if (p == null)
                {
                    using (var context = new SaleManagementDBContext())
                    {
                        context.Products.Add(product);
                        context.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("The product is already exist.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public static void UpdateProduct(Product product)
        {
            try
            {
                Product p = GetProductById(product.ProductId);
                if (p != null)
                {
                    using (var context = new SaleManagementDBContext())
                    {
                        context.Entry<Product>(product).State = EntityState.Modified;
                        context.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("The product does not already exist.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public static void RemoveProduct(Product product)
        {
            try
            {
                Product p = GetProductById(product.ProductId);
                if (p != null)
                {
                    using (var context = new SaleManagementDBContext())
                    {
                        context.Products.Remove(product);
                        context.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("The product does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<Product> SearchProductByName(string name)
        {
            List<Product> products;
            try
            {
                using (var context = new SaleManagementDBContext())
                {
                    products = context.Products.Where(p => p.ProductName.Contains(name)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return products;
        }
    }
}
