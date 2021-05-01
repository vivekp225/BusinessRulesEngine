
namespace BusinessRulesEngine.Interfaces.Products
{
    interface IMembership
    {
        void ActivateOrUpgradeMembership(bool isUpgrade);
        void SendEmail(bool isUpgrade);
    }
}
