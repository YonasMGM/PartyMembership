
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PartyMembership.BlazorServer.Data;
using PartyMembership.BlazorServer.Models;

namespace PartyMembership.BlazorServer.Services
{
    public class PartyService
    {
        private readonly ApplicationDbContext _appDbContext;

        public PartyService(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<Party> GetAllParties()
        {
            var parties = _appDbContext.Parties.ToList();

            return parties;
        }

        public Party GetParty(int Id)
        {
            var party = _appDbContext.Parties
                .Include(x => x.Addresses)
                .FirstOrDefault(x => x.PartyId == Id);
                
            return party;
        }

        public void AddParty(Party party)
        {
            _appDbContext.Parties.Add(party);
            _appDbContext.SaveChanges();
        }

        public void UpdateParty(Party party)
        {
            _appDbContext.Parties.Update(party);
            _appDbContext.SaveChanges();
        }

        public void DeleteParty(Party party)
        {
            _appDbContext.Parties.Remove(party);
            _appDbContext.SaveChanges();
        }


        public void AddAddress(Address address)
        {
            _appDbContext.Addresses.Add(address);
            _appDbContext.SaveChanges();
        }

    }
}
