using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace MyFarmWeb.Repository.Base
{
    public interface IService
    {
        public IJSRuntime JSRuntime { get; set; }
        ValueTask setfocus(Func<ElementReference> elementreference);



        ValueTask setfocusbyid(Func<string> elementId);
        ValueTask setfocusbyidtofirstchild(Func<string> elementId);
        ValueTask SelectAllText(Func<string> elementId);
        ValueTask SelectAllTextToFisrtChild(Func<string> elementId);



        ValueTask setreadOnly(Func<ElementReference> elementreferenc);
        ValueTask setWrite(Func<ElementReference> elementreference);
        ValueTask setdisable(Func<ElementReference> elementreference);
        ValueTask setenable(Func<ElementReference> elementreference);
    }
}
