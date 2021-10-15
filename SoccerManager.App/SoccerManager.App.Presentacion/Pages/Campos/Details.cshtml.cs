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
    public class DetailsCampoModel : PageModel
    {
        private readonly IRepositorios _appContext;
        public Campo campo { get; set; }

        public DetailsCampoModel()
        {
            this._appContext=new Repositorios(new SoccerManager.App.Persistencia.AppContext());
        }

        //se ejecuta al presionar Detalle en la lista
        public IActionResult OnGet(int campoId)
        {
            campo = _appContext.GetCampo(campoId);
            if(campo == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
    }
}