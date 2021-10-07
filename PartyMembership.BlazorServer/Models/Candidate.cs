using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyMembership.BlazorServer.Models
{
    public class Candidate
    {
        
        public int CandidateId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string CandidateNumber { get; set; }
        [Required]
        public int GenderId { get; set; }
        public Gender Gender { get; set; } //navigation property
        [Required]
        public int PartyId { get; set; }
        public Party Party { get; set; } //navigation property
    }
}
