using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PartyMembership.BlazorServer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PartyMembership.BlazorServer.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Party> Parties { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Gender> Genders { get; set; }
    }
}
