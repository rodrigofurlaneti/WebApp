#pragma checksum "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\Cliente\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "970ac8c5cae6f5ac538be6ea200d35ebd45d05f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Details), @"mvc.1.0.view", @"/Views/Cliente/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Details.cshtml", typeof(AspNetCore.Views_Cliente_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970ac8c5cae6f5ac538be6ea200d35ebd45d05f8", @"/Views/Cliente/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"028a70059b9e6500629ca3b20fd2ff054371a729", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vendas.WebApp.Models.Cliente>
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
#line 2 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\Cliente\Details.cshtml"
  
    ViewData["Title"] = "Detalhar Cliente";

#line default
#line hidden
            BeginContext(90, 60, false);
#line 5 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\Cliente\Details.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/_PartialNav.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(150, 173, true);
            WriteLiteral("\r\n<h2 class=\"display-4\">Detalhar Cliente</h2>\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            Codigo\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(324, 34, false);
#line 14 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\Cliente\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(358, 90, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Nome\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(449, 36, false);
#line 20 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\Cliente\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(485, 89, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Cpf\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(575, 35, false);
#line 26 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\Cliente\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cpf));

#line default
#line hidden
            EndContext();
            BeginContext(610, 92, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            E-mail\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(703, 37, false);
#line 32 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\Cliente\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(740, 93, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Celular\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(834, 39, false);
#line 38 "C:\Users\Administrador\source\repos\Venda\Vendas\Vendas.WebApp\Views\Cliente\Details.cshtml"
       Write(Html.DisplayFor(model => model.Celular));

#line default
#line hidden
            EndContext();
            BeginContext(873, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(920, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4785fe518e4c47c79534e755f7f0479e", async() => {
                BeginContext(975, 6, true);
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
            BeginContext(985, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vendas.WebApp.Models.Cliente> Html { get; private set; }
    }
}
#pragma warning restore 1591
