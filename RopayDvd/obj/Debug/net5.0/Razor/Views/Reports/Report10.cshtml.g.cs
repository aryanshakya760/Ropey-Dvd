#pragma checksum "C:\Users\saaru\Desktop\Application Development GroupCoursework\GroupCoursework\Program\RopeyDvd\RopayDvd\Views\Reports\Report10.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c4c42116e2854fc602d6b7f52d45025aba296f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reports_Report10), @"mvc.1.0.view", @"/Views/Reports/Report10.cshtml")]
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
#line 1 "C:\Users\saaru\Desktop\Application Development GroupCoursework\GroupCoursework\Program\RopeyDvd\RopayDvd\Views\_ViewImports.cshtml"
using RopayDvd.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c4c42116e2854fc602d6b7f52d45025aba296f9", @"/Views/Reports/Report10.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dc3e2d055f51c7015617562fd7534dbca520dc3", @"/Views/_ViewImports.cshtml")]
    public class Views_Reports_Report10 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RopayDvd.Models.DvdCopy>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DvdCopies", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-ctrName", "Reports", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\saaru\Desktop\Application Development GroupCoursework\GroupCoursework\Program\RopeyDvd\RopayDvd\Views\Reports\Report10.cshtml"
  
    ViewData["Title"] = "DVD and Copy Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4 class=\"text-center h3 text-white mb-4\">");
#nullable restore
#line 7 "C:\Users\saaru\Desktop\Application Development GroupCoursework\GroupCoursework\Program\RopeyDvd\RopayDvd\Views\Reports\Report10.cshtml"
                                      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
<table class=""table"">
    <thead>
        <tr>
            <th class=""h6 text-white "">
                Dvd Title
            </th>
            <th class=""h6 text-white "">
                Copy Number
            </th>
            <th class=""h6 text-white "">
                Purchased Date
            </th>
            <th>              
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 25 "C:\Users\saaru\Desktop\Application Development GroupCoursework\GroupCoursework\Program\RopeyDvd\RopayDvd\Views\Reports\Report10.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class=\"text-white\">\r\n                ");
#nullable restore
#line 28 "C:\Users\saaru\Desktop\Application Development GroupCoursework\GroupCoursework\Program\RopeyDvd\RopayDvd\Views\Reports\Report10.cshtml"
           Write(item.DvdNumberNavigation.DvdTite);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"text-white\">\r\n                ");
#nullable restore
#line 31 "C:\Users\saaru\Desktop\Application Development GroupCoursework\GroupCoursework\Program\RopeyDvd\RopayDvd\Views\Reports\Report10.cshtml"
           Write(item.CopyNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"text-white\">\r\n                ");
#nullable restore
#line 34 "C:\Users\saaru\Desktop\Application Development GroupCoursework\GroupCoursework\Program\RopeyDvd\RopayDvd\Views\Reports\Report10.cshtml"
           Write(item.DatePurchased.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>            \r\n            <td>                \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c4c42116e2854fc602d6b7f52d45025aba296f96535", async() => {
                WriteLiteral("Remove");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ctrName", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ctrName"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\saaru\Desktop\Application Development GroupCoursework\GroupCoursework\Program\RopeyDvd\RopayDvd\Views\Reports\Report10.cshtml"
                                                                                                WriteLiteral(item.CopyNumber);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 40 "C:\Users\saaru\Desktop\Application Development GroupCoursework\GroupCoursework\Program\RopeyDvd\RopayDvd\Views\Reports\Report10.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RopayDvd.Models.DvdCopy>> Html { get; private set; }
    }
}
#pragma warning restore 1591