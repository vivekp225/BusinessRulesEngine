using BusinessRulesEngine.Interfaces.DomainEntities;
using System.Collections.Generic;

namespace BusinessRulesEngine.DomainEntities
{
    public abstract class Product : IProduct
    {
        public string ItemName { get; set; }
        public List<string> ProcessingOperations { get; set; } = new List<string>();
    }
}
