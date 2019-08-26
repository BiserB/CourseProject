#pragma checksum "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\ReviewedQuestions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "921cb44a51a6a7f296a9d43142bd12fa36c3cab6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manager_Views_Shared_DisplayTemplates_ReviewedQuestions), @"mvc.1.0.view", @"/Areas/Manager/Views/Shared/DisplayTemplates/ReviewedQuestions.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manager/Views/Shared/DisplayTemplates/ReviewedQuestions.cshtml", typeof(AspNetCore.Areas_Manager_Views_Shared_DisplayTemplates_ReviewedQuestions))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"921cb44a51a6a7f296a9d43142bd12fa36c3cab6", @"/Areas/Manager/Views/Shared/DisplayTemplates/ReviewedQuestions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e319ea4ab965fa9b738c37dc1dae62cd7aaf9f7", @"/Areas/Manager/Views/_ViewImports.cshtml")]
    public class Areas_Manager_Views_Shared_DisplayTemplates_ReviewedQuestions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<QuestionFullModel>>
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
#line 3 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\ReviewedQuestions.cshtml"
  
    foreach (var question in Model)
    {
        var identifictor = "question" + question.Id;

#line default
#line hidden
            BeginContext(143, 12, true);
            WriteLiteral("        <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 155, "\"", 173, 1);
#line 7 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\ReviewedQuestions.cshtml"
WriteAttributeValue("", 160, identifictor, 160, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(174, 51, true);
            WriteLiteral(">\r\n            <div class=\"mr-3\">\r\n                ");
            EndContext();
            BeginContext(226, 16, false);
#line 9 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\ReviewedQuestions.cshtml"
           Write(question.Content);

#line default
#line hidden
            EndContext();
            BeginContext(242, 105, true);
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"row mx-0\">\r\n                <span class=\"content-mutted\">");
            EndContext();
            BeginContext(348, 20, false);
#line 13 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\ReviewedQuestions.cshtml"
                                        Write(question.PublishedOn);

#line default
#line hidden
            EndContext();
            BeginContext(368, 44, true);
            WriteLiteral("</span>\r\n                <span class=\"ml-3\">");
            EndContext();
            BeginContext(413, 19, false);
#line 14 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\ReviewedQuestions.cshtml"
                              Write(question.AuthorName);

#line default
#line hidden
            EndContext();
            BeginContext(432, 82, true);
            WriteLiteral("</span>\r\n                <div class=\"row ml-auto mr-4\">\r\n                    <span");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 514, "\"", 539, 2);
            WriteAttributeValue("", 519, "button", 519, 6, true);
#line 16 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\ReviewedQuestions.cshtml"
WriteAttributeValue("", 525, question.Id, 525, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(540, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 17 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\ReviewedQuestions.cshtml"
                          
                            if (question.Replies.Any())
                            {

#line default
#line hidden
            BeginContext(659, 70, true);
            WriteLiteral("                                <a class=\"mx-2\" data-toggle=\"collapse\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 729, "\"", 761, 2);
            WriteAttributeValue("", 736, "#repliesFor", 736, 11, true);
#line 20 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\ReviewedQuestions.cshtml"
WriteAttributeValue("", 747, question.Id, 747, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(762, 36, true);
            WriteLiteral(" role=\"button\" aria-expanded=\"false\"");
            EndContext();
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 798, "\"", 838, 2);
            WriteAttributeValue("", 814, "repliesFor", 814, 10, true);
#line 20 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\ReviewedQuestions.cshtml"
WriteAttributeValue("", 824, question.Id, 824, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(839, 123, true);
            WriteLiteral(">\r\n                                    <span class=\"font-weight-bold px-2\">R</span>\r\n                                </a>\r\n");
            EndContext();
#line 23 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\ReviewedQuestions.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(1020, 49, true);
            WriteLiteral("                    </span>\r\n                    ");
            EndContext();
            BeginContext(1069, 595, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8441ecc586264da8aa5cf1836388eaeb", async() => {
                BeginContext(1137, 32, true);
                WriteLiteral("\r\n                        <input");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1169, "\"", 1189, 1);
#line 27 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\ReviewedQuestions.cshtml"
WriteAttributeValue("", 1177, question.Id, 1177, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1190, 59, true);
                WriteLiteral(" type=\"hidden\" name=\"Id\" />\r\n                        <input");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1249, "\"", 1274, 1);
#line 28 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\ReviewedQuestions.cshtml"
WriteAttributeValue("", 1257, question.EventId, 1257, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1275, 64, true);
                WriteLiteral(" type=\"hidden\" name=\"EventId\" />\r\n                        <input");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1339, "\"", 1366, 1);
#line 29 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\ReviewedQuestions.cshtml"
WriteAttributeValue("", 1347, question.EventCode, 1347, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1367, 290, true);
                WriteLiteral(@" type=""hidden"" name=""EventCode"" />
                        <input type=""submit"" class=""btn btn-sm btn-outline-info"" value=""Arc"" formaction=""/manager/questions/archive"" />
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
            BeginContext(1664, 86, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"collapse mt-3\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1750, "\"", 1779, 2);
            WriteAttributeValue("", 1755, "repliesFor", 1755, 10, true);
#line 36 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\ReviewedQuestions.cshtml"
WriteAttributeValue("", 1765, question.Id, 1765, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1780, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 37 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\ReviewedQuestions.cshtml"
                  
                    foreach (var reply in question.Replies)
                    {

#line default
#line hidden
            BeginContext(1887, 85, true);
            WriteLiteral("                        <div class=\"row replies\">\r\n                            <span>");
            EndContext();
            BeginContext(1973, 13, false);
#line 41 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\ReviewedQuestions.cshtml"
                             Write(reply.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1986, 68, true);
            WriteLiteral("</span>\r\n                            <span class=\"ml-auto paradiso\">");
            EndContext();
            BeginContext(2055, 16, false);
#line 42 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\ReviewedQuestions.cshtml"
                                                      Write(reply.AuthorName);

#line default
#line hidden
            EndContext();
            BeginContext(2071, 88, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                        <hr class=\"style4\" />\r\n");
            EndContext();
#line 45 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\ReviewedQuestions.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(2201, 73, true);
            WriteLiteral("            </div>\r\n\r\n            <hr class=\"style6\" />\r\n        </div>\r\n");
            EndContext();
#line 51 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\DisplayTemplates\ReviewedQuestions.cshtml"
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
