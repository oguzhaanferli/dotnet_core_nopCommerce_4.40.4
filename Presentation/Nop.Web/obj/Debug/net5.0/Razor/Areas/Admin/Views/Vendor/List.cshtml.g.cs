#pragma checksum "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\Vendor\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "734de5284229d244abb918966c9e8c68716a0e3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Vendor_List), @"mvc.1.0.view", @"/Areas/Admin/Views/Vendor/List.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 9 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Services.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using static Nop.Services.Common.NopLinksDefaults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Affiliates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Customers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Directory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Discounts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ExternalAuthentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Forums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Messages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.MultiFactorAuthentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Payments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins.Marketplace;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Polls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Reports;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Security;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Shipping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Stores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tax;

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Templates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Vendors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Menu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models.DataTables;

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Honeypot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\Vendor\List.cshtml"
using Nop.Core.Domain.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"734de5284229d244abb918966c9e8c68716a0e3c", @"/Areas/Admin/Views/Vendor/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"181066c519b5e3a88fbfc1b430cb86e3463f4c97", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Vendor_List : Nop.Web.Framework.Mvc.Razor.NopRazorPage<VendorSearchModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Nop.Web.Framework.TagHelpers.Admin.NopLabelTagHelper __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Admin.NopEditorTagHelper __Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Admin.NopDocReferenceTagHelper __Nop_Web_Framework_TagHelpers_Admin_NopDocReferenceTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\Vendor\List.cshtml"
  
    //page title
    ViewBag.PageTitle = T("Admin.Vendors").Text;
    //active menu item (system name)
    Html.SetActiveMenuItemSystemName("Vendors");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\Vendor\List.cshtml"
  
    const string hideSearchBlockAttributeName = "VendorsPage.HideSearchBlock";
    var hideSearchBlock = await genericAttributeService.GetAttributeAsync<bool>(await workContext.GetCurrentCustomerAsync(), hideSearchBlockAttributeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"content-header clearfix\">\r\n    <h1 class=\"float-left\">\r\n        ");
