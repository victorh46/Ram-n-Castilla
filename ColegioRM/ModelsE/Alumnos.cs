//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ColegioRM.ModelsE
{
    using System;
    using System.Collections.Generic;
    
    public partial class Alumnos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Alumnos()
        {
            this.Cursos = new HashSet<Cursos>();
            this.Cursos1 = new HashSet<Cursos>();
        }
    
        public int idAlumno { get; set; }
        public string codAlumno { get; set; }
        public string apPaterno { get; set; }
        public string apMaterno { get; set; }
        public string nombres { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public System.DateTime dateNac { get; set; }
        public string direccion { get; set; }
        public string sexo { get; set; }
        public int idApoderado { get; set; }
    
        public virtual Apoderado Apoderado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cursos> Cursos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cursos> Cursos1 { get; set; }
    }
}
