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
    public class DeletePerfilModel : PageModel
    {
       private readonly IRepositorios _appContext;

        [BindProperty]
        public Perfil perfil  { get; set; } 

        public DeletePerfilModel()
        {
            this._appContext  =new Repositorios(new SoccerManager.App.Persistencia.AppContext());
        }
     
        //se ejecuta al presionar Eliminar en la lista
        public IActionResult OnGet(int perfilId)
        {
            perfil = _appContext.GetPerfil(perfilId);
            if(perfil == null)
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
            if(perfil.Id > 0)
            {
               _appContext.DeletePerfil(perfil.Id);
            }
            return Page();
        }
    }
}


