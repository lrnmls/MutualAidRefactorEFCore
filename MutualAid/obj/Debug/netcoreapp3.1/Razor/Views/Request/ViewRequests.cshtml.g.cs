#pragma checksum "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\ViewRequests.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29e98edf1870ddd7dc001fbfccf9eaee8827ecc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Request_ViewRequests), @"mvc.1.0.view", @"/Views/Request/ViewRequests.cshtml")]
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
#line 1 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\_ViewImports.cshtml"
using MutualAid;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29e98edf1870ddd7dc001fbfccf9eaee8827ecc0", @"/Views/Request/ViewRequests.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e98015e4a7b83e6cbca5cb9e1efc4fbbe2bdc33", @"/Views/_ViewImports.cshtml")]
    public class Views_Request_ViewRequests : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MutualAid.UI.Models.RequestViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\ViewRequests.cshtml"
  
    var user = AuthViewService.GetCurrentUser();
    ViewData["Title"] = "View User Requests";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"display-4\">View Requests</h1>\r\n<hr />\r\n<div>\r\n    ");
#nullable restore
#line 11 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\ViewRequests.cshtml"
Write(Html.ActionLink("Create Request", "CreateRequest", "Request"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
#nullable restore
#line 12 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\ViewRequests.cshtml"
Write(Html.ActionLink("Back to Account", "MyAccount", "Account"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<br />\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\ViewRequests.cshtml"
           Write(Html.DisplayNameFor(model => model.User.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\ViewRequests.cshtml"
           Write(Html.DisplayNameFor(model => model.User.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\ViewRequests.cshtml"
           Write(Html.DisplayNameFor(model => model.User.County));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\ViewRequests.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\ViewRequests.cshtml"
           Write(Html.DisplayNameFor(model => model.IsAccepted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\ViewRequests.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\ViewRequests.cshtml"
           Write(Html.DisplayFor(modelItem => item.User.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\ViewRequests.cshtml"
           Write(Html.DisplayFor(modelItem => item.User.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\ViewRequests.cshtml"
           Write(Html.DisplayFor(modelItem => item.User.County));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\ViewRequests.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\ViewRequests.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsAcceptedString));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
#nullable restore
#line 55 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\ViewRequests.cshtml"
             if (user.isAdmin)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 58 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\ViewRequests.cshtml"
               Write(Html.ActionLink("Details", "RequestDetails", "Request", new { reqId = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 59 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\ViewRequests.cshtml"
               Write(Html.ActionLink("Edit", "EditRequest", "Request", new { reqId = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 60 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\ViewRequests.cshtml"
               Write(Html.ActionLink("Delete", "DeleteRequest", "Request", new { reqId = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 62 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\ViewRequests.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 66 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\ViewRequests.cshtml"
               Write(Html.ActionLink("Details", "RequestDetails", "Request", new { reqId = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 68 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\ViewRequests.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 70 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\ViewRequests.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public MutualAid.UI.Interfaces.IAuthViewService AuthViewService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MutualAid.UI.Models.RequestViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591