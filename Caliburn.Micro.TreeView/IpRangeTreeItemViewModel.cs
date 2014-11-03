using Caliburn.Micro.TreeView.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Caliburn.Micro;

namespace Caliburn.Micro.TreeView
{
    public class IpRangeTreeItemViewModel : PropertyChangedBase
    {
        public IpRange DataModel { get; private set; }

        public String Name
        {
            get { return DataModel.Name; }
            set
            {
                DataModel.Name = value;
                NotifyOfPropertyChange(() => Name);
            }
        }

        public CollectionPointTreeItemViewModel Parent { get; set; }

        public IpRangeTreeItemViewModel(CollectionPointTreeItemViewModel parent, IpRange dataModel)
        {
            Parent = parent;
            DataModel = dataModel;
        }

        public IpRangeTreeItemViewModel(CollectionPointTreeItemViewModel parent)
            : this(parent, new IpRange { Name = "New IP Range" })
        {
        }


        public void AddNewIpRange(object o)
        {
            Console.WriteLine(o.ToString());
            IpRangeTreeItemViewModel iprVM = new IpRangeTreeItemViewModel(Parent, new IpRange { Name = "IP Range" });
            Parent.Children.Add(iprVM);
        }

        public void RemoveIpRange(object o)
        {
            Console.WriteLine(o.ToString());
            Parent.Children.Remove(this);
        }

        public void Todo1(object o)
        {
            Console.WriteLine(o.ToString());
        }

        public void Todo2(object o)
        {
            Console.WriteLine(o.ToString());
        }
    }
}
