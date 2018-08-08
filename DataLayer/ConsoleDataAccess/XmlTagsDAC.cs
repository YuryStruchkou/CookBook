using System.Collections.Generic;
using DomainLayer.Models;
using DomainLayer.Models.Entities;

namespace DataLayer.ConsoleDataAccess
{
    public class XmlTagsDAC : BaseXmlDAC<Tag>
    {
        protected override List<Tag> XmlList => XmlContext.Tags;
    }
}
