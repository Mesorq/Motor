//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PraktikaMotor
{
    using System;
    using System.Collections.Generic;
    
    public partial class TradeInSet
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string SerNumber { get; set; }
        public string PrePrice { get; set; }
    
        public virtual ClientsSet ClientsSet { get; set; }
    }
}
