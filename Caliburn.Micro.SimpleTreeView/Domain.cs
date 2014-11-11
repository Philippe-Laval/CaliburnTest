using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.SimpleTreeView
{
    public class Group : ITreeItem
    {
        public int Key { get; set; }
        public string Name { get; set; }

        public IList<Group> SubGroups { get; set; }
        public IList<Entry> Entries { get; set; }

        public IEnumerable<ITreeItem> Items
        {
            get
            {
                foreach (var group in this.SubGroups)
                    yield return group;
                foreach (var entry in this.Entries)
                    yield return entry;
            }
        }
    }
}
