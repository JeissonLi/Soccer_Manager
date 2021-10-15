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
    public class DeletePersonaModel : PageModel
    {
       private readonly IRepositorios _appContext;

        [BindProperty]
        public Persona persona  { get; set; } 

        public DeletePersonaModel()
        {
            this._appContext  =new Repositorios(new SoccerManager.App.Persistencia.AppContext());
        }
     
        //se ejecuta al presionar Eliminar en la lista
        public IActionResult OnGet(int personaId)
        {
            persona = _appContext.GetPersona(personaId);
            if(persona == null)
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
            if(persona.Id > 0)
            {
               _appContext.DeletePersona(persona.Id);
            }
            return Page();
        }
    }
}


