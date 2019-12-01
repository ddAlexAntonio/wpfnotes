namespace CapaDeDatos.Modelo_de_datos
{
    using System;

    /// <summary>
    /// Contedor de nota.
    /// </summary>
    public class ContenedorNota
    {
        /// <summary>
        /// Enumerado para el tipo de nota.
        /// </summary>
        public enum TipoNota
        {
            /// <summary>
            /// Tipo rich edit.
            /// </summary>
            RichEdit,

            /// <summary>
            /// Tipo tarea.
            /// </summary>
            Tarea,

            /// <summary>
            /// Tipo tarea agendable.
            /// </summary>
            TareaAgendada,
        }

        /// <summary>
        /// Gets or sets Identificador del contedor.
        /// </summary>
        public Guid IdContenedorNota { get; set; }

        /// <summary>
        /// Gets or sets Identificador de la libreta.
        /// </summary>
        public Guid IdLibreta { get; set; }

        /// <summary>
        /// Gets or sets Identificador del usuario.
        /// </summary>
        public Guid IdUsuario { get; set; }

        /// <summary>
        /// Gets or sets nombre de la libreta.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Gets or sets tipo de la nota.
        /// </summary>
        public TipoNota TipoNotaContenida { get; set; }

        /// <summary>
        /// Gets or sets Identificador de la nota asociada.
        /// </summary>
        public Guid IdNota { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether es una nota anclada. (stylecop me hace incluir el texto en inglés inicial)
        /// </summary>
        public bool Anclada { get; set; }

        /// <summary>
        /// Gets or sets fecha de última notificación de la nota.
        /// </summary>
        public DateTime FechaDeModificacion { get; set; }

        /// <summary>
        /// Gets or sets Fecja de creación de la nota.
        /// </summary>
        public DateTime FechaDeCreacion { get; set; }
    }
}
