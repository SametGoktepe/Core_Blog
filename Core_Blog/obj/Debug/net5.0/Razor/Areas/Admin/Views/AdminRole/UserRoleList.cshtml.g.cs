#pragma checksum "C:\Users\samet\Desktop\MVC\Core_Blog\Areas\Admin\Views\AdminRole\UserRoleList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaea9d9e93e3ad18d4c31f6eb73c095ff977af5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminRole_UserRoleList), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminRole/UserRoleList.cshtml")]
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
#line 1 "C:\Users\samet\Desktop\MVC\Core_Blog\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaea9d9e93e3ad18d4c31f6eb73c095ff977af5f", @"/Areas/Admin/Views/AdminRole/UserRoleList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51a8475087d8f7ccc675f88a02216c5813fdd8b8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminRole_UserRoleList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\samet\Desktop\MVC\Core_Blog\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
  
    ViewData["Title"] = "UserRoleList";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>User Role List</h1>\r\n\r\n<table class=\"table-bordered\">\r\n    <tr>\r\n        <th>User</th>\r\n        <th>Assign Role</th>\r\n    </tr>\r\n");
#nullable restore
#line 15 "C:\Users\samet\Desktop\MVC\Core_Blog\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\samet\Desktop\MVC\Core_Blog\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
           Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 395, "\"", 439, 3);
            WriteAttributeValue("", 402, "/Admin/AdminRole/AssignRole/", 402, 28, true);
#nullable restore
#line 19 "C:\Users\samet\Desktop\MVC\Core_Blog\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
WriteAttributeValue("", 430, item.Id, 430, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 438, "/", 438, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Assing Role</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 21 "C:\Users\samet\Desktop\MVC\Core_Blog\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<br />\r\n<a href=\"/Admin/AdminRole/Index/\" class=\"btn btn-dark\">Return Role List</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
