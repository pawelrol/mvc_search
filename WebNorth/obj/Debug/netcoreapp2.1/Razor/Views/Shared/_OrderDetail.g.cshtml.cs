#pragma checksum "C:\Users\Pawel\source\repos\WebNorth\WebNorth\Views\Shared\_OrderDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3813c4c19380fb0e9f81d21e27e9b12bb3281f15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__OrderDetail), @"mvc.1.0.view", @"/Views/Shared/_OrderDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_OrderDetail.cshtml", typeof(AspNetCore.Views_Shared__OrderDetail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3813c4c19380fb0e9f81d21e27e9b12bb3281f15", @"/Views/Shared/_OrderDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1398c3c2db6eddac82d1fb843640205f937288f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__OrderDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Orders>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 6, true);
            WriteLiteral("\r\n<td>");
            EndContext();
            BeginContext(22, 16, false);
#line 3 "C:\Users\Pawel\source\repos\WebNorth\WebNorth\Views\Shared\_OrderDetail.cshtml"
Write(Model.CustomerId);

#line default
#line hidden
            EndContext();
            BeginContext(38, 11, true);
            WriteLiteral("</td>\r\n<td>");
            EndContext();
            BeginContext(50, 14, false);
#line 4 "C:\Users\Pawel\source\repos\WebNorth\WebNorth\Views\Shared\_OrderDetail.cshtml"
Write(Model.Employee);

#line default
#line hidden
            EndContext();
            BeginContext(64, 11, true);
            WriteLiteral("</td>\r\n<td>");
            EndContext();
            BeginContext(76, 14, false);
#line 5 "C:\Users\Pawel\source\repos\WebNorth\WebNorth\Views\Shared\_OrderDetail.cshtml"
Write(Model.ShipCity);

#line default
#line hidden
            EndContext();
            BeginContext(90, 11, true);
            WriteLiteral("</td>\r\n<td>");
            EndContext();
            BeginContext(102, 20, false);
#line 6 "C:\Users\Pawel\source\repos\WebNorth\WebNorth\Views\Shared\_OrderDetail.cshtml"
Write(Model.ShipPostalCode);

#line default
#line hidden
            EndContext();
            BeginContext(122, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 7 "C:\Users\Pawel\source\repos\WebNorth\WebNorth\Views\Shared\_OrderDetail.cshtml"
 if (Model.ShippedDate != null)
{

#line default
#line hidden
            BeginContext(165, 8, true);
            WriteLiteral("    <td>");
            EndContext();
            BeginContext(174, 43, false);
#line 9 "C:\Users\Pawel\source\repos\WebNorth\WebNorth\Views\Shared\_OrderDetail.cshtml"
   Write(Model.ShippedDate.Value.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(217, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 10 "C:\Users\Pawel\source\repos\WebNorth\WebNorth\Views\Shared\_OrderDetail.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(236, 15, true);
            WriteLiteral("    <td></td>\r\n");
            EndContext();
#line 14 "C:\Users\Pawel\source\repos\WebNorth\WebNorth\Views\Shared\_OrderDetail.cshtml"
}

#line default
#line hidden
            BeginContext(254, 12, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
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