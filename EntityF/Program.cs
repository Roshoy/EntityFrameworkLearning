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
                var form = new CategoryForm();
                form.ShowDialog();
            }
            //Console.ReadKey();
        }
    }
}
