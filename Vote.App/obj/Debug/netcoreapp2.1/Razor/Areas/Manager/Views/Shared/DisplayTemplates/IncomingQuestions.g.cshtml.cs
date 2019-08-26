#pragma checksum "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\IncomingQuestions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3f3ea6c52fdbe34722d8aff3e92813d60ce9248"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manager_Views_Shared_DisplayTemplates_IncomingQuestions), @"mvc.1.0.view", @"/Areas/Manager/Views/Shared/DisplayTemplates/IncomingQuestions.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manager/Views/Shared/DisplayTemplates/IncomingQuestions.cshtml", typeof(AspNetCore.Areas_Manager_Views_Shared_DisplayTemplates_IncomingQuestions))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3f3ea6c52fdbe34722d8aff3e92813d60ce9248", @"/Areas/Manager/Views/Shared/DisplayTemplates/IncomingQuestions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e319ea4ab965fa9b738c37dc1dae62cd7aaf9f7", @"/Areas/Manager/Views/_ViewImports.cshtml")]
    public class Areas_Manager_Views_Shared_DisplayTemplates_IncomingQuestions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<QuestionFullModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/manager/questions/review"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\IncomingQuestions.cshtml"
  
    foreach (var question in Model)
    {
        var identifictor = "question" + question.Id;

#line default
#line hidden
            BeginContext(143, 12, true);
            WriteLiteral("        <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 155, "\"", 173, 1);
#line 7 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\IncomingQuestions.cshtml"
WriteAttributeValue("", 160, identifictor, 160, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(174, 71, true);
            WriteLiteral(">\r\n            <div class=\"mr-3\">                \r\n                    ");
            EndContext();
            BeginContext(246, 16, false);
#line 9 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\IncomingQuestions.cshtml"
               Write(question.Content);

#line default
#line hidden
            EndContext();
            BeginContext(262, 119, true);
            WriteLiteral("                \r\n            </div>\r\n            <div class=\"row ml-0\">\r\n                <span class=\"content-mutted\">");
            EndContext();
            BeginContext(382, 20, false);
#line 12 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\IncomingQuestions.cshtml"
                                        Write(question.PublishedOn);

#line default
#line hidden
            EndContext();
            BeginContext(402, 44, true);
            WriteLiteral("</span>\r\n                <span class=\"ml-3\">");
            EndContext();
            BeginContext(447, 19, false);
#line 13 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\IncomingQuestions.cshtml"
                              Write(question.AuthorName);

#line default
#line hidden
            EndContext();
            BeginContext(466, 83, true);
            WriteLiteral("</span> \r\n                <div class=\"row ml-auto mr-4\">\r\n                    <span");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 549, "\"", 574, 2);
            WriteAttributeValue("", 554, "button", 554, 6, true);
#line 15 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\IncomingQuestions.cshtml"
WriteAttributeValue("", 560, question.Id, 560, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(575, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 16 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\IncomingQuestions.cshtml"
                          
                            if (question.Replies.Any())
                            {

#line default
#line hidden
            BeginContext(694, 70, true);
            WriteLiteral("                                <a class=\"mx-2\" data-toggle=\"collapse\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 764, "\"", 796, 2);
            WriteAttributeValue("", 771, "#repliesFor", 771, 11, true);
#line 19 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\IncomingQuestions.cshtml"
WriteAttributeValue("", 782, question.Id, 782, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(797, 36, true);
            WriteLiteral(" role=\"button\" aria-expanded=\"false\"");
            EndContext();
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 833, "\"", 873, 2);
            WriteAttributeValue("", 849, "repliesFor", 849, 10, true);
#line 19 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\IncomingQuestions.cshtml"
WriteAttributeValue("", 859, question.Id, 859, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(874, 123, true);
            WriteLiteral(">\r\n                                    <span class=\"font-weight-bold px-2\">R</span>\r\n                                </a>\r\n");
            EndContext();
#line 22 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\IncomingQuestions.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(1055, 49, true);
            WriteLiteral("                    </span>\r\n                    ");
            EndContext();
            BeginContext(1104, 731, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4563b41516a74611af2f6f827d887733", async() => {
                BeginContext(1172, 32, true);
                WriteLiteral("\r\n                        <input");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1204, "\"", 1224, 1);
#line 26 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\IncomingQuestions.cshtml"
WriteAttributeValue("", 1212, question.Id, 1212, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1225, 59, true);
                WriteLiteral(" type=\"hidden\" name=\"Id\" />\r\n                        <input");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1284, "\"", 1309, 1);
#line 27 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\IncomingQuestions.cshtml"
WriteAttributeValue("", 1292, question.EventId, 1292, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1310, 64, true);
                WriteLiteral(" type=\"hidden\" name=\"EventId\" />\r\n                        <input");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1374, "\"", 1401, 1);
#line 28 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\IncomingQuestions.cshtml"
WriteAttributeValue("", 1382, question.EventCode, 1382, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1402, 426, true);
                WriteLiteral(@" type=""hidden"" name=""EventCode"" />
                        <input type=""submit"" class=""btn btn-sm btn-outline-info"" value=""Arc"" formaction=""/manager/questions/archive"" />
                        <input type=""submit"" class=""btn btn-sm btn-outline-info"" value=""Del"" formaction=""/manager/questions/delete"" />
                        <input type=""submit"" class=""btn btn-sm btn-outline-info"" value=""Rev"" />
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
            BeginContext(1835, 86, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"collapse mt-3\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1921, "\"", 1950, 2);
            WriteAttributeValue("", 1926, "repliesFor", 1926, 10, true);
#line 36 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\IncomingQuestions.cshtml"
WriteAttributeValue("", 1936, question.Id, 1936, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1951, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 37 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\IncomingQuestions.cshtml"
                  
                    foreach (var reply in question.Replies)
                    {

#line default
#line hidden
            BeginContext(2058, 85, true);
            WriteLiteral("                        <div class=\"row replies\">\r\n                            <span>");
            EndContext();
            BeginContext(2144, 13, false);
#line 41 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\IncomingQuestions.cshtml"
                             Write(reply.Content);

#line default
#line hidden
            EndContext();
            BeginContext(2157, 68, true);
            WriteLiteral("</span>\r\n                            <span class=\"ml-auto paradiso\">");
            EndContext();
            BeginContext(2226, 16, false);
#line 42 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\IncomingQuestions.cshtml"
                                                      Write(reply.AuthorName);

#line default
#line hidden
            EndContext();
            BeginContext(2242, 88, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                        <hr class=\"style4\" />\r\n");
            EndContext();
#line 45 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\IncomingQuestions.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(2372, 73, true);
            WriteLiteral("            </div>\r\n\r\n            <hr class=\"style6\" />\r\n        </div>\r\n");
            EndContext();
#line 51 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\IncomingQuestions.cshtml"
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