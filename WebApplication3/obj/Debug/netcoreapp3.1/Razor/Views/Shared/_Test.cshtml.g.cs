#pragma checksum "C:\Users\Administrator\Source\Repos\Keckich\Asp.net-blogcreator\WebApplication3\Views\Shared\_Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e3c3c7fca744b9bca806deeaca49f7a543ec0c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Test), @"mvc.1.0.view", @"/Views/Shared/_Test.cshtml")]
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
#line 1 "C:\Users\Administrator\Source\Repos\Keckich\Asp.net-blogcreator\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Source\Repos\Keckich\Asp.net-blogcreator\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Source\Repos\Keckich\Asp.net-blogcreator\WebApplication3\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e3c3c7fca744b9bca806deeaca49f7a543ec0c2", @"/Views/Shared/_Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab5fb352e176c40c0c0e1655943d056c9ca8ad9c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication3.Models.CategoryViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Administrator\Source\Repos\Keckich\Asp.net-blogcreator\WebApplication3\Views\Shared\_Test.cshtml"
 foreach (var post in Model.Posts)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\Source\Repos\Keckich\Asp.net-blogcreator\WebApplication3\Views\Shared\_Test.cshtml"
     if (post.Posted != false)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            ");
#nullable restore
#line 8 "C:\Users\Administrator\Source\Repos\Keckich\Asp.net-blogcreator\WebApplication3\Views\Shared\_Test.cshtml"
       Write(await Html.PartialAsync("_PostPartial", post));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n");
#nullable restore
#line 10 "C:\Users\Administrator\Source\Repos\Keckich\Asp.net-blogcreator\WebApplication3\Views\Shared\_Test.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrator\Source\Repos\Keckich\Asp.net-blogcreator\WebApplication3\Views\Shared\_Test.cshtml"
     

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication3.Models.CategoryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591