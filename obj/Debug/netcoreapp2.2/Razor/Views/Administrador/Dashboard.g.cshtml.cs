#pragma checksum "C:\Users\37258681825\Desktop\jao\Views\Administrador\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aae0dd516e5f8d5d36efb92f0d7c58692b4943d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Dashboard), @"mvc.1.0.view", @"/Views/Administrador/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Dashboard.cshtml", typeof(AspNetCore.Views_Administrador_Dashboard))]
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
#line 1 "C:\Users\37258681825\Desktop\jao\Views\_ViewImports.cshtml"
using RoleTopOficial;

#line default
#line hidden
#line 2 "C:\Users\37258681825\Desktop\jao\Views\_ViewImports.cshtml"
using RoleTopOficial.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aae0dd516e5f8d5d36efb92f0d7c58692b4943d2", @"/Views/Administrador/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"defdaef1e0c0b7c023e23102742f5e2a51c0b17b", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopOficial.ViewModel.ClienteViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 214, true);
            WriteLiteral("<!-- <table>\n  <tr>\n    <th>ID</th>\n    <th>Dono do Evento</th>\n    <th>Nome do Evento</th>\n    <th>Data Do Evento</th>\n    <th>Tipo De Evento</th>\n    <th>Numero De Pessoas</th>\n    <th>Situação</th>\n    \n  </tr>\n");
            EndContext();
