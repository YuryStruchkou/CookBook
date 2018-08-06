using System;
using System.Collections.Generic;
using System.Xml.Linq;
using DataLayer.DataConstants;
using DataLayer.Models;

namespace DataLayer.ConsoleDataAccess
{
    public class XmlDataAccessUsers : XmlDataAccess<User>
    {
        public XmlDataAccessUsers() : base(XMLConstants.DEFAULT_USERS_XML, XMLConstants.USERS)
        {
        }

        protected override XElement ConvertToXml(User item)
        {
            return new XElement("user",
                new XAttribute("id", item.Id),
                new XAttribute("username", item.Username),
                new XAttribute("email", item.Email),
                new XAttribute("passwordHash", item.PasswordHash),
                new XAttribute("creationDate", item.CreationDate.ToString()),
                new XAttribute("role", item.Role.RoleName),
                new XElement("profile",
                    new XAttribute("avatar", item.UserProfile.Avatar),
                    new XAttribute("muted", item.UserProfile.IsMuted.ToString()),
                    new XAttribute("status", item.UserProfile.UserStatus.StatusName)));
        }

        protected override User CreateFromXml(XElement element)
        {
            var profileElement = element.Element("profile");
            var user = new User
            {
                Id = element.Attribute("id").Value,
                Username = element.Attribute("username").Value,
                Email = element.Attribute("email").Value,
                PasswordHash = element.Attribute("passwordHash").Value,
                CreationDate = DateTime.Parse(element.Attribute("creationDate").Value),
                Role = new Role { RoleName = element.Attribute("role").Value },
                UserProfile = new UserProfile
                {
                    UserId = element.Attribute("id").Value,
                    Avatar = profileElement.Attribute("avatar").Value,
                    IsMuted = Boolean.Parse(profileElement.Attribute("muted").Value),
                    UserStatus = new UserStatus { StatusName = profileElement.Attribute("status").Value }
                }
            };
            return user;
        }
    }
}
