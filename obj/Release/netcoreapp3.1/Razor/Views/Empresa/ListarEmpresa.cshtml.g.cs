#pragma checksum "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Empresa\ListarEmpresa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ec8737613b738ab849d111dc0b2e53a5ebd793d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empresa_ListarEmpresa), @"mvc.1.0.view", @"/Views/Empresa/ListarEmpresa.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ec8737613b738ab849d111dc0b2e53a5ebd793d", @"/Views/Empresa/ListarEmpresa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd0fac415047dcab1efc9ccd42afadac5f9c7791", @"/Views/_ViewImports.cshtml")]
    public class Views_Empresa_ListarEmpresa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<web.appcore_nksystem.Models.Negocio>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Empresa\ListarEmpresa.cshtml"
  
    ViewData["Title"] = "Listado de Empresas";
    ViewData["Accion"] = "Acciones de Empresa";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral(@"
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""panel panel-filled"">
                <div class=""panel-heading"">

                </div>
                <div class=""panel-body"">

                    <p>
                        ");
#nullable restore
#line 21 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Empresa\ListarEmpresa.cshtml"
                   Write(Html.ActionLink("Crear Empresa", "CrearEmpresa"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>


                    <table id=""tableExample3"" class=""table table-striped table-hover table-responsive-sm"">
                        <thead>
                            <tr>
                                <th>
                                    ");
#nullable restore
#line 29 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Empresa\ListarEmpresa.cshtml"
                               Write(Html.DisplayNameFor(model => model.Codnegocio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 32 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Empresa\ListarEmpresa.cshtml"
                               Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 35 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Empresa\ListarEmpresa.cshtml"
                               Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 38 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Empresa\ListarEmpresa.cshtml"
                               Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 41 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Empresa\ListarEmpresa.cshtml"
                               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 44 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Empresa\ListarEmpresa.cshtml"
                               Write(Html.DisplayNameFor(model => model.Contribuyente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 47 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Empresa\ListarEmpresa.cshtml"
                               Write(Html.DisplayNameFor(model => model.Activa));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </th>
                                <th>
                                    Acciones
                                </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 55 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Empresa\ListarEmpresa.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 59 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Empresa\ListarEmpresa.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Codnegocio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 62 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Empresa\ListarEmpresa.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 65 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Empresa\ListarEmpresa.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 68 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Empresa\ListarEmpresa.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 71 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Empresa\ListarEmpresa.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 75 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Empresa\ListarEmpresa.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Contribuyente));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </td>
                                    <td>
                                        <span class=""label label-accent"">Active</span>

                                    </td>
                                    <td>
                                        <a href=""#""><i class=""fa fa-folder""></i></a>
                                        <a href=""#""><i class=""fa fa-edit""></i></a>
                                        <a href=""#""><i class=""fa fa-trash-o""></i></a>


                                    </td>
                                </tr>
");
#nullable restore
#line 89 "C:\Nk-System Consultores SCA\Proyectos\we.app-nksystemcore\Views\Empresa\ListarEmpresa.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                    <hr />\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<web.appcore_nksystem.Models.Negocio>> Html { get; private set; }
    }
}
#pragma warning restore 1591
