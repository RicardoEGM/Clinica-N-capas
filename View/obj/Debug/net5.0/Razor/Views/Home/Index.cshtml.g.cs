#pragma checksum "C:\Users\5vc_isuser13_sal\source\repos\Clinica\View\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e55af90160af0bbe3cf5717adaea8189a6816f87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\5vc_isuser13_sal\source\repos\Clinica\View\Views\_ViewImports.cshtml"
using View;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\5vc_isuser13_sal\source\repos\Clinica\View\Views\_ViewImports.cshtml"
using View.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e55af90160af0bbe3cf5717adaea8189a6816f87", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3816675dba29992f78477f9960cc4a6fdd149fec", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\5vc_isuser13_sal\source\repos\Clinica\View\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Citas Clinicas";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""col-sm-12 col-md-12"">
    <section class=""content"">
        <div class=""box"">
            <div class=""box-header with-border"">
                <h3 class=""box-title"">Citas</h3>
            </div>
            <div class=""box-body"">
                <div class=""row"">
                    <div class=""col-sm-4"">
                        <div class=""form-group"">
                            <button type=""button"" class=""btn btn-success"" id=""btn-new-category"" data-toggle=""modal"" data-target=""#exampleModal""><span class=""glyphicon glyphicon-plus""></span> Agregar una cita</button>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-sm-12 col-md-12"" id=""container-category"">
                        <table class=""table table-bordered"" id=""cita-table"">
                            <thead>
                                <tr>
                                    <th class=""text-center"">#</th>
     ");
            WriteLiteral(@"                               <th>Doctores</th>
                                    <th>Paciente</th>
                                    <th>Cita Para</th>
                                    <th>Estado</th>
                                    <th>Diagnóstico</th>
                                </tr>
                            </thead>
                            <tbody>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </section>
</div>



<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Add Cita</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <spa");
            WriteLiteral(@"n aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""form-row"">
                    <div class=""form-group col-md-6"">
                        <label for=""Description"">Description</label>
                        <input type=""text"" class=""form-control"" id=""Description"" placeholder=""Description"" name=""Description"">
                    </div>
                    <div class=""form-group col-md-6"">
                        <label for=""ID_VI"">Voluntary/Involuntary</label>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-primary"">Save</button>
            </div>
        </div>
    </div>
</div>");
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
