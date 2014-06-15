using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RequestsManager.Model
{
    public class Request
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public int CountPeople { get; set; }
        public string Comment { get; set; }
    }
}
