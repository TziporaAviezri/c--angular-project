//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class details
    {
        public short detailsId { get; set; }
        public Nullable<short> shopingId { get; set; }
        public Nullable<short> productId { get; set; }
        public Nullable<short> amount { get; set; }
    
        public virtual products products { get; set; }
        public virtual shoping shoping { get; set; }
    }
}