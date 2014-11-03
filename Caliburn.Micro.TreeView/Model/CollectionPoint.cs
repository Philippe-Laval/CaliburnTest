using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.TreeView.Model
{
   public class CollectionPoint
    {
       public String Name { get; set; }
       public Group Parent { get; set; }
       public Dictionary<String, IpRange> Children { get; set; }

       public CollectionPoint()
       {
           Name = "Untitled";
           Parent = null;
           Children = new Dictionary<String, IpRange>();
       }


    }
}
