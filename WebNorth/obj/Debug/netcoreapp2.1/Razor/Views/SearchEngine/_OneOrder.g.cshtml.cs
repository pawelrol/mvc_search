#pragma checksum "C:\Users\Pawel\source\repos\WebNorth\WebNorth\Views\SearchEngine\_OneOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55dd1d5810c8e465fade92a165a0882c2117a8ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SearchEngine__OneOrder), @"mvc.1.0.view", @"/Views/SearchEngine/_OneOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SearchEngine/_OneOrder.cshtml", typeof(AspNetCore.Views_SearchEngine__OneOrder))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55dd1d5810c8e465fade92a165a0882c2117a8ff", @"/Views/SearchEngine/_OneOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1398c3c2db6eddac82d1fb843640205f937288f0", @"/Views/_ViewImports.cshtml")]
    public class Views_SearchEngine__OneOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Orders>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 185, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-sm-6 col-md-4\">\r\n        <div class=\"thumbnail\">\r\n            <img src=\"...\" alt=\"...\">\r\n            <div class=\"caption\">\r\n                <h3>");
            EndContext();
            BeginContext(201, 14, false);
#line 8 "C:\Users\Pawel\source\repos\WebNorth\WebNorth\Views\SearchEngine\_OneOrder.cshtml"
               Write(Model.ShipName);

#line default
#line hidden
            EndContext();
            BeginContext(215, 26, true);
            WriteLiteral("</h3>\r\n                <p>");
            EndContext();
            BeginContext(242, 41, false);
#line 9 "C:\Users\Pawel\source\repos\WebNorth\WebNorth\Views\SearchEngine\_OneOrder.cshtml"
              Write(Model.OrderDate.Value.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(283, 208, true);
            WriteLiteral("</p>\r\n                <p><a href=\"#\" class=\"btn btn-primary\" role=\"button\">Button</a> <a href=\"#\" class=\"btn btn-default\" role=\"button\">Button</a></p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Orders> Html { get; private set; }
    }
}
#pragma warning restore 1591
