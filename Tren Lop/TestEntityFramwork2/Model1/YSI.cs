//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestEntityFramwork2.Model1
{
    using System;
    using System.Collections.Generic;
    
    public partial class YSI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public YSI()
        {
            this.DIEUTRIs = new HashSet<DIEUTRI>();
            this.KHOAs = new HashSet<KHOA>();
            this.LICHKHAMs = new HashSet<LICHKHAM>();
            this.TAIKHOANTRUONGKHOAs = new HashSet<TAIKHOANTRUONGKHOA>();
            this.TUCTRUCs = new HashSet<TUCTRUC>();
            this.YSI1 = new HashSet<YSI>();
        }
    
        public string MAYSI { get; set; }
        public string MAKHOA { get; set; }
        public string TENYSI { get; set; }
        public Nullable<System.DateTime> NGAYVAOLAM { get; set; }
        public string CHUCVU { get; set; }
        public Nullable<decimal> HESOLUONG { get; set; }
        public string LOAIYSI { get; set; }
        public string CHIHUY { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIEUTRI> DIEUTRIs { get; set; }
        public virtual KHOA KHOA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHOA> KHOAs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LICHKHAM> LICHKHAMs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAIKHOANTRUONGKHOA> TAIKHOANTRUONGKHOAs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TUCTRUC> TUCTRUCs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YSI> YSI1 { get; set; }
        public virtual YSI YSI2 { get; set; }
    }
}