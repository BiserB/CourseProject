#pragma checksum "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\EditorTemplates\PollPanelModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bcbd41440885f06c4d85724d4e934c2a41eb89b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manager_Views_Shared_EditorTemplates_PollPanelModel), @"mvc.1.0.view", @"/Areas/Manager/Views/Shared/EditorTemplates/PollPanelModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manager/Views/Shared/EditorTemplates/PollPanelModel.cshtml", typeof(AspNetCore.Areas_Manager_Views_Shared_EditorTemplates_PollPanelModel))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bcbd41440885f06c4d85724d4e934c2a41eb89b", @"/Areas/Manager/Views/Shared/EditorTemplates/PollPanelModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e319ea4ab965fa9b738c37dc1dae62cd7aaf9f7", @"/Areas/Manager/Views/_ViewImports.cshtml")]
    public class Areas_Manager_Views_Shared_EditorTemplates_PollPanelModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PollPanelModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "manager", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "polls", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-nowrap btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Manager", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Polls", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Activate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("pollsForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 135, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"text-right font-weight-bold mt-2 mr-md-2\">\r\n        Choose to activate\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(158, 2401, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1eeb8aa263194b9690f3e81ba02ff257", async() => {
                BeginContext(243, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 9 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\EditorTemplates\PollPanelModel.cshtml"
     foreach (var poll in Model.Polls)
    {
        var isChecked = "";
        if (poll.IsActive)
        {
            isChecked = "checked";
        }


#line default
#line hidden
                BeginContext(409, 137, true);
                WriteLiteral("        <hr class=\"style7\" />\r\n        <div class=\"row\">\r\n            <div class=\"col-10\">\r\n                <span class=\"swans-bg p-1\"><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 546, "\"", 584, 2);
                WriteAttributeValue("", 553, "/manager/polls/details/", 553, 23, true);
#line 20 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\EditorTemplates\PollPanelModel.cshtml"
WriteAttributeValue("", 576, poll.Id, 576, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(585, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(587, 17, false);
#line 20 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\EditorTemplates\PollPanelModel.cshtml"
                                                                                Write(poll.PollQuestion);

#line default
#line hidden
                EndContext();
                BeginContext(604, 72, true);
                WriteLiteral("</a></span>\r\n                <span class=\"text-muted font-weight-light\">");
                EndContext();
                BeginContext(677, 28, false);
#line 21 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\EditorTemplates\PollPanelModel.cshtml"
                                                      Write(poll.CreatedOn.ToString("g"));

#line default
#line hidden
                EndContext();
                BeginContext(705, 63, true);
                WriteLiteral("</span>\r\n                <span class=\"font-weight-bold\">Votes: ");
                EndContext();
                BeginContext(769, 10, false);
#line 22 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\EditorTemplates\PollPanelModel.cshtml"
                                                 Write(poll.Votes);

#line default
#line hidden
                EndContext();
                BeginContext(779, 193, true);
                WriteLiteral("</span>\r\n            </div>\r\n            <div class=\"ml-auto\">\r\n                <div>\r\n                    <label class=\"custom-checkbox\">\r\n                        <input type=\"radio\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 972, "\"", 988, 1);
#line 27 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\EditorTemplates\PollPanelModel.cshtml"
WriteAttributeValue("", 980, poll.Id, 980, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(989, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(991, 9, false);
#line 27 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\EditorTemplates\PollPanelModel.cshtml"
                                                                  Write(isChecked);

#line default
#line hidden
                EndContext();
                BeginContext(1000, 119, true);
                WriteLiteral(" />\r\n                        <span class=\"checkmark\"></span>\r\n                    </label>\r\n                    <button");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1119, "\"", 1135, 1);
#line 30 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\EditorTemplates\PollPanelModel.cshtml"
WriteAttributeValue("", 1127, poll.Id, 1127, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1136, 292, true);
                WriteLiteral(@" type=""button"" data-toggle=""modal"" data-target=""#confirmation"" class=""delete btn btn-sm ml-5 mr-3 mt-0"">
                        <i class=""icon-trash""></i>
                    </button>
                </div>
            </div>
        </div>
        <input type=""hidden"" name=""eventId""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1428, "\"", 1450, 1);
#line 36 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\EditorTemplates\PollPanelModel.cshtml"
WriteAttributeValue("", 1436, Model.EventId, 1436, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1451, 3, true);
                WriteLiteral(">\r\n");
                EndContext();
#line 37 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\EditorTemplates\PollPanelModel.cshtml"
    }

#line default
#line hidden
                BeginContext(1461, 628, true);
                WriteLiteral(@"    <hr class=""style7"" />
    <div class=""row py-2 border-bottom border-top"">
        <div class=""col-10 text-left"">
            <span class=""font-weight-bold"">Deactivate all</span>
        </div>
        <div class=""ml-auto"">
            <label class=""custom-checkbox deact"">
                <input type=""radio"" name=""id"" value=""-1"" />
                <span class=""checkmark""></span>
            </label>
            <label class=""mx-5 pt-0"">
            </label>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-9 mr-auto"">
            <div class=""text-left mt-3 ml-5"">
                ");
                EndContext();
                BeginContext(2089, 188, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5c370b69097431d88d7a0240d6fadd8", async() => {
                    BeginContext(2225, 48, true);
                    WriteLiteral("\r\n                    Add poll\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 55 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Manager\Views\Shared\EditorTemplates\PollPanelModel.cshtml"
                                                                                   WriteLiteral(Model.EventId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2277, 275, true);
                WriteLiteral(@"
            </div>
        </div>
        <div class="" ml-auto"">
            <div class=""text-center mt-3 mr-5"">
                <input type=""submit"" class=""btn btn-secondary"" value=""Apply"" />
            </div>
        </div>
    </div>
    <hr class=""style7"" />
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PollPanelModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
