#pragma checksum "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Cuisines/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0415d0066149847da9dc60d98be6c7bbc5b04c74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cuisines_Create), @"mvc.1.0.view", @"/Views/Cuisines/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cuisines/Create.cshtml", typeof(AspNetCore.Views_Cuisines_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0415d0066149847da9dc60d98be6c7bbc5b04c74", @"/Views/Cuisines/Create.cshtml")]
    public class Views_Cuisines_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestaurant.Models.Cuisine>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Cuisines/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(65, 28, true);
            WriteLiteral("\n<h4>Add a new cuisine</h4>\n");
            EndContext();
#line 8 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Cuisines/Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(126, 34, false);
#line 10 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Cuisines/Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(166, 36, false);
#line 11 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Cuisines/Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(203, 52, true);
            WriteLiteral("    <input type=\"submit\" value=\"Add new cuisine\" />\n");
            EndContext();
#line 13 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Cuisines/Create.cshtml"
}

#line default
#line hidden
            BeginContext(257, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(261, 44, false);
#line 14 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Cuisines/Create.cshtml"
Write(Html.ActionLink("Show all cuisine", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(305, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BestRestaurant.Models.Cuisine> Html { get; private set; }
    }
}
#pragma warning restore 1591