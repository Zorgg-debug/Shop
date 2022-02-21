using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Shop.Models;

namespace Shop.Shared
{
    public partial class FormCategory
    {
        [Parameter]
        public CategoryInfo category { get; set; } = new CategoryInfo();
        [Parameter]
        public bool visible { get; set; } = false;
        [Parameter]
        public EventCallback<bool> close { get; set; }
        bool loading = false;
        AntDesign.Form<CategoryInfo> form;

        private void HandleOk(MouseEventArgs e)
        {
            form.Validate();
            if (form.Validate())
            {
                visible = false;
                close.InvokeAsync(visible);
            }
        }
        private void HandleCancel(MouseEventArgs e)
        {
            visible = false;
            close.InvokeAsync(visible);
        }
    }
}
