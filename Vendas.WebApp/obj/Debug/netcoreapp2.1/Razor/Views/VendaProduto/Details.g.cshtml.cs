#pragma checksum "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\VendaProduto\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9afbbf891eac8457ca2deb990541eaf45214f94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VendaProduto_Details), @"mvc.1.0.view", @"/Views/VendaProduto/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/VendaProduto/Details.cshtml", typeof(AspNetCore.Views_VendaProduto_Details))]
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
#line 1 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\_ViewImports.cshtml"
using Vendas.WebApp;

#line default
#line hidden
#line 2 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\_ViewImports.cshtml"
using Vendas.WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9afbbf891eac8457ca2deb990541eaf45214f94", @"/Views/VendaProduto/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"028a70059b9e6500629ca3b20fd2ff054371a729", @"/Views/_ViewImports.cshtml")]
    public class Views_VendaProduto_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vendas.WebApp.Models.ViewModels.VendaProdutoFormViewModels>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\VendaProduto\Details.cshtml"
  
    ViewData["Title"] = "Detalhar venda produto";

#line default
#line hidden
            BeginContext(126, 60, false);
#line 5 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\VendaProduto\Details.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/_PartialNav.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(186, 175, true);
            WriteLiteral("\r\n<h2 class=\"display-4\">Detalhar venda produto</h2>\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            Id\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(362, 47, false);
#line 14 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\VendaProduto\Details.cshtml"
       Write(Html.DisplayFor(model => model.VendaProduto.Id));

#line default
#line hidden
            EndContext();
            BeginContext(409, 93, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            VendaId\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(503, 52, false);
#line 20 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\VendaProduto\Details.cshtml"
       Write(Html.DisplayFor(model => model.VendaProduto.VendaId));

#line default
#line hidden
            EndContext();
            BeginContext(555, 95, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ProdutoId\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(651, 54, false);
#line 26 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\VendaProduto\Details.cshtml"
       Write(Html.DisplayFor(model => model.VendaProduto.ProdutoId));

#line default
#line hidden
            EndContext();
            BeginContext(705, 93, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Produto\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(799, 57, false);
#line 32 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\VendaProduto\Details.cshtml"
       Write(Html.DisplayFor(model => model.VendaProduto.Produto.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(856, 96, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Quantidade\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(953, 55, false);
#line 38 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\VendaProduto\Details.cshtml"
       Write(Html.DisplayFor(model => model.VendaProduto.Quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(1008, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1055, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "270857c6e9b747fa93b23983b7b2ce4d", async() => {
                BeginContext(1110, 6, true);
                WriteLiteral("Voltar");
                EndContext();
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
            EndContext();
            BeginContext(1120, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vendas.WebApp.Models.ViewModels.VendaProdutoFormViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
