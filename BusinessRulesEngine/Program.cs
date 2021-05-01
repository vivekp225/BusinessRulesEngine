using BusinessRulesEngine.DomainEntities;
using BusinessRulesEngine.Service;
using System;

namespace BusinessRulesEngine
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your product type (Book/Membership/Video/Other):");
            string productType = Console.ReadLine().Trim();
            Console.WriteLine("\nEnter your product name:");
            string productName = Console.ReadLine().Trim();

            Product processedProduct = OrderProcessingService.ProcessOrder(ServiceHelper.GetProductType(productType), productName);
            Console.WriteLine($"\n\n\nProduct Name:\n{processedProduct.ItemName}");
            Console.WriteLine("\nOperations Performed:");

            foreach (string processedOperation in processedProduct.ProcessingOperations)
            {
                Console.WriteLine($"{processedOperation}");
            }

            Console.WriteLine("\n\n\n\n");
        }
    }
}
