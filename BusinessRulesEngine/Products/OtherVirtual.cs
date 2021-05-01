using BusinessRulesEngine.DomainEntities;

namespace BusinessRulesEngine.Products
{
    public class OtherVirtual : VirtualProduct
    {
        public OtherVirtual(string productName)
        {
            ItemName = productName;

            ProcessingOperations.Add($"Did nothing for {ItemName}.");
        }
    }
}
