#pragma checksum "C:\Users\Manuel Rodas\source\repos\blazor-whatsapp\QueOndas APP\QueOndas APP\Shared\Estado.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a668982faa1be61c7833ee950138a59b47b6d0b"
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
    public partial class Estado : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row ShortCutChat ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-3 ShortCutChatImgContainerStatus");
            __builder.OpenElement(4, "img");
            __builder.AddAttribute(5, "class", "ProfilePicture");
            __builder.AddAttribute(6, "src", 
#nullable restore
#line 3 "C:\Users\Manuel Rodas\source\repos\blazor-whatsapp\QueOndas APP\QueOndas APP\Shared\Estado.razor"
                                          Value.B64Photo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-9");
            __builder.AddAttribute(10, "style", "margin-top:5px");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-7 User");
            __builder.AddContent(15, 
#nullable restore
#line 8 "C:\Users\Manuel Rodas\source\repos\blazor-whatsapp\QueOndas APP\QueOndas APP\Shared\Estado.razor"
                 Value.ContactName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "row");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-11 Message");
            __builder.AddContent(21, 
#nullable restore
#line 13 "C:\Users\Manuel Rodas\source\repos\blazor-whatsapp\QueOndas APP\QueOndas APP\Shared\Estado.razor"
                 Value.StatusDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\Manuel Rodas\source\repos\blazor-whatsapp\QueOndas APP\QueOndas APP\Shared\Estado.razor"
       
    [Parameter]
    public EstadoGeneralEntity Value { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
