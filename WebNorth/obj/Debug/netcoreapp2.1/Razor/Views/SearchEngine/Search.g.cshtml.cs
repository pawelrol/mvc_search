#pragma checksum "C:\Users\Pawel\source\repos\WebNorth\WebNorth\Views\SearchEngine\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35135e18454d1b8c0c819dde1c07af253a03abf0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SearchEngine_Search), @"mvc.1.0.view", @"/Views/SearchEngine/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SearchEngine/Search.cshtml", typeof(AspNetCore.Views_SearchEngine_Search))]
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
#line 1 "C:\Users\Pawel\source\repos\WebNorth\WebNorth\Views\_ViewImports.cshtml"
using WebNorth;

#line default
#line hidden
#line 2 "C:\Users\Pawel\source\repos\WebNorth\WebNorth\Views\_ViewImports.cshtml"
using WebNorth.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35135e18454d1b8c0c819dde1c07af253a03abf0", @"/Views/SearchEngine/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1398c3c2db6eddac82d1fb843640205f937288f0", @"/Views/_ViewImports.cshtml")]
    public class Views_SearchEngine_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Orders>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SearchEngine", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 1079, true);
            WriteLiteral(@"

<style>
    #search {
        float: right;
        margin-top: 9px;
        width: 250px;
    }

    .search {
        padding: 5px 0;
        width: 230px;
        height: 30px;
        position: relative;
        left: 10px;
        float: left;
        line-height: 22px;
    }

        .search input {
            position: absolute;
            width: 0px;
            float: Left;
            margin-left: 210px;
            -webkit-transition: all 0.7s ease-in-out;
            -moz-transition: all 0.7s ease-in-out;
            -o-transition: all 0.7s ease-in-out;
            transition: all 0.7s ease-in-out;
            height: 30px;
            line-height: 18px;
            padding: 0 2px 0 2px;
            border-radius: 1px;
        }

            .search:hover input, .search input:focus {
                width: 200px;
                margin-left: 0px;
            }

    .btn {
        height: 30px;
        position: absolute;
        right: 0;
        top:");
            WriteLiteral(" 5px;\r\n        border-radius: 1px;\r\n    }\r\n</style>\r\n\r\n");
            EndContext();
            BeginContext(1100, 148, true);
            WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <h2>Slider Search box</h2>\r\n            <div class=\"search\">\r\n                ");
            EndContext();
            BeginContext(1248, 289, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f17394170c6d42dd9c91561a01572f52", async() => {
                BeginContext(1304, 226, true);
                WriteLiteral("\r\n                    <input type=\"text\" name=\"q\" class=\"form-control input-sm\" maxlength=\"64\" placeholder=\"Search\" />\r\n                    <button type=\"submit\" class=\"btn btn-primary btn-sm\">Search</button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1537, 79, true);
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n<div class=\"container\">\r\n");
            EndContext();
#line 65 "C:\Users\Pawel\source\repos\WebNorth\WebNorth\Views\SearchEngine\Search.cshtml"
     if(Model != null && Model.Count > 0)
    {
        foreach(var order in Model)
        {
            

#line default
#line hidden
            BeginContext(1727, 32, false);
#line 69 "C:\Users\Pawel\source\repos\WebNorth\WebNorth\Views\SearchEngine\Search.cshtml"
       Write(Html.Partial("_OneOrder", order));

#line default
#line hidden
            EndContext();
#line 69 "C:\Users\Pawel\source\repos\WebNorth\WebNorth\Views\SearchEngine\Search.cshtml"
                                             
        }
    }

#line default
#line hidden
            BeginContext(1779, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Orders>> Html { get; private set; }
    }
}
#pragma warning restore 1591