using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyMembership.BlazorServer.Models
{
    public class Party
    {
        public int PartyId { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime Established { get; set; }

        public ICollection<Address> Addresses { get; set; }

        public ICollection<Candidate> Candidates { get; set; }
    }
}
