#pragma checksum "C:\Users\Manuel Rodas\source\repos\blazor-whatsapp\QueOndas APP\QueOndas APP\Shared\ContentNavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49b291a7181f95994256896a606e2999dc656c71"
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
    public partial class ContentNavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "SecondNavBarFixedCostum");
            __builder.AddAttribute(2, "b-44u9b9ywde");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddAttribute(5, "b-44u9b9ywde");
            __builder.AddMarkupContent(6, "<div class=\"col-2 offset-1\" b-44u9b9ywde><a b-44u9b9ywde><img src=\"/img/camera.PNG\" b-44u9b9ywde></a>\r\n                <div class=\"divAlertIcon\" b-44u9b9ywde></div></div>\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-2");
            __builder.AddAttribute(9, "b-44u9b9ywde");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(10);
            __builder.AddAttribute(11, "href", "");
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(13, "<a b-44u9b9ywde>CHATS</a>\r\n                    <div class=\"divAlert\" b-44u9b9ywde></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col-3");
            __builder.AddAttribute(17, "b-44u9b9ywde");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(18);
            __builder.AddAttribute(19, "href", "estados");
            __builder.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(21, "<a b-44u9b9ywde>ESTADOS</a>\r\n                    <div class=\"divAlert\" b-44u9b9ywde></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "col-3");
            __builder.AddAttribute(25, "b-44u9b9ywde");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(26);
            __builder.AddAttribute(27, "href", "llamadas");
            __builder.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(29, "<a b-44u9b9ywde>LLAMADAS</a>\r\n                    <div class=\"divAlert\" b-44u9b9ywde></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
