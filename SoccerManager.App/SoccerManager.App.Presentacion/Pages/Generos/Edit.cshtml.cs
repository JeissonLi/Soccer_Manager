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
    public class EditGeneroModel : PageModel
    {
       private readonly IRepositorios _appContext;

        [BindProperty]
        public Genero genero  { get; set; } 

        public EditGeneroModel()
       {
            this._appContext  =new Repositorios(new SoccerManager.App.Persistencia.AppContext());
       }
     

        public IActionResult OnGet(int? generoId)
        {
            if (generoId.HasValue)
            {
                genero = _appContext.GetGenero(generoId.Value);
            }
            else
            {
                genero = new Genero();
            }
            if (genero == null)
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
            if(genero.Id > 0)
            {
               genero = _appContext.UpdateGenero(genero);
            }
            else
            {
               _appContext.AddGenero(genero);
            }
            return Page();
        }
    }
}

