//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TiecCuoi.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CTHOPDONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CTHOPDONG()
        {
            this.HOPDONGs = new HashSet<HOPDONG>();
            this.DICHVUs = new HashSet<DICHVU>();
            this.MENUs = new HashSet<MENU>();
        }
    
        public string MACTHD { get; set; }
        public string TENCODAU { get; set; }
        public string TENCHURE { get; set; }
        public string MASANH { get; set; }
        public Nullable<int> CA { get; set; }
        public Nullable<decimal> SOBAN { get; set; }
        public Nullable<System.DateTime> NGAYTC { get; set; }
        public Nullable<int> SOTIENCOC { get; set; }
        public Nullable<int> TONGTIEN { get; set; }
    
        public virtual SANH SANH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPDONG> HOPDONGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DICHVU> DICHVUs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MENU> MENUs { get; set; }
    }
}