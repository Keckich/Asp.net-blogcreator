#pragma checksum "/home/nikita/RiderProjects/WebApplication3/WebApplication3/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aeab03130b8fc1b1c72bfc04d966f873a0f01363"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/home/nikita/RiderProjects/WebApplication3/WebApplication3/Views/_ViewImports.cshtml"
using WebApplication3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/nikita/RiderProjects/WebApplication3/WebApplication3/Views/_ViewImports.cshtml"
using WebApplication3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aeab03130b8fc1b1c72bfc04d966f873a0f01363", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45cc74ddc7223fb325d65fcc92e383cbef4a02de", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication3.Models.Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/nikita/RiderProjects/WebApplication3/WebApplication3/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "/home/nikita/RiderProjects/WebApplication3/WebApplication3/Views/Home/Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<div class=\"page-wrapper\">\n    <ul class=\"col-md-8\">\n");
#nullable restore
#line 9 "/home/nikita/RiderProjects/WebApplication3/WebApplication3/Views/Home/Index.cshtml"
         foreach (var post in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\n                ");
#nullable restore
#line 12 "/home/nikita/RiderProjects/WebApplication3/WebApplication3/Views/Home/Index.cshtml"
           Write(Html.Partial("PostPartial", post));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </li>\n");
#nullable restore
#line 14 "/home/nikita/RiderProjects/WebApplication3/WebApplication3/Views/Home/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\n    <div class=\"right-panel-wrapper\">\n        <div class=\"right-panel\">\n            ");
#nullable restore
#line 18 "/home/nikita/RiderProjects/WebApplication3/WebApplication3/Views/Home/Index.cshtml"
       Write(await Component.InvokeAsync("LastPosts", new {howMany = 2}));

#line default
#line hidden
#nullable disable
            WriteLiteral("        \n        </div>\n    </div>  \n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication3.Models.Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
