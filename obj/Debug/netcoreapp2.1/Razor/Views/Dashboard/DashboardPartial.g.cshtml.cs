#pragma checksum "D:\CodingDojo\csharp\DotNetflix\Views\Dashboard\DashboardPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3acebb31388976435a6052f958694a1da80323c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_DashboardPartial), @"mvc.1.0.view", @"/Views/Dashboard/DashboardPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/DashboardPartial.cshtml", typeof(AspNetCore.Views_Dashboard_DashboardPartial))]
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
#line 1 "D:\CodingDojo\csharp\DotNetflix\Views\_ViewImports.cshtml"
using LoginReg;

#line default
#line hidden
#line 2 "D:\CodingDojo\csharp\DotNetflix\Views\_ViewImports.cshtml"
using LoginReg.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3acebb31388976435a6052f958694a1da80323c", @"/Views/Dashboard/DashboardPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32cffb413b3ff31940133525c56529196ca370a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_DashboardPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 38, true);
            WriteLiteral("<h1>CodingDojo Wall</h1>\r\n<p>Welcome, ");
            EndContext();
            BeginContext(39, 22, false);
#line 2 "D:\CodingDojo\csharp\DotNetflix\Views\Dashboard\DashboardPartial.cshtml"
       Write(ViewBag.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(61, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(63, 21, false);
#line 2 "D:\CodingDojo\csharp\DotNetflix\Views\Dashboard\DashboardPartial.cshtml"
                               Write(ViewBag.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(84, 81, true);
            WriteLiteral("</p>\r\n<a href = \"/dashboard\">Dashboard</a> | <a href=\"/logout\">Logout</a><br><br>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591