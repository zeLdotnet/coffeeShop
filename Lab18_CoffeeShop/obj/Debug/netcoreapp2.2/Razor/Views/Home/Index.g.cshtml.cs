#pragma checksum "C:\Users\zeL\grandCircus\labs\grandRepo\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9cceb1b8ffdffc569019bfb834f58cf9d6d1243"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9cceb1b8ffdffc569019bfb834f58cf9d6d1243", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93989b773f77e2913c612ef3051e369fe276073b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\zeL\grandCircus\labs\grandRepo\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 112, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome to the Coffee Shop!</h1>\r\n    <div class=\"reg\">\r\n");
            EndContext();
            BeginContext(215, 65, true);
            WriteLiteral("        <input class=\"button\" type=\"button\" value=\"Register Here\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 280, "\"", 329, 3);
            WriteAttributeValue("", 290, "location.href=\'", 290, 15, true);
#line 9 "C:\Users\zeL\grandCircus\labs\grandRepo\Lab18_CoffeeShop\Lab18_CoffeeShop\Views\Home\Index.cshtml"
WriteAttributeValue("", 305, Url.Action("Register"), 305, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 328, "\'", 328, 1, true);
            EndWriteAttribute();
            BeginContext(330, 476, true);
            WriteLiteral(@"/>
    </div>
</div>
<style>
    h1{
        color:sandybrown;
        background-color:saddlebrown;
        opacity:0.65;
        border-style:outset;
    }
    
    .reg{
        text-decoration:none;
        font-size: 24px;
        margin-top: 100px;
    }

    .button{
        border-radius: 12px;
        text-align: center;
        background-color: white;
        color: saddlebrown;
        opacity: 0.88;
        width:15%;
    }
</style>
");
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
