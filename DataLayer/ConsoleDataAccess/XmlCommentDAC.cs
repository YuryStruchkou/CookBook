using System.Collections.Generic;
using DomainLayer.Models;
using DomainLayer.Models.Entities;

namespace DataLayer.ConsoleDataAccess
{
    public class XmlCommentDAC : BaseXmlDAC<Comment>
    {
        protected override List<Comment> XmlList => XmlContext.Comments;
    }
}
