using Microsoft.AspNetCore.Components;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Shop.Shared
{
    public partial class Category
    {
        [Parameter]
        public CategoryInfo category { get; set; }
        [Parameter]
        public EventCallback<CategoryInfo> edit { get; set; } 

        private void Edit(string id)
        {
            edit.InvokeAsync(category);
        }
        private async void Stop(string id)
        {
            await Confirm("Категория добавлена в стоп лист");
        }
        private async void Delete(string id)
        {
            await Confirm("Категория удалена");
        }
        private async Task Confirm(string textMessage)
        {
            await _message.Success(textMessage);
        }
    }
}
