using System.Collections.Generic;
using DomainLayer.Models;

namespace DataLayer.ConsoleDataAccess
{
    public class XmlDataAccessVotes : BaseXmlDataAccess<Vote>
    {
        protected override List<Vote> XmlList => XmlContext.Votes;
    }
}
