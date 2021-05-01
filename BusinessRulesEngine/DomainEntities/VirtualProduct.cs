using BusinessRulesEngine.Interfaces.DomainEntities;
using System;

namespace BusinessRulesEngine.DomainEntities
{
    class VirtualProduct : Product, IVirtualProduct
    {
        public void SendEmail()
        {
            throw new NotImplementedException();
        }
    }
}
