#pragma checksum "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Usuario\ListarUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c123ab8368ab8f2d3caa0c2bcecea226f661c21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_ListarUsuario), @"mvc.1.0.view", @"/Views/Usuario/ListarUsuario.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c123ab8368ab8f2d3caa0c2bcecea226f661c21", @"/Views/Usuario/ListarUsuario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd0fac415047dcab1efc9ccd42afadac5f9c7791", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_ListarUsuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<we.app_nksystemcore.Models.Usuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/funcionesusuario.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Usuario\ListarUsuario.cshtml"
  
    ViewData["Title"] = "Listado de Usuarios";
    ViewData["Accion"] = "Acciones de los usuarios";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c123ab8368ab8f2d3caa0c2bcecea226f661c213955", async() => {
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
#line 18 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Usuario\ListarUsuario.cshtml"
               Write(Html.ActionLink("Crear Usuario", "CrearUsuario"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </p>
                <table id=""tableExample3"" class=""table table-striped table-hover table-responsive-sm"">
                    <thead>
                        <tr>
                            <th>
                                Usuario
                            </th>

                            <th>
                                Nombre
                            </th>
                            <th>
                                Descripcion
                            </th>

                            <th>
                                Email
                            </th>
                            <th>
                                Rol
                            </th>

                            <th>Acciones</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 45 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Usuario\ListarUsuario.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 49 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Usuario\ListarUsuario.cshtml"
                               Write(Html.DisplayFor(modelItem => item.login));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 52 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Usuario\ListarUsuario.cshtml"
                               Write(Html.DisplayFor(modelItem => item.nombrecompleto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 55 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Usuario\ListarUsuario.cshtml"
                               Write(Html.DisplayFor(modelItem => item.descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td>\r\n                                    ");
#nullable restore
#line 59 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Usuario\ListarUsuario.cshtml"
                               Write(Html.DisplayFor(modelItem => item.direccioncorreo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 62 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Usuario\ListarUsuario.cshtml"
                               Write(Html.DisplayFor(modelItem => item.rolid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2402, "\"", 2476, 1);
#nullable restore
#line 66 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Usuario\ListarUsuario.cshtml"
WriteAttributeValue("", 2409, Url.Action("MostrarUsuario","Usuario", new { RutaId = item.login}), 2409, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-folder\"></i></a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2550, "\"", 2623, 1);
#nullable restore
#line 67 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Usuario\ListarUsuario.cshtml"
WriteAttributeValue("", 2557, Url.Action("EditarUsuario","Usuario", new { RutaId = item.login}), 2557, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-edit\"></i></a>\r\n                                    <a href=\"#\"><i class=\"fa fa-trash-o\"></i></a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 71 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Usuario\ListarUsuario.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<we.app_nksystemcore.Models.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
