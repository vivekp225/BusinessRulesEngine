using BusinessRulesEngine.DomainEntities;
using BusinessRulesEngine.Interfaces.Products;

namespace BusinessRulesEngine.Products
{
    public class Book : PhysicalProduct, IBook
    {
        public Book(string bookName)
        {
            ItemName = bookName;

            GeneratePackingSlip();
            DuplicatePackingSlip();
            GenerateComissionPayment();
        }

        public void DuplicatePackingSlip()
        {
            ProcessingOperations.Add("Duplicate packing slip for royalty department created.");
        }
    }
}
