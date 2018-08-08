using System.Collections.Generic;
using DomainLayer.Models;

namespace DataLayer.ConsoleDataAccess
{
    public class XmlVotesDAC : BaseXmlDAC<Vote>
    {
        protected override List<Vote> XmlList => XmlContext.Votes;
    }
}
