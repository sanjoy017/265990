using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int Contact { get; set; }
        public string Address { get; set; }
    }
    public class Delete
    {
        public int Id { get; set; }
    }
    public class Update
    {
        public string Name { get; set; }
        public int Contact { get; set; }
        public string Address { get; set; }
        public int Id { get; set; }
    }
    public class Search
    {
        public string Name { get; set; }
    }
    
}
