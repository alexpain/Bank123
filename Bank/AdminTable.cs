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
    
    public partial class AdminTable
    {
        public int id { get; set; }
        public string loginAdmin { get; set; }
        public string passwordAdmin { get; set; }
        public int accessStatusId { get; set; }
    
        public virtual AccessStatus AccessStatus { get; set; }
    }
}