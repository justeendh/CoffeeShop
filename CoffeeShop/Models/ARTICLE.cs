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
    
    public partial class ARTICLE
    {
        public int KEY_ARTICLE { get; set; }
        public string NAME_ARTICLE { get; set; }
        public string DESCRIPTION_ARTICLE { get; set; }
        public string CONTENT_ARTICLE { get; set; }
        public string TAG_ARTICLE { get; set; }
        public string IMAGE_ARTICLE { get; set; }
        public Nullable<bool> IS_SHOW_ARTICLE { get; set; }
        public Nullable<bool> IS_HIGHLIGHT_ARTICLE { get; set; }
        public Nullable<int> ORDER_INDEX { get; set; }
        public Nullable<System.DateTime> DATE_CREATED_ARTICLE { get; set; }
        public Nullable<System.DateTime> DATE_UPDATE_ARTICLE { get; set; }
        public Nullable<int> KEY_GROUP_ARTICLE { get; set; }
        public string MODULE_ARTICLE { get; set; }
        public string META_TITLE { get; set; }
        public string META_KEYWORDS { get; set; }
        public string META_DESCRIPTION { get; set; }
    }
}
