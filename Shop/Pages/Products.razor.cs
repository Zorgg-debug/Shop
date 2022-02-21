using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Pages
{
    public partial class Products
    {
        public List<ProductInfo> _testRes { get; set; }
         = new List<ProductInfo>()
        {
            new ProductInfo() {Category = "категория1"},
            new ProductInfo() {Category = "категория1"},
            new ProductInfo() {Category = "категория1"},
            new ProductInfo() {Category = "категория1"},
            new ProductInfo() {Category = "категория1"},
            new ProductInfo() {Category = "категория12"},
             new ProductInfo() {Category = "категория12"},
            new ProductInfo() {Category = "категория12"},
            new ProductInfo() {Category = "категория12"},
            new ProductInfo() {Category = "категория12"},
            new ProductInfo() {Category = "категория12"},
            new ProductInfo() {Category = "категория12"},
            new ProductInfo() {Category = "категория12"},
            new ProductInfo() {Category = "категория12"}
        };

        public List<CategoryInfo> _testResCategory = new List<CategoryInfo>() {
        new CategoryInfo(){Name = "Категория 1" },
        new CategoryInfo(){Name = "Категория 12" },
        new CategoryInfo(){Name = "Категория 13" },
        new CategoryInfo(){Name = "Категория 14" },
        new CategoryInfo(){Name = "Категория 5" },
        new CategoryInfo(){Name = "Категория 16" },
        new CategoryInfo(){Name = "Категория 17" },
        new CategoryInfo(){Name = "Категория 18" },
        new CategoryInfo(){Name = "Категория 19" }
        };
    }
    
}
