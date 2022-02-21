using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Shared
{
    public partial class FormOrder
    {
        [Parameter]
        public OrderInfo order { get; set; } = new OrderInfo();
        [Parameter]
        public bool visible { get; set; } = false;
        [Parameter]
        public EventCallback<bool> close { get; set; }
        bool loading = false;
        AntDesign.Form<OrderInfo> form;
        private PersonalInfo personalInfo;
        protected override void OnInitialized()
        {
            base.OnInitialized();
            personalInfo = GetPersonInfo(order.Id_user);

        }
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
        private PersonalInfo GetPersonInfo(string id)
        {
            return new PersonalInfo();
        }
    }
}
