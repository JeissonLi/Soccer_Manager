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
    public class DetailsGeneroModel : PageModel
    {
        private readonly IRepositorios _appContext;
        public Genero genero { get; set; }

        public DetailsGeneroModel()
        {
            this._appContext=new Repositorios(new SoccerManager.App.Persistencia.AppContext());
        }

        //se ejecuta al presionar Detalle en la lista
        public IActionResult OnGet(int generoId)
        {
            genero = _appContext.GetGenero(generoId);
            if(genero == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
    }
}