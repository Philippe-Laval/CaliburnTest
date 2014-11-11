using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.SimpleTreeView
{
    public interface ITreeItem
    {
        int Key { get; set; }
        string Name { get; set; }
    }
}
