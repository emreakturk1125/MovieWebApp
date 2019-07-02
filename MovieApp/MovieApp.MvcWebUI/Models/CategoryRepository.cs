using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.MvcWebUI.Models
{
    public static class CategoryRepository
    {
        private static List<Category> categories;
        static CategoryRepository()
        {
            categories = new List<Category>()
            {
                new Category(){Id=1,Name="Category 1"},
                new Category(){Id=2,Name="Category 2"},
                new Category(){Id=3,Name="Category 3"},
                new Category(){Id=4,Name="Category 4"},
                new Category(){Id=5,Name="Category 5"},
                new Category(){Id=6,Name="Category 6"}
            };

        }


        public static List<Category> Categories
        {
            get { return categories; }
        }

        public static void AddCategory(Category category)
        {
            categories.Add(category);
        }

        public static Category GetById(int id)
        {
            return categories.FirstOrDefault(x => x.Id == id);
        }
    }
}