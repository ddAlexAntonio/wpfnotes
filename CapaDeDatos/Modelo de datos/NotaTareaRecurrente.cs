namespace CapaDeDatos.Modelo_de_datos
{
    using System;

    /// <summary>
    /// Nota de tipo tarea recurrente.
    /// </summary>
    public class NotaTareaRecurrente : INota
    {
        /// <summary>
        /// Enumerado para indicar el tipo de recurrencia.
        /// </summary>
        public enum TipoRepeticionEnum
        {
            /// <summary>
            /// Repitición diaria.
            /// </summary>
            Diaria,

            /// <summary>
            /// Repetición semanal.
            /// </summary>
            Semanal,

            /// <summary>
            /// Repetición mensual.
            /// </summary>
            Mensual,

            /// <summary>
            /// Repetición anual.
            /// </summary>
            Anual,
        }

        /// <summary>
        /// Gets or sets Identificador de la nota.
        /// </summary>
        public Guid IdNota { get; set; }

        /// <summary>
        /// Gets or sets Contenido de la nota.
        /// </summary>
        public string Contenido { get; set; }

        /// <summary>
        /// Gets or sets fecha de inicio recurrencia.
        /// </summary>
        public DateTime FechaInicio { get; set; }

        /// <summary>
        /// Gets or sets fecha de fin recurrencia.
        /// </summary>
        public DateTime FechaFin { get; set; }

        /// <summary>
        /// Gets or sets Hora de aviso de la tarea.
        /// </summary>
        public DateTime HoraAviso { get; set; }

        /// <summary>
        /// Gets or sets Contenido de la nota.
        /// </summary>
        public TipoRepeticionEnum TipoRepeticion { get; set; }
    }
}
