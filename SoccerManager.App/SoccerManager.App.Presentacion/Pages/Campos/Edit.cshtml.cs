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
    public class EditCampoModel : PageModel
    {
       private readonly IRepositorios _appContext;

        [BindProperty]
        public Campo campo  { get; set; } 

        public EditCampoModel()
       {
            this._appContext  =new Repositorios(new SoccerManager.App.Persistencia.AppContext());
       }
     

        public IActionResult OnGet(int? campoId)
        {
            if (campoId.HasValue)
            {
                campo = _appContext.GetCampo(campoId.Value);
            }
            else
            {
                campo = new Campo();
            }
            if (campo == null)
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
            if(campo.Id > 0)
            {
               campo = _appContext.UpdateCampo(campo);
            }
            else
            {
               _appContext.AddCampo(campo);
            }
            return Page();
        }
    }
}

