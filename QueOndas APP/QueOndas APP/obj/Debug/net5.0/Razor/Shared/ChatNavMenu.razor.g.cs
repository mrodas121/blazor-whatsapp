#pragma checksum "C:\Users\Manuel Rodas\source\repos\blazor-whatsapp\QueOndas APP\QueOndas APP\Shared\ChatNavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "449adaf285fa1936285caae31f3c10784b8a78a6"
// <auto-generated/>
#pragma warning disable 1591
namespace QueOndas_APP.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Manuel Rodas\source\repos\blazor-whatsapp\QueOndas APP\QueOndas APP\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Manuel Rodas\source\repos\blazor-whatsapp\QueOndas APP\QueOndas APP\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Manuel Rodas\source\repos\blazor-whatsapp\QueOndas APP\QueOndas APP\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Manuel Rodas\source\repos\blazor-whatsapp\QueOndas APP\QueOndas APP\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Manuel Rodas\source\repos\blazor-whatsapp\QueOndas APP\QueOndas APP\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Manuel Rodas\source\repos\blazor-whatsapp\QueOndas APP\QueOndas APP\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Manuel Rodas\source\repos\blazor-whatsapp\QueOndas APP\QueOndas APP\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Manuel Rodas\source\repos\blazor-whatsapp\QueOndas APP\QueOndas APP\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Manuel Rodas\source\repos\blazor-whatsapp\QueOndas APP\QueOndas APP\_Imports.razor"
using QueOndas_APP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Manuel Rodas\source\repos\blazor-whatsapp\QueOndas APP\QueOndas APP\_Imports.razor"
using QueOndas_APP.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Manuel Rodas\source\repos\blazor-whatsapp\QueOndas APP\QueOndas APP\_Imports.razor"
using Models.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Manuel Rodas\source\repos\blazor-whatsapp\QueOndas APP\QueOndas APP\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Manuel Rodas\source\repos\blazor-whatsapp\QueOndas APP\QueOndas APP\_Imports.razor"
using Data.Servicios;

#line default
#line hidden
#nullable disable
    public partial class ChatNavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "NavBarFixedChat");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row NavBarFixedChatContainer");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-2");
            __builder.AddAttribute(6, "style", "margin-left: 18px;");
            __builder.OpenElement(7, "img");
            __builder.AddAttribute(8, "src", "/img/backIcon.PNG");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\Manuel Rodas\source\repos\blazor-whatsapp\QueOndas APP\QueOndas APP\Shared\ChatNavMenu.razor"
                                                   () => ReturnIndex()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n            <img class=\"ProfilePictureChat\" src=\"/img/pictures/5.jpg\">");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.AddMarkupContent(12, "<div class=\"col-5\" style=\"margin-left: 8px;\">\r\n            Alejandro Bonilla\r\n            <br>\r\n            <a>en linea</a></div>\r\n        ");
            __builder.AddMarkupContent(13, "<div class=\"align-self-end\" style=\"margin-left: 8px;margin-bottom: 5px;\"><img src=\"/img/videoCallIco.PNG\">\r\n            <img src=\"/img/callNavBarIco.PNG\">\r\n            <img src=\"/img/3dotsChatIco.PNG\"></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\Manuel Rodas\source\repos\blazor-whatsapp\QueOndas APP\QueOndas APP\Shared\ChatNavMenu.razor"
       
    protected override async Task OnInitializedAsync()
    {
        AppState.hide(true);
    }
    public void ReturnIndex()
    {
        AppState.hide(false);
        NavManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppState AppState { get; set; }
    }
}
#pragma warning restore 1591