#line 13 "C:\Users\37258681825\Desktop\jao\Views\Administrador\Dashboard.cshtml"
 foreach(var evento in @Model.Eventos)
{

#line default
#line hidden
            BeginContext(304, 21, true);
            WriteLiteral("    <tr>\n        <td>");
            EndContext();
            BeginContext(326, 9, false);
#line 16 "C:\Users\37258681825\Desktop\jao\Views\Administrador\Dashboard.cshtml"
       Write(evento.ID);

#line default
#line hidden
            EndContext();
            BeginContext(335, 18, true);
            WriteLiteral("</td>\n        <td>");
            EndContext();
            BeginContext(354, 19, false);
#line 17 "C:\Users\37258681825\Desktop\jao\Views\Administrador\Dashboard.cshtml"
       Write(evento.DonoDoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(373, 18, true);
            WriteLiteral("</td>\n        <td>");
            EndContext();
            BeginContext(392, 11, false);
#line 18 "C:\Users\37258681825\Desktop\jao\Views\Administrador\Dashboard.cshtml"
       Write(evento.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(403, 18, true);
            WriteLiteral("</td>\n        <td>");
            EndContext();
            BeginContext(422, 19, false);
#line 19 "C:\Users\37258681825\Desktop\jao\Views\Administrador\Dashboard.cshtml"
       Write(evento.DataDoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(441, 18, true);
            WriteLiteral("</td>\n        <td>");
            EndContext();
            BeginContext(460, 19, false);
#line 20 "C:\Users\37258681825\Desktop\jao\Views\Administrador\Dashboard.cshtml"
       Write(evento.TipoDeEvento);

#line default
#line hidden
            EndContext();
            BeginContext(479, 18, true);
            WriteLiteral("</td>\n        <td>");
            EndContext();
            BeginContext(498, 22, false);
#line 21 "C:\Users\37258681825\Desktop\jao\Views\Administrador\Dashboard.cshtml"
       Write(evento.NumeroDePessoas);

#line default
#line hidden
            EndContext();
            BeginContext(520, 40, true);
            WriteLiteral("</td>\n        <td>Pendente</td>\n        ");
            EndContext();
            BeginContext(560, 216, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aae0dd516e5f8d5d36efb92f0d7c58692b4943d26217", async() => {
                BeginContext(629, 41, true);
                WriteLiteral("\n          <input type=\"hidden\" name=\"ID\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 670, "", 687, 1);
#line 24 "C:\Users\37258681825\Desktop\jao\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 677, evento.ID, 677, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(687, 82, true);
                WriteLiteral(">\n          <td><input type=\"submit\" name=\"Aprovar\" value=\"Aprovar\"></td>\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 23 "C:\Users\37258681825\Desktop\jao\Views\Administrador\Dashboard.cshtml"
AddHtmlAttributeValue("", 588, Url.Action("Aprovar", "Administrador"), 588, 39, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(776, 9, true);
            WriteLiteral("\n        ");
            EndContext();
            BeginContext(785, 219, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aae0dd516e5f8d5d36efb92f0d7c58692b4943d28837", async() => {
                BeginContext(855, 41, true);
                WriteLiteral("\n          <input type=\"hidden\" name=\"ID\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 896, "", 913, 1);
#line 28 "C:\Users\37258681825\Desktop\jao\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 903, evento.ID, 903, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(913, 84, true);
                WriteLiteral(">\n          <td><input type=\"submit\" name=\"Cancelar\" value=\"Cancelar\"></td>\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 27 "C:\Users\37258681825\Desktop\jao\Views\Administrador\Dashboard.cshtml"
AddHtmlAttributeValue("", 813, Url.Action("Cancelar", "Administrador"), 813, 40, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1004, 11, true);
            WriteLiteral("\n    </tr>\n");
            EndContext();
#line 32 "C:\Users\37258681825\Desktop\jao\Views\Administrador\Dashboard.cshtml"

}

#line default
#line hidden
            BeginContext(1017, 313, true);
            WriteLiteral(@" -->
<center>

</table>

    <main>
        <h2>Dashboard</h2>

        <section id=""status-pedidos"">
                <h3>Status dos pedidos</h3>
                <div id=""painel"">
                    <div class=""box-status-pedidos aprovados"">
                        <h4>Aprovados</h4>
                        <p>");
            EndContext();
            BeginContext(1331, 21, false);
#line 46 "C:\Users\37258681825\Desktop\jao\Views\Administrador\Dashboard.cshtml"
                      Write(Model.Aprovados.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1352, 165, true);
            WriteLiteral("</p>\n                    </div>\n                    <div class=\"box-status-pedidos pendentes\">\n                        <h4>Pendentes</h4>\n                        <p>");
            EndContext();
            BeginContext(1518, 19, false);
#line 50 "C:\Users\37258681825\Desktop\jao\Views\Administrador\Dashboard.cshtml"
                      Write(Model.Eventos.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1537, 167, true);
            WriteLiteral("</p>\n                    </div>\n                    <div class=\"box-status-pedidos reprovados\">\n                        <h4>Reprovados</h4>\n                        <p>");
            EndContext();
            BeginContext(1705, 22, false);
#line 54 "C:\Users\37258681825\Desktop\jao\Views\Administrador\Dashboard.cshtml"
                      Write(Model.Reprovados.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1727, 1082, true);
            WriteLiteral(@"</p>
                    </div>
                </div>
            </section>
        <center>

            <section id=""lista-pedidos"">
                    <h3>Lista de pedidos</h3>
                    <table>
                        <thead>
                            <tr>
                                <th rowspan=""2"">Nome</th>
                                <th rowspan=""2"">Tipo do Evento</th>
                                <th colspan=""2"">N° de Pessoas</th>
                                <th colspan=""2"" rowspan=""2"">Aprovar</th>
                            </tr>
                            <tr>
                                <th><i class=""fas fa-hamburger""></i></th>
                                <th><i class=""fas fa-mug-hot""></i></th>
                                <th></th>
                                <th></th>
                            </tr>
                        </thead>
                        <tfoot>
                            <tr>
                                <td colspan=""6"">
    ");
            WriteLiteral("                                <p>Pedidos atualizados em ");
            EndContext();
            BeginContext(2810, 12, false);
#line 80 "C:\Users\37258681825\Desktop\jao\Views\Administrador\Dashboard.cshtml"
                                                         Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(2822, 150, true);
            WriteLiteral(" às 7:41</p>\n                                </td>\n                            </tr>\n                        </tfoot>\n                        <tbody>\n");
            EndContext();
#line 85 "C:\Users\37258681825\Desktop\jao\Views\Administrador\Dashboard.cshtml"
                             foreach(var evento in @Model.Eventos)
                            {

#line default
#line hidden
            BeginContext(3069, 77, true);
            WriteLiteral("                                <tr>\n                                    <td>");
            EndContext();
            BeginContext(3147, 19, false);
#line 88 "C:\Users\37258681825\Desktop\jao\Views\Administrador\Dashboard.cshtml"
                                   Write(evento.DonoDoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(3166, 46, true);
            WriteLiteral("</td>\n                                    <td>");
            EndContext();
            BeginContext(3213, 19, false);
#line 89 "C:\Users\37258681825\Desktop\jao\Views\Administrador\Dashboard.cshtml"
                                   Write(evento.TipoDeEvento);

#line default
#line hidden
            EndContext();
            BeginContext(3232, 46, true);
            WriteLiteral("</td>\n                                    <td>");
            EndContext();
            BeginContext(3279, 22, false);
#line 90 "C:\Users\37258681825\Desktop\jao\Views\Administrador\Dashboard.cshtml"
                                   Write(evento.NumeroDePessoas);

#line default
#line hidden
            EndContext();
            BeginContext(3301, 96, true);
            WriteLiteral("</td>\n                                    <td>Pendente</td>\n                                    ");
            EndContext();
            BeginContext(3397, 296, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aae0dd516e5f8d5d36efb92f0d7c58692b4943d216649", async() => {
                BeginContext(3466, 67, true);
                WriteLiteral("\n                                    <input type=\"hidden\" name=\"ID\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 3533, "", 3550, 1);
#line 93 "C:\Users\37258681825\Desktop\jao\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 3540, evento.ID, 3540, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3550, 136, true);
                WriteLiteral(">\n                                    <td><input type=\"submit\" name=\"Aprovar\" value=\"Aprovar\"></td>\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 92 "C:\Users\37258681825\Desktop\jao\Views\Administrador\Dashboard.cshtml"
AddHtmlAttributeValue("", 3425, Url.Action("Aprovar", "Administrador"), 3425, 39, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3693, 37, true);
            WriteLiteral("\n                                    ");
            EndContext();
            BeginContext(3730, 299, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aae0dd516e5f8d5d36efb92f0d7c58692b4943d219390", async() => {
                BeginContext(3800, 67, true);
                WriteLiteral("\n                                    <input type=\"hidden\" name=\"ID\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 3867, "", 3884, 1);
#line 97 "C:\Users\37258681825\Desktop\jao\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 3874, evento.ID, 3874, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3884, 138, true);
                WriteLiteral(">\n                                    <td><input type=\"submit\" name=\"Cancelar\" value=\"Cancelar\"></td>\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 96 "C:\Users\37258681825\Desktop\jao\Views\Administrador\Dashboard.cshtml"
AddHtmlAttributeValue("", 3758, Url.Action("Cancelar", "Administrador"), 3758, 40, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4029, 39, true);
            WriteLiteral("\n                                </tr>\n");
            EndContext();
#line 101 "C:\Users\37258681825\Desktop\jao\Views\Administrador\Dashboard.cshtml"

                            }

#line default
#line hidden
            BeginContext(4099, 128, true);
            WriteLiteral("                        </tbody>\n                    </table>\n                </section>\n        </center>\n    </main>\n</center>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopOficial.ViewModel.ClienteViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
