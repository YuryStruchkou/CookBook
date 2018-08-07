﻿using System.Collections.Generic;
using DomainLayer.Models;

namespace DataLayer.ConsoleDataAccess
{
    public class XmlDataAccessRecipes : BaseXmlDataAccess<Recipe>
    {
        protected override List<Recipe> XmlList => XmlContext.Recipes;
    }
}
