//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KaracsonyfaRendeles
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rendeles
    {
        public int rendeles_sk { get; set; }
        public int fenyo_fk { get; set; }
        public int ugyfel_fk { get; set; }
        public System.DateTime datum { get; set; }
        public string fizmod { get; set; }
    
        public virtual Fenyo Fenyo { get; set; }
        public virtual Ugyfel Ugyfel { get; set; }
    }
}
