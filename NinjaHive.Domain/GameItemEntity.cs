//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NinjaHive.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class GameItemEntity
    {
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public bool Craftable { get; set; }
        public bool IsUpgrader { get; set; }
        public bool IsCrafter { get; set; }
        public bool IsQuestItem { get; set; }
        public int Value { get; set; }
    }
}
