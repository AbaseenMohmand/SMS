#pragma checksum "C:\Users\Abbasin\source\repos\SchoolManagementSystem2\SchoolManagementSystem2\Views\Month\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58daf4f88b6a72653a96b71ea4709dbfd2f3fb30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Month_Index), @"mvc.1.0.view", @"/Views/Month/Index.cshtml")]
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
#line 1 "C:\Users\Abbasin\source\repos\SchoolManagementSystem2\SchoolManagementSystem2\Views\_ViewImports.cshtml"
using SchoolManagementSystem2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abbasin\source\repos\SchoolManagementSystem2\SchoolManagementSystem2\Views\_ViewImports.cshtml"
using SchoolManagementSystem2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abbasin\source\repos\SchoolManagementSystem2\SchoolManagementSystem2\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58daf4f88b6a72653a96b71ea4709dbfd2f3fb30", @"/Views/Month/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5d40e2b66e7d55d685aa78b22a031e263c60a33", @"/Views/_ViewImports.cshtml")]
    public class Views_Month_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SchoolManagementSystem2.ViewModels.MonthViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Abbasin\source\repos\SchoolManagementSystem2\SchoolManagementSystem2\Views\Month\Index.cshtml"
  
    ViewData["Title"] = "Month Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Months List</h1>\r\n\r\n<p>\r\n\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Abbasin\source\repos\SchoolManagementSystem2\SchoolManagementSystem2\Views\Month\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n          \r\n            \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 24 "C:\Users\Abbasin\source\repos\SchoolManagementSystem2\SchoolManagementSystem2\Views\Month\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 28 "C:\Users\Abbasin\source\repos\SchoolManagementSystem2\SchoolManagementSystem2\Views\Month\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n               \r\n\r\n                \r\n            </tr>\r\n");
#nullable restore
#line 34 "C:\Users\Abbasin\source\repos\SchoolManagementSystem2\SchoolManagementSystem2\Views\Month\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SchoolManagementSystem2.ViewModels.MonthViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591