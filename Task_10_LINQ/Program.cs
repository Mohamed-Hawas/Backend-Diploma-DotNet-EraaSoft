using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Numerics;
using Task_10_LINQ.Data;
using Task_10_LINQ.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_10_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new BikeStores528Context();

            // 1-List all customers' first and last names along with their email addresses.
            //var customers = db.Customers
            //    .Select(c => new {
            //        Name = c.FirstName + " " + c.LastName,
            //        c.Email
            //    })
            //    .ToList();

            //foreach (var item in customers)
            //{
            //    Console.WriteLine($"Name: {item.Name}, Email: {item.Email}");
            //}

            // 2 - Retrieve all orders processed by a specific staff member(e.g., staff_id = 3).
            //var orders = db.Orders
            //    .Where(o => o.StaffId == 3);

            //foreach (var item in orders)
            //{
            //    Console.WriteLine($"Order ID: {item.OrderId}, Customer ID: {item.CustomerId}, StaffId: {item.StaffId}");
            //}

            // 3 - Get all products that belong to a category named "Mountain Bikes".
            //var products = db.Products
            //    .Where(p => p.Category.CategoryName == "Mountain Bikes")
            //    .Include(p => p.Category);

            //foreach (var item in products)
            //{
            //    Console.WriteLine($"Product ID: {item.ProductId}, Name: {item.ProductName}, Price: {item.ListPrice}, Category: {item.Category.CategoryName}");
            //}

            // 4 - Count the total number of orders per store.
            //var ordersOfStores = db.Orders
            //    .Include(o => o.Store)
            //    .GroupBy(o => o.Store)
            //    .Select(o => new
            //    {
            //       StoreName = o.Key.StoreName,
            //       count = o.Count()
            //    });
            //foreach (var item in ordersOfStores)
            //{
            //    Console.WriteLine($"Store {item.StoreName} has {item.count} orders ");
            //}

            //5 - List all orders that have not been shipped yet(shipped_date is null).
            //var orders = db.Orders
            //    .Where(o => o.ShippedDate == null);
            //foreach (var item in orders)
            //{
            //    Console.WriteLine($"Order ID: {item.OrderId}, Shipped Date: {item.ShippedDate}");
            //}

            //6 - Display each customer’s full name and the number of orders they have placed.
            //var customers = db.Customers
            //    .GroupBy(c => c)
            //    .Select(c => new
            //    {
            //        Name = c.Key.FirstName + " " + c.Key.LastName,
            //        OrderNum = c.Count()
            //    });
            //foreach (var item in customers)
            //{
            //    Console.WriteLine($"Name: {item.Name}, Count of orders: {item.OrderNum}");
            //}

            // 7 - List all products that have never been ordered(not found in order_items).
            //var products = db.Products
            //    .LeftJoin(
            //    db.OrderItems,
            //    p => p.ProductId,
            //    oi => oi.ProductId,
            //    (p, oi) => new{p, oi}
            //    )               
            //    .Where(x => x.oi == null)
            //    .Select(x => new
            //    {
            //        x.p.ProductName
            //    });
            //foreach (var item in products)
            //{
            //    Console.WriteLine($"{item.ProductName}");
            //}

            // 8 - Display products that have a quantity of less than 5 in any store stock.
            //var products = db.Stocks
            //    .Join(
            //    db.Products,
            //    stock => stock.ProductId,
            //    product => product.ProductId,
            //    (stock, product) => new { stock, product }
            //    )
            //    .Join(
            //    db.Stores,
            //    output => output.stock.StoreId,
            //    store => store.StoreId,
            //    (output, store) => new { output, store }
            //    )
            //    .Where(x => x.output.stock.Quantity < 5)
            //    .Select(e => new
            //    {
            //         e.output.product.ProductName,
            //         e.output.stock.Quantity

            //    });

            //foreach (var item in products)
            //{
            //    Console.WriteLine($"Product Name : {item.ProductName}, Stock : {item.Quantity}");
            //}

            //9 - Retrieve the first product from the products table.
            //var firstProduct = db.Products
            //    .SingleOrDefault(e => e.ProductId == 1);

            //Console.WriteLine($"First Product: {firstProduct?.ProductName}");


            //10 - Retrieve all products from the products table with a certain model year.
            //var products = db.Products
            //    .Where(e => e.ModelYear == 2018);
            //foreach (var item in products)
            //{
            //    Console.WriteLine($"Product Name : {item.ProductName}, ModelYear: {item.ModelYear}");
            //}

            //11 - Display each product with the number of times it was ordered. 
            //var orders = db.OrderItems
            //    .GroupBy(oi => oi.Product)
            //    .Select(x => new
            //    {
            //        ProductName = x.Key.ProductName,
            //        Count = x.Count()
            //    });
            //foreach (var item in orders)
            //{
            //    Console.WriteLine($"Product Name : {item.ProductName}, Count: {item.Count}");
            //}
            //12 - Count the number of products in a specific category.
            //13 - Calculate the average list price of products. 
            //14 - Retrieve a specific product from the products table by ID.
            //15 - List all products that were ordered with a quantity greater than 3 in any order. 
            //16 - Display each staff member’s name and how many orders they processed. 
            //17 - List active staff members only(active = true) along with their phone numbers.
            //18 - List all products with their brand name and category name.
            //19 - Retrieve orders that are completed. 
            //20 - List each product with the total quantity sold(sum of quantity from order_items).
        }
    }
}
