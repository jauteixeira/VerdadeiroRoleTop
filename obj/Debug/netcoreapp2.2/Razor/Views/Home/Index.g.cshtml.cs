#pragma checksum "C:\Users\37258681825\Desktop\jao\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13aafbb67ca40d6baa6bf7672727db1fc472bc33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13aafbb67ca40d6baa6bf7672727db1fc472bc33", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"defdaef1e0c0b7c023e23102742f5e2a51c0b17b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/47778.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<div id=\"logo-area\">\n    ");
            EndContext();
            BeginContext(25, 27, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "13aafbb67ca40d6baa6bf7672727db1fc472bc333514", async() => {
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
            EndContext();
            BeginContext(52, 2170, true);
            WriteLiteral(@"

</div>
</header>
   <main>
        
        <section id=""quem-somos"">
            <div class=""section-container"">
                <h2>QUEM SOMOS</h2>
                    <img src=""img/aperto.jpg"" width=""700"" height=""500"">
                <p>Alexandre Fukaya e Cesar Sportore são grandes empresários na área de eventos, criado em 2010 após uma viagem, a casa Rolê Top é exemplo no mercado, oferecendo um bom espaço para o seu evento.</p>
            </div>
        </section>

        <section id=""local"">
            <div class=""section-container"">
                <h2>MAPA E LOCALIZAÇÃO</h2>                
                <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d7315.798712843945!2d-46.64947723494454!3d-23.536121991808464!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94ce58423abe6eb3%3A0x9fe0fc5d7dd25ad7!2sCampos%20El%C3%ADseos%2C%20S%C3%A3o%20Paulo%20-%20SP!5e0!3m2!1spt-BR!2sbr!4v1568113612106!5m2!1spt-BR!2sbr"" width=""600"" height=""450"" frameborder=""0"" style=""border:0;"" allowfulls");
            WriteLiteral(@"creen=""""></iframe>                
                <p>Estamos localizados na Alameda Barão de Limeira, 539 - Santa Cecilia, São Paulo - SP, 01202-001, próximo a estação do metrô Santa Cecília.</p>
            </div>
        </section>

        <section id=""galeria"">
            <div class=""section-container"">
                <h2>GALERIA</h2>
                    <img class=""ImagemInicio"" src=""img/casamento.jpg"" alt=""Foto de um Casamento"" title=""Casamento"">
                    <img class=""ImagemInicio"" src=""img/asd.jpg"" alt=""Foto de jovens curtindo o salão"" title=""Balada Rolê Top"">
                    <img class=""ImagemInicio"" src=""img/palel.jpg"" alt=""Foto de uma Palestra"" title=""Palestra"">
                    <img class=""ImagemInicio"" src=""img/salao-para-festa-valor.jpg"" alt=""Foto do Ambiente1"" title=""Rolê Top Ambiente1"">
                    <img class=""ImagemInicio"" src=""img/salao-de-festas-2.jpg"" alt=""Foto do Ambiente2"" title=""Rolê Top Ambiente2"">
                    <img class=""ImagemInicio"" src=""img/salao_");
            WriteLiteral("festas.jpg\" alt=\"Foto do Ambiente3\" title=\"Rolê Top Ambiente3\">\n            </div>\n        </section>\n\n    </main> \n\n    \n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
