#pragma checksum "C:\Users\saaru\Desktop\Application Development GroupCoursework\GroupCoursework\Program\RopeyDvd\RopayDvd\Views\Reports\Report11.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09d2bebef5103f3eae1db6945184f5836a1ff563"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reports_Report11), @"mvc.1.0.view", @"/Views/Reports/Report11.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09d2bebef5103f3eae1db6945184f5836a1ff563", @"/Views/Reports/Report11.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dc3e2d055f51c7015617562fd7534dbca520dc3", @"/Views/_ViewImports.cshtml")]
    public class Views_Reports_Report11 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RopayDvd.Models.Loan>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\saaru\Desktop\Application Development GroupCoursework\GroupCoursework\Program\RopeyDvd\RopayDvd\Views\Reports\Report11.cshtml"
  
    ViewData["Title"] = "DVD Loan Details";
    var datewiseReport = Model.Select(l=>l.DateOut).Distinct();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4 class=\"text-center h3 text-white mb-4\">");
#nullable restore
#line 8 "C:\Users\saaru\Desktop\Application Development GroupCoursework\GroupCoursework\Program\RopeyDvd\RopayDvd\Views\Reports\Report11.cshtml"
                                      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
<table class=""table"">
    <thead>
        <tr>
            <th class=""h6 text-white "">Loan Date</th>
            <th class=""h6 text-white "">
                Dvd Title
            </th>
            <th class=""h6 text-white "">
                Copy Number
            </th>
            <th class=""h6 text-white "">
                Borrower Name
            </th>
            <th class=""h6 text-white "">   
                No. of Loans
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 28 "C:\Users\saaru\Desktop\Application Development GroupCoursework\GroupCoursework\Program\RopeyDvd\RopayDvd\Views\Reports\Report11.cshtml"
 foreach (var item in datewiseReport) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\saaru\Desktop\Application Development GroupCoursework\GroupCoursework\Program\RopeyDvd\RopayDvd\Views\Reports\Report11.cshtml"
           Write(item.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"text-white\">\r\n                <ul>\r\n");
#nullable restore
#line 35 "C:\Users\saaru\Desktop\Application Development GroupCoursework\GroupCoursework\Program\RopeyDvd\RopayDvd\Views\Reports\Report11.cshtml"
                     foreach (Loan loan in Model.Where(l => l.DateOut == item).OrderBy(l=>l.CopyNumberNavigation.DvdNumberNavigation.DvdTite))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>");
#nullable restore
#line 37 "C:\Users\saaru\Desktop\Application Development GroupCoursework\GroupCoursework\Program\RopeyDvd\RopayDvd\Views\Reports\Report11.cshtml"
                       Write(loan.CopyNumberNavigation.DvdNumberNavigation.DvdTite);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 38 "C:\Users\saaru\Desktop\Application Development GroupCoursework\GroupCoursework\Program\RopeyDvd\RopayDvd\Views\Reports\Report11.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </td>\r\n            <td class=\"text-white\">\r\n                <ul>\r\n");
#nullable restore
#line 43 "C:\Users\saaru\Desktop\Application Development GroupCoursework\GroupCoursework\Program\RopeyDvd\RopayDvd\Views\Reports\Report11.cshtml"
                     foreach (Loan loan in Model.Where(l => l.DateOut == item).OrderBy(l => l.CopyNumberNavigation.DvdNumberNavigation.DvdTite))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>");
#nullable restore
#line 45 "C:\Users\saaru\Desktop\Application Development GroupCoursework\GroupCoursework\Program\RopeyDvd\RopayDvd\Views\Reports\Report11.cshtml"
                       Write(loan.CopyNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 46 "C:\Users\saaru\Desktop\Application Development GroupCoursework\GroupCoursework\Program\RopeyDvd\RopayDvd\Views\Reports\Report11.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </td>\r\n            <td class=\"text-white\">\r\n                <ul>\r\n");
#nullable restore
#line 51 "C:\Users\saaru\Desktop\Application Development GroupCoursework\GroupCoursework\Program\RopeyDvd\RopayDvd\Views\Reports\Report11.cshtml"
                     foreach (Loan loan in Model.Where(l => l.DateOut == item).OrderBy(l => l.CopyNumberNavigation.DvdNumberNavigation.DvdTite))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>");
#nullable restore
#line 53 "C:\Users\saaru\Desktop\Application Development GroupCoursework\GroupCoursework\Program\RopeyDvd\RopayDvd\Views\Reports\Report11.cshtml"
                        Write(loan.MemberNumberNavigation.MemberFirstName+" "+loan.MemberNumberNavigation.MemberLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 54 "C:\Users\saaru\Desktop\Application Development GroupCoursework\GroupCoursework\Program\RopeyDvd\RopayDvd\Views\Reports\Report11.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>                \r\n            </td>            \r\n            <td class=\"text-white\">                \r\n                ");
#nullable restore
#line 58 "C:\Users\saaru\Desktop\Application Development GroupCoursework\GroupCoursework\Program\RopeyDvd\RopayDvd\Views\Reports\Report11.cshtml"
           Write(Model.Where(l=>l.DateOut==item).ToList().Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 61 "C:\Users\saaru\Desktop\Application Development GroupCoursework\GroupCoursework\Program\RopeyDvd\RopayDvd\Views\Reports\Report11.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RopayDvd.Models.Loan>> Html { get; private set; }
    }
}
#pragma warning restore 1591
