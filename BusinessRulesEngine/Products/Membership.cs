using BusinessRulesEngine.DomainEntities;
using BusinessRulesEngine.Interfaces.Products;

namespace BusinessRulesEngine.Products
{
    class Membership : VirtualProduct, IMembership
    {
        public Membership(string membershipType, string membershipTransaction)
        {
            ItemName = membershipType;
            bool isUpgrade = membershipTransaction.Trim().ToLower().Equals("upgrade");

            ActivateOrUpgradeMembership(isUpgrade);
            SendEmail(isUpgrade);
        }

        public void ActivateOrUpgradeMembership(bool isUpgrade)
        {
            ProcessingOperations.Add(isUpgrade ?
                $"Upgraded to {ItemName} membership." :
                $"Activated {ItemName} membership.");
        }

        public void SendEmail(bool isUpgrade)
        {
            ProcessingOperations.Add(isUpgrade ?
                $"Email to owner informing about membership upgrade sent." :
                $"Email to owner informing about membership activation sent.");
        }
    }
}
