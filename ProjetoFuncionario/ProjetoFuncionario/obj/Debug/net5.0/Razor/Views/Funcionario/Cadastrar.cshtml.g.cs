#pragma checksum "C:\DesenvolverProjeto\ProjetoFuncionario\ProjetoFuncionario\Views\Funcionario\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "876e771eca40a49bbe5e19d8a300bfa6a5ca2806"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionario_Cadastrar), @"mvc.1.0.view", @"/Views/Funcionario/Cadastrar.cshtml")]
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
#line 1 "C:\DesenvolverProjeto\ProjetoFuncionario\ProjetoFuncionario\Views\_ViewImports.cshtml"
using ProjetoFuncionario;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DesenvolverProjeto\ProjetoFuncionario\ProjetoFuncionario\Views\_ViewImports.cshtml"
using ProjetoFuncionario.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"876e771eca40a49bbe5e19d8a300bfa6a5ca2806", @"/Views/Funcionario/Cadastrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c4372b71c73a6534e1469d3c5dbef7b68cf844b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Funcionario_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\DesenvolverProjeto\ProjetoFuncionario\ProjetoFuncionario\Views\Funcionario\Cadastrar.cshtml"
  
    ViewData["Title"] = "Cadastrar Funcionario";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Cadastrar Funcionario</h1>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "876e771eca40a49bbe5e19d8a300bfa6a5ca28063678", async() => {
                WriteLiteral(@"
  <div class=""form-group"">
    <label for=""Nome"">Nome</label>
    <input type=""text"" class=""form-control"" aria-describedby=""emailHelp"" placeholder=""Digite o Nome"">
    <small id=""emailHelp"" class=""form-text text-muted"">Nunca vamos compartilhar seu email, com ninguém.</small>
  </div>
  <div class=""form-group"">
    <label for=""e-mail"">Email</label>
    <input type=""text"" class=""form-control"" placeholder=""Digite o E-mail"">
  </div>
  <div class=""form-group"">
    <label for=""Profissao"">Profissão</label>
    <input type=""text"" class=""form-control"" placeholder=""Digite o E-mail"">
  </div>
  <div class=""form-group"">
    <label for=""tempoExperiencia"">Tempo de Experiência</label>
    <input type=""number"" class=""form-control"" placeholder=""Digite o tempo de Experiencia"">
  </div>
    <div class=""form-group"">
    <label for=""salario"">Salario</label>
    <input type=""text"" class=""form-control"" placeholder=""Digite o Salrio"">
  </div>
  <button type=""submit"" class=""btn btn-primary btn-block"">Cadastro ");
                WriteLiteral("do Funcionario</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591