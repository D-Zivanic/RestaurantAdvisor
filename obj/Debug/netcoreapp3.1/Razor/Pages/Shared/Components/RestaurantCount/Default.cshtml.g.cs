#pragma checksum "C:\Users\dcvis\source\repos\RestaurantAdvisor\Pages\Shared\Components\RestaurantCount\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bdcca6ba65b0eb5daae9a32bcb47ae5ce56fb99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RestaurantAdvisor.Pages.Shared.Components.RestaurantCount.Pages_Shared_Components_RestaurantCount_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/RestaurantCount/Default.cshtml")]
namespace RestaurantAdvisor.Pages.Shared.Components.RestaurantCount
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
#line 1 "C:\Users\dcvis\source\repos\RestaurantAdvisor\Pages\_ViewImports.cshtml"
using RestaurantAdvisor;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bdcca6ba65b0eb5daae9a32bcb47ae5ce56fb99", @"/Pages/Shared/Components/RestaurantCount/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09709bd4dbf45a3821c5a3c17dfd56c912cc13ef", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_RestaurantCount_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"well\">\r\n    There are ");
#nullable restore
#line 4 "C:\Users\dcvis\source\repos\RestaurantAdvisor\Pages\Shared\Components\RestaurantCount\Default.cshtml"
         Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Restaurants in our database.\r\n</div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
