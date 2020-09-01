#pragma checksum "C:\Users\Gregory\source\repos\MusicShop\MusicHub\Views\Order\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fe46d594a4ddfe95a7973a3d4661aca06e4c831"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Detail), @"mvc.1.0.view", @"/Views/Order/Detail.cshtml")]
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
#line 1 "C:\Users\Gregory\source\repos\MusicShop\MusicHub\Views\_ViewImports.cshtml"
using MusicHub;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gregory\source\repos\MusicShop\MusicHub\Views\_ViewImports.cshtml"
using MusicHub.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fe46d594a4ddfe95a7973a3d4661aca06e4c831", @"/Views/Order/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cff3d055fe8ad9cee3631ea5013e52e73dc7617", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MusicHub.ViewModels.OrderViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Gregory\source\repos\MusicShop\MusicHub\Views\Order\Detail.cshtml"
  
     ViewData["Title"] = "My Order History";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Gregory\source\repos\MusicShop\MusicHub\Views\Order\Detail.cshtml"
  
     ViewData["Title"] = "Order Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""shop-orders-detail"">
     <div class=""container"">
          <section class=""shop-orders-detail-section"">
               <article class=""shop-orders-detail-titles row"">
                    <section class=""shop-orders-detail-title col-xs-3"">OrderNumber</section>
                    <section class=""shop-orders-detail-title col-xs-3"">Date</section>
                    <section class=""shop-orders-detail-title col-xs-2"">Total</section>
                    <section class=""shop-orders-detail-title col-xs-3"">Status</section>
               </article>



               <article class=""shop-orders-detail-items row"">
                    <section class=""shop-orders-detail-title col-xs-3"">");
#nullable restore
#line 22 "C:\Users\Gregory\source\repos\MusicShop\MusicHub\Views\Order\Detail.cshtml"
                                                                  Write(Model.OrderNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n                    <section class=\"shop-orders-detail-title col-xs-3\">");
#nullable restore
#line 23 "C:\Users\Gregory\source\repos\MusicShop\MusicHub\Views\Order\Detail.cshtml"
                                                                  Write(Model.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n                    <section class=\"shop-orders-detail-title col-xs-2\">");
#nullable restore
#line 24 "C:\Users\Gregory\source\repos\MusicShop\MusicHub\Views\Order\Detail.cshtml"
                                                                  Write(Model.Total.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n                    <section class=\"shop-orders-detail-title col-xs-3\">");
#nullable restore
#line 25 "C:\Users\Gregory\source\repos\MusicShop\MusicHub\Views\Order\Detail.cshtml"
                                                                  Write(Model.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</section>
               </article>

               <section class=""shop-orders-detail-section"">
                    <article class=""shop-orders-detail-titles row"">
                         <section class=""shop-orders-detail-title col-xs-12"">Shipping Address</section>
                    </article>

                    <article class=""shop-orders-detail-items row"">
                         <section class=""shop-orders-detail-item col-xs-12"">");
#nullable restore
#line 34 "C:\Users\Gregory\source\repos\MusicShop\MusicHub\Views\Order\Detail.cshtml"
                                                                       Write(Model.ShippingAddress.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n                    </article>\r\n\r\n                    <article class=\"shop-orders-detail-items row\">\r\n                         <section class=\"shop-orders-detail-item col-xs-12\">");
#nullable restore
#line 38 "C:\Users\Gregory\source\repos\MusicShop\MusicHub\Views\Order\Detail.cshtml"
                                                                       Write(Model.ShippingAddress.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n                    </article>\r\n\r\n                    <article class=\"shop-orders-detail-items row\">\r\n                         <section class=\"shop-orders-detail-item col-xs-12\">");
#nullable restore
#line 42 "C:\Users\Gregory\source\repos\MusicShop\MusicHub\Views\Order\Detail.cshtml"
                                                                       Write(Model.ShippingAddress.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</section>
                    </article>
               </section>

               <section class=""shop-orders-detail-section"">
                    <article class=""shop-orders-detail-titles row"">
                         <section class=""shop-orders-detail-title col-xs-12"">ORDER DETAILS</section>
                    </article>

");
#nullable restore
#line 51 "C:\Users\Gregory\source\repos\MusicShop\MusicHub\Views\Order\Detail.cshtml"
                     for (int i = 0; i < Model.OrderItems.Count; i++)
                    {
                         var item = Model.OrderItems[i];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                         <article class=""shop-orders-detail-items esh-orders-detail-items--border row"">
                              <section class=""shop-orders-detail-item col-md-4 hidden-md-down"">
                                   <img class=""shop-orders-detail-image""");
            BeginWriteAttribute("src", " src=\"", 2865, "\"", 2887, 1);
#nullable restore
#line 56 "C:\Users\Gregory\source\repos\MusicShop\MusicHub\Views\Order\Detail.cshtml"
WriteAttributeValue("", 2871, item.PictureUrl, 2871, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                              </section>\r\n                              <section class=\"shop-orders-detail-item esh-orders-detail-item--middle col-xs-3\">");
#nullable restore
#line 58 "C:\Users\Gregory\source\repos\MusicShop\MusicHub\Views\Order\Detail.cshtml"
                                                                                                          Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n                              <section class=\"shop-orders-detail-item esh-orders-detail-item--middle col-xs-1\">$ ");
#nullable restore
#line 59 "C:\Users\Gregory\source\repos\MusicShop\MusicHub\Views\Order\Detail.cshtml"
                                                                                                            Write(item.UnitPrice.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n                              <section class=\"shop-orders-detail-item esh-orders-detail-item--middle col-xs-1\">");
#nullable restore
#line 60 "C:\Users\Gregory\source\repos\MusicShop\MusicHub\Views\Order\Detail.cshtml"
                                                                                                          Write(item.Units);

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n                              <section class=\"shop-orders-detail-item esh-orders-detail-item--middle col-xs-2\">$ ");
#nullable restore
#line 61 "C:\Users\Gregory\source\repos\MusicShop\MusicHub\Views\Order\Detail.cshtml"
                                                                                                            Write(Math.Round(item.Units * item.UnitPrice, 2).ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n                         </article>\r\n");
#nullable restore
#line 63 "C:\Users\Gregory\source\repos\MusicShop\MusicHub\Views\Order\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"               </section>

               <section class=""shop-orders-detail-section esh-orders-detail-section--right"">
                    <article class=""shop-orders-detail-titles esh-basket-titles--clean row"">
                         <section class=""shop-orders-detail-title col-xs-9""></section>
                         <section class=""shop-orders-detail-title col-xs-2"">TOTAL</section>
                    </article>

                    <article class=""shop-orders-detail-items row"">
                         <section class=""shop-orders-detail-item col-xs-9""></section>
                         <section class=""shop-orders-detail-item esh-orders-detail-item--mark col-xs-2"">$ ");
#nullable restore
#line 74 "C:\Users\Gregory\source\repos\MusicShop\MusicHub\Views\Order\Detail.cshtml"
                                                                                                     Write(Model.Total.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n                    </article>\r\n               </section>\r\n\r\n          </section>\r\n     </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MusicHub.ViewModels.OrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
