#pragma checksum "C:\Users\zeL\grandCircus\labs\grandRepo\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Home\AddUserToList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19724b5106af23bd5962101b2469e45288a4c11c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddUserToList), @"mvc.1.0.view", @"/Views/Home/AddUserToList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AddUserToList.cshtml", typeof(AspNetCore.Views_Home_AddUserToList))]
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
#line 1 "C:\Users\zeL\grandCircus\labs\grandRepo\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\_ViewImports.cshtml"
using Lab18_CoffeeShop;

#line default
#line hidden
#line 2 "C:\Users\zeL\grandCircus\labs\grandRepo\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\_ViewImports.cshtml"
using Lab18_CoffeeShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19724b5106af23bd5962101b2469e45288a4c11c", @"/Views/Home/AddUserToList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93989b773f77e2913c612ef3051e369fe276073b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AddUserToList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Lab18_CoffeeShop.Models.RegisterUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\zeL\grandCircus\labs\grandRepo\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Home\AddUserToList.cshtml"
  
    ViewData["Title"] = "AddUserToList";

#line default
#line hidden
            BeginContext(51, 26, true);
            WriteLiteral("\r\n<h1>AddUserToList</h1>\r\n");
            EndContext();
            BeginContext(135, 75, true);
            WriteLiteral("<table>\r\n    <tr>\r\n        <th>User Name</th>\r\n        <th>Nick Name</th>\r\n");
            EndContext();
            BeginContext(236, 35, true);
            WriteLiteral("        <th>email</th>\r\n    </tr>\r\n");
            EndContext();
#line 15 "C:\Users\zeL\grandCircus\labs\grandRepo\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Home\AddUserToList.cshtml"
     foreach (var user in Model)
    {

#line default
#line hidden
            BeginContext(312, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(343, 13, false);
#line 18 "C:\Users\zeL\grandCircus\labs\grandRepo\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Home\AddUserToList.cshtml"
           Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(356, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(380, 13, false);
#line 19 "C:\Users\zeL\grandCircus\labs\grandRepo\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Home\AddUserToList.cshtml"
           Write(user.NickName);

#line default
#line hidden
            EndContext();
            BeginContext(393, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
            BeginContext(441, 16, true);
            WriteLiteral("            <td>");
            EndContext();
            BeginContext(458, 10, false);
#line 21 "C:\Users\zeL\grandCircus\labs\grandRepo\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Home\AddUserToList.cshtml"
           Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(468, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 23 "C:\Users\zeL\grandCircus\labs\grandRepo\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Home\AddUserToList.cshtml"
    }

#line default
#line hidden
            BeginContext(497, 12, true);
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Lab18_CoffeeShop.Models.RegisterUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
