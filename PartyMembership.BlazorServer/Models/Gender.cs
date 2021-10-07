using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyMembership.BlazorServer.Models
{
    public class Gender
    {
        public int GenderId { get; set; }
        public string Label { get; set; }
        public ICollection<Candidate> Candidates { get; set; }
    }
}
