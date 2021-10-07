using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PartyMembership.BlazorServer.Data;
using PartyMembership.BlazorServer.Models;

namespace PartyMembership.BlazorServer.Services
{
    public class CandidateService
    {
        private readonly ApplicationDbContext _appDbContext;

        public CandidateService(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<Candidate> GetAllCandidates()
        {
            var candidates = _appDbContext.Candidates
                .Include(x=>x.Gender)
                .Include(x=>x.Party)
                .ToList();
            return candidates;
        }

        public Candidate GetCandidate(int Id)
        {
            var candidate = _appDbContext.Candidates
                .Include(x => x.Party)
                .FirstOrDefault(x => x.CandidateId == Id);

            return candidate;
        }

        public void AddCandidate(Candidate candidate)
        {
            _appDbContext.Candidates.Add(candidate);
            _appDbContext.SaveChanges();
        }

        public void UpdateCandidate(Candidate candidate)
        {
            _appDbContext.Candidates.Update(candidate);
            _appDbContext.SaveChanges();
        }

        public void DeleteCandidate(Candidate candidate)
        {
            _appDbContext.Candidates.Remove(candidate);
            _appDbContext.SaveChanges();
        }

        public List<Gender> GetAllGenders()
        {
            var genders = _appDbContext.Genders.ToList();

            return genders;
        }

    }
}
