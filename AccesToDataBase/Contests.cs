//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesToDataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contests
    {
        public Contests()
        {
            this.ContestToQuestion = new HashSet<ContestToQuestion>();
            this.ContestToTeam = new HashSet<ContestToTeam>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
    
        public virtual ICollection<ContestToQuestion> ContestToQuestion { get; set; }
        public virtual ICollection<ContestToTeam> ContestToTeam { get; set; }
    }
}