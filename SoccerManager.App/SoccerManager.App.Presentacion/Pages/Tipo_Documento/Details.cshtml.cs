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
    public class DetailsTipo_DocumentoModel : PageModel
    {
        private readonly IRepositorios _appContext;
        public Tipo_Documento tipo_documento { get; set; }

        public DetailsTipo_DocumentoModel()
        {
            this._appContext=new Repositorios(new SoccerManager.App.Persistencia.AppContext());
        }

        //se ejecuta al presionar Detalle en la lista
        public IActionResult OnGet(int tipo_documentoId)
        {
            tipo_documento = _appContext.GetTipo_Documento(tipo_documentoId);
            if(tipo_documento == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
    }
}