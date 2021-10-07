using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyMembership.BlazorServer.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public String Postcode { get; set; }
        [Required]
        public int PartyId { get; set; }
        public Party Party { get; set; } //navigation property

    }
}
