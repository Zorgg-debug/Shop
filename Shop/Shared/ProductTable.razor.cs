using Microsoft.AspNetCore.Components;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Shop.Shared
{
    public partial class ProductTable
    {
        [Parameter]
        public List<ProductInfo> products { get; set; }
        [Parameter]
        public List<CategoryInfo> categories { get; set; }
        public string _category { get; set; } = string.Empty;
        public int count { get; set; } = 0;
        string searchValue { get; set; }
        public CategoryInfo сategory { get; set; }
        public ProductInfo product { get; set; }

        private bool formCategoryVisible = false;
        private bool formProductVisible = false;
        private bool visibleDrawer = false;
        private void OpenFormCategory(CategoryInfo category)
        {
            if (category == null)
                this.сategory = new CategoryInfo();
            formCategoryVisible = true;
        }
        private void OpenFormProduct(ProductInfo product)
        {
            if (product == null)
                this.product = new ProductInfo();
            formProductVisible = true;
        }
        private void CloseFormProduct(bool visible)
        {
            formProductVisible = visible;
        }
        private void CloseFormCategory(bool visible)
        {
            formCategoryVisible = visible;
        }
        private void openDrawer()
        {
            visibleDrawer = true;
        }
        private void closeDrawer()
        {
            visibleDrawer = false;
        }
    }
}
