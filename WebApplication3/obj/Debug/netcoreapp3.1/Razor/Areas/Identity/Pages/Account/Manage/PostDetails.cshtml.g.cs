#pragma checksum "D:\RiderProjects\WebApplication3\WebApplication3\Areas\Identity\Pages\Account\Manage\PostDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "430cde90e85de48ee4a057ffdd3adae4117660fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Manage_PostDetails), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Manage/PostDetails.cshtml")]
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
#line 2 "D:\RiderProjects\WebApplication3\WebApplication3\Areas\Identity\Pages\_ViewImports.cshtml"
using WebApplication3.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\RiderProjects\WebApplication3\WebApplication3\Areas\Identity\Pages\_ViewImports.cshtml"
using WebApplication3.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\RiderProjects\WebApplication3\WebApplication3\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using WebApplication3.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\RiderProjects\WebApplication3\WebApplication3\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using WebApplication3.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\RiderProjects\WebApplication3\WebApplication3\Areas\Identity\Pages\Account\Manage\PostDetails.cshtml"
using WebApplication3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\RiderProjects\WebApplication3\WebApplication3\Areas\Identity\Pages\Account\Manage\PostDetails.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"430cde90e85de48ee4a057ffdd3adae4117660fd", @"/Areas/Identity/Pages/Account/Manage/PostDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02f8e8a47bd065edae4762abfccd00ac6ee7a6a7", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07db3dc63ff3d2a71c68a0814a0e5a5d633f32b8", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54bc7660d200bb21093865dbcf379f20fc31be2b", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage_PostDetails : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("min-width: 600px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"page-wrapper\">\r\n    <ul class=\"col-md-8\">\r\n");
            WriteLiteral("        <div class=\"page-wrapper\">\r\n            <div class=\"left-panel-wrapper\">\r\n                <div class=\"left-panel\" style=\"min-width: 200px\">\r\n                    <p>\r\n");
#nullable restore
#line 17 "D:\RiderProjects\WebApplication3\WebApplication3\Areas\Identity\Pages\Account\Manage\PostDetails.cshtml"
                         if (UserManager.FindByNameAsync(Model.PostDetails.Author).Result.ProfilePicture != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img style=\"width:40px; height:40px; object-fit:cover; border-radius:30px\"");
            BeginWriteAttribute("src", " src=\"", 761, "\"", 889, 2);
            WriteAttributeValue("", 767, "data:image/*;base64,", 767, 20, true);
#nullable restore
#line 19 "D:\RiderProjects\WebApplication3\WebApplication3\Areas\Identity\Pages\Account\Manage\PostDetails.cshtml"
WriteAttributeValue("", 787, Convert.ToBase64String(UserManager.FindByNameAsync(Model.PostDetails.Author).Result.ProfilePicture), 787, 102, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 20 "D:\RiderProjects\WebApplication3\WebApplication3\Areas\Identity\Pages\Account\Manage\PostDetails.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </p>\r\n                    <p>");
#nullable restore
#line 22 "D:\RiderProjects\WebApplication3\WebApplication3\Areas\Identity\Pages\Account\Manage\PostDetails.cshtml"
                  Write(Model.PostDetails.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>");
#nullable restore
#line 23 "D:\RiderProjects\WebApplication3\WebApplication3\Areas\Identity\Pages\Account\Manage\PostDetails.cshtml"
                  Write(Model.PostDetails.PostedOn.ToString("dd MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
                <hr />
            </div>
            <div class=""content-wrapper"" style=""padding: 30px"">
                <div class=""content"">
                    <div class=""input-group"">
                        <h4>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "430cde90e85de48ee4a057ffdd3adae4117660fd8847", async() => {
                WriteLiteral("\r\n                                ");
#nullable restore
#line 32 "D:\RiderProjects\WebApplication3\WebApplication3\Areas\Identity\Pages\Account\Manage\PostDetails.cshtml"
                           Write(Model.PostDetails.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "D:\RiderProjects\WebApplication3\WebApplication3\Areas\Identity\Pages\Account\Manage\PostDetails.cshtml"
                                                                            WriteLiteral(Model.PostDetails.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </h4>\r\n                    </div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "430cde90e85de48ee4a057ffdd3adae4117660fd11701", async() => {
                WriteLiteral("\r\n                    <p>");
#nullable restore
#line 37 "D:\RiderProjects\WebApplication3\WebApplication3\Areas\Identity\Pages\Account\Manage\PostDetails.cshtml"
                  Write(Model.PostDetails.ShortDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 36 "D:\RiderProjects\WebApplication3\WebApplication3\Areas\Identity\Pages\Account\Manage\PostDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PostDetails.ShortDescription);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <hr style=\"min-width: 710px\"/>\r\n        <div style=\"min-width: 710px\">\r\n            <p>");
#nullable restore
#line 44 "D:\RiderProjects\WebApplication3\WebApplication3\Areas\Identity\Pages\Account\Manage\PostDetails.cshtml"
          Write(Html.Raw(Model.PostDetails.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        \r\n    </ul>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication3.Areas.Identity.Pages.Account.Manage.PostDetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication3.Areas.Identity.Pages.Account.Manage.PostDetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication3.Areas.Identity.Pages.Account.Manage.PostDetailsModel>)PageContext?.ViewData;
        public WebApplication3.Areas.Identity.Pages.Account.Manage.PostDetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
