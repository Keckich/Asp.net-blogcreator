#pragma checksum "C:\Users\Administrator\Source\Repos\Keckich\Asp.net-blogcreator\WebApplication3\Areas\Identity\Pages\Account\Manage\PostEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39b107a6f580bf4d4515934177f10aa8a177fed1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Manage_PostEdit), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Manage/PostEdit.cshtml")]
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
#line 1 "C:\Users\Administrator\Source\Repos\Keckich\Asp.net-blogcreator\WebApplication3\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Source\Repos\Keckich\Asp.net-blogcreator\WebApplication3\Areas\Identity\Pages\_ViewImports.cshtml"
using WebApplication3.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Source\Repos\Keckich\Asp.net-blogcreator\WebApplication3\Areas\Identity\Pages\_ViewImports.cshtml"
using WebApplication3.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Administrator\Source\Repos\Keckich\Asp.net-blogcreator\WebApplication3\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using WebApplication3.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Administrator\Source\Repos\Keckich\Asp.net-blogcreator\WebApplication3\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using WebApplication3.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39b107a6f580bf4d4515934177f10aa8a177fed1", @"/Areas/Identity/Pages/Account/Manage/PostEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02f8e8a47bd065edae4762abfccd00ac6ee7a6a7", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07db3dc63ff3d2a71c68a0814a0e5a5d633f32b8", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54bc7660d200bb21093865dbcf379f20fc31be2b", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage_PostEdit : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("disabled", new global::Microsoft.AspNetCore.Html.HtmlString("disabled"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39b107a6f580bf4d4515934177f10aa8a177fed15797", async() => {
                WriteLiteral("\r\n    <fieldset>\r\n        <p>\r\n            <label>Category:</label>\r\n            <select name=\"CategoryId\">\r\n");
#nullable restore
#line 11 "C:\Users\Administrator\Source\Repos\Keckich\Asp.net-blogcreator\WebApplication3\Areas\Identity\Pages\Account\Manage\PostEdit.cshtml"
                 foreach (var category in Model.PostEdit.Categories)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Administrator\Source\Repos\Keckich\Asp.net-blogcreator\WebApplication3\Areas\Identity\Pages\Account\Manage\PostEdit.cshtml"
                     if (category.Id == Model.PostEdit.Post.CategoryId)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39b107a6f580bf4d4515934177f10aa8a177fed16864", async() => {
#nullable restore
#line 15 "C:\Users\Administrator\Source\Repos\Keckich\Asp.net-blogcreator\WebApplication3\Areas\Identity\Pages\Account\Manage\PostEdit.cshtml"
                                                                                        Write(category.Title);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\Users\Administrator\Source\Repos\Keckich\Asp.net-blogcreator\WebApplication3\Areas\Identity\Pages\Account\Manage\PostEdit.cshtml"
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
#line 16 "C:\Users\Administrator\Source\Repos\Keckich\Asp.net-blogcreator\WebApplication3\Areas\Identity\Pages\Account\Manage\PostEdit.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39b107a6f580bf4d4515934177f10aa8a177fed19442", async() => {
#nullable restore
#line 19 "C:\Users\Administrator\Source\Repos\Keckich\Asp.net-blogcreator\WebApplication3\Areas\Identity\Pages\Account\Manage\PostEdit.cshtml"
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
#line 19 "C:\Users\Administrator\Source\Repos\Keckich\Asp.net-blogcreator\WebApplication3\Areas\Identity\Pages\Account\Manage\PostEdit.cshtml"
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
#line 20 "C:\Users\Administrator\Source\Repos\Keckich\Asp.net-blogcreator\WebApplication3\Areas\Identity\Pages\Account\Manage\PostEdit.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Administrator\Source\Repos\Keckich\Asp.net-blogcreator\WebApplication3\Areas\Identity\Pages\Account\Manage\PostEdit.cshtml"
                     

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </select>\r\n        </p>\r\n        <p>\r\n            <label>Title:</label>\r\n            <input type=\"text\" name=\"Title\"");
                BeginWriteAttribute("value", " value=\"", 846, "\"", 880, 1);
#nullable restore
#line 27 "C:\Users\Administrator\Source\Repos\Keckich\Asp.net-blogcreator\WebApplication3\Areas\Identity\Pages\Account\Manage\PostEdit.cshtml"
WriteAttributeValue("", 854, Model.PostEdit.Post.Title, 854, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"min-width: 780px\" />\r\n        </p>\r\n        <p>\r\n            <label>Short description:</label>\r\n            <input type=\"text\" name=\"ShortDescription\"");
                BeginWriteAttribute("value", " value=\"", 1039, "\"", 1084, 1);
#nullable restore
#line 31 "C:\Users\Administrator\Source\Repos\Keckich\Asp.net-blogcreator\WebApplication3\Areas\Identity\Pages\Account\Manage\PostEdit.cshtml"
WriteAttributeValue("", 1047, Model.PostEdit.Post.ShortDescription, 1047, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"min-width: 690px\" />\r\n        </p>\r\n        <p>\r\n            <label>Description:</label>\r\n            <textarea id=\"editor1\" name=\"Description\">");
#nullable restore
#line 35 "C:\Users\Administrator\Source\Repos\Keckich\Asp.net-blogcreator\WebApplication3\Areas\Identity\Pages\Account\Manage\PostEdit.cshtml"
                                                 Write(Model.PostEdit.Post.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n            <input type=\"hidden\" name=\"Posted\" value=\"false\" />\r\n            <input type=\"submit\" value=\"Edit\">\r\n        </p>\r\n        \r\n    </fieldset>\r\n");
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication3.Areas.Identity.Pages.Account.Manage.PostEditModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication3.Areas.Identity.Pages.Account.Manage.PostEditModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication3.Areas.Identity.Pages.Account.Manage.PostEditModel>)PageContext?.ViewData;
        public WebApplication3.Areas.Identity.Pages.Account.Manage.PostEditModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
