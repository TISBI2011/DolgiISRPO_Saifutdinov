//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DolgiISRPO2Practica.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> DatePokaza { get; set; }
        public Nullable<int> JanorId { get; set; }
        public int PuskinCard { get; set; }
    
        public virtual Janor Janor { get; set; }
        public virtual PuskinCard PuskinCard1 { get; set; }
    }
}