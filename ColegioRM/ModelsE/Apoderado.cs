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
    
    public partial class Apoderado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Apoderado()
        {
            this.Alumnos = new HashSet<Alumnos>();
        }
    
        public int idApoderado { get; set; }
        public string codApoderado { get; set; }
        public string apPaterno { get; set; }
        public string apMaterno { get; set; }
        public string nombres { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public System.DateTime dateNac { get; set; }
        public string direccion { get; set; }
        public string sexo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Alumnos> Alumnos { get; set; }
    }
}
