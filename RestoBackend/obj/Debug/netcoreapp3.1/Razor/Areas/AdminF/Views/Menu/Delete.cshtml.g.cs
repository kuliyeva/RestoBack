#pragma checksum "C:\Users\TOSHIBA\Desktop\RestoBackend\RestoBackend\Areas\AdminF\Views\Menu\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "163841ff83a9aebba0c9af4ee0a70d3bac748f42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminF_Views_Menu_Delete), @"mvc.1.0.view", @"/Areas/AdminF/Views/Menu/Delete.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\TOSHIBA\Desktop\RestoBackend\RestoBackend\Areas\AdminF\Views\_ViewImports.cshtml"
using RestoBackend.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TOSHIBA\Desktop\RestoBackend\RestoBackend\Areas\AdminF\Views\_ViewImports.cshtml"
using RestoBackend.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"163841ff83a9aebba0c9af4ee0a70d3bac748f42", @"/Areas/AdminF/Views/Menu/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60270a5a874ffa90f274f8662e404b05e1d75577", @"/Areas/AdminF/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_AdminF_Views_Menu_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Menu>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\TOSHIBA\Desktop\RestoBackend\RestoBackend\Areas\AdminF\Views\Menu\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Areas/AdminF/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h5>");
#nullable restore
#line 7 "C:\Users\TOSHIBA\Desktop\RestoBackend\RestoBackend\Areas\AdminF\Views\Menu\Delete.cshtml"
Write(Model.Image);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n<h5>");
#nullable restore
#line 8 "C:\Users\TOSHIBA\Desktop\RestoBackend\RestoBackend\Areas\AdminF\Views\Menu\Delete.cshtml"
Write(Model.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n<h5>");
#nullable restore
#line 9 "C:\Users\TOSHIBA\Desktop\RestoBackend\RestoBackend\Areas\AdminF\Views\Menu\Delete.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n<h5>");
#nullable restore
#line 10 "C:\Users\TOSHIBA\Desktop\RestoBackend\RestoBackend\Areas\AdminF\Views\Menu\Delete.cshtml"
Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Menu> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
