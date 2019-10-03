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
     public class CustomerManager
    {
        CustomeRepository _customeRepository = new CustomeRepository();
        public bool Add(Customer customer)
        {
            return _customeRepository.Add(customer);
        }
        public bool IsNameExists(string name)
        {
            return _customeRepository.IsNameExists(name);
        }
        public bool Delete(Delete delete)
        {
            return _customeRepository.Delete(delete);
        }
        public DataTable ShowInformation()
        {
            return _customeRepository.ShowInformation();
        }
        public bool Update(Update update)
        {
            return _customeRepository.Update(update);
        }
        public DataTable Search(Search search)
        {
            return _customeRepository.Search(search);
        }
        
    }
}
