#pragma checksum "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\Produto\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59a7426d9d62f2b0a6775c74aff368f1e1835bd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Details), @"mvc.1.0.view", @"/Views/Produto/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Details.cshtml", typeof(AspNetCore.Views_Produto_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59a7426d9d62f2b0a6775c74aff368f1e1835bd2", @"/Views/Produto/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"028a70059b9e6500629ca3b20fd2ff054371a729", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vendas.WebApp.Models.ViewModels.ProdutoFormViewModels>
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
#line 2 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\Produto\Details.cshtml"
  
    ViewData["Title"] = "Detalhar produto";

#line default
#line hidden
            BeginContext(115, 60, false);
#line 5 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\Produto\Details.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/_PartialNav.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(175, 173, true);
            WriteLiteral("\r\n<h2 class=\"display-4\">Detalhar produto</h2>\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            Codigo\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(349, 42, false);
#line 14 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\Produto\Details.cshtml"
       Write(Html.DisplayFor(model => model.Produto.Id));

#line default
#line hidden
            EndContext();
            BeginContext(391, 90, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Nome\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(482, 44, false);
#line 20 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\Produto\Details.cshtml"
       Write(Html.DisplayFor(model => model.Produto.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(526, 107, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Quantidade no estoque\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(634, 50, false);
#line 26 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\Produto\Details.cshtml"
       Write(Html.DisplayFor(model => model.Produto.Quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(684, 114, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Quantidade mínima no estoque\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(799, 56, false);
#line 32 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\Produto\Details.cshtml"
       Write(Html.DisplayFor(model => model.Produto.QuantidadeMinima));

#line default
#line hidden
            EndContext();
            BeginContext(855, 97, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Valor venda\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(953, 45, false);
#line 38 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\Produto\Details.cshtml"
       Write(Html.DisplayFor(model => model.Produto.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(998, 106, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Valor custo unitário\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1105, 58, false);
#line 44 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\Produto\Details.cshtml"
       Write(Html.DisplayFor(model => model.Produto.ValorCustoUnitario));

#line default
#line hidden
            EndContext();
            BeginContext(1163, 103, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Valor custo total\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1267, 55, false);
#line 50 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\Produto\Details.cshtml"
       Write(Html.DisplayFor(model => model.Produto.ValorCustoTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1322, 106, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Valor lucro unitário\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1429, 58, false);
#line 56 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\Produto\Details.cshtml"
       Write(Html.DisplayFor(model => model.Produto.ValorLucroUnitario));

#line default
#line hidden
            EndContext();
            BeginContext(1487, 103, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Valor lucro total\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1591, 55, false);
#line 62 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\Produto\Details.cshtml"
       Write(Html.DisplayFor(model => model.Produto.ValorLucroTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1646, 97, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Valor bruto\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1744, 50, false);
#line 68 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\Produto\Details.cshtml"
       Write(Html.DisplayFor(model => model.Produto.ValorBruto));

#line default
#line hidden
            EndContext();
            BeginContext(1794, 95, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Categoria\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1890, 49, false);
#line 74 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\Produto\Details.cshtml"
       Write(Html.DisplayFor(model => model.CategoriaObj.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1939, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1986, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bf00113ff9f4e0192d464147a604582", async() => {
                BeginContext(2041, 6, true);
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
            BeginContext(2051, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vendas.WebApp.Models.ViewModels.ProdutoFormViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
