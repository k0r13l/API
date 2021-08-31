//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PACIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PACIENTE()
        {
            this.ALERGIA_PACIENTE = new HashSet<ALERGIA_PACIENTE>();
            this.CITA = new HashSet<CITA>();
            this.PACIENTE_TELEFONO = new HashSet<PACIENTE_TELEFONO>();
            this.VACUNA_PACIENTE = new HashSet<VACUNA_PACIENTE>();
        }
    
        public string CEDULA { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDOS { get; set; }
        public System.DateTime FECHA_NAC { get; set; }
        public string TIPO_SANGRE { get; set; }
        public string ESTADO_CIVIL { get; set; }
        public string PROVINCIA { get; set; }
        public string CANTON { get; set; }
        public string DISTRITO { get; set; }
        public string OTRAS_SEÑAS { get; set; }
        public string CONTRASENNA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALERGIA_PACIENTE> ALERGIA_PACIENTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CITA> CITA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PACIENTE_TELEFONO> PACIENTE_TELEFONO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VACUNA_PACIENTE> VACUNA_PACIENTE { get; set; }
    }
}