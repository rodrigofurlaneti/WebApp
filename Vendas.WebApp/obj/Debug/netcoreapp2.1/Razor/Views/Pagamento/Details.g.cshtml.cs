#pragma checksum "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\Pagamento\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e1ae9c60854ccaa04b706fcbd78d0e0176063cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pagamento_Details), @"mvc.1.0.view", @"/Views/Pagamento/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pagamento/Details.cshtml", typeof(AspNetCore.Views_Pagamento_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e1ae9c60854ccaa04b706fcbd78d0e0176063cd", @"/Views/Pagamento/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"028a70059b9e6500629ca3b20fd2ff054371a729", @"/Views/_ViewImports.cshtml")]
    public class Views_Pagamento_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Vendas.WebApp.Models.Pagamento>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\Pagamento\Details.cshtml"
  
    ViewData["Title"] = "Detalhar pagamento";

#line default
#line hidden
            BeginContext(107, 506, true);
            WriteLiteral(@"<h2 class=""display-4"">Detalhar comanda produto</h2>
<table class=""table"" id=""myTable"">
    <thead>
        <tr class=""col-12"">
            <th>
                Data
            </th>
            <th style=""text-align: center"" ;>
                Produto
            </th>
            <th style=""text-align: center"" ;>
                Quantidade
            </th>
            <th style=""text-align: center"" ;>
                Valor
            </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 24 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\Pagamento\Details.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(662, 15, true);
            WriteLiteral("            <tr");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 677, "\"", 712, 3);
            WriteAttributeValue("", 687, "Detalhar(", 687, 9, true);
#line 26 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\Pagamento\Details.cshtml"
WriteAttributeValue("", 696, item.ComandaId, 696, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 711, ")", 711, 1, true);
            EndWriteAttribute();
            BeginContext(713, 45, true);
            WriteLiteral(">\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(759, 39, false);
#line 28 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\Pagamento\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Data));

#line default
#line hidden
            EndContext();
            BeginContext(798, 96, true);
            WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align: center\" ;>\r\n                    ");
            EndContext();
            BeginContext(895, 42, false);
#line 31 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\Pagamento\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Produto));

#line default
#line hidden
            EndContext();
            BeginContext(937, 95, true);
            WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align: center;\">\r\n                    ");
            EndContext();
            BeginContext(1033, 45, false);
#line 34 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\Pagamento\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(1078, 100, true);
            WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align: center\">\r\n                    <span>");
            EndContext();
            BeginContext(1179, 40, false);
#line 37 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\Pagamento\Details.cshtml"
                     Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1219, 51, true);
            WriteLiteral("</span>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 40 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\Pagamento\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(1281, 305, true);
            WriteLiteral(@"        <tr>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td style=""text-align: center"" ;>
                <div id=""ValorTotal"" class=""ValorTotal""></div>
            </td>
        </tr>
    </tbody>
</table>
<div>
    ");
            EndContext();
            BeginContext(1586, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25234ff6a3654fd6afc19a4b53f6768f", async() => {
                BeginContext(1641, 6, true);
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
            BeginContext(1651, 21, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1672, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec5e334ab1da4f839748d46e74ff1073", async() => {
                BeginContext(1726, 5, true);
                WriteLiteral("Pagar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1735, 691, true);
            WriteLiteral(@"
</div>
<script>
    window.onload = contar();
    function contar() {
        var valores = document.querySelectorAll(""span"");
        let val = [];
        for (i = 0; i < valores.length; i++) {
            val.push(parseFloat(valores[i].innerHTML.replace(',', '.')))
        }
        console.log(val);
        var total = val.reduce((acumulador, numero) => {
            return acumulador += numero;
        }, 0)
        var arr = total.toFixed(2);
        console.log(arr);
        var $wrapper = document.querySelector('.ValorTotal'),
            HTMLNovo = '<label class=""control-label"">' + arr + '</label>';
        $wrapper.innerHTML = HTMLNovo;
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Vendas.WebApp.Models.Pagamento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
