#pragma checksum "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f8e3c1d991e8b3d80a240395d00b6d35b743cb4"
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
#line 1 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\_ViewImports.cshtml"
using BrandBucket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\_ViewImports.cshtml"
using BrandBucket_Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
using BrandBucket_Utility;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f8e3c1d991e8b3d80a240395d00b6d35b743cb4", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c684f36e8c4f368cf3764dbfc8817615bbd045", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Clear", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("formmethod", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("Update"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Upadte Cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
 if (Model.Count() > 0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f8e3c1d991e8b3d80a240395d00b6d35b743cb49369", async() => {
                WriteLiteral(@"
        <br />
        <div class=""backgroundWhiteBorder"">
            <div class=""container row"">
                <div class=""col -8"">
                    <div class=""card mt-4"">
                        <div class=""card-header bg-dark text-light ml-0 row container"">
                            <div class=""col-6"">
                                <i class=""fa fa-shopping-cart""></i> &nbsp;
                                Shopping Cart
                            </div>
                            <div class=""col-6 text-right"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f8e3c1d991e8b3d80a240395d00b6d35b743cb410216", async() => {
                    WriteLiteral("Clear Cart");
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
                WriteLiteral("\r\n\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f8e3c1d991e8b3d80a240395d00b6d35b743cb411563", async() => {
                    WriteLiteral("Continue Shopping");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
                        <div class=""card-body"">
                            <div class="" d-none d-lg-block"">
                                <div class=""row"" style=""color:#821f3d"">
                                    <div class=""col-lg-2"">
                                    </div>
");
#nullable restore
#line 29 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
                                     if (User.IsInRole(WC.AdminRole))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"col-12 col-lg-3\">\r\n                                            Product Details\r\n                                        </div>\r\n");
#nullable restore
#line 34 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"col-12 col-lg-7\">\r\n                                            Product Details\r\n                                        </div>\r\n");
#nullable restore
#line 40 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"col-12 col-lg-2\">\r\n                                        Price\r\n                                    </div>\r\n");
#nullable restore
#line 44 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
                                     if (User.IsInRole(WC.AdminRole))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        <div class=""col-6 col-lg-2"">
                                            Quantity
                                        </div>
                                        <div class=""col-6 col-lg-2"">
                                            Total Price
                                        </div>
");
#nullable restore
#line 52 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"col-6 col-sm-4 col-lg-1\">\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n\r\n                            <hr />\r\n\r\n");
#nullable restore
#line 60 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
                               

                                var orderTotal = 0.0;
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 65 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
                             for(int i=0;i<Model.Count();i++)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5f8e3c1d991e8b3d80a240395d00b6d35b743cb416673", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 67 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model[i].Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <div class=\"row h-100\">\r\n                            <div class=\"col-4 col-md-2 text-center py-2\">\r\n                                <img");
                BeginWriteAttribute("src", " src=\"", 3219, "\"", 3253, 2);
#nullable restore
#line 70 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
WriteAttributeValue("", 3225, WC.ImagePath, 3225, 13, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
WriteAttributeValue("", 3238, Model[i].Image, 3238, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rounded\" width=\"100%\" />\r\n                            </div>\r\n\r\n");
#nullable restore
#line 73 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
                             if (User.IsInRole(WC.AdminRole))
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"col-8 col-lg-3\">\r\n                                    <h5>");
#nullable restore
#line 76 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
                                   Write(Model[i].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                                    <div style=\"font-size:11px;\">");
#nullable restore
#line 77 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
                                                            Write(Model[i].ShortDesc);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                </div>\r\n");
#nullable restore
#line 79 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"col-8 col-lg-7\">\r\n                                    <h5>");
#nullable restore
#line 83 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
                                   Write(Model[i].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                                    <div style=\"font-size:11px;\">");
#nullable restore
#line 84 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
                                                            Write(Model[i].ShortDesc);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                </div>\r\n");
#nullable restore
#line 86 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col-3 col-lg-2 pt-lg-4\" style=\"font-size:11px;\">\r\n                                <span style=\"font-size:17px;\">₹");
#nullable restore
#line 88 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
                                                          Write(Model[i].Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            </div>\r\n");
#nullable restore
#line 90 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
                             if (User.IsInRole(WC.AdminRole))
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"col-4 col-lg-2 pt-lg-4\" style=\"font-size:11px;\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5f8e3c1d991e8b3d80a240395d00b6d35b743cb422642", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 93 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model[i].TempQty);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n");
                WriteLiteral("                                <div class=\"col-3 col-lg-2 pt-lg-4\" style=\"font-size:11px;\">\r\n                                    <span style=\"font-size:17px;\">₹");
#nullable restore
#line 97 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
                                                               Write(@Model[i].Price* @Model[i].TempQty);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                </div>\r\n");
#nullable restore
#line 99 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col-2 col-lg-1 p-0 pt-lg-4 text-center\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f8e3c1d991e8b3d80a240395d00b6d35b743cb425392", async() => {
                    WriteLiteral("\r\n                                    <i class=\"fas fa-trash\"></i>\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 101 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
                                                         WriteLiteral(Model[i].Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 106 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
                                orderTotal += @Model[i].Price * @Model[i].TempQty;
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("<hr />\r\n");
#nullable restore
#line 108 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
                             if (User.IsInRole(WC.AdminRole))
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div>\r\n                            <div class=\"col-12 text-right pr-4\" style=\"color:darkviolet\">\r\n                                Order Total :  ");
#nullable restore
#line 113 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
                                          Write(string.Format("{0:c}", orderTotal));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 116 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
                            } 

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n                        <div class=\"card-footer\">\r\n                            <div class=\"row\">\r\n                                <div class=\"col-6 col-md-3 offset-md-6\">\r\n");
#nullable restore
#line 121 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
                                     if (User.IsInRole(WC.AdminRole))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5f8e3c1d991e8b3d80a240395d00b6d35b743cb430087", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 124 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </div>
                                    <div class=""col-6 col-md-3"">
                                        <button type=""submit"" class=""btn btn-success form-control "">
                                            <span>Continue</span>
                                        </button>
                                    </div>
                                </div>
                            </div>
                    </div>
                </div>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_15.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 138 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p> Your Cart is Empty!</p>");
#nullable restore
#line 141 "C:\ShoppingCartProject\shoppingcart\BrandBucket\BrandBucket\Views\Cart\Index.cshtml"
                           }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
