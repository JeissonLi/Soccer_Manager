using System.Collections.Generic;
using SoccerManager.App.Dominio;

namespace SoccerManager.App.Persistencia
{
    public interface IRepositorios
    {
        //CRUD PERSONA
        IEnumerable<Persona> GetAllPersonas();

        Persona AddPersona(Persona persona);

        Persona UpdatePersona(Persona persona);

        void DeletePersona(int IdPersona);
        
        Persona GetPersona(int? IdPersona);
        //========================================================================================
        //CRUD CAMPOS

        IEnumerable<Campo> GetAllCampos();

        Campo AddCampo(Campo campo);

        Campo UpdateCampo(Campo campo);

        void DeleteCampo(int IdCampo);

        Campo GetCampo(int? IdCampo);
        //========================================================================================
        //========================================================================================
        //CRUD TIPO DOCUMENTO

        IEnumerable<Tipo_Documento> GetAllTipos_Documentos();

        Tipo_Documento AddTipo_Documento(Tipo_Documento tipo_documento);

        Tipo_Documento UpdateTipo_Documento(Tipo_Documento tipo_documento);

        void DeleteTipo_Documento(int IdTipo_Documento);

        Tipo_Documento GetTipo_Documento(int? IdTipo_Documento);
        //========================================================================================
        //========================================================================================
        //CRUD GENERO

        IEnumerable<Genero> GetAllGeneros();

        Genero AddGenero(Genero genero);

        Genero UpdateGenero(Genero genero);

        void DeleteGenero(int IdGenero);

        Genero GetGenero(int? IdGenero);
        //========================================================================================
        //========================================================================================
        //CRUD CIUDAD

        IEnumerable<Ciudad> GetAllCiudades();

        Ciudad AddCiudad(Ciudad ciudad);

        Ciudad UpdateCiudad(Ciudad ciudad);

        void DeleteCiudad(int IdCiudad);

        Ciudad GetCiudad(int? IdCiudad);
        //========================================================================================
        //CRUD Perfil

        IEnumerable<Perfil> GetAllPerfiles();

        Perfil AddPerfil(Perfil perfil);

        Perfil UpdatePerfil(Perfil perfil);

        void DeletePerfil(int IdPerfil);

        Perfil GetPerfil(int? IdPerfil);
        //========================================================================================
    }
}