namespace CapaDeDatos.Modelo_de_datos
{
    using System;

    /// <summary>
    /// Libreta para notas.
    /// </summary>
    public class Libreta
    {
        /// <summary>
        /// Gets or sets identificador de libreta.
        /// </summary>
        public Guid IdLibreta { get; set; }

        /// <summary>
        /// Gets or sets identificador de usuario.
        /// </summary>
        public Guid IdUsuario { get; set; }

        /// <summary>
        /// Gets or sets identificador de libreta padre.
        /// </summary>
        public Guid IdLibretaPadre { get; set; }

        /// <summary>
        /// Gets or sets nombre de la libreta.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Gets or sets fecha de última modificación.
        /// </summary>
        public DateTime FechaDeModificacion { get; set; }

        /// <summary>
        /// Gets or sets fecha de creación.
        /// </summary>
        public DateTime FechaDeCreacion { get; set; }
    }
}
