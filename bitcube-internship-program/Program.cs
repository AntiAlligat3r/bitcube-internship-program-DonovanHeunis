using System;

namespace bitcube_internship_program
{
    class Program
    {
        interface IOnlineStore
        {
            void AddProductsToInventory(ProductsPurchaseOrder purchaseOrder);

            ProductsSoldResult SellProductsFromInventory(ProductsSellOrder itemsSoldOrder);

            InventoryItemSummery GetInventoryItemSummary(ProductType stockType);
            InventorySummery GetInventorySummary();
        }
        


        class Products : IOnlineStore
        {
            public void AddProductsToInventory(ProductsPurchaseOrder purchaseOrder)
            {

            }
            public ProductsSoldResult SellProductsFromInventory(ProductsSellOrder itemsSoldOrder)
            {
                return;
            }
            public InventoryItemSummery GetInventoryItemSummary(ProductType stockType)
            {
                return;
            }
            public InventorySummery GetInventorySummary()
            {
                return;
            }
        }

        static void Main(string[] args)
        {
            Products myProducts = new Products();
            Console.WriteLine("Hello World!");
        }
    }

    public class ProductType
    {
    }

    public class InventorySummery
    {
    }

    public class InventoryItemSummery
    {
    }

    public class ProductsSoldResult
    {
    }

    public class ProductsSellOrder
    {
    }

    public class ProductsPurchaseOrder
    {
    }
}
