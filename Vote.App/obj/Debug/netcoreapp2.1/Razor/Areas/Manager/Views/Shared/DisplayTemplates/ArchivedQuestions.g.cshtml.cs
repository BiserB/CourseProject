#pragma checksum "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\ArchivedQuestions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12f7834f6a4f405e9cd0b04aed6547fa1644dd32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manager_Views_Shared_DisplayTemplates_ArchivedQuestions), @"mvc.1.0.view", @"/Areas/Manager/Views/Shared/DisplayTemplates/ArchivedQuestions.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manager/Views/Shared/DisplayTemplates/ArchivedQuestions.cshtml", typeof(AspNetCore.Areas_Manager_Views_Shared_DisplayTemplates_ArchivedQuestions))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12f7834f6a4f405e9cd0b04aed6547fa1644dd32", @"/Areas/Manager/Views/Shared/DisplayTemplates/ArchivedQuestions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e319ea4ab965fa9b738c37dc1dae62cd7aaf9f7", @"/Areas/Manager/Views/_ViewImports.cshtml")]
    public class Areas_Manager_Views_Shared_DisplayTemplates_ArchivedQuestions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<QuestionFullModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/manager/questions/delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mx-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\ArchivedQuestions.cshtml"
  
    if (Model.Count == 0)
    {

#line default
#line hidden
            BeginContext(79, 76, true);
            WriteLiteral("        <p class=\"h5 text-muted text-center m-5\">No archived questions</p>\r\n");
            EndContext();
#line 7 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\ArchivedQuestions.cshtml"
    }
    else
    {
        foreach (var question in Model)
        {
            var identifictor = "question" + question.Id;

#line default
#line hidden
            BeginContext(289, 16, true);
            WriteLiteral("            <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 305, "\"", 323, 1);
#line 13 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\ArchivedQuestions.cshtml"
WriteAttributeValue("", 310, identifictor, 310, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(324, 59, true);
            WriteLiteral(">\r\n                <div class=\"mr-3\">\r\n                    ");
            EndContext();
            BeginContext(384, 16, false);
#line 15 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\ArchivedQuestions.cshtml"
               Write(question.Content);

#line default
#line hidden
            EndContext();
            BeginContext(400, 115, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"row mx-0\">\r\n                    <span class=\"content-mutted\">");
            EndContext();
            BeginContext(516, 20, false);
#line 18 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\ArchivedQuestions.cshtml"
                                            Write(question.PublishedOn);

#line default
#line hidden
            EndContext();
            BeginContext(536, 48, true);
            WriteLiteral("</span>\r\n                    <span class=\"ml-3\">");
            EndContext();
            BeginContext(585, 19, false);
#line 19 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\ArchivedQuestions.cshtml"
                                  Write(question.AuthorName);

#line default
#line hidden
            EndContext();
            BeginContext(604, 128, true);
            WriteLiteral("</span>\r\n                    <div class=\"ml-auto mr-5\">\r\n                        <div class=\"row\">\r\n                            ");
            EndContext();
            BeginContext(732, 647, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a50c212e24f74e9f92f127fe0879a744", async() => {
                BeginContext(800, 40, true);
                WriteLiteral("\r\n                                <input");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 840, "\"", 860, 1);
#line 23 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\ArchivedQuestions.cshtml"
WriteAttributeValue("", 848, question.Id, 848, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(861, 67, true);
                WriteLiteral(" type=\"hidden\" name=\"Id\" />\r\n                                <input");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 928, "\"", 953, 1);
#line 24 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\ArchivedQuestions.cshtml"
WriteAttributeValue("", 936, question.EventId, 936, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(954, 72, true);
                WriteLiteral(" type=\"hidden\" name=\"eventId\" />\r\n                                <input");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1026, "\"", 1053, 1);
#line 25 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\ArchivedQuestions.cshtml"
WriteAttributeValue("", 1034, question.EventCode, 1034, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1054, 318, true);
                WriteLiteral(@" type=""hidden"" name=""EventCode"" />
                                <input type=""submit"" class=""btn btn-sm btn-outline-info"" value=""Restore"" formaction=""/manager/questions/restore"" />
                                <input type=""submit"" class=""btn btn-sm btn-outline-info"" value=""Del"" />
                            ");
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1379, 145, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <hr class=\"style6\" />\r\n            </div>\r\n");
            EndContext();
#line 34 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\ArchivedQuestions.cshtml"
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<QuestionFullModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
