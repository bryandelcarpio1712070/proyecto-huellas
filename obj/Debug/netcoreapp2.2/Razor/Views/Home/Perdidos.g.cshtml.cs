#pragma checksum "C:\Users\alumno\Downloads\proyecto_huellas\Views\Home\Perdidos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ea211b66e96f54a02ba3d32a89b19f2c8ea3420"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Perdidos), @"mvc.1.0.view", @"/Views/Home/Perdidos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Perdidos.cshtml", typeof(AspNetCore.Views_Home_Perdidos))]
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
#line 1 "C:\Users\alumno\Downloads\proyecto_huellas\Views\_ViewImports.cshtml"
using proyecto_huellas;

#line default
#line hidden
#line 2 "C:\Users\alumno\Downloads\proyecto_huellas\Views\_ViewImports.cshtml"
using proyecto_huellas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ea211b66e96f54a02ba3d32a89b19f2c8ea3420", @"/Views/Home/Perdidos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15e34367aea9f00fc13120014b9e369d4c0730f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Perdidos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\alumno\Downloads\proyecto_huellas\Views\Home\Perdidos.cshtml"
  
    ViewData["Title"] = "Home Page";
    var noticias = (List<P_Perdidos>)ViewBag.noticias;

#line default
#line hidden
            BeginContext(101, 381, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Mascotas perdidas</h1>
    <table class=""table table-bordered table-dark"">
          <thead>
            <tr>
              <th scope=""col"">Id</th>
              <th scope=""col"">Telefono</th>
              <th scope=""col"">Descripcion</th>
              <th scope=""col"">Foto</th>
            </tr>
          </thead>
");
            EndContext();
#line 17 "C:\Users\alumno\Downloads\proyecto_huellas\Views\Home\Perdidos.cshtml"
     foreach(var n in noticias) {        
        

#line default
#line hidden
            BeginContext(535, 76, true);
            WriteLiteral("          <tbody>\r\n            <tr>\r\n              <td Style=\"width: 100PX\">");
            EndContext();
            BeginContext(612, 4, false);
#line 21 "C:\Users\alumno\Downloads\proyecto_huellas\Views\Home\Perdidos.cshtml"
                                  Write(n.Id);

#line default
#line hidden
            EndContext();
            BeginContext(616, 46, true);
            WriteLiteral("</td>\r\n              <td Style=\"width: 200px\">");
            EndContext();
            BeginContext(663, 13, false);
#line 22 "C:\Users\alumno\Downloads\proyecto_huellas\Views\Home\Perdidos.cshtml"
                                  Write(n.NumTelefono);

#line default
#line hidden
            EndContext();
            BeginContext(676, 49, true);
            WriteLiteral("</td>   \r\n              <td Style=\"width: 520px\">");
            EndContext();
            BeginContext(726, 13, false);
#line 23 "C:\Users\alumno\Downloads\proyecto_huellas\Views\Home\Perdidos.cshtml"
                                  Write(n.Descripcion);

#line default
#line hidden
            EndContext();
            BeginContext(739, 29, true);
            WriteLiteral("</td>\r\n              <td><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 768, "\"", 783, 1);
#line 24 "C:\Users\alumno\Downloads\proyecto_huellas\Views\Home\Perdidos.cshtml"
WriteAttributeValue("", 774, n.Imagen, 774, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(784, 91, true);
            WriteLiteral(" alt=\"\" style=\"width: 200px; height: 100px\" ></td>\r\n\r\n            </tr>\r\n          </tbody>");
            EndContext();
#line 27 "C:\Users\alumno\Downloads\proyecto_huellas\Views\Home\Perdidos.cshtml"
                  }

#line default
#line hidden
            BeginContext(878, 30, true);
            WriteLiteral("        </table>\r\n    \r\n</div>");
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
