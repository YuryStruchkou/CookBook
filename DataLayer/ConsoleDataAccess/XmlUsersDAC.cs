using System.Collections.Generic;
using DomainLayer.Models;
using DomainLayer.Models.Entities;

namespace DataLayer.ConsoleDataAccess
{
    public class XmlUsersDAC : BaseXmlDAC<User>
    {
        protected override List<User> XmlList => XmlContext.Users;
    }
}
