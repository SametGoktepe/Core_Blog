#pragma checksum "C:\Users\samet\Desktop\MVC\Core_Blog\Views\Shared\Components\BlogLast3Post\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05671dc2046706cecd38fcd288d3814bd1a5e4bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogLast3Post_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
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
#line 1 "C:\Users\samet\Desktop\MVC\Core_Blog\Views\_ViewImports.cshtml"
using Core_Blog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\samet\Desktop\MVC\Core_Blog\Views\_ViewImports.cshtml"
using Core_Blog.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\samet\Desktop\MVC\Core_Blog\Views\Shared\Components\BlogLast3Post\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05671dc2046706cecd38fcd288d3814bd1a5e4bf", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c65cd9c55936d1c7da1298b70d67b494b25eac2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BlogLast3Post_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"tech-btm\">\r\n    <h3>Latest Posts</h3>\r\n");
#nullable restore
#line 5 "C:\Users\samet\Desktop\MVC\Core_Blog\Views\Shared\Components\BlogLast3Post\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"blog-grids row mb-3\">\r\n\r\n            <div class=\"col-md-5 blog-grid-left\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 254, "\"", 291, 2);
            WriteAttributeValue("", 261, "/Blog/BlogReadAll/", 261, 18, true);
#nullable restore
#line 10 "C:\Users\samet\Desktop\MVC\Core_Blog\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 279, item.BlogID, 279, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 319, "\"", 336, 1);
#nullable restore
#line 11 "C:\Users\samet\Desktop\MVC\Core_Blog\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 325, item.Image, 325, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 355, "\"", 361, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n            </div>\r\n            <div class=\"col-md-7 blog-grid-right\">\r\n                <h5>\r\n                    <a href=\"single.html\">");
#nullable restore
#line 16 "C:\Users\samet\Desktop\MVC\Core_Blog\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                     Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                </h5>\r\n                <div class=\"sub-meta\">\r\n                    <span>\r\n                        <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 20 "C:\Users\samet\Desktop\MVC\Core_Blog\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                                 Write(((DateTime)item.CreateDate).ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 25 "C:\Users\samet\Desktop\MVC\Core_Blog\Views\Shared\Components\BlogLast3Post\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591