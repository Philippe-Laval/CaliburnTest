using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.TreeView.Model
{
    public class Group
    {
       public String Name { get; set; }
       public Dictionary<String, CollectionPoint> Children { get; set; }
 
       public Group()
       {
           Name = "New Group";
           Children = new Dictionary<String, CollectionPoint>();
       }
    }
}
