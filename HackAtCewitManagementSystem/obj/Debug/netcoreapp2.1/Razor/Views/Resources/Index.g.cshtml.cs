#pragma checksum "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/Resources/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "843638762c4d8693aad10ec4f97b51f047e99c38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Resources_Index), @"mvc.1.0.view", @"/Views/Resources/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Resources/Index.cshtml", typeof(AspNetCore.Views_Resources_Index))]
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
#line 1 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/_ViewImports.cshtml"
using HackAtCewitManagementSystem;

#line default
#line hidden
#line 3 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/_ViewImports.cshtml"
using HackAtCewitManagementSystem.Models;

#line default
#line hidden
#line 4 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/_ViewImports.cshtml"
using HackAtCewitManagementSystem.Models.AccountViewModels;

#line default
#line hidden
#line 5 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/_ViewImports.cshtml"
using HackAtCewitManagementSystem.Models.ManageViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"843638762c4d8693aad10ec4f97b51f047e99c38", @"/Views/Resources/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9850bc5e39616953c51bc9b6b6e6fb4dca3609eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Resources_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Resource>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("buttonForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 1 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/Resources/Index.cshtml"
  
    ViewData["Title"] = "Resources";

#line default
#line hidden
            BeginContext(42, 208, true);
            WriteLiteral("<section>\n    <div class=\"container\">\n        <div class=\"row\">\n            <div class=\"col-lg-12 my-auto\">\n                <div class=\"container-fluid\">\n                    <br />\n                    <br />\n");
            EndContext();
            BeginContext(292, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 12 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/Resources/Index.cshtml"
                     if (Model == null || Model.Count == 0)
                    {

#line default
#line hidden
            BeginContext(374, 80, true);
            WriteLiteral("                            <h4>Sorry, no schedule available for this day!</h4>\n");
            EndContext();
#line 15 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/Resources/Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(523, 29, true);
            WriteLiteral("                    <table>\n\n");
            EndContext();
#line 20 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/Resources/Index.cshtml"
                         foreach (var resource in Model)
                        {

#line default
#line hidden
            BeginContext(635, 249, true);
            WriteLiteral("                            <tr style=\"        vertical-align: middle;\">\n                                <td class=\"section-heading\" style=\"        float: left;\n        vertical-align: middle;\">\n                                    <a target=\"_blank\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 884, "\"", 905, 1);
#line 25 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/Resources/Index.cshtml"
WriteAttributeValue("", 891, resource.Link, 891, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(906, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(908, 14, false);
#line 25 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/Resources/Index.cshtml"
                                                                        Write(resource.Title);

#line default
#line hidden
            EndContext();
            BeginContext(922, 43, true);
            WriteLiteral("</a>\n                                </td>\n");
            EndContext();
#line 27 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/Resources/Index.cshtml"
                                 if (this.User.IsInRole("admin"))
                                {

#line default
#line hidden
            BeginContext(1065, 129, true);
            WriteLiteral("                                    <td>\n                                        <input class=\"button\" type=\"button\" value=\"Edit\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1194, "\"", 1278, 3);
            WriteAttributeValue("", 1204, "location.href=\'", 1204, 15, true);
#line 30 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/Resources/Index.cshtml"
WriteAttributeValue("", 1219, Url.Action("Edit", "Resources", new { id = resource.Id }), 1219, 58, false);

#line default
#line hidden
            WriteAttributeValue("", 1277, "\'", 1277, 1, true);
            EndWriteAttribute();
            BeginContext(1279, 44, true);
            WriteLiteral(" />\n                                        ");
            EndContext();
            BeginContext(1323, 225, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bce3be5db5d14ba88a7e4e12a2de7b1a", async() => {
                BeginContext(1402, 139, true);
                WriteLiteral("\n                                            <input class=\"button\" type=\"submit\" value=\"Delete\" />\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1370, "/Resources/Delete/", 1370, 18, true);
#line 31 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/Resources/Index.cshtml"
AddHtmlAttributeValue("", 1388, resource.Id, 1388, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1548, 43, true);
            WriteLiteral("\n                                    </td>\n");
            EndContext();
#line 35 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/Resources/Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(1625, 195, true);
            WriteLiteral("                            </tr>\n                            <tr>\n                                <td colspan=\"2\" style=\"        padding: 0px 0px 40px 0px;\">\n                                    ");
            EndContext();
            BeginContext(1821, 20, false);
#line 39 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/Resources/Index.cshtml"
                               Write(resource.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1841, 73, true);
            WriteLiteral("\n                                </td>\n                            </tr>\n");
            EndContext();
#line 42 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/Resources/Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1940, 30, true);
            WriteLiteral("\n                    </table>\n");
            EndContext();
#line 45 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/Resources/Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1992, 131, true);
            WriteLiteral("                    <br/>\n                    <br/>\n                </div>\n            </div>\n        </div>\n    </div>\n</section>\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(2140, 10, true);
                WriteLiteral("\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2150, "\"", 2198, 1);
#line 54 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/Resources/Index.cshtml"
WriteAttributeValue("", 2157, Url.Content("~/css/Resources/Index.css"), 2157, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2199, 37, true);
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Resource>> Html { get; private set; }
    }
}
#pragma warning restore 1591