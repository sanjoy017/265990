using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day8.Repository;
using System.Data;
using System.Data.SqlClient;
using Day8.Model;

namespace Day8.BLL
{
    public class ItemManager
    {
        ItemRepository _itemRepository = new ItemRepository();
        

        public bool Connection(Item item)
        {
            return _itemRepository.Connection(item);
        }
        public bool IsItemExists(string item)
        {
            return _itemRepository.IsItemExists(item);
        }
        public DataTable ShowItemInformation()
        {
            return _itemRepository.ShowItemInformation();
        }
        public bool Delete(int id)
        {
            return _itemRepository.Delete(id);
        }
        public bool Update(string name, int id)
        {
            return _itemRepository.Update(name, id);
        }
    }
}
