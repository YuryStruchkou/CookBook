using System;
using System.Xml.Linq;
using DataLayer.Models;

namespace DataLayer.ConsoleDataAccess
{
    public class XmlDataAccessUsers : XmlDataAccess<User>
    {
        public XmlDataAccessUsers(string xmlFileLocation, string rootElementName) : base(xmlFileLocation, rootElementName)
        {
        }

        public override void Add(User item)
        {
            var xdoc = XDocument.Load(_xmlFileLocation);
            var rootElement = xdoc.Element(_rootElementName);
            rootElement.Add(new XElement("user",
                new XAttribute("id", item.Id),
                new XAttribute("username", item.Username),
                new XAttribute("email", item.Email),
                new XAttribute("passwordHash", item.PasswordHash),
                new XAttribute("creationDate", item.CreationDate.ToString()),
                new XAttribute("role", item.Role.RoleName),
                new XElement("profile", 
                    new XAttribute("avatar", item.UserProfile.Avatar),
                    new XAttribute("muted", item.UserProfile.IsMuted.ToString()),
                    new XAttribute("status", item.UserProfile.UserStatus.StatusName))));
            xdoc.Save(_xmlFileLocation);
        }

        public override void Delete(Func<User, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public override User Get(Func<User, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public override void Update(User item, Func<User, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
