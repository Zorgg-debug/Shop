using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Shop.Models;


namespace Shop.Shared
{
    public partial class Product
    {
        [Parameter]
        public ProductInfo product { get; set; }
        [Parameter]
        public EventCallback<ProductInfo> edit { get; set; }
        private async void Stop(string idProduct)
        {
            await Confirm("Товар добавлен в стоп лист");
        }
        private async void Delete(string idProduct)
        {
            await Confirm("Товар удален");
        }
        private void Edit(ProductInfo product)
        {
            edit.InvokeAsync(product);
        }
        private async Task Confirm(string textMessage)
        {
            await _message.Success(textMessage);
        }
    }
}
