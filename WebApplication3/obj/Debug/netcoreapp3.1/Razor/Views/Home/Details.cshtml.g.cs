#pragma checksum "D:\RiderProjects\WebApplication3\WebApplication3\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3836c0980d0b7c3609a0319502c2f71261f0b32a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Home\Details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Home\Details.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3836c0980d0b7c3609a0319502c2f71261f0b32a", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab5fb352e176c40c0c0e1655943d056c9ca8ad9c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication3.Models.CommentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Home\Details.cshtml"
  
    var midDel = "myModalDel" + Model.Post.Id;
    var tmDel = "#myModalDel" + Model.Post.Id;
    var mid = "myModal" + Model.Post.Id;
    var tm = "#myModal" + Model.Post.Id;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-wrapper\">\r\n    <ul class=\"col-md-8\">\r\n        ");
#nullable restore
#line 15 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Home\Details.cshtml"
   Write(await Html.PartialAsync("_PostPartial", Model.Post));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 16 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Home\Details.cshtml"
         if (UserManager.GetUserAsync(User).Result != null && UserManager.GetUserAsync(User).Result.UserName == Model.Post.Author && !User.IsInRole("Admin") && !User.IsInRole("Moderator"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"input-group-btn\">\r\n                <button class=\"btn btn-danger\" data-toggle=\"modal\" data-target=\"");
#nullable restore
#line 19 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Home\Details.cshtml"
                                                                           Write(tmDel);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 19 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Home\Details.cshtml"
                                                                                   Write(Localizer["Delete"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n            </span>\r\n");
#nullable restore
#line 21 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Home\Details.cshtml"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Home\Details.cshtml"
         if ((User.IsInRole("Admin") || User.IsInRole("Moderator")) && Model.Post.Posted == true)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"input-group-btn\">\r\n                <button class=\"btn btn-danger\" data-toggle=\"modal\" data-target=\"");
#nullable restore
#line 26 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Home\Details.cshtml"
                                                                           Write(tmDel);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 26 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Home\Details.cshtml"
                                                                                   Write(Localizer["Delete"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n            </span>\r\n");
#nullable restore
#line 28 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Home\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3836c0980d0b7c3609a0319502c2f71261f0b32a8064", async() => {
                WriteLiteral("\r\n\r\n            <div class=\"modal fade\"");
                BeginWriteAttribute("id", " id=\"", 1402, "\"", 1414, 1);
#nullable restore
#line 31 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Home\Details.cshtml"
WriteAttributeValue("", 1407, midDel, 1407, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
                <div class=""modal-dialog"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h4 class=""modal-title"" id=""myModalLabel"">Delete Confirmation</h4>
                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                        </div>
                        <div class=""modal-body"">
                            Are you sure want to delete this item?
                        </div>
                        <div class=""modal-footer"">
                            <button class=""btn bg-danger"">Delete</button>
                            <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
                        </div>
                    </div>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Home\Details.cshtml"
                                                                        WriteLiteral(Model.Post.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Home\Details.cshtml"
                                                                                                          WriteLiteral(Model.Post.Author);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["author"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-author", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["author"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <hr />\r\n        <p>");
#nullable restore
#line 50 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Home\Details.cshtml"
      Write(Html.Raw(Model.Post.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </ul>\r\n    <div class=\"right-panel-wrapper\">\r\n        <div class=\"right-panel\">\r\n            ");
#nullable restore
#line 54 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Home\Details.cshtml"
       Write(await Component.InvokeAsync("LastPosts", new { howMany = 2 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<h2>");
#nullable restore
#line 59 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Home\Details.cshtml"
Write(Localizer["Comments"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<div class=\"col-md-4\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3836c0980d0b7c3609a0319502c2f71261f0b32a14105", async() => {
                WriteLiteral("\r\n            <p>\r\n                <input type=\"text\" name=\"CContent\">\r\n                <input type=\"hidden\" name=\"PostId\"");
                BeginWriteAttribute("value", " value=\"", 2943, "\"", 2965, 1);
#nullable restore
#line 65 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Home\Details.cshtml"
WriteAttributeValue("", 2951, Model.Post.Id, 2951, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            </p>\r\n                <button type=\"button\" class=\"btn btn-success\" data-toggle=\"modal\" data-target=\"");
#nullable restore
#line 67 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Home\Details.cshtml"
                                                                                          Write(tm);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n                    Submit\r\n                </button>\r\n                <div class=\"modal fade\"");
                BeginWriteAttribute("id", " id=\"", 3183, "\"", 3192, 1);
#nullable restore
#line 70 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Home\Details.cshtml"
WriteAttributeValue("", 3188, mid, 3188, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
                    <div class=""modal-dialog"">
                        <div class=""modal-content"">
                            <div class=""modal-header"">
                                <h4 class=""modal-title"" id=""myModalLabel"">Submit Comment Confirmation</h4>
                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                            </div>
                            <div class=""modal-body"">
                                Are you sure to post this comment? Before it appears on the page it will be validate by administration,
                                this may take up two days.
                            </div>
                            <div class=""modal-footer"">
                                <input type=""submit"" class=""btn btn-success"" value=""Submit"">
                                <button type=""button"" class=""btn btn-default"" d");
                WriteLiteral("ata-dismiss=\"modal\">Close</button>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            \r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"row justify-content-center\" id=\"comments\">\r\n        ");
#nullable restore
#line 92 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Home\Details.cshtml"
   Write(await Html.PartialAsync("~/Views/Home/CommentList.cshtml", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
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
