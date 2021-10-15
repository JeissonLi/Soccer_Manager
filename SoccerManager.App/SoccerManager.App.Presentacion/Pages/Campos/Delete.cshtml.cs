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
    public class DeleteCampoModel : PageModel
    {
       private readonly IRepositorios _appContext;

        [BindProperty]
        public Campo campo  { get; set; } 

        public DeleteCampoModel()
        {
            this._appContext  =new Repositorios(new SoccerManager.App.Persistencia.AppContext());
        }
     
        //se ejecuta al presionar Eliminar en la lista
        public IActionResult OnGet(int campoId)
        {
            campo = _appContext.GetCampo(campoId);
            if(campo == null)
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
            if(campo.Id > 0)
            {
               _appContext.DeleteCampo(campo.Id);
            }
            return Page();
        }
    }
}


