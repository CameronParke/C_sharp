#pragma checksum "/Users/CamPaign/Desktop/C_sharp/crudelicious/Views/Home/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b20ad2f70458145e51d8260c4ef77386aa6f4ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Show), @"mvc.1.0.view", @"/Views/Home/Show.cshtml")]
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
#line 1 "/Users/CamPaign/Desktop/C_sharp/crudelicious/Views/_ViewImports.cshtml"
using crudelicious;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/CamPaign/Desktop/C_sharp/crudelicious/Views/_ViewImports.cshtml"
using crudelicious.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b20ad2f70458145e51d8260c4ef77386aa6f4ae", @"/Views/Home/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d1344efeabb6281de7249210f4b4c13df6c6eab", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration: underline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/CamPaign/Desktop/C_sharp/crudelicious/Views/Home/Show.cshtml"
 foreach (var d in @ViewBag.OneDish)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container pt-4\">\n        <div>\n            <div class=\"navbar-collapse collapse d-sm-flex\">\n                <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b20ad2f70458145e51d8260c4ef77386aa6f4ae4575", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\n            </div>\n            <div>\n                <div class=\"row flex-column\">\n                    <h1 class=\"text-center\">");
#nullable restore
#line 12 "/Users/CamPaign/Desktop/C_sharp/crudelicious/Views/Home/Show.cshtml"
                                       Write(d.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                </div>\n                <div class=\"row align-items-center flex-column\">\n                    <div class=\"col-10\">\n                        <div class=\"row pt-1 align-items-center flex-column\">\n                            <h5>");
#nullable restore
#line 17 "/Users/CamPaign/Desktop/C_sharp/crudelicious/Views/Home/Show.cshtml"
                           Write(d.Chef);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n        <hr class=\"w-50\" noshade>\n        <ul class=\"list-unstyled\">\n            <li class=\"mb-3\">");
#nullable restore
#line 25 "/Users/CamPaign/Desktop/C_sharp/crudelicious/Views/Home/Show.cshtml"
                        Write(d.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            <li class=\"mb-3\"><b>Calories:</b> ");
#nullable restore
#line 26 "/Users/CamPaign/Desktop/C_sharp/crudelicious/Views/Home/Show.cshtml"
                                         Write(d.Calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            <li class=\"mb-3\"><b>Tastiness:</b> ");
#nullable restore
#line 27 "/Users/CamPaign/Desktop/C_sharp/crudelicious/Views/Home/Show.cshtml"
                                          Write(d.Tastiness);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n        </ul>\n    </div>\n        <div class=\"d-flex pt-5 justify-content-around\">\n            <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1156, "\"", 1180, 2);
            WriteAttributeValue("", 1163, "/remove/", 1163, 8, true);
#nullable restore
#line 31 "/Users/CamPaign/Desktop/C_sharp/crudelicious/Views/Home/Show.cshtml"
WriteAttributeValue("", 1171, d.DishId, 1171, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\n            <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1231, "\"", 1253, 2);
            WriteAttributeValue("", 1238, "/edit/", 1238, 6, true);
#nullable restore
#line 32 "/Users/CamPaign/Desktop/C_sharp/crudelicious/Views/Home/Show.cshtml"
WriteAttributeValue("", 1244, d.DishId, 1244, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\n        </div>\n");
#nullable restore
#line 34 "/Users/CamPaign/Desktop/C_sharp/crudelicious/Views/Home/Show.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
