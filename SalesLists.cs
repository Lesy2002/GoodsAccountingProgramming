//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GoodsAccountingPractice1
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesLists
    {
        public int IdSalesLists { get; set; }
        public int IdSales { get; set; }
        public int IdProduct { get; set; }
        public string Amount { get; set; }
        public Nullable<decimal> SumProduct { get; set; }
    
        public virtual GoodsDirectory GoodsDirectory { get; set; }
        public virtual Sales Sales { get; set; }
    }
}
