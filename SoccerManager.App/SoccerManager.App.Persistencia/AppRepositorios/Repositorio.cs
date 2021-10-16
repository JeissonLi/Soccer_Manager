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
                //PersonaEncontrado.Tipo_Documento = persona.Tipo_Documento;  
                              
                
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
        //===============================================================================================
        //CRUD TIPO DE DOCUMENTO
        Tipo_Documento IRepositorios.AddTipo_Documento(Tipo_Documento tipo_documento)
        {
            try
            {
                var Tipo_DocumentoAdicionado = _appContext.Tipos_Documentos.Add(tipo_documento);  //INSERT en la BD
                _appContext.SaveChanges();
                return Tipo_DocumentoAdicionado.Entity;
            }
            catch
            {
                throw;
            }
        }

        IEnumerable<Tipo_Documento> IRepositorios.GetAllTipos_Documentos()
        {
            return _appContext.Tipos_Documentos;
        }

        Tipo_Documento IRepositorios.GetTipo_Documento(int? IdTipo_Documento)
        {
            return _appContext.Tipos_Documentos.FirstOrDefault(p => p.Id == IdTipo_Documento);
        }

        Tipo_Documento IRepositorios.UpdateTipo_Documento(Tipo_Documento tipo_documento)
        {
            var Tipo_DocumentoEncontrado = _appContext.Tipos_Documentos.FirstOrDefault(p => p.Id == tipo_documento.Id);
            if (Tipo_DocumentoEncontrado != null)
            {
                
                Tipo_DocumentoEncontrado.Nombre = tipo_documento.Nombre;
                Tipo_DocumentoEncontrado.Abreviatura = tipo_documento.Abreviatura;
                

                _appContext.SaveChanges();
            }
            return Tipo_DocumentoEncontrado;
        }

        void IRepositorios.DeleteTipo_Documento(int IdTipo_Documento)
        {
            var Tipo_DocumentoEncontrado = _appContext.Tipos_Documentos.FirstOrDefault(p => p.Id == IdTipo_Documento);
            if (Tipo_DocumentoEncontrado == null)
                return;
            _appContext.Tipos_Documentos.Remove(Tipo_DocumentoEncontrado);
            _appContext.SaveChanges();
        }
        //===============================================================================================
        //CRUD GENERO
        Genero IRepositorios.AddGenero(Genero genero)
        {
            try
            {
                var GeneroAdicionado = _appContext.Generos.Add(genero);  //INSERT en la BD
                _appContext.SaveChanges();
                return GeneroAdicionado.Entity;
            }
            catch
            {
                throw;
            }
        }

        IEnumerable<Genero> IRepositorios.GetAllGeneros()
        {
            return _appContext.Generos;
        }

        Genero IRepositorios.GetGenero(int? IdGenero)
        {
            return _appContext.Generos.FirstOrDefault(p => p.Id == IdGenero);
        }

        Genero IRepositorios.UpdateGenero(Genero genero)
        {
            var GeneroEncontrado = _appContext.Generos.FirstOrDefault(p => p.Id == genero.Id);
            if (GeneroEncontrado != null)
            {
                
                GeneroEncontrado.Nombre = genero.Nombre;
                GeneroEncontrado.Abreviatura = genero.Abreviatura;
                

                _appContext.SaveChanges();
            }
            return GeneroEncontrado;
        }

        void IRepositorios.DeleteGenero(int IdGenero)
        {
            var GeneroEncontrado = _appContext.Generos.FirstOrDefault(p => p.Id == IdGenero);
            if (GeneroEncontrado == null)
                return;
            _appContext.Generos.Remove(GeneroEncontrado);
            _appContext.SaveChanges();
        }
        //===============================================================================================
        //CRUD Ciudad
        Ciudad IRepositorios.AddCiudad(Ciudad ciudad)
        {
            try
            {
                var CiudadAdicionado = _appContext.Ciudades.Add(ciudad);  //INSERT en la BD
                _appContext.SaveChanges();
                return CiudadAdicionado.Entity;
            }
            catch
            {
                throw;
            }
        }

        IEnumerable<Ciudad> IRepositorios.GetAllCiudades()
        {
            return _appContext.Ciudades;
        }

        Ciudad IRepositorios.GetCiudad(int? IdCiudad)
        {
            return _appContext.Ciudades.FirstOrDefault(p => p.Id == IdCiudad);
        }

        Ciudad IRepositorios.UpdateCiudad(Ciudad ciudad)
        {
            var CiudadEncontrado = _appContext.Ciudades.FirstOrDefault(p => p.Id == ciudad.Id);
            if (CiudadEncontrado != null)
            {
                
                CiudadEncontrado.Nombre = ciudad.Nombre;
                
                

                _appContext.SaveChanges();
            }
            return CiudadEncontrado;
        }

        void IRepositorios.DeleteCiudad(int IdCiudad)
        {
            var CiudadEncontrado = _appContext.Ciudades.FirstOrDefault(p => p.Id == IdCiudad);
            if (CiudadEncontrado == null)
                return;
            _appContext.Ciudades.Remove(CiudadEncontrado);
            _appContext.SaveChanges();
        }
        //===============================================================================================
        //CRUD Perfil
        Perfil IRepositorios.AddPerfil(Perfil perfil)
        {
            try
            {
                var PerfilAdicionado = _appContext.Perfiles.Add(perfil);  //INSERT en la BD
                _appContext.SaveChanges();
                return PerfilAdicionado.Entity;
            }
            catch
            {
                throw;
            }
        }

        IEnumerable<Perfil> IRepositorios.GetAllPerfiles()
        {
            return _appContext.Perfiles;
        }

        Perfil IRepositorios.GetPerfil(int? IdPerfil)
        {
            return _appContext.Perfiles.FirstOrDefault(p => p.Id == IdPerfil);
        }

        Perfil IRepositorios.UpdatePerfil(Perfil perfil)
        {
            var PerfilEncontrado = _appContext.Perfiles.FirstOrDefault(p => p.Id == perfil.Id);
            if (PerfilEncontrado != null)
            {
                
                PerfilEncontrado.Nombre = perfil.Nombre;
                
                

                _appContext.SaveChanges();
            }
            return PerfilEncontrado;
        }

        void IRepositorios.DeletePerfil(int IdPerfil)
        {
            var PerfilEncontrado = _appContext.Perfiles.FirstOrDefault(p => p.Id == IdPerfil);
            if (PerfilEncontrado == null)
                return;
            _appContext.Perfiles.Remove(PerfilEncontrado);
            _appContext.SaveChanges();
        }

