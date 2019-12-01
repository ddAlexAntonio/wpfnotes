namespace CapaDeDatos.Modelo_de_datos
{
    using System;

    /// <summary>
    /// Nota de tipo lista de tareas para compra.
    /// </summary>
    public class NotaTareaCompra : INota
    {
        /// <summary>
        /// Gets or sets Identificador de la nota.
        /// </summary>
        public Guid IdNota { get; set; }

        /// <summary>
        /// Gets or sets Contenido de la nota.
        /// </summary>
        public string Contenido { get; set; }
    }
}
