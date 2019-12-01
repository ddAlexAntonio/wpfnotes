namespace CapaDeDatos.Modelo_de_datos
{
    using System;

    /// <summary>
    /// Interfaz genérica para las notas.
    /// </summary>
    public interface INota
    {
        /// <summary>
        /// Gets or sets identificador de nota.
        /// </summary>
        Guid IdNota { get; set; }

        /// <summary>
        /// Gets or sets contenido de la nota.
        /// </summary>
        string Contenido { get; set; }
    }
}
