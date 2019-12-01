namespace CapaDeDatos.Modelo_de_datos
{
    using System;

    /// <summary>
    /// Clase usuario.
    /// </summary>
    public class Usuario
    {
        /// <summary>
        /// Gets or sets Identificador de usuario.
        /// </summary>
        public Guid IdUsuario { get; set; }

        /// <summary>
        /// Gets or sets Nombre.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Gets or sets Primer apellido.
        /// </summary>
        public string Apellido1 { get; set; }

        /// <summary>
        /// Gets or sets Segundo apellido.
        /// </summary>
        public string Apellido2 { get; set; }

        /// <summary>
        /// Gets or sets Correo eletrónico.
        /// </summary>
        public string CorreoElectronico { get; set; }

        /// <summary>
        /// Gets or sets Nombre de usuario para login.
        /// </summary>
        public string NombreUsuario { get; set; }

        /// <summary>
        /// Gets or sets Password para login.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets Fecha de nacimiento.
        /// </summary>
        public DateTime FechaDeNacimiento { get; set; }

        /// <summary>
        /// Gets or sets Fecha de creación.
        /// </summary>
        public DateTime FechaDeCreacion { get; set; }

        /// <summary>
        /// Gets or sets Fecha de última modificación.
        /// </summary>
        public DateTime FechaDeModificacion { get; set; }
    }
}
