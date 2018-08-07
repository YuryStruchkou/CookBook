using System;
using System.Collections.Generic;
using DataLayer.ConsoleDataAccess;
using DomainLayer.Models;

namespace BusinessLogicLayer.VoteManagement
{
    public class VoteManager
    {
        private readonly IXmlDataAccess<Vote> _xmlDataAccessVotes;

        public VoteManager()
        {
            _xmlDataAccessVotes = new XmlDataAccessVotes();
        }

        public VoteManager(IXmlDataAccess<Vote> xmlDataAccessVotes)
        {
            _xmlDataAccessVotes = xmlDataAccessVotes;
        }

        public void AddVote(Vote item)
        {
            _xmlDataAccessVotes.Add(item);
        }

        public void UpdateVote(Vote item, Func<Vote, bool> predicate)
        {
            _xmlDataAccessVotes.Update(item, predicate);
        }

        public void DeleteVote(Func<Vote, bool> predicate)
        {
            _xmlDataAccessVotes.Delete(predicate);
        }

        public List<Vote> Get(Func<Vote, bool> predicate)
        {
            return _xmlDataAccessVotes.Get(predicate);
        }

        public List<Vote> GetAll()
        {
            return _xmlDataAccessVotes.GetAll();
        }

        public int GetVoteCount()
        {
            return _xmlDataAccessVotes.GetAll().Count;
        }
    }
}
