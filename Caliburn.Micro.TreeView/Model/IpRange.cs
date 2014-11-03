using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.TreeView.Model
{
    public class IpRange
    {
        public String Name { get; set; }
        public CollectionPoint Parent { get; set; } 

        public IpRange()
       {
           Name = "Untitled";
           Parent = null;
       }
    }
}
