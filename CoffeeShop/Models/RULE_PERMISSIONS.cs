//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoffeeShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RULE_PERMISSIONS
    {
        public int KEY_PERMISSTION { get; set; }
        public System.Guid KEY_RULE { get; set; }
        public Nullable<bool> ENABLE_VIEW { get; set; }
        public Nullable<bool> ENABLE_ADD { get; set; }
        public Nullable<bool> ENABLE_MODIFY { get; set; }
        public Nullable<bool> ENABLE_DELETE { get; set; }
        public Nullable<bool> ENABLE_EXECUTE { get; set; }
        public string AVALABLE_ACTION { get; set; }
    }
}