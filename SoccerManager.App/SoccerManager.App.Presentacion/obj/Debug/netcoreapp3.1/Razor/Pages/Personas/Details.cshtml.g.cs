#pragma checksum "C:\Users\Familia\Documents\GitHub\Soccer_Manager\SoccerManager.App\SoccerManager.App.Presentacion\Pages\Personas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec0cc66437bb2333db11a39a1e6e63e39baef080"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SoccerManager.App.Presentacion.Pages.Personas.Pages_Personas_Details), @"mvc.1.0.razor-page", @"/Pages/Personas/Details.cshtml")]
namespace SoccerManager.App.Presentacion.Pages.Personas
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
#line 1 "C:\Users\Familia\Documents\GitHub\Soccer_Manager\SoccerManager.App\SoccerManager.App.Presentacion\Pages\_ViewImports.cshtml"
using SoccerManager.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec0cc66437bb2333db11a39a1e6e63e39baef080", @"/Pages/Personas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7c281c7cfa43d00f8e49cce6d2376fd6984103c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Personas_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1><svg xmlns=""http://www.w3.org/2000/svg"" width=""50"" height=""50"" fill=""currentColor"" class=""bi bi-receipt""
        viewBox=""0 0 18 18"">
        <path
            d=""M1.92.506a.5.5 0 0 1 .434.14L3 1.293l.646-.647a.5.5 0 0 1 .708 0L5 1.293l.646-.647a.5.5 0 0 1 .708 0L7 1.293l.646-.647a.5.5 0 0 1 .708 0L9 1.293l.646-.647a.5.5 0 0 1 .708 0l.646.647.646-.647a.5.5 0 0 1 .708 0l.646.647.646-.647a.5.5 0 0 1 .801.13l.5 1A.5.5 0 0 1 15 2v12a.5.5 0 0 1-.053.224l-.5 1a.5.5 0 0 1-.8.13L13 14.707l-.646.647a.5.5 0 0 1-.708 0L11 14.707l-.646.647a.5.5 0 0 1-.708 0L9 14.707l-.646.647a.5.5 0 0 1-.708 0L7 14.707l-.646.647a.5.5 0 0 1-.708 0L5 14.707l-.646.647a.5.5 0 0 1-.708 0L3 14.707l-.646.647a.5.5 0 0 1-.801-.13l-.5-1A.5.5 0 0 1 1 14V2a.5.5 0 0 1 .053-.224l.5-1a.5.5 0 0 1 .367-.27zm.217 1.338L2 2.118v11.764l.137.274.51-.51a.5.5 0 0 1 .707 0l.646.647.646-.646a.5.5 0 0 1 .708 0l.646.646.646-.646a.5.5 0 0 1 .708 0l.646.646.646-.646a.5.5 0 0 1 .708 0l.646.646.646-.646a.5.5 0 0 1 .708 0l.646.646.646-.646a.5.5 0 0 1 .708 0l.509");
            WriteLiteral(@".509.137-.274V2.118l-.137-.274-.51.51a.5.5 0 0 1-.707 0L12 1.707l-.646.647a.5.5 0 0 1-.708 0L10 1.707l-.646.647a.5.5 0 0 1-.708 0L8 1.707l-.646.647a.5.5 0 0 1-.708 0L6 1.707l-.646.647a.5.5 0 0 1-.708 0L4 1.707l-.646.647a.5.5 0 0 1-.708 0l-.509-.51z"" />
        <path
            d=""M3 4.5a.5.5 0 0 1 .5-.5h6a.5.5 0 1 1 0 1h-6a.5.5 0 0 1-.5-.5zm0 2a.5.5 0 0 1 .5-.5h6a.5.5 0 1 1 0 1h-6a.5.5 0 0 1-.5-.5zm0 2a.5.5 0 0 1 .5-.5h6a.5.5 0 1 1 0 1h-6a.5.5 0 0 1-.5-.5zm0 2a.5.5 0 0 1 .5-.5h6a.5.5 0 0 1 0 1h-6a.5.5 0 0 1-.5-.5zm8-6a.5.5 0 0 1 .5-.5h1a.5.5 0 0 1 0 1h-1a.5.5 0 0 1-.5-.5zm0 2a.5.5 0 0 1 .5-.5h1a.5.5 0 0 1 0 1h-1a.5.5 0 0 1-.5-.5zm0 2a.5.5 0 0 1 .5-.5h1a.5.5 0 0 1 0 1h-1a.5.5 0 0 1-.5-.5zm0 2a.5.5 0 0 1 .5-.5h1a.5.5 0 0 1 0 1h-1a.5.5 0 0 1-.5-.5z"" />
    </svg>Detalles de Perfil</h1>
<svg xmlns=""http://www.w3.org/2000/svg"" width=""100"" height=""100"" fill=""currentColor"" class=""bi bi-person-bounding-box""
    viewBox=""0 0 16 16"">
    <path
        d=""M1.5 1a.5.5 0 0 0-.5.5v3a.5.5 0 0 1-1 0v-3A1.5 1.5 0 0 1 ");
            WriteLiteral(@"1.5 0h3a.5.5 0 0 1 0 1h-3zM11 .5a.5.5 0 0 1 .5-.5h3A1.5 1.5 0 0 1 16 1.5v3a.5.5 0 0 1-1 0v-3a.5.5 0 0 0-.5-.5h-3a.5.5 0 0 1-.5-.5zM.5 11a.5.5 0 0 1 .5.5v3a.5.5 0 0 0 .5.5h3a.5.5 0 0 1 0 1h-3A1.5 1.5 0 0 1 0 14.5v-3a.5.5 0 0 1 .5-.5zm15 0a.5.5 0 0 1 .5.5v3a1.5 1.5 0 0 1-1.5 1.5h-3a.5.5 0 0 1 0-1h3a.5.5 0 0 0 .5-.5v-3a.5.5 0 0 1 .5-.5z"" />
    <path d=""M3 14s-1 0-1-1 1-4 6-4 6 3 6 4-1 1-1 1H3zm8-9a3 3 0 1 1-6 0 3 3 0 0 1 6 0z"" />
</svg>
<div>ID: ");
#nullable restore
#line 18 "C:\Users\Familia\Documents\GitHub\Soccer_Manager\SoccerManager.App\SoccerManager.App.Presentacion\Pages\Personas\Details.cshtml"
    Write(Model.persona.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n<div>Nombre: ");
#nullable restore
#line 19 "C:\Users\Familia\Documents\GitHub\Soccer_Manager\SoccerManager.App\SoccerManager.App.Presentacion\Pages\Personas\Details.cshtml"
        Write(Model.persona.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Apellido: ");
#nullable restore
#line 20 "C:\Users\Familia\Documents\GitHub\Soccer_Manager\SoccerManager.App\SoccerManager.App.Presentacion\Pages\Personas\Details.cshtml"
          Write(Model.persona.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Email: ");
#nullable restore
#line 21 "C:\Users\Familia\Documents\GitHub\Soccer_Manager\SoccerManager.App\SoccerManager.App.Presentacion\Pages\Personas\Details.cshtml"
       Write(Model.persona.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Telefono: ");
#nullable restore
#line 22 "C:\Users\Familia\Documents\GitHub\Soccer_Manager\SoccerManager.App\SoccerManager.App.Presentacion\Pages\Personas\Details.cshtml"
          Write(Model.persona.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Fecha de Nacimiento: ");
#nullable restore
#line 23 "C:\Users\Familia\Documents\GitHub\Soccer_Manager\SoccerManager.App\SoccerManager.App.Presentacion\Pages\Personas\Details.cshtml"
                     Write(Model.persona.Fecha_Nacimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SoccerManager.App.Presentacion.DetailsPersonaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SoccerManager.App.Presentacion.DetailsPersonaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SoccerManager.App.Presentacion.DetailsPersonaModel>)PageContext?.ViewData;
        public SoccerManager.App.Presentacion.DetailsPersonaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
