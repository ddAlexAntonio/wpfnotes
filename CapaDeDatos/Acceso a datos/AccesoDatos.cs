namespace CapaDeDatos.Acceso_a_datos
{
    using System;
    using System.Collections.Generic;
    using CapaDeDatos.Modelo_de_datos;

    /// <summary>
    /// Clase de acceso a datos.
    /// </summary>
    public class AccesoDatos
    {
        private static Guid libretaTest1 = Guid.NewGuid();
        private static Guid libretaTest1sub1 = Guid.NewGuid();
        private static Guid libretaTest2 = Guid.NewGuid();
        private static Guid idContenedorNota1 = Guid.NewGuid();
        private static Guid idContenedorNota2 = Guid.NewGuid();
        private static Guid idContenedorNota3 = Guid.NewGuid();
        private static Guid idContenedorNota4 = Guid.NewGuid();
        private static Guid idContenedorNota5 = Guid.NewGuid();

        /// <summary>
        /// Recupera todas las libretas para el usuario.
        /// </summary>
        /// <param name="idUsuario">Identificador de usuario.</param>
        /// <returns>Lista de libretas.</returns>
        public static IEnumerable<Libreta> GetAllLibretas(Guid idUsuario)
        {
            return new Libreta[]
            {
               new Libreta()
               {
                   IdLibreta = libretaTest1,
                   FechaDeCreacion = DateTime.Now,
                   FechaDeModificacion = DateTime.Now,
                   Nombre = "LIbreta1",
               },
               new Libreta()
               {
                   IdLibreta = libretaTest1sub1,
                   IdLibretaPadre = libretaTest1sub1,
                   FechaDeCreacion = DateTime.Now,
                   FechaDeModificacion = DateTime.Now,
                   Nombre = "LIbreta1sub1",
               },
               new Libreta()
               {
                   IdLibreta = libretaTest2,
                   FechaDeCreacion = DateTime.Now,
                   FechaDeModificacion = DateTime.Now,
                   Nombre = "LIbreta2",
               },
            };
        }

        /// <summary>
        /// Recupera todos los contenedores de notas para la libreta.
        /// </summary>
        /// <param name="idLibreta">Identificador de libreta.</param>
        /// <param name="idUsuario">Identificador de usuario.</param>
        /// <returns>Lista de contenedores de nota.</returns>
        public static IEnumerable<ContenedorNota> GetContenedoresNotas(Guid idLibreta, Guid idUsuario)
        {
            return new ContenedorNota[]
            {
                new ContenedorNota()
                {
                    IdContenedorNota = idContenedorNota1,
                    Anclada = false,
                    IdNota = Guid.NewGuid(),
                    TipoNotaContenida = ContenedorNota.TipoNota.RichEdit,
                },
                new ContenedorNota()
                {
                    IdContenedorNota = idContenedorNota2,
                    Anclada = false,
                    IdNota = Guid.NewGuid(),
                    TipoNotaContenida = ContenedorNota.TipoNota.RichEdit,
                },
                new ContenedorNota()
                {
                    IdContenedorNota = idContenedorNota3,
                    Anclada = false,
                    IdNota = Guid.NewGuid(),
                    TipoNotaContenida = ContenedorNota.TipoNota.RichEdit,
                },
                new ContenedorNota()
                {
                    IdContenedorNota = idContenedorNota4,
                    Anclada = false,
                    IdNota = Guid.NewGuid(),
                    TipoNotaContenida = ContenedorNota.TipoNota.RichEdit,
                },
                new ContenedorNota()
                {
                    IdContenedorNota = idContenedorNota5,
                    Anclada = false,
                    IdNota = Guid.NewGuid(),
                    TipoNotaContenida = ContenedorNota.TipoNota.RichEdit,
                },
            };
        }

        /// <summary>
        /// El método bueno sería el genérico, este sólo es para pruebas.
        /// </summary>
        /// <param name="idNota">Identificador nota.</param>
        /// <returns>Nota.</returns>
        public static NotaRichEdit GetNotaRichEdit(Guid idNota)
        {
            return new NotaRichEdit
            {
                IdNota = idNota,
                Contenido = "hola",
            };
        }

        /// <summary>
        /// Recupera una nota.
        /// </summary>
        /// <typeparam name="T">Tipo de nota a recuperar</typeparam>
        /// <param name="idNota"></param>
        /// <returns></returns>
        //public static T GetNota<T>(Guid idNota)
        //    where T : INota
        //{
        //    return n 
        //    {

        //    };
        //}


    }
}
