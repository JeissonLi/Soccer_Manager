using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using SoccerManager.App.Dominio;
using SoccerManager.App.Persistencia;

namespace SoccerManager.App.Presentacion
{
    public class EditTipo_DocumentoModel : PageModel
    {
       private readonly IRepositorios _appContext;

        [BindProperty]
        public Tipo_Documento tipo_documento  { get; set; } 

        public EditTipo_DocumentoModel()
       {
            this._appContext  =new Repositorios(new SoccerManager.App.Persistencia.AppContext());
       }
     

        public IActionResult OnGet(int? tipo_documentoId)
        {
            if (tipo_documentoId.HasValue)
            {
                tipo_documento = _appContext.GetTipo_Documento(tipo_documentoId.Value);
            }
            else
            {
                tipo_documento = new Tipo_Documento();
            }
            if (tipo_documento == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(tipo_documento.Id > 0)
            {
               tipo_documento = _appContext.UpdateTipo_Documento(tipo_documento);
            }
            else
            {
               _appContext.AddTipo_Documento(tipo_documento);
            }
            return Page();
        }
    }
}

