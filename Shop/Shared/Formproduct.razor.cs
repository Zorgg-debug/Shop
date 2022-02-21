using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Shared
{
    public partial class Formproduct
    {
        [Parameter]
        public ProductInfo product { get; set; } = new ProductInfo();
        [Parameter]
        public bool visible { get; set; }
        [Parameter]
        public EventCallback<bool> close { get; set; }

        AntDesign.Form<ProductInfo> form;
        private bool loading = false;
        private void HandleOk(MouseEventArgs e)
        {
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
