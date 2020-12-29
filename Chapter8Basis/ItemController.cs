using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudInterfaces;
using Model;
using System;

namespace Chapter8Basis
{
    class ItemController
    {
        private readonly IRead<Item> reader;
        private readonly ISave<Item> saver;
        private readonly IDelete<Item> deleter;

        public ItemController(IRead<Item> itemReader, ISave<Item> itemSaver, IDelete<Item> itemDeleter)
        {
            reader = itemReader;
            saver = itemSaver;
            deleter = itemDeleter;
        }

        public void CreateItem(Item item)
        {
            saver.Save(item);
            Console.WriteLine("CreateOrder: Saving order of " + item.product);
        }

        public Item GetSingleItem(Guid identity)
        {
            Item itm = reader.ReadOne(identity);
            Console.WriteLine("GetSingleOrder: Saving order of " + itm.product);
            return itm;
        }

        public void UpdateItem(Item item)
        {
            saver.Save(item);
            Console.WriteLine("UpdateOrder: Saving order of " + item.product);
        }

        public void DeleteItem(Item item)
        {
            deleter.Delete(item);
            Console.WriteLine("DeleteOrder: Delete order of " + item.product);
        }
    }
}

    
