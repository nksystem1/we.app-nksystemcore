#pragma checksum "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Zona\ListarZonas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c99e1e124fb11d3ef36384a47b815899954535f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Zona_ListarZonas), @"mvc.1.0.view", @"/Views/Zona/ListarZonas.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c99e1e124fb11d3ef36384a47b815899954535f", @"/Views/Zona/ListarZonas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd0fac415047dcab1efc9ccd42afadac5f9c7791", @"/Views/_ViewImports.cshtml")]
    public class Views_Zona_ListarZonas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<we.app_nksystemcore.Models.Zona>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/funcioneszona.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Zona\ListarZonas.cshtml"
  
    ViewData["Title"] = "Listado de Zonas";
    ViewData["Accion"] = "Acciones de las Zona";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c99e1e124fb11d3ef36384a47b815899954535f3912", async() => {
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
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"panel panel-filled\">\r\n            <div class=\"panel-heading\">\r\n            </div>\r\n            <div class=\"panel-body\">\r\n                <p>\r\n                    ");
#nullable restore
#line 18 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Zona\ListarZonas.cshtml"
               Write(Html.ActionLink("Crear Zona", "CrearZona"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </p>

                <table id=""tableExample3"" class=""table table-striped table-hover table-responsive-sm"">
                    <thead>
                        <tr>
                            <th>
                                Codigo
                            </th>
                            <th>
                                Nombre
                            </th>

                            <th>Acciones</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 35 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Zona\ListarZonas.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 39 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Zona\ListarZonas.cshtml"
                               Write(Html.DisplayFor(modelItem => item.codzona));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 42 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Zona\ListarZonas.cshtml"
                               Write(Html.DisplayFor(modelItem => item.nomzona));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1559, "\"", 1629, 1);
#nullable restore
#line 45 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Zona\ListarZonas.cshtml"
WriteAttributeValue("", 1566, Url.Action("MostrarZona","Zona", new { ZonaId = item.codzona}), 1566, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-folder""></i></a>
                                    <a href=""#""><i class=""fa fa-edit""></i></a>
                                    <a href=""#""><i class=""fa fa-trash-o""></i></a>
                                </td>
                            </tr>
");
#nullable restore
#line 50 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Zona\ListarZonas.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n                <hr />\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<we.app_nksystemcore.Models.Zona>> Html { get; private set; }
    }
}
#pragma warning restore 1591
