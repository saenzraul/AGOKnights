//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AGOKnights
{
    using System;
    using System.Collections.Generic;
    
    public partial class Address
    {
        public Address()
        {
            this.People = new HashSet<Person>();
            this.Events = new HashSet<Event>();
        }
    
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Alias { get; set; }
    
        public virtual ICollection<Person> People { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}
