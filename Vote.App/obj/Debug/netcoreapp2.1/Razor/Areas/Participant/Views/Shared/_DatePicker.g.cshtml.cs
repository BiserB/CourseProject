#pragma checksum "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Participant\Views\Shared\_DatePicker.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9360ee0179e9c5f2a6797aca02f3a65915b5f23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Participant_Views_Shared__DatePicker), @"mvc.1.0.view", @"/Areas/Participant/Views/Shared/_DatePicker.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Participant/Views/Shared/_DatePicker.cshtml", typeof(AspNetCore.Areas_Participant_Views_Shared__DatePicker))]
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
#line 1 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Participant\Views\_ViewImports.cshtml"
using Vote.App;

#line default
#line hidden
#line 2 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Participant\Views\_ViewImports.cshtml"
using Vote.Common.ViewModels.Polls;

#line default
#line hidden
#line 3 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Participant\Views\_ViewImports.cshtml"
using Vote.Common.ViewModels.Events;

#line default
#line hidden
#line 4 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Participant\Views\_ViewImports.cshtml"
using Vote.Common.BindingModels;

#line default
#line hidden
#line 5 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Participant\Views\_ViewImports.cshtml"
using Vote.Common.ViewModels;

#line default
#line hidden
#line 6 "D:\CSharp\FinalProject_Extended\Vote.App\Areas\Participant\Views\_ViewImports.cshtml"
using Vote.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9360ee0179e9c5f2a6797aca02f3a65915b5f23", @"/Areas/Participant/Views/Shared/_DatePicker.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90692d05df0b654536d723e5a4869591ffb40f27", @"/Areas/Participant/Views/_ViewImports.cshtml")]
    public class Areas_Participant_Views_Shared__DatePicker : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 299, true);
            WriteLiteral(@"<script src=""https://code.jquery.com/jquery-1.12.4.min.js""></script>
<script src=""https://code.jquery.com/ui/1.12.1/jquery-ui.min.js""></script>
<script>
    $(document).ready(function () {
        $('.datepicker').datepicker({
            dateFormat: 'yy-mm-dd'
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591