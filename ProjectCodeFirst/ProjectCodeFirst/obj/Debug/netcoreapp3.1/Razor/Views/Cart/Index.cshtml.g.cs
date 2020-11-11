#pragma checksum "C:\Users\DELL\source\repos\ProjectCodeFirst\ProjectCodeFirst\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85e1d09784a92999ba54b000990cde5b010b0740"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Users\DELL\source\repos\ProjectCodeFirst\ProjectCodeFirst\Views\_ViewImports.cshtml"
using ProjectCodeFirst;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\source\repos\ProjectCodeFirst\ProjectCodeFirst\Views\_ViewImports.cshtml"
using ProjectCodeFirst.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85e1d09784a92999ba54b000990cde5b010b0740", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20e72dd49793071f5853bba01ab98f9413436a64", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjectCodeFirst.Models.CartModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DELL\source\repos\ProjectCodeFirst\ProjectCodeFirst\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""bg-light py-3"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12 mb-0""><a href=""index.html"">Trang chủ</a> <span class=""mx-2 mb-0"">/</span> <strong class=""text-black"">Giỏ hàng</strong></div>
        </div>
    </div>
</div>

<div class=""site-section"">
    <div class=""container"">
        <div class=""row mb-5"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85e1d09784a92999ba54b000990cde5b010b07404580", async() => {
                WriteLiteral(@"
                <div class=""site-blocks-table"">
                    <table class=""table table-bordered"">
                        <thead>
                            <tr>
                                <th class=""product-thumbnail"">Image</th>
                                <th class=""product-name"">Product</th>
                                <th class=""product-price"">Price</th>
                                <th class=""product-quantity"">Quantity</th>
                                <th class=""product-total"">Total</th>
                                <th class=""product-remove"">Remove</th>
                            </tr>
                        </thead>
                        <tbody>

");
#nullable restore
#line 33 "C:\Users\DELL\source\repos\ProjectCodeFirst\ProjectCodeFirst\Views\Cart\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <tr>
                                    <td class=""product-thumbnail"">
                                        <img src=""images/cloth_1.jpg"" alt=""Image"" class=""img-fluid"">
                                    </td>
                                    <td class=""product-name"">
                                        <h2 class=""h5 text-black"">");
#nullable restore
#line 40 "C:\Users\DELL\source\repos\ProjectCodeFirst\ProjectCodeFirst\Views\Cart\Index.cshtml"
                                                             Write(item.product.NAME);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                                    </td>\r\n                                    <td>");
#nullable restore
#line 42 "C:\Users\DELL\source\repos\ProjectCodeFirst\ProjectCodeFirst\Views\Cart\Index.cshtml"
                                   Write(item.product.PRICE);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                                    <td>
                                        <div class=""input-group mb-3"" style=""max-width: 120px;"">
                                            <div class=""input-group-prepend"">
                                                <button class=""btn btn-outline-primary js-btn-minus"" type=""button"">&minus;</button>
                                            </div>
                                            <input type=""text"" class=""form-control text-center"" value=""1""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2393, "\"", 2407, 0);
                EndWriteAttribute();
                WriteLiteral(@" aria-label=""Example text with button addon"" aria-describedby=""button-addon1"">
                                            <div class=""input-group-append"">
                                                <button class=""btn btn-outline-primary js-btn-plus"" type=""button"">&plus;</button>
                                            </div>
                                        </div>

                                    </td>
                                    <td>$49.00</td>
                                    <td><a href=""#"" class=""btn btn-primary btn-sm"">X</a></td>
                                </tr>
");
#nullable restore
#line 58 "C:\Users\DELL\source\repos\ProjectCodeFirst\ProjectCodeFirst\Views\Cart\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                            <tr>
                                <td class=""product-thumbnail"">
                                    <img src=""images/cloth_2.jpg"" alt=""Image"" class=""img-fluid"">
                                </td>
                                <td class=""product-name"">
                                    <h2 class=""h5 text-black"">Polo Shirt</h2>
                                </td>
                                <td>$49.00</td>
                                <td>
                                    <div class=""input-group mb-3"" style=""max-width: 120px;"">
                                        <div class=""input-group-prepend"">
                                            <button class=""btn btn-outline-primary js-btn-minus"" type=""button"">&minus;</button>
                                        </div>
                                        <input type=""text"" class=""form-control text-center"" value=""1""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 4010, "\"", 4024, 0);
                EndWriteAttribute();
                WriteLiteral(@" aria-label=""Example text with button addon"" aria-describedby=""button-addon1"">
                                        <div class=""input-group-append"">
                                            <button class=""btn btn-outline-primary js-btn-plus"" type=""button"">&plus;</button>
                                        </div>
                                    </div>

                                </td>
                                <td>$49.00</td>
                                <td><a href=""#"" class=""btn btn-primary btn-sm"">X</a></td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>

        <div class=""row"">
            <div class=""col-md-6"">
                <div class=""row mb-5"">
                    <div class=""col-md-6 mb-3 mb-md-0"">
                        <button class=""btn btn-primary btn-sm btn-block"">Update Cart</button>
                    </div>
                    <div class=""col-md-6"">
                        <button class=""btn btn-outline-primary btn-sm btn-block"">Continue Shopping</button>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-12"">
                        <label class=""text-black h4"" for=""coupon"">Coupon</label>
                        <p>Enter your coupon code if you have one.</p>
                    </div>
                    <div class=""col-md-8 mb-3 mb-md-0"">
                        <input type=""text"" class=""form-control py-3"" id=""coupon"" placeholder=""Coupon Code"">
                    </div>
                    <div class=""col-md-4"">
                ");
            WriteLiteral(@"        <button class=""btn btn-primary btn-sm"">Apply Coupon</button>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 pl-5"">
                <div class=""row justify-content-end"">
                    <div class=""col-md-7"">
                        <div class=""row"">
                            <div class=""col-md-12 text-right border-bottom mb-5"">
                                <h3 class=""text-black h4 text-uppercase"">Cart Totals</h3>
                            </div>
                        </div>
                        <div class=""row mb-3"">
                            <div class=""col-md-6"">
                                <span class=""text-black"">Subtotal</span>
                            </div>
                            <div class=""col-md-6 text-right"">
                                <strong class=""text-black"">$230.00</strong>
                            </div>
                        </div>
                        <div class=""row");
            WriteLiteral(@" mb-5"">
                            <div class=""col-md-6"">
                                <span class=""text-black"">Total</span>
                            </div>
                            <div class=""col-md-6 text-right"">
                                <strong class=""text-black"">$230.00</strong>
                            </div>
                        </div>

                        <div class=""row"">
                            <div class=""col-md-12"">
                                <button class=""btn btn-primary btn-lg py-3 btn-block"" onclick=""window.location='checkout.html'"">Proceed To Checkout</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjectCodeFirst.Models.CartModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591