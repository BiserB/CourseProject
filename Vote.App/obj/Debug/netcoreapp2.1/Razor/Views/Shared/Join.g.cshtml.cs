#pragma checksum "D:\CSharp\FinalProject\Vote.App\Views\Shared\Join.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfa90ae83cf2c3264bdad786d2e121782167ec8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Join), @"mvc.1.0.view", @"/Views/Shared/Join.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Join.cshtml", typeof(AspNetCore.Views_Shared_Join))]
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
#line 1 "D:\CSharp\FinalProject\Vote.App\Views\_ViewImports.cshtml"
using Vote.App;

#line default
#line hidden
#line 2 "D:\CSharp\FinalProject\Vote.App\Views\_ViewImports.cshtml"
using Vote.App.Models;

#line default
#line hidden
#line 3 "D:\CSharp\FinalProject\Vote.App\Views\_ViewImports.cshtml"
using Vote.Entities;

#line default
#line hidden
#line 1 "D:\CSharp\FinalProject\Vote.App\Views\Shared\Join.cshtml"
using Vote.Common.BindingModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfa90ae83cf2c3264bdad786d2e121782167ec8b", @"/Views/Shared/Join.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38f8b3b8bdf3493e8f8a62aeaba17c64fce1bdc8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Join : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JoinEventViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\CSharp\FinalProject\Vote.App\Views\Shared\Join.cshtml"
  
    ViewData["Title"] = "Join";

#line default
#line hidden
            BeginContext(101, 14, true);
            WriteLiteral("\r\n<h2><strong>");
            EndContext();
            BeginContext(116, 16, false);
#line 7 "D:\CSharp\FinalProject\Vote.App\Views\Shared\Join.cshtml"
       Write(Model.EventTitle);

#line default
#line hidden
            EndContext();
            BeginContext(132, 10, true);
            WriteLiteral("</strong> ");
            EndContext();
            BeginContext(143, 15, false);
#line 7 "D:\CSharp\FinalProject\Vote.App\Views\Shared\Join.cshtml"
                                  Write(Model.EventCode);

#line default
#line hidden
            EndContext();
            BeginContext(158, 30, true);
            WriteLiteral(" </h2>\r\n\r\n<p>Questions: </p>\r\n");
            EndContext();
#line 10 "D:\CSharp\FinalProject\Vote.App\Views\Shared\Join.cshtml"
  
    foreach (var question in Model.Questions)
    {

#line default
#line hidden
            BeginContext(246, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(258, 8, false);
#line 13 "D:\CSharp\FinalProject\Vote.App\Views\Shared\Join.cshtml"
      Write(question);

#line default
#line hidden
            EndContext();
            BeginContext(266, 7, true);
            WriteLiteral(".</p>\r\n");
            EndContext();
#line 14 "D:\CSharp\FinalProject\Vote.App\Views\Shared\Join.cshtml"
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JoinEventViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591