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
    
    public partial class ContestToQuestion
    {
        public int ID { get; set; }
        public int ContestID { get; set; }
        public int QuestionID { get; set; }
    
        public virtual Base Base { get; set; }
        public virtual Contests Contests { get; set; }
    }
}
