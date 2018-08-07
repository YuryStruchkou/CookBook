using System.Collections.Generic;
using DomainLayer.Models;

namespace DataLayer.ConsoleDataAccess
{
    public class XmlDataAccessUsers : XmlDataAccess<User>
    {
        protected override List<User> XmlList => XmlContext.Users;
    }
}
