#pragma checksum "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\ComandaProduto\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f17e458a1015e808b0a92066387d3d902e8dfad9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ComandaProduto_Details), @"mvc.1.0.view", @"/Views/ComandaProduto/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ComandaProduto/Details.cshtml", typeof(AspNetCore.Views_ComandaProduto_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f17e458a1015e808b0a92066387d3d902e8dfad9", @"/Views/ComandaProduto/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"028a70059b9e6500629ca3b20fd2ff054371a729", @"/Views/_ViewImports.cshtml")]
    public class Views_ComandaProduto_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Vendas.WebApp.Models.ComandaProduto>>
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
#line 2 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\ComandaProduto\Details.cshtml"
  
    ViewData["Title"] = "Detalhar comanda produto";

#line default
#line hidden
            BeginContext(119, 60, false);
#line 5 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\ComandaProduto\Details.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/_PartialNav.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(179, 421, true);
            WriteLiteral(@"
<h2 class=""display-4"">Detalhar comanda produto</h2>
<table class=""table"" id=""myTable"">
    <thead>
        <tr class=""col-12"">
            <th>
                Data
            </th>
            <th>
                Produto
            </th>
            <th>
                Quantidade
            </th>
            <th>
                Valor
            </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 25 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\ComandaProduto\Details.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
            BeginContext(651, 15, true);
            WriteLiteral("            <tr");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 666, "\"", 694, 3);
            WriteAttributeValue("", 676, "Detalhar(", 676, 9, true);
#line 28 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\ComandaProduto\Details.cshtml"
WriteAttributeValue("", 685, item.Id, 685, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 693, ")", 693, 1, true);
            EndWriteAttribute();
            BeginContext(695, 45, true);
            WriteLiteral(">\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(741, 43, false);
#line 30 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\ComandaProduto\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.DataHora));

#line default
#line hidden
            EndContext();
            BeginContext(784, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(852, 42, false);
#line 33 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\ComandaProduto\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Produto));

#line default
#line hidden
            EndContext();
            BeginContext(894, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(962, 45, false);
#line 36 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\ComandaProduto\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(1007, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1075, 40, false);
#line 39 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\ComandaProduto\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1115, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 42 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\ComandaProduto\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(1170, 35, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1205, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48edd48f546c4f898b0363c782fabdeb", async() => {
                BeginContext(1260, 6, true);
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
            BeginContext(1270, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Vendas.WebApp.Models.ComandaProduto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
