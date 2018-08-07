using System.Collections.Generic;
using DomainLayer.Models;

namespace DataLayer.ConsoleDataAccess
{
    public class XmlDataAccessTags : BaseXmlDataAccess<Tag>
    {
        protected override List<Tag> XmlList => XmlContext.Tags;
    }
}
