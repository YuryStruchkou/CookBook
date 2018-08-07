using System.Collections.Generic;
using DomainLayer.Models;

namespace DataLayer.ConsoleDataAccess
{
    public class XmlDataAccessVotes : XmlDataAccess<Vote>
    {
        protected override List<Vote> XmlList => XmlContext.Votes;
    }
}
