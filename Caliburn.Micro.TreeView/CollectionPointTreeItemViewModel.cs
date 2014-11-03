using Caliburn.Micro.TreeView.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.TreeView
{
    public class CollectionPointTreeItemViewModel : PropertyChangedBase
    {
        protected CollectionPoint DataModel {get; private set;}

        public String Name
        {
            get { return DataModel.Name; }
            set
            {
                DataModel.Name = value;
                NotifyOfPropertyChange(() => Name);
            }
        }

        public GroupTreeItemViewModel Parent { get; set; }

        public BindableCollection<IpRangeTreeItemViewModel> Children { get; private set; }

        public CollectionPointTreeItemViewModel(GroupTreeItemViewModel parent)
            :this(parent, new CollectionPoint())
        {
        }

        public CollectionPointTreeItemViewModel(GroupTreeItemViewModel parent, CollectionPoint dataModel)
        {
            Parent = parent;
            DataModel = dataModel;

            Children = new BindableCollection<IpRangeTreeItemViewModel>{
                new IpRangeTreeItemViewModel(this, new IpRange { Name = "New IP Range" }),
                new IpRangeTreeItemViewModel(this, new IpRange { Name = "a1" }),
                new IpRangeTreeItemViewModel(this, new IpRange { Name = "a1" }),
                new IpRangeTreeItemViewModel(this, new IpRange { Name = "a1" })
            };
        }

        public void AddNewIpRange(object o)
        {
            Console.WriteLine(o.ToString());
            Children.Add(new IpRangeTreeItemViewModel(this, new IpRange { Name = "New Ip Range" }));
        }

        public void AddNewCollectionPoint(object o)
        {
            CollectionPointTreeItemViewModel cpVM = new CollectionPointTreeItemViewModel(Parent, new CollectionPoint { Name = "New Collection Point" });
            Parent.Children.Add(cpVM);
        }


        public void RemoveCollectionPoint(object o)
        {
            Console.WriteLine(o.ToString());
            Parent.Children.Remove(this);

        }
    }
}
