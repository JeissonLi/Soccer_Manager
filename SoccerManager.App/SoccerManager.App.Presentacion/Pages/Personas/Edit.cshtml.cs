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
    public class EditPersonaModel : PageModel
    {
       private readonly IRepositorios _appContext;

        [BindProperty]
        public Persona persona  { get; set; } 

        public EditPersonaModel()
       {
            this._appContext  =new Repositorios(new SoccerManager.App.Persistencia.AppContext());
       }
     

        public IActionResult OnGet(int? personaId)
        {
            if (personaId.HasValue)
            {
                persona = _appContext.GetPersona(personaId.Value);
            }
            else
            {
                persona = new Persona();
            }
            if (persona == null)
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
            if(persona.Id > 0)
            {
               persona = _appContext.UpdatePersona(persona);
            }
            else
            {
               _appContext.AddPersona(persona);
            }
            return Page();
        }
    }
}

