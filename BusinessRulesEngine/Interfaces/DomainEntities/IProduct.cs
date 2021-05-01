using System.Collections.Generic;

namespace BusinessRulesEngine.Interfaces.DomainEntities
{
    interface IProduct
    {
        string ItemName { get; set; }
        List<string> ProcessingOperations { get; set; }
    }
}
