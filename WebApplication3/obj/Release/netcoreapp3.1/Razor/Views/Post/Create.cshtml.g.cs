#pragma checksum "D:\RiderProjects\WebApplication3\WebApplication3\Views\Post\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dee3092bebc51c54d5a336ec30d84453a2bee01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Create), @"mvc.1.0.view", @"/Views/Post/Create.cshtml")]
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
#line 1 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Post\Create.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dee3092bebc51c54d5a336ec30d84453a2bee01", @"/Views/Post/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab5fb352e176c40c0c0e1655943d056c9ca8ad9c", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication3.Models.Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/signalr.js/jquery.signalR.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/aspnet-signalr/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Post\Create.cshtml"
  
    ViewData["Title"] = @Localizer["MainTitle"];
    var mid = "myModal";
    var tm = "#myModal";


#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 10 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Post\Create.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div id=\"notify\"></div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dee3092bebc51c54d5a336ec30d84453a2bee015299", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dee3092bebc51c54d5a336ec30d84453a2bee016338", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dee3092bebc51c54d5a336ec30d84453a2bee017381", async() => {
                WriteLiteral("\r\n    <fieldset>\r\n        <p>\r\n            <label>");
#nullable restore
#line 19 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Post\Create.cshtml"
              Write(Localizer["Category"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(":</label>\r\n            <select name=\"CategoryId\">\r\n");
#nullable restore
#line 21 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Post\Create.cshtml"
                 foreach (var category in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dee3092bebc51c54d5a336ec30d84453a2bee018262", async() => {
#nullable restore
#line 23 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Post\Create.cshtml"
                                            Write(category.Title);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Post\Create.cshtml"
                       WriteLiteral(category.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 24 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Post\Create.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </select>\r\n        </p>\r\n        <p>\r\n            <label>");
#nullable restore
#line 28 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Post\Create.cshtml"
              Write(Localizer["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(":</label>\r\n            <input id=\"articleHeading\" type=\"text\" name=\"Title\" style=\"min-width: 1070px\" />\r\n        </p>\r\n        <p>\r\n            <label>");
#nullable restore
#line 32 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Post\Create.cshtml"
              Write(Localizer["ShortDescription"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(":</label>\r\n            <input type=\"text\" name=\"ShortDescription\" style=\"min-width: 980px\" />\r\n        </p>\r\n        <p>\r\n            <label>");
#nullable restore
#line 36 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Post\Create.cshtml"
              Write(Localizer["Description"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(":</label>\r\n            <textarea id=\"editor1\" name=\"Description\"></textarea>\r\n            <input type=\"hidden\" name=\"Posted\" value=\"false\" />\r\n\r\n            <button type=\"button\" class=\"btn btn-success\" data-toggle=\"modal\" data-target=\"");
#nullable restore
#line 40 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Post\Create.cshtml"
                                                                                      Write(tm);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n                ");
#nullable restore
#line 41 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Post\Create.cshtml"
           Write(Localizer["Submit"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </button>\r\n            <div class=\"modal fade\"");
                BeginWriteAttribute("id", " id=\"", 1507, "\"", 1516, 1);
#nullable restore
#line 43 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Post\Create.cshtml"
WriteAttributeValue("", 1512, mid, 1512, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
                <div class=""modal-dialog"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h4 class=""modal-title"" id=""myModalLabel"">Submit Post Confirmation</h4>
                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                        </div>
                        <div class=""modal-body"">
                            Are you sure to submit this post? Before it appears on the page it will be validate by administration,
                            this may take up two days.
                        </div>
                        <div class=""modal-footer"">
                            <input type=""submit"" class=""btn btn-success""");
                BeginWriteAttribute("value", " value=", 2392, "", 2419, 1);
#nullable restore
#line 55 "D:\RiderProjects\WebApplication3\WebApplication3\Views\Post\Create.cshtml"
WriteAttributeValue("", 2399, Localizer["Submit"], 2399, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <button type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\">Close</button>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </p>\r\n    </fieldset>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication3.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
