#pragma checksum "C:\Users\zeL\grandCircus\labs\grandRepo\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Home\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49f77777bc1bdbe7cfd482c50013a751b4d665a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Register), @"mvc.1.0.view", @"/Views/Home/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Register.cshtml", typeof(AspNetCore.Views_Home_Register))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49f77777bc1bdbe7cfd482c50013a751b4d665a1", @"/Views/Home/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93989b773f77e2913c612ef3051e369fe276073b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab18_CoffeeShop.Models.RegisterUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\zeL\grandCircus\labs\grandRepo\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Home\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
            BeginContext(46, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 8 "C:\Users\zeL\grandCircus\labs\grandRepo\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Home\Register.cshtml"
 using (var form = Html.BeginForm())
{

#line default
#line hidden
            BeginContext(136, 53, true);
            WriteLiteral("    <div class=\"form\">\r\n\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(190, 89, false);
#line 13 "C:\Users\zeL\grandCircus\labs\grandRepo\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Home\Register.cshtml"
       Write(Html.TextBoxFor(m => m.UserName, new { placeholder = "userName", @class = "form-input" }));

#line default
#line hidden
            EndContext();
            BeginContext(279, 45, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(325, 90, false);
#line 16 "C:\Users\zeL\grandCircus\labs\grandRepo\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Home\Register.cshtml"
       Write(Html.TextBoxFor(m => m.NickName, new { placeholder = "Nick Name", @class = "form-input" }));

#line default
#line hidden
            EndContext();
            BeginContext(415, 45, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(461, 82, false);
#line 19 "C:\Users\zeL\grandCircus\labs\grandRepo\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Home\Register.cshtml"
       Write(Html.TextBoxFor(m => m.BirthDay, new { @type = "date", placeholder = "birthday" }));

#line default
#line hidden
            EndContext();
            BeginContext(543, 45, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(589, 83, false);
#line 22 "C:\Users\zeL\grandCircus\labs\grandRepo\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Home\Register.cshtml"
       Write(Html.TextBoxFor(m => m.Email, new { placeholder = "Email", @class = "form-input" }));

#line default
#line hidden
            EndContext();
            BeginContext(672, 45, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(718, 110, false);
#line 25 "C:\Users\zeL\grandCircus\labs\grandRepo\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Home\Register.cshtml"
       Write(Html.PasswordFor(m => m.Password, new { placeholder = "Password", @class = "form-input", @type = "password" }));

#line default
#line hidden
            EndContext();
            BeginContext(828, 28, true);
            WriteLiteral("\r\n\r\n        </div>\r\n        ");
            EndContext();
            BeginContext(857, 24, false);
#line 28 "C:\Users\zeL\grandCircus\labs\grandRepo\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Home\Register.cshtml"
   Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(881, 62, true);
            WriteLiteral("\r\n        <input type=\"submit\" value=\"Submit\" />\r\n    </div>\r\n");
            EndContext();
            BeginContext(945, 266, true);
            WriteLiteral(@"    <style>
        input {
            margin-bottom: 5px;
        }

        .form {
            text-align: center;
            padding: 160px 0px 50px 0px;
            
        }

        .form li{
            color: red;
        }

    </style>
");
            EndContext();
#line 48 "C:\Users\zeL\grandCircus\labs\grandRepo\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Home\Register.cshtml"
}

#line default
#line hidden
            BeginContext(1214, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab18_CoffeeShop.Models.RegisterUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
