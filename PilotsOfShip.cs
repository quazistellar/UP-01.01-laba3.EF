//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UP_laba3_EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class PilotsOfShip
    {
        public int ID_Pilot { get; set; }
        public string NamePilot { get; set; }
        public string SurnamePilot { get; set; }
        public int AgePilot { get; set; }
        public Nullable<int> SpaceShip_ID { get; set; }
    
        public virtual SpaceShips SpaceShips { get; set; }
    }
}
