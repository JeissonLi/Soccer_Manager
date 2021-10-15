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
    public class DeleteCiudadModel : PageModel
    {
       private readonly IRepositorios _appContext;

        [BindProperty]
        public Ciudad ciudad  { get; set; } 

        public DeleteCiudadModel()
        {
            this._appContext  =new Repositorios(new SoccerManager.App.Persistencia.AppContext());
        }
     
        //se ejecuta al presionar Eliminar en la lista
        public IActionResult OnGet(int ciudadId)
        {
            ciudad = _appContext.GetCiudad(ciudadId);
            if(ciudad == null)
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
            if(ciudad.Id > 0)
            {
               _appContext.DeleteCiudad(ciudad.Id);
            }
            return Page();
        }
    }
}


