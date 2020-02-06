#pragma checksum "D:\CSharp\FinalProject\Vote.App\Areas\Manager\Views\Polls\IndexPastEvent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b51256368cf0bb42722a863183cca6018a0c8301"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manager_Views_Polls_IndexPastEvent), @"mvc.1.0.view", @"/Areas/Manager/Views/Polls/IndexPastEvent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manager/Views/Polls/IndexPastEvent.cshtml", typeof(AspNetCore.Areas_Manager_Views_Polls_IndexPastEvent))]
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
#line 1 "D:\CSharp\FinalProject\Vote.App\Areas\Manager\Views\_ViewImports.cshtml"
using Vote.App;

#line default
#line hidden
#line 2 "D:\CSharp\FinalProject\Vote.App\Areas\Manager\Views\_ViewImports.cshtml"
using Vote.Common.BindingModels;

#line default
#line hidden
#line 3 "D:\CSharp\FinalProject\Vote.App\Areas\Manager\Views\_ViewImports.cshtml"
using Vote.Common.ViewModels.Polls;

#line default
#line hidden
#line 4 "D:\CSharp\FinalProject\Vote.App\Areas\Manager\Views\_ViewImports.cshtml"
using Vote.Common.ViewModels.Events;

#line default
#line hidden
#line 5 "D:\CSharp\FinalProject\Vote.App\Areas\Manager\Views\_ViewImports.cshtml"
using Vote.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b51256368cf0bb42722a863183cca6018a0c8301", @"/Areas/Manager/Views/Polls/IndexPastEvent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e319ea4ab965fa9b738c37dc1dae62cd7aaf9f7", @"/Areas/Manager/Views/_ViewImports.cshtml")]
    public class Areas_Manager_Views_Polls_IndexPastEvent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PollPanelModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\CSharp\FinalProject\Vote.App\Areas\Manager\Views\Polls\IndexPastEvent.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(64, 306, true);
            WriteLiteral(@"
<div class=""row mt-1"">

    <div class=""col-5 text-right"">
        <h4>Polls</h4>
    </div>
    <div class=""col-5"">
        <div class=""text-right"">
        </div>
    </div>
</div>
<hr class=""style3"" />
<div class=""container"">
    <h5 class=""text-center""><span class=""text-muted m-2"">code- ");
            EndContext();
            BeginContext(371, 15, false);
#line 18 "D:\CSharp\FinalProject\Vote.App\Areas\Manager\Views\Polls\IndexPastEvent.cshtml"
                                                          Write(Model.EventCode);

#line default
#line hidden
            EndContext();
            BeginContext(386, 8, true);
            WriteLiteral("</span> ");
            EndContext();
            BeginContext(395, 16, false);
#line 18 "D:\CSharp\FinalProject\Vote.App\Areas\Manager\Views\Polls\IndexPastEvent.cshtml"
                                                                                  Write(Model.EventTitle);

#line default
#line hidden
            EndContext();
            BeginContext(411, 17, true);
            WriteLiteral("</h5>\r\n</div>\r\n\r\n");
            EndContext();
#line 21 "D:\CSharp\FinalProject\Vote.App\Areas\Manager\Views\Polls\IndexPastEvent.cshtml"
  
    if (!Model.Polls.Any())
    {

#line default
#line hidden
            BeginContext(468, 49, true);
            WriteLiteral("        <p>No polls created</p>\r\n        <hr />\r\n");
            EndContext();
#line 26 "D:\CSharp\FinalProject\Vote.App\Areas\Manager\Views\Polls\IndexPastEvent.cshtml"
    }
    else
    {

        int cnt = 1;
        foreach (var poll in Model.Polls)
        {

#line default
#line hidden
            BeginContext(619, 194, true);
            WriteLiteral("            <hr class=\"style2\" />\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div>\r\n                        <span class=\"font-weight-bold mr-2\">");
            EndContext();
            BeginContext(814, 3, false);
#line 37 "D:\CSharp\FinalProject\Vote.App\Areas\Manager\Views\Polls\IndexPastEvent.cshtml"
                                                       Write(cnt);

#line default
#line hidden
            EndContext();
            BeginContext(817, 42, true);
            WriteLiteral(" </span>\r\n                        <span><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 859, "\"", 897, 2);
            WriteAttributeValue("", 866, "/manager/polls/details/", 866, 23, true);
#line 38 "D:\CSharp\FinalProject\Vote.App\Areas\Manager\Views\Polls\IndexPastEvent.cshtml"
WriteAttributeValue("", 889, poll.Id, 889, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(898, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(900, 17, false);
#line 38 "D:\CSharp\FinalProject\Vote.App\Areas\Manager\Views\Polls\IndexPastEvent.cshtml"
                                                                   Write(poll.PollQuestion);

#line default
#line hidden
            EndContext();
            BeginContext(917, 163, true);
            WriteLiteral("</a></span>\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <span class=\"text-muted font-weight-light\">");
            EndContext();
            BeginContext(1081, 28, false);
#line 42 "D:\CSharp\FinalProject\Vote.App\Areas\Manager\Views\Polls\IndexPastEvent.cshtml"
                                                          Write(poll.CreatedOn.ToString("g"));

#line default
#line hidden
            EndContext();
            BeginContext(1109, 709, true);
            WriteLiteral(@"</span>
                    <div class=""ml-auto"">
                        <a class=""btn btn-sm btn-secondary mx-3"" href=""path/to/settings"" aria-label=""Delete"">
                            <i class=""icon-cancel""></i>
                        </a>
                        <a class=""btn btn-sm btn-warning mx-1"" href=""path/to/settings"" aria-label=""Delete"">
                            <i class=""icon-box""></i>
                        </a>
                        <a class=""btn btn-sm btn-danger mx-3"" href=""path/to/settings"" aria-label=""Delete"">
                            <i class=""icon-trash""></i>
                        </a>
                    </div>
                </div>
            </div>
");
            EndContext();
#line 56 "D:\CSharp\FinalProject\Vote.App\Areas\Manager\Views\Polls\IndexPastEvent.cshtml"
            cnt++;
        }

#line default
#line hidden
            BeginContext(1849, 31, true);
            WriteLiteral("        <hr class=\"style2\" />\r\n");
            EndContext();
#line 59 "D:\CSharp\FinalProject\Vote.App\Areas\Manager\Views\Polls\IndexPastEvent.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PollPanelModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
