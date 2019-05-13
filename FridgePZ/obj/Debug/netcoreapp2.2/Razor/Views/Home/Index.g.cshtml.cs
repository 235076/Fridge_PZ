#pragma checksum "C:\Users\Lenovo\Documents\FridgeWspolne\Main\Fridge_PZ\FridgePZ\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5735ce3b6a8a1828807da30d63a3c0be3d6d25f"
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
#line 1 "C:\Users\Lenovo\Documents\FridgeWspolne\Main\Fridge_PZ\FridgePZ\Views\_ViewImports.cshtml"
using FridgePZ;

#line default
#line hidden
#line 2 "C:\Users\Lenovo\Documents\FridgeWspolne\Main\Fridge_PZ\FridgePZ\Views\_ViewImports.cshtml"
using FridgePZ.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5735ce3b6a8a1828807da30d63a3c0be3d6d25f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35637e76b85c4316bc78e95a1bdf0b6192c624e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FridgePZ.Models.Itempattern>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExpItems", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Lenovo\Documents\FridgeWspolne\Main\Fridge_PZ\FridgePZ\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(94, 76, true);
            WriteLiteral("    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Fridge</h1>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\Lenovo\Documents\FridgeWspolne\Main\Fridge_PZ\FridgePZ\Views\Home\Index.cshtml"
          



            fridgepzContext db = new fridgepzContext();
            var query1 = from itempattern in db.Itempattern
                         join _item in db.Item on itempattern.ItemPatternId equals _item.ItemPatternId
                         where _item.NotificationId == 1
                         select _item;
            var query2 = from itempattern in db.Itempattern
                         join _item in db.Item on itempattern.ItemPatternId equals _item.ItemPatternId
                         where _item.NotificationId == 3
                         select _item;
            List<Item> product = query1.ToList();
            List<Item> awareProduct = query2.ToList();

            if (product != null)
            {
                if (product.Count == 0)
                {
                    if (awareProduct.Count == 0) { }
                    else
                    {

#line default
#line hidden
            BeginContext(1092, 134, true);
            WriteLiteral("                        <div class=\"alert alert-info\">\r\n                            <strong>Number of products with alerts: </strong> ");
            EndContext();
            BeginContext(1227, 18, false);
#line 32 "C:\Users\Lenovo\Documents\FridgeWspolne\Main\Fridge_PZ\FridgePZ\Views\Home\Index.cshtml"
                                                                         Write(awareProduct.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1245, 34, true);
            WriteLiteral("\r\n                        </div>\r\n");
            EndContext();
#line 34 "C:\Users\Lenovo\Documents\FridgeWspolne\Main\Fridge_PZ\FridgePZ\Views\Home\Index.cshtml"
                    }
                }
                else
                {
                    if (awareProduct.Count == 0)
                    {

#line default
#line hidden
            BeginContext(1435, 132, true);
            WriteLiteral("                        <div class=\"alert alert-danger\">\r\n                            <strong>Number of products expired: </strong> ");
            EndContext();
            BeginContext(1568, 13, false);
#line 41 "C:\Users\Lenovo\Documents\FridgeWspolne\Main\Fridge_PZ\FridgePZ\Views\Home\Index.cshtml"
                                                                     Write(product.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1581, 34, true);
            WriteLiteral("\r\n                        </div>\r\n");
            EndContext();
#line 43 "C:\Users\Lenovo\Documents\FridgeWspolne\Main\Fridge_PZ\FridgePZ\Views\Home\Index.cshtml"

                    }
                    else
                    {


#line default
#line hidden
            BeginContext(1691, 132, true);
            WriteLiteral("                        <div class=\"alert alert-danger\">\r\n                            <strong>Number of products expired: </strong> ");
            EndContext();
            BeginContext(1824, 13, false);
#line 49 "C:\Users\Lenovo\Documents\FridgeWspolne\Main\Fridge_PZ\FridgePZ\Views\Home\Index.cshtml"
                                                                     Write(product.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1837, 168, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"alert alert-info\">\r\n                            <strong>Number of products with alerts: </strong> ");
            EndContext();
            BeginContext(2006, 18, false);
#line 52 "C:\Users\Lenovo\Documents\FridgeWspolne\Main\Fridge_PZ\FridgePZ\Views\Home\Index.cshtml"
                                                                         Write(awareProduct.Count);

#line default
#line hidden
            EndContext();
            BeginContext(2024, 34, true);
            WriteLiteral("\r\n                        </div>\r\n");
            EndContext();
#line 54 "C:\Users\Lenovo\Documents\FridgeWspolne\Main\Fridge_PZ\FridgePZ\Views\Home\Index.cshtml"
                    }
                }
            }
        

#line default
#line hidden
            BeginContext(2126, 81, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n        <p>\r\n            <button type=\"button\" class=\"btn btn-primary\">");
            EndContext();
            BeginContext(2207, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5735ce3b6a8a1828807da30d63a3c0be3d6d25f9291", async() => {
                BeginContext(2253, 23, true);
                WriteLiteral("Add item to application");
                EndContext();
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
            EndContext();
            BeginContext(2280, 70, true);
            WriteLiteral(" </button>\r\n            <button type=\"button\" class=\"btn btn-primary\">");
            EndContext();
            BeginContext(2350, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5735ce3b6a8a1828807da30d63a3c0be3d6d25f10837", async() => {
                BeginContext(2395, 14, true);
                WriteLiteral("Show all items");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2413, 69, true);
            WriteLiteral(" </button>\r\n            <button type=\"button\" class=\"btn btn-danger\">");
            EndContext();
            BeginContext(2482, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5735ce3b6a8a1828807da30d63a3c0be3d6d25f12374", async() => {
                BeginContext(2526, 21, true);
                WriteLiteral("Your expired products");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1394, 78, true);
            WriteLiteral(" </button>\r\n                    <button type=\"button\" class=\"btn btn-primary\">");
            EndContext();
            BeginContext(1472, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba2afb0996af32474f4e6c70ca8922d4e80723a211611", async() => {
                BeginContext(1520, 14, true);
                WriteLiteral("Show all items");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1538, 77, true);
            WriteLiteral(" </button>\r\n                    <button type=\"button\" class=\"btn btn-danger\">");
            EndContext();
            BeginContext(1615, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba2afb0996af32474f4e6c70ca8922d4e80723a213156", async() => {
                BeginContext(1659, 21, true);
                WriteLiteral("Your expired products");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1684, 40, true);
            WriteLiteral(" </button>\r\n                </p>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FridgePZ.Models.Itempattern>> Html { get; private set; }
    }
}
#pragma warning restore 1591
