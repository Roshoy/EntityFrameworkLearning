using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityF
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter category name: ");
            string categoryName;
            categoryName = Console.ReadLine();*/
            using(var context = new ProdContext())
            {/*
                var category = new Category()
                {
                    Name = categoryName
                };
                //context.categories.Add(category);
                //context.SaveChanges();

                var categories = from c in context.categories
                                 select c;
                Console.WriteLine("Categories: ");
                foreach (var c in categories)
                {
                    Console.WriteLine($"- {c.Name}");
                }*/
             //var form = new CategoryForm();
             //form.ShowDialog();
             //printAllCategoriesWithCount(context);

                Shop shop = new Shop(context);
                shop.ShowDialog();
            }
            //Console.ReadKey();
        }

        static void printAllCategories(ProdContext context)
        {
            var categories = context.categories.Select(c => c.Name);
            Console.WriteLine("Categories: ");
            foreach (var c in categories)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();
        }

        static void printAllCategoriesImmediate(ProdContext context)
        {
            var categories = context.categories.Select(c => c.Name).ToArray();
            Console.WriteLine("Categories: ");
            foreach (var c in categories)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();
        }

        static void printAllCategoriesAndProducts(ProdContext context)
        {
            var categoriesAndProducts = context.categories.Join(context.products,
                c => c.CategoryID,
                p => p.CategoryId,
                (c, p) => new
                {
                    CategoryName = c.Name,
                    ProductName = p.Name
                });
            foreach (var cp in categoriesAndProducts)
            {
                Console.WriteLine($"{cp.CategoryName}: {cp.ProductName}");
            }

            Console.WriteLine("With query : ");

            var categoriesAndProducts2 = from category in context.categories
                                         join product in context.products
                                         on category.CategoryID equals product.CategoryId into prodGroup
                                         from prod in prodGroup
                                         select new
                                         {
                                             CategoryName = category.Name,
                                             ProductName = prod.Name
                                         };
            foreach (var cp in categoriesAndProducts2)
            {
                Console.WriteLine($"{cp.CategoryName}: {cp.ProductName}");
            }
        }

        static void printAllCategoriesWithCount(ProdContext context)
        {
            var categoriesAndProducts = context.categories.GroupJoin(context.products,
                c => c.CategoryID,
                p => p.CategoryId,
                (c, p) => new
                {
                    CategoryName = c.Name,
                    ProductCount = p.Count()
                });
            foreach (var cp in categoriesAndProducts)
            {
                Console.WriteLine($"{cp.CategoryName}: {cp.ProductCount}");
            }

            Console.WriteLine("With query : ");

            var categoriesAndProducts2 = from category in context.categories
                                         join product in context.products
                                         on category.CategoryID equals product.CategoryId into prodGroup
                                         from prod in prodGroup
                                         select new
                                         {
                                             CategoryName = category.Name//,
                                            // ProductCount = prodGroup.Count()
                                         };
            foreach (var cp in categoriesAndProducts2)
            {
                Console.WriteLine($"{cp.CategoryName}");
            }
        }

    }
}
