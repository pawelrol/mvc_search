#pragma checksum "C:\Users\Pawel\source\repos\WebNorth\WebNorth\Views\Shared\_Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "755e0fd7c2ed0da5674ff60306c2c134082b9452"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Contact), @"mvc.1.0.view", @"/Views/Shared/_Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Contact.cshtml", typeof(AspNetCore.Views_Shared__Contact))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"755e0fd7c2ed0da5674ff60306c2c134082b9452", @"/Views/Shared/_Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1398c3c2db6eddac82d1fb843640205f937288f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 130, true);
            WriteLiteral("<div class=\"\">\r\n    <h1>Contact</h1>;\r\n    <p>\r\n        ul. Prosta 12\r\n        <br />\r\n        tel. 987-789-987\r\n    </p>\r\n    <p>");
            EndContext();
            BeginContext(146, 5, false);
#line 9 "C:\Users\Pawel\source\repos\WebNorth\WebNorth\Views\Shared\_Contact.cshtml"
  Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(151, 12, true);
            WriteLiteral("</p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