//===============================================================================================
        //CRUD Rama
        Rama IRepositorios.AddRama(Rama rama)
        {
            try
            {
                var RamaAdicionado = _appContext.Ramas.Add(rama);  //INSERT en la BD
                _appContext.SaveChanges();
                return RamaAdicionado.Entity;
            }
            catch
            {
                throw;
            }
        }

        IEnumerable<Rama> IRepositorios.GetAllRamas()
        {
            return _appContext.Ramas;
        }

        Rama IRepositorios.GetRama(int? IdRama)
        {
            return _appContext.Ramas.FirstOrDefault(p => p.Id == IdRama);
        }

        Rama IRepositorios.UpdateRama(Rama rama)
        {
            var RamaEncontrado = _appContext.Ramas.FirstOrDefault(p => p.Id == rama.Id);
            if (RamaEncontrado != null)
            {
                
                RamaEncontrado.Nombre = rama.Nombre;
                
                

                _appContext.SaveChanges();
            }
            return RamaEncontrado;
        }

        void IRepositorios.DeleteRama(int IdRama)
        {
            var RamaEncontrado = _appContext.Ramas.FirstOrDefault(p => p.Id == IdRama);
            if (RamaEncontrado == null)
                return;
            _appContext.Ramas.Remove(RamaEncontrado);
            _appContext.SaveChanges();
        }
//===============================================================================================
        //CRUD Modalidad
        Modalidad IRepositorios.AddModalidad(Modalidad modalidad)
        {
            try
            {
                var ModalidadAdicionado = _appContext.Modalidades.Add(modalidad);  //INSERT en la BD
                _appContext.SaveChanges();
                return ModalidadAdicionado.Entity;
            }
            catch
            {
                throw;
            }
        }

        IEnumerable<Modalidad> IRepositorios.GetAllModalidades()
        {
            return _appContext.Modalidades;
        }

        Modalidad IRepositorios.GetModalidad(int? IdModalidad)
        {
            return _appContext.Modalidades.FirstOrDefault(p => p.Id == IdModalidad);
        }

        Modalidad IRepositorios.UpdateModalidad(Modalidad modalidad)
        {
            var ModalidadEncontrado = _appContext.Modalidades.FirstOrDefault(p => p.Id == modalidad.Id);
            if (ModalidadEncontrado != null)
            {
                
                ModalidadEncontrado.Nombre = modalidad.Nombre;
                
                

                _appContext.SaveChanges();
            }
            return ModalidadEncontrado;
        }

        void IRepositorios.DeleteModalidad(int IdModalidad)
        {
            var ModalidadEncontrado = _appContext.Modalidades.FirstOrDefault(p => p.Id == IdModalidad);
            if (ModalidadEncontrado == null)
                return;
            _appContext.Modalidades.Remove(ModalidadEncontrado);
            _appContext.SaveChanges();
        }

//===============================================================================================
        //CRUD Categoria
        Categoria IRepositorios.AddCategoria(Categoria categoria)
        {
            try
            {
                var CategoriaAdicionado = _appContext.Categorias.Add(categoria);  //INSERT en la BD
                _appContext.SaveChanges();
                return CategoriaAdicionado.Entity;
            }
            catch
            {
                throw;
            }
        }

        IEnumerable<Categoria> IRepositorios.GetAllCategorias()
        {
            return _appContext.Categorias;
        }

        Categoria IRepositorios.GetCategoria(int? IdCategoria)
        {
            return _appContext.Categorias.FirstOrDefault(p => p.Id == IdCategoria);
        }

        Categoria IRepositorios.UpdateCategoria(Categoria categoria)
        {
            var CategoriaEncontrado = _appContext.Categorias.FirstOrDefault(p => p.Id == categoria.Id);
            if (CategoriaEncontrado != null)
            {
                
                CategoriaEncontrado.Nombre = categoria.Nombre;
                
                

                _appContext.SaveChanges();
            }
            return CategoriaEncontrado;
        }

        void IRepositorios.DeleteCategoria(int IdCategoria)
        {
            var CategoriaEncontrado = _appContext.Categorias.FirstOrDefault(p => p.Id == IdCategoria);
            if (CategoriaEncontrado == null)
                return;
            _appContext.Categorias.Remove(CategoriaEncontrado);
            _appContext.SaveChanges();
        }


    }
}

