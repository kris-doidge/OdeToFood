#pragma checksum "C:\Users\kdoid\Documents\PluralSight\OdeToFood\OdeToFood\Pages\Restaurants\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a1fd777b3319851856d8460cdfc2d7325c786d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OdeToFood.Pages.Restaurants.Pages_Restaurants_List), @"mvc.1.0.razor-page", @"/Pages/Restaurants/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Restaurants/List.cshtml", typeof(OdeToFood.Pages.Restaurants.Pages_Restaurants_List), null)]
namespace OdeToFood.Pages.Restaurants
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\kdoid\Documents\PluralSight\OdeToFood\OdeToFood\Pages\_ViewImports.cshtml"
using OdeToFood;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1fd777b3319851856d8460cdfc2d7325c786d3", @"/Pages/Restaurants/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0820fb6dbe507f6ce740cdfd07cdc5236e4275df", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Restaurants_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\kdoid\Documents\PluralSight\OdeToFood\OdeToFood\Pages\Restaurants\List.cshtml"
  
    ViewData["Title"] = "Restaurants";

#line default
#line hidden
            BeginContext(72, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(74, 269, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a1fd777b3319851856d8460cdfc2d7325c786d33745", async() => {
                BeginContext(94, 242, true);
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <input type=\"search\" class=\"form-control\" value=\"\" name=\"searchTerm\" />\r\n        <span class=\"input-group-btn\">\r\n            <button class=\"btn btn-dark\">Search</button>\r\n        </span>\r\n\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(343, 25, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n");
            EndContext();
#line 17 "C:\Users\kdoid\Documents\PluralSight\OdeToFood\OdeToFood\Pages\Restaurants\List.cshtml"
     foreach (var restaurant in Model.Restaurants)
    {

#line default
#line hidden
            BeginContext(427, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(458, 15, false);
#line 20 "C:\Users\kdoid\Documents\PluralSight\OdeToFood\OdeToFood\Pages\Restaurants\List.cshtml"
           Write(restaurant.Name);

#line default
#line hidden
            EndContext();
            BeginContext(473, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(497, 19, false);
#line 21 "C:\Users\kdoid\Documents\PluralSight\OdeToFood\OdeToFood\Pages\Restaurants\List.cshtml"
           Write(restaurant.Location);

#line default
#line hidden
            EndContext();
            BeginContext(516, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(540, 22, false);
#line 22 "C:\Users\kdoid\Documents\PluralSight\OdeToFood\OdeToFood\Pages\Restaurants\List.cshtml"
           Write(restaurant.CuisineType);

#line default
#line hidden
            EndContext();
            BeginContext(562, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 24 "C:\Users\kdoid\Documents\PluralSight\OdeToFood\OdeToFood\Pages\Restaurants\List.cshtml"
    }

#line default
#line hidden
            BeginContext(591, 32, true);
            WriteLiteral("</table>\r\n\r\n<h2>Restaurants</h2>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ListModel>)PageContext?.ViewData;
        public ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
