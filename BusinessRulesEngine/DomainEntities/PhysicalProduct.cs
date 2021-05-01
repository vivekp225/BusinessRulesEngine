using BusinessRulesEngine.Interfaces.DomainEntities;

namespace BusinessRulesEngine.DomainEntities
{
    public abstract class PhysicalProduct : Product, IPhysicalProduct
    {
        public void GeneratePackingSlip()
        {
            ProcessingOperations.Add("Packing slip for shipping generated.");
        }

        public void GenerateComissionPayment()
        {
            ProcessingOperations.Add("Comssion payment to the agent generated.");
        }
    }
}
