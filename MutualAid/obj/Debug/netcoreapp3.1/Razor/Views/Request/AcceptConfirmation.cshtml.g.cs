#pragma checksum "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1f1d8ac9eba8402494998de417120069284e4d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Request_AcceptConfirmation), @"mvc.1.0.view", @"/Views/Request/AcceptConfirmation.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1f1d8ac9eba8402494998de417120069284e4d1", @"/Views/Request/AcceptConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e98015e4a7b83e6cbca5cb9e1efc4fbbe2bdc33", @"/Views/_ViewImports.cshtml")]
    public class Views_Request_AcceptConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MutualAid.UI.Models.RequestViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
  
    ViewData["Title"] = "Request Confirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"display-4\">Request Confirmation</h1>\r\n<hr />\r\n<div>Thank you for accepting this order. We appreciate your help within your community.</div>\r\n<div>\r\n    <br />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayNameFor(model => model.User.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayFor(model => model.User.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayNameFor(model => model.User.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayFor(model => model.User.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayNameFor(model => model.User.County));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayFor(model => model.User.County));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayNameFor(model => model.User.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayFor(model => model.User.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayNameFor(model => model.User.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayFor(model => model.User.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayNameFor(model => model.ToiletPaper));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayFor(model => model.ToiletPaper));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayNameFor(model => model.PaperTowels));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayFor(model => model.PaperTowels));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayNameFor(model => model.HandSoap));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayFor(model => model.HandSoap));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayNameFor(model => model.Shampoo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayFor(model => model.Shampoo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayNameFor(model => model.Conditioner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayFor(model => model.Conditioner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayNameFor(model => model.Toothpaste));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayFor(model => model.Toothpaste));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayNameFor(model => model.Disinfectant));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 95 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayFor(model => model.Disinfectant));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 98 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayNameFor(model => model.Dairy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 101 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayFor(model => model.Dairy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 104 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayNameFor(model => model.Bread));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 107 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayFor(model => model.Bread));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 110 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayNameFor(model => model.Produce));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 113 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayFor(model => model.Produce));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 116 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayNameFor(model => model.CannedFood));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 119 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayFor(model => model.CannedFood));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 122 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayNameFor(model => model.Meat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 125 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayFor(model => model.Meat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 128 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayNameFor(model => model.Seafood));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 131 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayFor(model => model.Seafood));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 134 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayNameFor(model => model.Cereal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 137 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayFor(model => model.Cereal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 140 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayNameFor(model => model.Pantry));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 143 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayFor(model => model.Pantry));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 146 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayNameFor(model => model.Allergens));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 149 "C:\Users\Lauren Miles\OneDrive\Projects\MutualAidRefactor\MutualAid\Views\Request\AcceptConfirmation.cshtml"
       Write(Html.DisplayFor(model => model.Allergens));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MutualAid.UI.Models.RequestViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
