using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Day8.Repository;
using Day8.Model;

namespace Day8.BLL
{
    
    public class QuantityManager
    {
        QuantityRepository _quantityRepository = new QuantityRepository();

        public bool Connection(int quantity)
        {
            return _quantityRepository.Connection(quantity);
        }
        public DataTable ShowInformation()
        {
            return _quantityRepository.ShowInformation();
        }
        public bool Delete(int id)
        {
            return _quantityRepository.Delete(id);
        }
        public bool Update(int quantity, int id)
        {
            return _quantityRepository.Update(quantity, id);
        }
    }
}
