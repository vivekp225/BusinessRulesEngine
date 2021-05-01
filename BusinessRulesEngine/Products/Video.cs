using BusinessRulesEngine.DomainEntities;
using BusinessRulesEngine.Interfaces.Products;

namespace BusinessRulesEngine.Products
{
    public class Video : PhysicalProduct, IVideo
    {
        public Video(string videoName)
        {
            ItemName = videoName;

            GeneratePackingSlip();
            AddFreeVideo();
            GenerateComissionPayment();
        }

        public void AddFreeVideo()
        {
            if (ItemName.ToLower().Equals("learning to ski"))
            {
                ProcessingOperations.Add("Added a free 'Free Aid' video to the packing slip.");
            }
        }
    }
}
