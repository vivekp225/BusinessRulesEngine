using BusinessRulesEngine.DomainEntities;
using BusinessRulesEngine.Enums;
using BusinessRulesEngine.Products;
using System;

namespace BusinessRulesEngine.Service
{
    public class OrderProcessingService
    {
        public static Product ProcessOrder(ProductType productType, string productName)
        {
            Product product;

            switch (productType)
            {
                case ProductType.Book:
                    {
                        product = new Book(productName);

                        break;
                    }
                case ProductType.Membership:
                    {
                        Console.WriteLine("\nEnter your transaction type (Activation/Upgrade):");
                        string transaction = Console.ReadLine().Trim();
                        product = new Membership(productName, transaction);

                        break;
                    }
                case ProductType.Video:
                    {
                        product = new Video(productName);

                        break;
                    }
                case ProductType.Other:
                default:
                    {
                        product = new OtherVirtual(productName);

                        break;
                    }
            }

            return product;
        }
    }
}
