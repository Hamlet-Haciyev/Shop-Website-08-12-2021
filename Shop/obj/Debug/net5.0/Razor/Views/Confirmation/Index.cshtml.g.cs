#pragma checksum "C:\Users\FX505GT\Desktop\ASP.NET\Shop\Shop\Views\Confirmation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0bab238ebbcbd02e3fcaafa362344307b307e07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Confirmation_Index), @"mvc.1.0.view", @"/Views/Confirmation/Index.cshtml")]
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
#line 1 "C:\Users\FX505GT\Desktop\ASP.NET\Shop\Shop\Views\_ViewImports.cshtml"
using Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FX505GT\Desktop\ASP.NET\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\FX505GT\Desktop\ASP.NET\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0bab238ebbcbd02e3fcaafa362344307b307e07", @"/Views/Confirmation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2598949981c40b234e1da37c87747a2f181d430", @"/Views/_ViewImports.cshtml")]
    public class Views_Confirmation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmHome>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_SocialPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\FX505GT\Desktop\ASP.NET\Shop\Shop\Views\Confirmation\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""breadcrumb breadcrumb_bg"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-lg-12"">
                <div class=""breadcrumb_iner"">
                    <div class=""breadcrumb_iner_item"">
                        <p>Home / About</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<section class=""confirmation_part section_padding"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""confirmation_tittle"">
                    <span>Thank you. Your order has been received.</span>
                </div>
            </div>
            <div class=""col-lg-6 col-lx-4"">
                <div class=""single_confirmation_details"">
                    <h4>order info</h4>
                    <ul>
                        <li>
                            <p>order number</p><span>: 60235</span>
              ");
            WriteLiteral(@"          </li>
                        <li>
                            <p>data</p><span>: Oct 03, 2017</span>
                        </li>
                        <li>
                            <p>total</p><span>: USD 2210</span>
                        </li>
                        <li>
                            <p>mayment methord</p><span>: Check payments</span>
                        </li>
                    </ul>
                </div>
            </div>
            <div class=""col-lg-6 col-lx-4"">
                <div class=""single_confirmation_details"">
                    <h4>Billing Address</h4>
                    <ul>
                        <li>
                            <p>Street</p><span>: 56/8</span>
                        </li>
                        <li>
                            <p>city</p><span>: Los Angeles</span>
                        </li>
                        <li>
                            <p>country</p><span>: United States</span>
          ");
            WriteLiteral(@"              </li>
                        <li>
                            <p>postcode</p><span>: 36952</span>
                        </li>
                    </ul>
                </div>
            </div>
            <div class=""col-lg-6 col-lx-4"">
                <div class=""single_confirmation_details"">
                    <h4>shipping Address</h4>
                    <ul>
                        <li>
                            <p>Street</p><span>: 56/8</span>
                        </li>
                        <li>
                            <p>city</p><span>: Los Angeles</span>
                        </li>
                        <li>
                            <p>country</p><span>: United States</span>
                        </li>
                        <li>
                            <p>postcode</p><span>: 36952</span>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""row"">
     ");
            WriteLiteral(@"       <div class=""col-lg-12"">
                <div class=""order_details_iner"">
                    <h3>Order Details</h3>
                    <table class=""table table-borderless"">
                        <thead>
                            <tr>
                                <th scope=""col"" colspan=""2"">Product</th>
                                <th scope=""col"">Quantity</th>
                                <th scope=""col"">Total</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <th colspan=""2""><span>Pixelstore fresh Blackberry</span></th>
                                <th>x02</th>
                                <th> <span>$720.00</span></th>
                            </tr>
                            <tr>
                                <th colspan=""2""><span>Pixelstore fresh Blackberry</span></th>
                                <th>x02</th>
                       ");
            WriteLiteral(@"         <th> <span>$720.00</span></th>
                            </tr>
                            <tr>
                                <th colspan=""2""><span>Pixelstore fresh Blackberry</span></th>
                                <th>x02</th>
                                <th> <span>$720.00</span></th>
                            </tr>
                            <tr>
                                <th colspan=""3"">Subtotal</th>
                                <th> <span>$2160.00</span></th>
                            </tr>
                            <tr>
                                <th colspan=""3"">shipping</th>
                                <th><span>flat rate: $50.00</span></th>
                            </tr>
                        </tbody>
                        <tfoot>
                            <tr>
                                <th scope=""col"" colspan=""3"">Quantity</th>
                                <th scope=""col"">Total</th>
                            </tr>
 ");
            WriteLiteral("                       </tfoot>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c0bab238ebbcbd02e3fcaafa362344307b307e079264", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 136 "C:\Users\FX505GT\Desktop\ASP.NET\Shop\Shop\Views\Confirmation\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Social;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmHome> Html { get; private set; }
    }
}
#pragma warning restore 1591
