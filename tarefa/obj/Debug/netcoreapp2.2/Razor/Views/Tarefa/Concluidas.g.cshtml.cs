#pragma checksum "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\trabalho1\tarefa\Views\Tarefa\Concluidas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c52f1946dbd1e40899fedccccf7da49df6d4304"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tarefa_Concluidas), @"mvc.1.0.view", @"/Views/Tarefa/Concluidas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tarefa/Concluidas.cshtml", typeof(AspNetCore.Views_Tarefa_Concluidas))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c52f1946dbd1e40899fedccccf7da49df6d4304", @"/Views/Tarefa/Concluidas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94475b55689d4542834770881cca57be4f344ea4", @"/Views/_ViewImports.cshtml")]
    public class Views_Tarefa_Concluidas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<tarefa.Models.Cadastro>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 376, true);
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
#line 17 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\trabalho1\tarefa\Views\Tarefa\Concluidas.cshtml"
         foreach(var item in Model)
        {

#line default
#line hidden
            BeginContext(468, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(507, 7, false);
#line 20 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\trabalho1\tarefa\Views\Tarefa\Concluidas.cshtml"
               Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(514, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(542, 15, false);
#line 21 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\trabalho1\tarefa\Views\Tarefa\Concluidas.cshtml"
               Write(item.prioridade);

#line default
#line hidden
            EndContext();
            BeginContext(557, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(585, 15, false);
#line 22 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\trabalho1\tarefa\Views\Tarefa\Concluidas.cshtml"
               Write(item.nameTarefa);

#line default
#line hidden
            EndContext();
            BeginContext(600, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(628, 9, false);
#line 23 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\trabalho1\tarefa\Views\Tarefa\Concluidas.cshtml"
               Write(item.data);

#line default
#line hidden
            EndContext();
            BeginContext(637, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(665, 12, false);
#line 24 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\trabalho1\tarefa\Views\Tarefa\Concluidas.cshtml"
               Write(item.percent);

#line default
#line hidden
            EndContext();
            BeginContext(677, 51, true);
            WriteLiteral("</td>\r\n               <td><a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 728, "\"", 755, 2);
            WriteAttributeValue("", 735, "Tarefa/Dell/", 735, 12, true);
#line 25 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\trabalho1\tarefa\Views\Tarefa\Concluidas.cshtml"
WriteAttributeValue("", 747, item.id, 747, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(756, 38, true);
            WriteLiteral(">Delete</a> </td>\r\n            </tr>\r\n");
            EndContext();
#line 27 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\trabalho1\tarefa\Views\Tarefa\Concluidas.cshtml"
        }

#line default
#line hidden
            BeginContext(805, 33, true);
            WriteLiteral("     </table>\r\n</div>\r\n\r\n        ");
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
