#pragma checksum "D:\BME_Laborok_előadások\Specializációs tárgyak\Webportál_fejlesztés\MyWorkout\MyWorkout.Web\Pages\Components\Pager\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83d37efe5970e7d503b6ff586ec54f3677dbb8a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyWorkout.Web.Pages.Components.Pager.Pages_Components_Pager_Default), @"mvc.1.0.view", @"/Pages/Components/Pager/Default.cshtml")]
namespace MyWorkout.Web.Pages.Components.Pager
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
#line 1 "D:\BME_Laborok_előadások\Specializációs tárgyak\Webportál_fejlesztés\MyWorkout\MyWorkout.Web\Pages\_ViewImports.cshtml"
using MyWorkout.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83d37efe5970e7d503b6ff586ec54f3677dbb8a0", @"/Pages/Components/Pager/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"700693020a0ba3b68bbfb046871333cc3236c550", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Components_Pager_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyWorkout.Web.ViewComponents.PagerViewComponent.PagerSpecification>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-pageNumber", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 5 "D:\BME_Laborok_előadások\Specializációs tárgyak\Webportál_fejlesztés\MyWorkout\MyWorkout.Web\Pages\Components\Pager\Default.cshtml"
 if (Model.TotalPages > 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <nav>\r\n        <ul class=\"pagination justify-content-center\">\r\n");
#nullable restore
#line 9 "D:\BME_Laborok_előadások\Specializációs tárgyak\Webportál_fejlesztés\MyWorkout\MyWorkout.Web\Pages\Components\Pager\Default.cshtml"
             if (Model.PageNumber > 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83d37efe5970e7d503b6ff586ec54f3677dbb8a04507", async() => {
                WriteLiteral("\r\n                        <span>&laquo;</span>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 16 "D:\BME_Laborok_előadások\Specializációs tárgyak\Webportál_fejlesztés\MyWorkout\MyWorkout.Web\Pages\Components\Pager\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 18 "D:\BME_Laborok_előadások\Specializációs tárgyak\Webportál_fejlesztés\MyWorkout\MyWorkout.Web\Pages\Components\Pager\Default.cshtml"
             for (var pageNumber = Math.Max(1, Model.PageNumber - Model.PagesToShow);
              pageNumber < Math.Min(Model.TotalPages, Model.PageNumber + Model.PagesToShow);
              pageNumber++)
            {
                if (Model.PageNumber == pageNumber)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item active\">\r\n                        <a class=\"page-link\">\r\n                            ");
#nullable restore
#line 26 "D:\BME_Laborok_előadások\Specializációs tárgyak\Webportál_fejlesztés\MyWorkout\MyWorkout.Web\Pages\Components\Pager\Default.cshtml"
                       Write(pageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                    </li>\r\n");
#nullable restore
#line 29 "D:\BME_Laborok_előadások\Specializációs tárgyak\Webportál_fejlesztés\MyWorkout\MyWorkout.Web\Pages\Components\Pager\Default.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83d37efe5970e7d503b6ff586ec54f3677dbb8a07822", async() => {
                WriteLiteral("\r\n                            ");
#nullable restore
#line 34 "D:\BME_Laborok_előadások\Specializációs tárgyak\Webportál_fejlesztés\MyWorkout\MyWorkout.Web\Pages\Components\Pager\Default.cshtml"
                       Write(pageNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "D:\BME_Laborok_előadások\Specializációs tárgyak\Webportál_fejlesztés\MyWorkout\MyWorkout.Web\Pages\Components\Pager\Default.cshtml"
                                     WriteLiteral(pageNumber);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n");
#nullable restore
#line 37 "D:\BME_Laborok_előadások\Specializációs tárgyak\Webportál_fejlesztés\MyWorkout\MyWorkout.Web\Pages\Components\Pager\Default.cshtml"
                }

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 42 "D:\BME_Laborok_előadások\Specializációs tárgyak\Webportál_fejlesztés\MyWorkout\MyWorkout.Web\Pages\Components\Pager\Default.cshtml"
             if (Model.PageNumber < Model.TotalPages)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83d37efe5970e7d503b6ff586ec54f3677dbb8a010973", async() => {
                WriteLiteral("\r\n                        <span>&raquo;</span>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 49 "D:\BME_Laborok_előadások\Specializációs tárgyak\Webportál_fejlesztés\MyWorkout\MyWorkout.Web\Pages\Components\Pager\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </nav>\r\n");
#nullable restore
#line 52 "D:\BME_Laborok_előadások\Specializációs tárgyak\Webportál_fejlesztés\MyWorkout\MyWorkout.Web\Pages\Components\Pager\Default.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyWorkout.Web.ViewComponents.PagerViewComponent.PagerSpecification> Html { get; private set; }
    }
}
#pragma warning restore 1591
