#pragma checksum "C:\Users\Tanner\ISCore\WINTER 2023\IS413 Enterprise App\Missions\BaconLibrary\BaconBookstore\Pages\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87766c56107c8af948956247eac7e7545af2ef83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Cart), @"mvc.1.0.razor-page", @"/Pages/Cart.cshtml")]
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
#nullable restore
#line 2 "C:\Users\Tanner\ISCore\WINTER 2023\IS413 Enterprise App\Missions\BaconLibrary\BaconBookstore\Pages\_ViewImports.cshtml"
using BaconBookstore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87766c56107c8af948956247eac7e7545af2ef83", @"/Pages/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3007dec881a1c14b32555b0b2e61bf5e0c966b2", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Cart : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Purchase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Tanner\ISCore\WINTER 2023\IS413 Enterprise App\Missions\BaconLibrary\BaconBookstore\Pages\Cart.cshtml"
  
    bool isEmpty = !Model.basket.Items.Any();

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Cart</h2>\r\n\r\n<div");
            BeginWriteAttribute("class", " class=\"", 121, "\"", 192, 3);
            WriteAttributeValue("", 129, "jumbotron", 129, 9, true);
            WriteAttributeValue(" ", 138, "jumbotron-fluid", 139, 16, true);
#nullable restore
#line 8 "C:\Users\Tanner\ISCore\WINTER 2023\IS413 Enterprise App\Missions\BaconLibrary\BaconBookstore\Pages\Cart.cshtml"
WriteAttributeValue(" ", 154, isEmpty ? "bg-warning" : "bg-info", 155, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"container\">\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Tanner\ISCore\WINTER 2023\IS413 Enterprise App\Missions\BaconLibrary\BaconBookstore\Pages\Cart.cshtml"
         if (isEmpty)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1 class=\"display-4\">Empty</h1>\r\n            <p class=\"lead\">There are no books in your cart.</p>\r\n");
#nullable restore
#line 15 "C:\Users\Tanner\ISCore\WINTER 2023\IS413 Enterprise App\Missions\BaconLibrary\BaconBookstore\Pages\Cart.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1 class=\"display-4\">");
#nullable restore
#line 18 "C:\Users\Tanner\ISCore\WINTER 2023\IS413 Enterprise App\Missions\BaconLibrary\BaconBookstore\Pages\Cart.cshtml"
                             Write(Model.basket.Items.Last().Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <p class=\"lead\">You successfully added ");
#nullable restore
#line 19 "C:\Users\Tanner\ISCore\WINTER 2023\IS413 Enterprise App\Missions\BaconLibrary\BaconBookstore\Pages\Cart.cshtml"
                                              Write(Model.basket.Items.Last().Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" to your cart!</p>\r\n");
#nullable restore
#line 20 "C:\Users\Tanner\ISCore\WINTER 2023\IS413 Enterprise App\Missions\BaconLibrary\BaconBookstore\Pages\Cart.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>

<table class=""table table-bordered table-striped"">
    <thead>
        <tr>
            <th>Title</th>
            <th>Quantity</th>
            <th>Price</th>
            <th>Subtotal</th>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 35 "C:\Users\Tanner\ISCore\WINTER 2023\IS413 Enterprise App\Missions\BaconLibrary\BaconBookstore\Pages\Cart.cshtml"
         foreach (var i in Model.basket.Items)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\Tanner\ISCore\WINTER 2023\IS413 Enterprise App\Missions\BaconLibrary\BaconBookstore\Pages\Cart.cshtml"
               Write(i.Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\Tanner\ISCore\WINTER 2023\IS413 Enterprise App\Missions\BaconLibrary\BaconBookstore\Pages\Cart.cshtml"
               Write(i.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\Tanner\ISCore\WINTER 2023\IS413 Enterprise App\Missions\BaconLibrary\BaconBookstore\Pages\Cart.cshtml"
               Write(i.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "C:\Users\Tanner\ISCore\WINTER 2023\IS413 Enterprise App\Missions\BaconLibrary\BaconBookstore\Pages\Cart.cshtml"
                Write((i.Quantity * i.Price).ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td class=\"text-center\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87766c56107c8af948956247eac7e7545af2ef839123", async() => {
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"bookId\"");
                BeginWriteAttribute("value", " value=\"", 1309, "\"", 1331, 1);
#nullable restore
#line 45 "C:\Users\Tanner\ISCore\WINTER 2023\IS413 Enterprise App\Missions\BaconLibrary\BaconBookstore\Pages\Cart.cshtml"
WriteAttributeValue("", 1317, i.Book.BookId, 1317, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"returnUrl\"");
                BeginWriteAttribute("value", " value=\"", 1398, "\"", 1422, 1);
#nullable restore
#line 46 "C:\Users\Tanner\ISCore\WINTER 2023\IS413 Enterprise App\Missions\BaconLibrary\BaconBookstore\Pages\Cart.cshtml"
WriteAttributeValue("", 1406, Model.ReturnUrl, 1406, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <button type=\"submit\" class=\"btn btn-sm btn-danger\">Remove</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 51 "C:\Users\Tanner\ISCore\WINTER 2023\IS413 Enterprise App\Missions\BaconLibrary\BaconBookstore\Pages\Cart.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n    <tfoot>\r\n        <tr>\r\n            <td colspan=\"3\">Total:</td>\r\n            <td>");
#nullable restore
#line 57 "C:\Users\Tanner\ISCore\WINTER 2023\IS413 Enterprise App\Missions\BaconLibrary\BaconBookstore\Pages\Cart.cshtml"
           Write(Model.basket.CalculateTotal().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </tfoot>\r\n</table>\r\n\r\n<div class=\"d-grid gap-2\">\r\n    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1853, "\"", 1876, 1);
#nullable restore
#line 63 "C:\Users\Tanner\ISCore\WINTER 2023\IS413 Enterprise App\Missions\BaconLibrary\BaconBookstore\Pages\Cart.cshtml"
WriteAttributeValue("", 1860, Model.ReturnUrl, 1860, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Back to where you left off!\">Continue Shopping</a>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87766c56107c8af948956247eac7e7545af2ef8313155", async() => {
                WriteLiteral("Checkout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BaconBookstore.Pages.CartModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BaconBookstore.Pages.CartModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BaconBookstore.Pages.CartModel>)PageContext?.ViewData;
        public BaconBookstore.Pages.CartModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
