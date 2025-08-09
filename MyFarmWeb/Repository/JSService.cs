using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MyFarmWeb.Repository.Base;

namespace MyFarmWeb.Repository
{
    public class JSService : IService
    {
        public IJSRuntime JSRuntime { get; set; }

        public async ValueTask setdisable(Func<ElementReference> elementreference)
        {
            await JSRuntime.InvokeVoidAsync("setdisable", elementreference());
        }

        public async ValueTask setenable(Func<ElementReference> elementreference)
        {
            await JSRuntime.InvokeVoidAsync("setenable", elementreference());
        }

        public async ValueTask setfocus(Func<ElementReference> elementreference)
        {
            await JSRuntime.InvokeVoidAsync("setfocus", elementreference());

        }

        public async ValueTask setfocusbyid(Func<string> elementId)
        {
            await JSRuntime.InvokeVoidAsync("setfocusbyid", elementId());
        }
        public async ValueTask setfocusbyidtofirstchild(Func<string> elementId)
        {
            await JSRuntime.InvokeVoidAsync("setfocusbyidtofirstchild", elementId());
        }

        public async ValueTask SelectAllText(Func<string> elementId)
        {
            await JSRuntime.InvokeVoidAsync("selectAllText", elementId());
        }

        public async ValueTask SelectAllTextToFisrtChild(Func<string> elementId)
        {
            await JSRuntime.InvokeVoidAsync("selectAllTextToFirstChild", elementId());
        }

        public async ValueTask setreadOnly(Func<ElementReference> elementreference)
        {
            await JSRuntime.InvokeVoidAsync("setreadonly", elementreference());
        }

        public async ValueTask setWrite(Func<ElementReference> elementreference)
        {
            await JSRuntime.InvokeVoidAsync("setwrite", elementreference());
        }

    }
}
