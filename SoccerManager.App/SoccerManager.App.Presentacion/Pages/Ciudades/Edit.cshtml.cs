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
    public class EditCiudadModel : PageModel
    {
       private readonly IRepositorios _appContext;

        [BindProperty]
        public Ciudad ciudad  { get; set; } 

        public EditCiudadModel()
       {
            this._appContext  =new Repositorios(new SoccerManager.App.Persistencia.AppContext());
       }
     

        public IActionResult OnGet(int? ciudadId)
        {
            if (ciudadId.HasValue)
            {
                ciudad = _appContext.GetCiudad(ciudadId.Value);
            }
            else
            {
                ciudad = new Ciudad();
            }
            if (ciudad == null)
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
            if(ciudad.Id > 0)
            {
               ciudad = _appContext.UpdateCiudad(ciudad);
            }
            else
            {
               _appContext.AddCiudad(ciudad);
            }
            return Page();
        }
    }
}

