//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bank
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sale
    {
        public int id { get; set; }
        public int discount { get; set; }
        public int statusId { get; set; }
        public int servicesId { get; set; }
    
        public virtual StatusClient StatusClient { get; set; }
        public virtual TypeServices TypeServices { get; set; }
    }
}
