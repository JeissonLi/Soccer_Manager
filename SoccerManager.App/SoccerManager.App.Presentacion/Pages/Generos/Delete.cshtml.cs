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
    public class DeleteGeneroModel : PageModel
    {
       private readonly IRepositorios _appContext;

        [BindProperty]
        public Genero genero  { get; set; } 

        public DeleteGeneroModel()
        {
            this._appContext  =new Repositorios(new SoccerManager.App.Persistencia.AppContext());
        }
     
        //se ejecuta al presionar Eliminar en la lista
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
        
        //se ejecuta al presionar Eliminar en el formulario 
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(genero.Id > 0)
            {
               _appContext.DeleteGenero(genero.Id);
            }
            return Page();
        }
    }
}


