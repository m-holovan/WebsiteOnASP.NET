#pragma checksum "D:\ProjectOnASP.NET\MyCompany\Views\Shared\FooterPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1709047013349e8692c301e402e376b4a58703d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_FooterPartial), @"mvc.1.0.view", @"/Views/Shared/FooterPartial.cshtml")]
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
#line 2 "D:\ProjectOnASP.NET\MyCompany\Views\_ViewImports.cshtml"
using MyCompany.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ProjectOnASP.NET\MyCompany\Views\_ViewImports.cshtml"
using MyCompany.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\ProjectOnASP.NET\MyCompany\Views\_ViewImports.cshtml"
using MyCompany.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\ProjectOnASP.NET\MyCompany\Views\_ViewImports.cshtml"
using MyCompany.Models.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1709047013349e8692c301e402e376b4a58703d", @"/Views/Shared/FooterPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1015f69c6639778e551e8eebba7e553a28371f16", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_FooterPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Footer -->\r\n<div id=\"footer-wrapper\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n\r\n                <div id=\"copyright\">\r\n                    &copy; ");
#nullable restore
#line 8 "D:\ProjectOnASP.NET\MyCompany\Views\Shared\FooterPartial.cshtml"
                      Write(Config.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral(". All rights reserved. | Design: <a href=\"http://html5up.net\">HTML5 UP</a>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