#nullable restore
#line 18 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\Vendor\List.cshtml"
   Write(T("Admin.Vendors"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h1>\r\n    <div class=\"float-right\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "734de5284229d244abb918966c9e8c68716a0e3c17964", async() => {
                WriteLiteral("\r\n            <i class=\"fas fa-plus-square\"></i>\r\n            ");
#nullable restore
#line 23 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\Vendor\List.cshtml"
       Write(T("Admin.Common.AddNew"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
#nullable restore
#line 25 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\Vendor\List.cshtml"
   Write(await Component.InvokeAsync("AdminWidget", new { widgetZone = AdminWidgetZones.VendorListButtons }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</div>

<section class=""content"">
    <div class=""container-fluid"">
    <div class=""form-horizontal"">
        <div class=""cards-group"">
            <div class=""card card-default card-search"">
                <div class=""card-body"">
                    <div");
            BeginWriteAttribute("class", " class=\"", 1153, "\"", 1211, 3);
            WriteAttributeValue("", 1161, "row", 1161, 3, true);
            WriteAttributeValue(" ", 1164, "search-row", 1165, 11, true);
#nullable restore
#line 35 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\Vendor\List.cshtml"
WriteAttributeValue(" ", 1175, !hideSearchBlock ? "opened" : "", 1176, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-hideAttribute=\"");
#nullable restore
#line 35 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\Vendor\List.cshtml"
                                                                                                   Write(hideSearchBlockAttributeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <div class=\"search-text\">");
#nullable restore
#line 36 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\Vendor\List.cshtml"
                                            Write(T("Admin.Common.Search"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"icon-search\"><i class=\"fas fa-search\" aria-hidden=\"true\"></i></div>\r\n                        <div class=\"icon-collapse\"><i");
            BeginWriteAttribute("class", " class=\"", 1506, "\"", 1562, 3);
            WriteAttributeValue("", 1514, "far", 1514, 3, true);
            WriteAttributeValue(" ", 1517, "fa-angle-", 1518, 10, true);
#nullable restore
#line 38 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\Vendor\List.cshtml"
WriteAttributeValue("", 1527, !hideSearchBlock ? "up" : "down", 1527, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-hidden=\"true\"></i></div>\r\n                    </div>\r\n\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 1649, "\"", 1703, 2);
            WriteAttributeValue("", 1657, "search-body", 1657, 11, true);
#nullable restore
#line 41 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\Vendor\List.cshtml"
WriteAttributeValue(" ", 1668, hideSearchBlock ? "closed" : "", 1669, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <div class=""form-group row"">
                                    <div class=""col-md-4"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "734de5284229d244abb918966c9e8c68716a0e3c23104", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopLabelTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper);
#nullable restore
#line 46 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\Vendor\List.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchName);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"col-md-8\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-editor", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "734de5284229d244abb918966c9e8c68716a0e3c24738", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopEditorTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper);
#nullable restore
#line 49 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\Vendor\List.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchName);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                                </div>
                            <div class=""col-md-6"">
                                <div class=""form-group row"">
                                    <div class=""col-md-4"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "734de5284229d244abb918966c9e8c68716a0e3c26571", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopLabelTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper);
#nullable restore
#line 56 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\Vendor\List.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchEmail);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"col-md-8\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-editor", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "734de5284229d244abb918966c9e8c68716a0e3c28206", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopEditorTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper);
#nullable restore
#line 59 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\Vendor\List.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchEmail);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""text-center col-12"">
                                <button type=""button"" id=""search-vendors"" class=""btn btn-primary btn-search"">
                                    <i class=""fas fa-search""></i>
                                    ");
#nullable restore
#line 68 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\Vendor\List.cshtml"
                               Write(T("Admin.Common.Search"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""card card-default"">
                <div class=""card-body"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-doc-reference", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "734de5284229d244abb918966c9e8c68716a0e3c30770", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopDocReferenceTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopDocReferenceTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopDocReferenceTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\Vendor\List.cshtml"
                                                WriteLiteral(T("Admin.Documentation.Reference.VendorManagement", Docs.VendorManagement + Utm.OnAdmin));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Nop_Web_Framework_TagHelpers_Admin_NopDocReferenceTagHelper.StringResource = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-string-resource", __Nop_Web_Framework_TagHelpers_Admin_NopDocReferenceTagHelper.StringResource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    ");
#nullable restore
#line 80 "C:\Users\admin\Documents\GitHub\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Areas\Admin\Views\Vendor\List.cshtml"
               Write(await Html.PartialAsync("Table", new DataTablesModel
                    {
                        Name = "vendors-grid",
                        UrlRead = new DataUrl("List", "Vendor", null),
                        SearchButtonId = "search-vendors",
                        Length = Model.PageSize,
                        LengthMenu = Model.AvailablePageSizes,
                        Filters = new List<FilterParameter>
                        {
                            new FilterParameter(nameof(Model.SearchName)),
                            new FilterParameter(nameof(Model.SearchEmail))
                        },
                        ColumnCollection = new List<ColumnProperty>
                        {
                            new ColumnProperty(nameof(VendorModel.Name))
                            {
                                Title = T("Admin.Vendors.Fields.Name").Text,
                                Width = "300"
                            },
                            new ColumnProperty(nameof(VendorModel.Email))
                            {
                                Title = T("Admin.Vendors.Fields.Email").Text,
                                Width = "300"
                            },
                            new ColumnProperty(nameof(VendorModel.Active))
                            {
                                Title = T("Admin.Vendors.Fields.Active").Text,
                                Width = "50",
                                ClassName =  NopColumnClassDefaults.CenterAll,
                                Render = new RenderBoolean()
                            },
                            new ColumnProperty(nameof(VendorModel.Id))
                            {
                                Title = T("Admin.Common.Edit").Text,
                                Width = "50",
                                ClassName =  NopColumnClassDefaults.Button,
                                Render = new RenderButtonEdit(new DataUrl("Edit"))
                            }
                        }
                    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n</section>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWorkContext workContext { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IGenericAttributeService genericAttributeService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VendorSearchModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
