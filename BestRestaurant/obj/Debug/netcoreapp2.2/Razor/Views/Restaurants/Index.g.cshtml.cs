#pragma checksum "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "303e337a79b8721ad8b05b9072f0c05247bb61d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_Index), @"mvc.1.0.view", @"/Views/Restaurants/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Restaurants/Index.cshtml", typeof(AspNetCore.Views_Restaurants_Index))]
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
#line 5 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Index.cshtml"
using BestRestaurant.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"303e337a79b8721ad8b05b9072f0c05247bb61d1", @"/Views/Restaurants/Index.cshtml")]
    public class Views_Restaurants_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BestRestaurant.Models.Restaurant>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(105, 23, true);
            WriteLiteral("\n<h1>Restaurants</h1>\n\n");
            EndContext();
#line 10 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(154, 47, true);
            WriteLiteral("  <h3>No Restaurants have been added yet!</h3>\n");
            EndContext();
#line 13 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Index.cshtml"
} 

#line default
#line hidden
            BeginContext(204, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 15 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Index.cshtml"
 foreach (Restaurant restaurant in Model)
{

#line default
#line hidden
            BeginContext(249, 6, true);
            WriteLiteral("  <li>");
            EndContext();
            BeginContext(256, 93, false);
#line 17 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Index.cshtml"
 Write(Html.ActionLink($"{restaurant.Description}", "Details", new { id = restaurant.RestaurantId }));

#line default
#line hidden
            EndContext();
            BeginContext(349, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(353, 23, false);
#line 17 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Index.cshtml"
                                                                                                  Write(restaurant.Cuisine.Name);

#line default
#line hidden
            EndContext();
            BeginContext(376, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 18 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Index.cshtml"
}

#line default
#line hidden
            BeginContext(384, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(389, 47, false);
#line 20 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Index.cshtml"
Write(Html.ActionLink("Add new restaurant", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(436, 9, true);
            WriteLiteral("</p>\n\n<p>");
            EndContext();
            BeginContext(446, 40, false);
#line 22 "/Users/danaluukko/Desktop/BestRestaurant.Solution/BestRestaurant/Views/Restaurants/Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(486, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BestRestaurant.Models.Restaurant>> Html { get; private set; }
    }
}
#pragma warning restore 1591
