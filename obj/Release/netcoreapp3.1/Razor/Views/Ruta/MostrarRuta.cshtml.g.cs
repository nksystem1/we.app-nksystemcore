#pragma checksum "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Ruta\MostrarRuta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ecb51b2206adb40f411b2e7e6412691215d4852"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ruta_MostrarRuta), @"mvc.1.0.view", @"/Views/Ruta/MostrarRuta.cshtml")]
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
#line 1 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\_ViewImports.cshtml"
using we.app_nksystemcore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\_ViewImports.cshtml"
using we.app_nksystemcore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ecb51b2206adb40f411b2e7e6412691215d4852", @"/Views/Ruta/MostrarRuta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd0fac415047dcab1efc9ccd42afadac5f9c7791", @"/Views/_ViewImports.cshtml")]
    public class Views_Ruta_MostrarRuta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<we.app_nksystemcore.Models.Ruta>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/funcionesruta.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListarRuta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Ruta\MostrarRuta.cshtml"
  
    ViewData["Title"] = "Visualizar Informacion Ruta";
    ViewData["Accion"] = "Consulta la informacion de la Ruta.";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ecb51b2206adb40f411b2e7e6412691215d48524362", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-4"">
        <div class=""panel"">
            <div class=""panel-heading"">
                Datos Basicos de Vendedor
            </div>
            <div class=""panel-body"">
                <div class=""form-group"">
                    <label for=""exampleInput"">Codigo</label>
                    <input class=""form-control"" id=""disabledInput"" type=""text""");
            BeginWriteAttribute("value", " value=\"", 646, "\"", 693, 1);
#nullable restore
#line 20 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Ruta\MostrarRuta.cshtml"
WriteAttributeValue("", 654, Html.DisplayFor(model => model.codigo), 654, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <label for=\"exampleInputName\">Nombre</label>\r\n                    <input class=\"form-control\" id=\"disabledInput\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 918, "\"", 965, 1);
#nullable restore
#line 25 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Ruta\MostrarRuta.cshtml"
WriteAttributeValue("", 926, Html.DisplayFor(model => model.nombre), 926, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <label for=\"exampleInputName\">Calle A1</label>\r\n                    <input class=\"form-control\" id=\"disabledInput\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1192, "\"", 1241, 1);
#nullable restore
#line 30 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Ruta\MostrarRuta.cshtml"
WriteAttributeValue("", 1200, Html.DisplayFor(model => model.desdeuno), 1200, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <label for=\"exampleInputName\">Calle A2</label>\r\n                    <input class=\"form-control\" id=\"disabledInput\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1468, "\"", 1517, 1);
#nullable restore
#line 35 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Ruta\MostrarRuta.cshtml"
WriteAttributeValue("", 1476, Html.DisplayFor(model => model.hastauno), 1476, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <label for=\"exampleInputName\">Calle B1</label>\r\n                    <input class=\"form-control\" id=\"disabledInput\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1744, "\"", 1793, 1);
#nullable restore
#line 40 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Ruta\MostrarRuta.cshtml"
WriteAttributeValue("", 1752, Html.DisplayFor(model => model.desdedos), 1752, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <label for=\"exampleInputName\">Calle B2</label>\r\n                    <input class=\"form-control\" id=\"disabledInput\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2020, "\"", 2069, 1);
#nullable restore
#line 45 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Ruta\MostrarRuta.cshtml"
WriteAttributeValue("", 2028, Html.DisplayFor(model => model.hastados), 2028, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" disabled>
                </div>

            </div>
        </div>
    </div>
    <div class=""col-lg-8"">
        <div class=""panel"">
            <div class=""panel-body"">
                <div class=""modal-example"">
                    <style>
                        /* Local style only for demo purpose */
                        .modal-example .modal {
                            position: relative;
                            top: auto;
                            right: auto;
                            bottom: auto;
                            left: auto;
                            z-index: 1;
                            display: block;
                        }
                    </style>
                    <div class=""modal"" id=""myModal3"" tabindex=""-1"" role=""dialog"">
                        <div class=""modal-dialog"">
                            <div class=""modal-content"">
                                <div class=""modal-body"">
                                    <h4 class=""");
            WriteLiteral(@"m-t-none"">Informacion de Zona y Vendedor</h4>
                                    <p>Muestra la informacion del Vendedor que visita dicha ruta y a que Zona pertenece..</p>
                                    <div class=""row"">
                                        <div class=""col-md-4"">
                                            <small class=""stat-label"">Codigo</small>
                                            <h4 class=""m-t-xs"">");
#nullable restore
#line 76 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Ruta\MostrarRuta.cshtml"
                                                          Write(Html.DisplayFor(model => model.zona.codzona));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                                        </div>
                                        <div class=""col-md-8"">
                                            <small class=""stat-label"">Zona</small>
                                            <h4 class=""m-t-xs"">");
#nullable restore
#line 80 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Ruta\MostrarRuta.cshtml"
                                                          Write(Html.DisplayFor(model => model.zona.nomzona));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                                        </div>
                                    </div>

                                    <div class=""row"">
                                        <div class=""col-md-4"">
                                            <small class=""stat-label"">Codigo</small>
                                            <h4 class=""m-t-xs"">");
#nullable restore
#line 87 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Ruta\MostrarRuta.cshtml"
                                                          Write(Html.DisplayFor(model => model.vendedor.codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                                        </div>
                                        <div class=""col-md-8"">
                                            <small class=""stat-label"">Vendedor</small>
                                            <h4 class=""m-t-xs"">");
#nullable restore
#line 91 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Ruta\MostrarRuta.cshtml"
                                                          Write(Html.DisplayFor(model => model.vendedor.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                                        </div>
                                    </div>

                                </div>
                                <div class=""modal-footer"">
                                </div>
                            </div>
                        </div>
                    </div>

                </div>

            </div>
        </div>
    </div>

    <div>
        ");
#nullable restore
#line 109 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Ruta\MostrarRuta.cshtml"
   Write(Html.ActionLink("Editar", "EditarRuta", new { /*model => model.Codigo */}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ecb51b2206adb40f411b2e7e6412691215d485214029", async() => {
                WriteLiteral("Regresar a la Lista");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<we.app_nksystemcore.Models.Ruta> Html { get; private set; }
    }
}
#pragma warning restore 1591