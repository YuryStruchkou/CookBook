using System.Collections.Generic;
using DomainLayer.Models;

namespace DataLayer.ConsoleDataAccess
{
    public class XmlDataAccessComments : BaseXmlDataAccess<Comment>
    {
        protected override List<Comment> XmlList => XmlContext.Comments;
    }
}
