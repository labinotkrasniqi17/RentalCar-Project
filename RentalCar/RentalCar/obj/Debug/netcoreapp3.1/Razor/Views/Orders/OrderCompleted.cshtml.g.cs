#pragma checksum "C:\Users\lenovo\Desktop\Rent a car(Xh.-Projekti)\RentalCar\Views\Orders\OrderCompleted.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb897a00c4759af69df9611393fb6641d033c36f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_OrderCompleted), @"mvc.1.0.view", @"/Views/Orders/OrderCompleted.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb897a00c4759af69df9611393fb6641d033c36f", @"/Views/Orders/OrderCompleted.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df1e5268667d36c6382d12e4cda76ad98a980c28", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Orders_OrderCompleted : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\lenovo\Desktop\Rent a car(Xh.-Projekti)\RentalCar\Views\Orders\OrderCompleted.cshtml"
  
    ViewData["Title"] = "All Orders";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-6  offset-3 alert alert-success text-center\">\r\n");
#nullable restore
#line 9 "C:\Users\lenovo\Desktop\Rent a car(Xh.-Projekti)\RentalCar\Views\Orders\OrderCompleted.cshtml"
         foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>Order Completed Successfully</h2>\r\n        <p>You can check all your orders in the Orders section of your profile</p>\r\n");
#nullable restore
#line 12 "C:\Users\lenovo\Desktop\Rent a car(Xh.-Projekti)\RentalCar\Views\Orders\OrderCompleted.cshtml"
       Write(item.User);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <hr />\r\n        <p>Thank You!</p>\r\n");
#nullable restore
#line 15 "C:\Users\lenovo\Desktop\Rent a car(Xh.-Projekti)\RentalCar\Views\Orders\OrderCompleted.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
