#pragma checksum "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\trabalho1\tarefa\Views\Tarefa\Abertas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7d5d02e75bb609209751bd8185bfd5780bb7804"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tarefa_Abertas), @"mvc.1.0.view", @"/Views/Tarefa/Abertas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tarefa/Abertas.cshtml", typeof(AspNetCore.Views_Tarefa_Abertas))]
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
#line 1 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\trabalho1\tarefa\Views\_ViewImports.cshtml"
using tarefa;

#line default
#line hidden
#line 2 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\trabalho1\tarefa\Views\_ViewImports.cshtml"
using tarefa.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7d5d02e75bb609209751bd8185bfd5780bb7804", @"/Views/Tarefa/Abertas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94475b55689d4542834770881cca57be4f344ea4", @"/Views/_ViewImports.cshtml")]
    public class Views_Tarefa_Abertas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<tarefa.Models.Cadastro>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 378, true);
            WriteLiteral(@"    
<div class=""container"">
    <table class=""table"">
        <thead>
            <tr>
                <th>Id</th>
                <th>Prioridade</th>
                <th>Nome Tarefa</th>
                <th>Data</th>
                <th>Percentual </th>
                <th></th>
                <th></th>
            </tr>
            </tr>
        </thead>

");
            EndContext();
#line 18 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\trabalho1\tarefa\Views\Tarefa\Abertas.cshtml"
     foreach(var item in Model)
        {

#line default
#line hidden
            BeginContext(466, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(513, 7, false);
#line 21 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\trabalho1\tarefa\Views\Tarefa\Abertas.cshtml"
                   Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(520, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(552, 15, false);
#line 22 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\trabalho1\tarefa\Views\Tarefa\Abertas.cshtml"
                   Write(item.prioridade);

#line default
#line hidden
            EndContext();
            BeginContext(567, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(599, 15, false);
#line 23 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\trabalho1\tarefa\Views\Tarefa\Abertas.cshtml"
                   Write(item.nameTarefa);

#line default
#line hidden
            EndContext();
            BeginContext(614, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(646, 9, false);
#line 24 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\trabalho1\tarefa\Views\Tarefa\Abertas.cshtml"
                   Write(item.data);

#line default
#line hidden
            EndContext();
            BeginContext(655, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(687, 12, false);
#line 25 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\trabalho1\tarefa\Views\Tarefa\Abertas.cshtml"
                   Write(item.percent);

#line default
#line hidden
            EndContext();
            BeginContext(699, 42, true);
            WriteLiteral("</td>\r\n                </tr>            \r\n");
            EndContext();
#line 27 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\trabalho1\tarefa\Views\Tarefa\Abertas.cshtml"
        }

#line default
#line hidden
            BeginContext(752, 20, true);
            WriteLiteral("    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<tarefa.Models.Cadastro>> Html { get; private set; }
    }
}
#pragma warning restore 1591