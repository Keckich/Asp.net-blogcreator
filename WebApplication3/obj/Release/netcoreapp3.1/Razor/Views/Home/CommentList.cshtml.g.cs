#pragma checksum "D:\RiderProjects\WebApplication3\WebApplication3\Views\Home\CommentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd82415899bf673082a18499ce8e43b2a9418b3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CommentList), @"mvc.1.0.view", @"/Views/Home/CommentList.cshtml")]
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
#line 1 "D:\RiderProjects\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\RiderProjects\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\RiderProjects\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd82415899bf673082a18499ce8e43b2a9418b3c", @"/Views/Home/CommentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab5fb352e176c40c0c0e1655943d056c9ca8ad9c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CommentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication3.Models.CommentViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"listing\" id=\"commentList\">\r\n");
#nullable restore
#line 5 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Home\CommentList.cshtml"
     foreach (var comment in Model.Comments)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Home\CommentList.cshtml"
         if (comment.CommentPosted == true && comment.PostId == Model.Post.Id)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <lu>\r\n                ");
#nullable restore
#line 10 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Home\CommentList.cshtml"
           Write(await Html.PartialAsync("_CommentPartial", comment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </lu>\r\n");
#nullable restore
#line 12 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Home\CommentList.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Home\CommentList.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication3.Models.CommentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
