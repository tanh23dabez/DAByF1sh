﻿using SellerProduct.IServices;
using SellerProduct.Models;

namespace SellerProduct.Services;

public class ProductService : IProductService
{
    ShopDbContext context;

    public ProductService()
    {
        context = new ShopDbContext();
    }

    public bool CreateProduct(Product p)
    {
        try
        {
            context.Products.Add(p);
            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public bool DeleteProduct(Guid id)
    {
        try
        {
            dynamic product = context.Products.Find(id); // hàm Find truyền thẳng tham số chỉ dùng được cho khóa chính
            context.Products.Remove(product);
            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public List<Product> GetAllProducts()
    {
        return context.Products.ToList();
    }

    public Product GetProductById(Guid id)
    {
        // return context.Products.FirstOrDefault(p => p.Id==id);
        // return context.Products.SingleOrDefault(p => p.Id == id);
        return context.Products.Find(id);
    }

    public List<Product> GetProductByName(string name)
    {
        return context.Products.Where(p => p.Name.Contains(name)).ToList();
    }

    public bool UpdateProduct(Product p)
    {
        try
        {
            var product = context.Products.Find(p.Id);
            product.Name = p.Name;
            product.AvailableQuantity = p.AvailableQuantity;
            product.Description = p.Description;
            product.Price = p.Price;
            product.Supplier = p.Supplier;
            product.Status = p.Status;
            context.Update(product);
            context.SaveChanges(); return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
