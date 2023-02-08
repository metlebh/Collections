using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_08._02._2023__1_
{
    public class Group
    {
        public string Name { get; set; }
        public string GetDetails()  
        {
            return $"Group name {Name}";
        }
    }
}
