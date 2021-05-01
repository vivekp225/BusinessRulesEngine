using BusinessRulesEngine.Enums;
using System;

namespace BusinessRulesEngine.Service
{
    public class ServiceHelper
    {
        public static ProductType GetProductType(string productType)
        {
            ProductType type;

            try
            {
                type = (ProductType)Enum.Parse(typeof(ProductType), productType, true);
            }
            catch (Exception)
            {
                type = ProductType.Other;
            }

            return type;
        }
    }
}
