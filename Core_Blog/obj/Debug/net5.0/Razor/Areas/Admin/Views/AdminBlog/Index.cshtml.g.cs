#pragma checksum "C:\Users\samet\Desktop\MVC\Core_Blog\Areas\Admin\Views\AdminBlog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53ed1e24c82664ce66b13c7f40dfc149f331e981"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminBlog_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminBlog/Index.cshtml")]
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
#line 1 "C:\Users\samet\Desktop\MVC\Core_Blog\Areas\Admin\Views\_ViewImports.cshtml"
using Core_Blog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\samet\Desktop\MVC\Core_Blog\Areas\Admin\Views\_ViewImports.cshtml"
using Core_Blog.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\samet\Desktop\MVC\Core_Blog\Areas\Admin\Views\_ViewImports.cshtml"
using Core_Blog.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\samet\Desktop\MVC\Core_Blog\Areas\Admin\Views\AdminBlog\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53ed1e24c82664ce66b13c7f40dfc149f331e981", @"/Areas/Admin/Views/AdminBlog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51a8475087d8f7ccc675f88a02216c5813fdd8b8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminBlog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\samet\Desktop\MVC\Core_Blog\Areas\Admin\Views\AdminBlog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53ed1e24c82664ce66b13c7f40dfc149f331e9813800", async() => {
                WriteLiteral("\r\n    <div class=\"wrapper wrapper-content animated fadeInRight\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 13 "C:\Users\samet\Desktop\MVC\Core_Blog\Areas\Admin\Views\AdminBlog\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"col-md-3\">\r\n                    <div class=\"ibox\">\r\n                        <div class=\"ibox-content product-box\">\r\n                            <div class=\"product-imitation\">\r\n                               <img");
                BeginWriteAttribute("src", " src=\"", 563, "\"", 580, 1);
#nullable restore
#line 19 "C:\Users\samet\Desktop\MVC\Core_Blog\Areas\Admin\Views\AdminBlog\Index.cshtml"
WriteAttributeValue("", 569, item.Image, 569, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"240\" height=\"225\" />\r\n                            </div>\r\n                            <div class=\"product-desc\">\r\n                                <span class=\"product-price\">\r\n                                    ");
#nullable restore
#line 23 "C:\Users\samet\Desktop\MVC\Core_Blog\Areas\Admin\Views\AdminBlog\Index.cshtml"
                                Write(((DateTime)item.CreateDate).ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </span>\r\n                                <small class=\"text-muted\">");
#nullable restore
#line 25 "C:\Users\samet\Desktop\MVC\Core_Blog\Areas\Admin\Views\AdminBlog\Index.cshtml"
                                                     Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\r\n                                <a href=\"#\" class=\"product-name\"> ");
#nullable restore
#line 26 "C:\Users\samet\Desktop\MVC\Core_Blog\Areas\Admin\Views\AdminBlog\Index.cshtml"
                                                             Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                                <div class=\"m-t text-righ\">\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 1178, "\"", 1215, 2);
                WriteAttributeValue("", 1185, "/Blog/BlogReadAll/", 1185, 18, true);
#nullable restore
#line 28 "C:\Users\samet\Desktop\MVC\Core_Blog\Areas\Admin\Views\AdminBlog\Index.cshtml"
WriteAttributeValue("", 1203, item.BlogID, 1203, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-xs btn-outline btn-primary"">Details<i class=""fa fa-long-arrow-right""></i> </a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 34 "C:\Users\samet\Desktop\MVC\Core_Blog\Areas\Admin\Views\AdminBlog\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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