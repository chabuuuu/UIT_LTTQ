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
    
    public partial class NHANVIENSUDUNGTAISAN
    {
        public string MANHANVIEN { get; set; }
        public string MATAISAN { get; set; }
        public Nullable<System.DateTime> NGAYSUDUNG { get; set; }
        public Nullable<System.DateTime> NGAYKETTHUC { get; set; }
        public string MUCDICH { get; set; }
    
        public virtual NHANVIEN NHANVIEN { get; set; }
        public virtual TAISANCONG TAISANCONG { get; set; }
    }
}