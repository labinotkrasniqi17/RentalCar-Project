#pragma checksum "C:\Users\lenovo\Desktop\Rent a car(Xh.-Projekti)\RentalCar\Views\Account\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8484d70cf2d6ca2b8aa60504969a05ae55d2fc52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Users), @"mvc.1.0.view", @"/Views/Account/Users.cshtml")]
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
#line 1 "C:\Users\lenovo\Desktop\Rent a car(Xh.-Projekti)\RentalCar\Views\_ViewImports.cshtml"
using RentalCar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\Desktop\Rent a car(Xh.-Projekti)\RentalCar\Views\_ViewImports.cshtml"
using RentalCar.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lenovo\Desktop\Rent a car(Xh.-Projekti)\RentalCar\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lenovo\Desktop\Rent a car(Xh.-Projekti)\RentalCar\Views\Account\Users.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lenovo\Desktop\Rent a car(Xh.-Projekti)\RentalCar\Views\Account\Users.cshtml"
using X.PagedList.Mvc.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lenovo\Desktop\Rent a car(Xh.-Projekti)\RentalCar\Views\Account\Users.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8484d70cf2d6ca2b8aa60504969a05ae55d2fc52", @"/Views/Account/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df1e5268667d36c6382d12e4cda76ad98a980c28", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<ApplicationUser>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "C:\Users\lenovo\Desktop\Rent a car(Xh.-Projekti)\RentalCar\Views\Account\Users.cshtml"
  
    ViewData["Title"] = "List of Users";

    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 16 "C:\Users\lenovo\Desktop\Rent a car(Xh.-Projekti)\RentalCar\Views\Account\Users.cshtml"
     using (Html.BeginForm("Users", "Account", FormMethod.Get))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p style=\"margin-top:10px; margin-left:30px\">\r\n            <b>Find by name</b> : ");
#nullable restore
#line 19 "C:\Users\lenovo\Desktop\Rent a car(Xh.-Projekti)\RentalCar\Views\Account\Users.cshtml"
                             Write(Html.TextBox("SearchString", ViewBag.CurrentFilter as string));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n");
#nullable restore
#line 21 "C:\Users\lenovo\Desktop\Rent a car(Xh.-Projekti)\RentalCar\Views\Account\Users.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-6 offset-0\">\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 27 "C:\Users\lenovo\Desktop\Rent a car(Xh.-Projekti)\RentalCar\Views\Account\Users.cshtml"
                   Write(Html.ActionLink("Full Name", "Users", new { sortOrder = ViewBag.NameSortParm, currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n\r\n                    <th>\r\n                        ");
#nullable restore
#line 31 "C:\Users\lenovo\Desktop\Rent a car(Xh.-Projekti)\RentalCar\Views\Account\Users.cshtml"
                   Write(Html.ActionLink("Username", "Users", new { sortOrder = ViewBag.NameSortParm, currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 34 "C:\Users\lenovo\Desktop\Rent a car(Xh.-Projekti)\RentalCar\Views\Account\Users.cshtml"
                   Write(Html.ActionLink("Email", "Users", new { sortOrder = ViewBag.NameSortParm, currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 39 "C:\Users\lenovo\Desktop\Rent a car(Xh.-Projekti)\RentalCar\Views\Account\Users.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"align-middle\">\r\n                            ");
#nullable restore
#line 43 "C:\Users\lenovo\Desktop\Rent a car(Xh.-Projekti)\RentalCar\Views\Account\Users.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
#nullable restore
#line 46 "C:\Users\lenovo\Desktop\Rent a car(Xh.-Projekti)\RentalCar\Views\Account\Users.cshtml"
                       Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
#nullable restore
#line 49 "C:\Users\lenovo\Desktop\Rent a car(Xh.-Projekti)\RentalCar\Views\Account\Users.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 52 "C:\Users\lenovo\Desktop\Rent a car(Xh.-Projekti)\RentalCar\Views\Account\Users.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n<br />\r\n\r\n<div class=\"col-md-6 offset-3\">\r\n\r\n    <button class=\"btn-info\">\r\n        Page ");
#nullable restore
#line 62 "C:\Users\lenovo\Desktop\Rent a car(Xh.-Projekti)\RentalCar\Views\Account\Users.cshtml"
         Write(Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 62 "C:\Users\lenovo\Desktop\Rent a car(Xh.-Projekti)\RentalCar\Views\Account\Users.cshtml"
                                                                        Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </button>\r\n    ");
#nullable restore
#line 64 "C:\Users\lenovo\Desktop\Rent a car(Xh.-Projekti)\RentalCar\Views\Account\Users.cshtml"
Write(Html.PagedListPager(Model, page => Url.Action("Users",
   new { page, sortOrder = ViewBag.CurrentSort, currentFilter = ViewBag.CurrentFilter })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<ApplicationUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
