using BusinessRulesEngine.Interfaces.DomainEntities;
using System;

namespace BusinessRulesEngine.DomainEntities
{
    class PhysicalProduct : Product, IPhysicalProduct
    {
        public void GeneratePackingSlip()
        {
            throw new NotImplementedException();
        }
    }
}
