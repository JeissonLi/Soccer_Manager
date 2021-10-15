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
    public class EditPerfilModel : PageModel
    {
       private readonly IRepositorios _appContext;

        [BindProperty]
        public Perfil perfil  { get; set; } 

        public EditPerfilModel()
       {
            this._appContext  =new Repositorios(new SoccerManager.App.Persistencia.AppContext());
       }
     

        public IActionResult OnGet(int? perfilId)
        {
            if (perfilId.HasValue)
            {
                perfil = _appContext.GetPerfil(perfilId.Value);
            }
            else
            {
                perfil = new Perfil();
            }
            if (perfil == null)
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
            if(perfil.Id > 0)
            {
               perfil = _appContext.UpdatePerfil(perfil);
            }
            else
            {
               _appContext.AddPerfil(perfil);
            }
            return Page();
        }
    }
}

