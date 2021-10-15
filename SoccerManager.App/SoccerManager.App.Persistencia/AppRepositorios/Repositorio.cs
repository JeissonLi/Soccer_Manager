using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

using SoccerManager.App.Dominio;

namespace SoccerManager.App.Persistencia
{
    public class Repositorios : IRepositorios
    {
        private readonly AppContext _appContext;

        public Repositorios(AppContext appContext)
        {
            _appContext = appContext;
        }
        //===============================================================================================
        //CRUD PERSONA
        Persona IRepositorios.AddPersona(Persona persona)
        {
            try
            {
                var PersonaAdicionado = _appContext.Personas.Add(persona);  //INSERT en la BD
                _appContext.SaveChanges();
                return PersonaAdicionado.Entity;
            }
            catch
            {
                throw;
            }
        }

        IEnumerable<Persona> IRepositorios.GetAllPersonas()
        {
            return _appContext.Personas;
        }

        Persona IRepositorios.GetPersona(int? IdPersona)
        {
            return _appContext.Personas.FirstOrDefault(p => p.Id == IdPersona);
        }

        Persona IRepositorios.UpdatePersona(Persona persona)
        {
            var PersonaEncontrado = _appContext.Personas.FirstOrDefault(p => p.Id == persona.Id);
            if (PersonaEncontrado != null)
            {
                
                PersonaEncontrado.Nombre = persona.Nombre;
                PersonaEncontrado.Apellido = persona.Apellido;
                PersonaEncontrado.Correo = persona.Correo;
                PersonaEncontrado.Num_Documento = persona.Num_Documento;
                PersonaEncontrado.Telefono = persona.Telefono;
                PersonaEncontrado.Fecha_Nacimiento = persona.Fecha_Nacimiento;  
                              
                
                _appContext.SaveChanges();
            }
            return PersonaEncontrado;
        }

        void IRepositorios.DeletePersona(int IdPersona)
        {
            var PersonaEncontrado = _appContext.Personas.FirstOrDefault(p => p.Id == IdPersona);
            if (PersonaEncontrado == null)
                return;
            _appContext.Personas.Remove(PersonaEncontrado);
            _appContext.SaveChanges();
        }
        //===============================================================================================
        //CRUD CAMPO
        Campo IRepositorios.AddCampo(Campo campo)
        {
            try
            {
                var CampoAdicionado = _appContext.Campos.Add(campo);  //INSERT en la BD
                _appContext.SaveChanges();
                return CampoAdicionado.Entity;
            }
            catch
            {
                throw;
            }
        }

        IEnumerable<Campo> IRepositorios.GetAllCampos()
        {
            return _appContext.Campos;
        }

        Campo IRepositorios.GetCampo(int? IdCampo)
        {
            return _appContext.Campos.FirstOrDefault(p => p.Id == IdCampo);
        }

        Campo IRepositorios.UpdateCampo(Campo campo)
        {
            var CampoEncontrado = _appContext.Campos.FirstOrDefault(p => p.Id == campo.Id);
            if (CampoEncontrado != null)
            {
                
                CampoEncontrado.Nombre = campo.Nombre;
                CampoEncontrado.Fecha_Horario_Inicial = campo.Fecha_Horario_Inicial;
                CampoEncontrado.Fecha_Horario_Final = campo.Fecha_Horario_Final;

                _appContext.SaveChanges();
            }
            return CampoEncontrado;
        }

        void IRepositorios.DeleteCampo(int IdCampo)
        {
            var CampoEncontrado = _appContext.Campos.FirstOrDefault(p => p.Id == IdCampo);
            if (CampoEncontrado == null)
                return;
            _appContext.Campos.Remove(CampoEncontrado);
            _appContext.SaveChanges();
        }


    }
}

