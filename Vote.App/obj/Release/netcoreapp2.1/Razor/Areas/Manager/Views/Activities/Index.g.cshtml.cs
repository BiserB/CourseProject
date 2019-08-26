#pragma checksum "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Activities\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db7fd3bc52d4ef59e98f5ac3b3098bf8c6c3328d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manager_Views_Activities_Index), @"mvc.1.0.view", @"/Areas/Manager/Views/Activities/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manager/Views/Activities/Index.cshtml", typeof(AspNetCore.Areas_Manager_Views_Activities_Index))]
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
#line 1 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\_ViewImports.cshtml"
using Vote.App;

#line default
#line hidden
#line 2 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\_ViewImports.cshtml"
using Vote.Common.BindingModels;

#line default
#line hidden
#line 3 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\_ViewImports.cshtml"
using Vote.Common.ViewModels.Polls;

#line default
#line hidden
#line 4 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\_ViewImports.cshtml"
using Vote.Common.ViewModels.Events;

#line default
#line hidden
#line 5 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\_ViewImports.cshtml"
using Vote.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db7fd3bc52d4ef59e98f5ac3b3098bf8c6c3328d", @"/Areas/Manager/Views/Activities/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e319ea4ab965fa9b738c37dc1dae62cd7aaf9f7", @"/Areas/Manager/Views/_ViewImports.cshtml")]
    public class Areas_Manager_Views_Activities_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AllEventsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ConfirmationDialog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Confirmation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Activities\Index.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "_ManagerEventsLayout";

#line default
#line hidden
            BeginContext(103, 697, true);
            WriteLiteral(@"

<div class=""bright-bg p-3 height80"">
    <ul class=""nav nav-tabs pt-3"" id=""myTab"" role=""tablist"">
        <li class=""nav-item"">
            <a class=""nav-link active"" id=""active-tab"" data-toggle=""tab"" href=""#active"" role=""tab"" aria-controls=""home"" aria-selected=""true"">Active</a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" id=""past-tab"" data-toggle=""tab"" href=""#past"" role=""tab"" aria-controls=""profile"" aria-selected=""false"">Past</a>
        </li>
    </ul>
    <div class=""tab-content"" id=""myTabContent"">
        <div class=""tab-pane fade show active"" id=""active"" role=""tabpanel"" aria-labelledby=""active-tab"">
            <div class=""list-group"">
");
            EndContext();
#line 20 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Activities\Index.cshtml"
                  
                    if (!Model.ActiveEvents.Any())
                    {

#line default
#line hidden
            BeginContext(895, 62, true);
            WriteLiteral("                        <p class=\"m-5\">No active events.</p>\r\n");
            EndContext();
#line 24 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Activities\Index.cshtml"
                    }
                    foreach (var activeEvent in Model.ActiveEvents)
                    {
                        

#line default
#line hidden
            BeginContext(1097, 33, false);
#line 27 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Activities\Index.cshtml"
                   Write(Html.DisplayFor(m => activeEvent));

#line default
#line hidden
            EndContext();
#line 27 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Activities\Index.cshtml"
                                                          
                    }

#line default
#line hidden
            BeginContext(1155, 107, true);
            WriteLiteral("                    <p class=\"mx-5 mt-2\"><a href=\"/manager/activities/create\">Create a new event.</a></p>\r\n");
            EndContext();
            BeginContext(1281, 164, true);
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"tab-pane fade\" id=\"past\" role=\"tabpanel\" aria-labelledby=\"past-tab\">\r\n            <div class=\"list-group\">\r\n");
            EndContext();
#line 35 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Activities\Index.cshtml"
                  
                    if (!Model.PastEvents.Any())
                    {

#line default
#line hidden
            BeginContext(1538, 64, true);
            WriteLiteral("                        <p class=\"m-5\">No past events yet.</p>\r\n");
            EndContext();
#line 39 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Activities\Index.cshtml"
                    }
                    foreach (var pastEvent in Model.PastEvents)
                    {
                        

#line default
#line hidden
            BeginContext(1738, 31, false);
#line 42 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Activities\Index.cshtml"
                   Write(Html.DisplayFor(m => pastEvent));

#line default
#line hidden
            EndContext();
#line 42 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Activities\Index.cshtml"
                                                        
                    }
                

#line default
#line hidden
            BeginContext(1813, 58, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(1871, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9c1eded8b510439a93fa5edce6b405a6", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1909, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1931, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1937, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eddc122d0c9d4e8d83d37964f05d5096", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1981, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1987, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6f6f8cbccfa049a1aa931a446c1911a0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2019, 2, true);
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AllEventsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591