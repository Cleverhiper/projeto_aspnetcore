#pragma checksum "C:\projetosgit\projeto_aspnetcore\Views\Funcionarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "018190dd603b1392165a0f45140d0d6f226bb8f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionarios_Index), @"mvc.1.0.view", @"/Views/Funcionarios/Index.cshtml")]
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
#line 1 "C:\projetosgit\projeto_aspnetcore\Views\_ViewImports.cshtml"
using projeto_aspnetcore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projetosgit\projeto_aspnetcore\Views\_ViewImports.cshtml"
using projeto_aspnetcore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"018190dd603b1392165a0f45140d0d6f226bb8f0", @"/Views/Funcionarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0def20fa01c1026068486da1350bb7ec625c265f", @"/Views/_ViewImports.cshtml")]
    public class Views_Funcionarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<projeto_aspnetcore.Models.Funcionario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Todos os funcionários</h2>\r\n<a href=\"/Funcionarios/Cadastrar\" class=\"btn btn-success\">Novo Funcionário</a>\r\n");
#nullable restore
#line 5 "C:\projetosgit\projeto_aspnetcore\Views\Funcionarios\Index.cshtml"
 foreach (var funcionario in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>CPF: ");
#nullable restore
#line 7 "C:\projetosgit\projeto_aspnetcore\Views\Funcionarios\Index.cshtml"
       Write(funcionario.Cpf);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Nome: ");
#nullable restore
#line 8 "C:\projetosgit\projeto_aspnetcore\Views\Funcionarios\Index.cshtml"
        Write(funcionario.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Salário: ");
#nullable restore
#line 9 "C:\projetosgit\projeto_aspnetcore\Views\Funcionarios\Index.cshtml"
           Write(funcionario.Salario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 331, "\"", 374, 2);
            WriteAttributeValue("", 338, "/Funcionarios/Editar/", 338, 21, true);
#nullable restore
#line 10 "C:\projetosgit\projeto_aspnetcore\Views\Funcionarios\Index.cshtml"
WriteAttributeValue("", 359, funcionario.Id, 359, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Editar</a>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 418, "\"", 462, 2);
            WriteAttributeValue("", 425, "/Funcionarios/Deletar/", 425, 22, true);
#nullable restore
#line 11 "C:\projetosgit\projeto_aspnetcore\Views\Funcionarios\Index.cshtml"
WriteAttributeValue("", 447, funcionario.Id, 447, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Deletar</a>\r\n    <hr>\r\n");
#nullable restore
#line 13 "C:\projetosgit\projeto_aspnetcore\Views\Funcionarios\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<projeto_aspnetcore.Models.Funcionario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
