using Caliburn.Micro.TreeView.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.TreeView
{
    public class GroupTreeItemViewModel : PropertyChangedBase
    {
        public Group DataModel {get; private set;}

        public ShellViewModel Parent { get; set; }

        public String Name
        {
            get { return DataModel.Name; }
            set
            {
                DataModel.Name = value;
                NotifyOfPropertyChange(() => Name);
            }
        }

        public BindableCollection<CollectionPointTreeItemViewModel> Children { get; private set; }

        public GroupTreeItemViewModel(ShellViewModel parent)
            :this(parent, new Group())
        {
        }

        public GroupTreeItemViewModel(ShellViewModel parent, Group dataModel)
        {
            Parent = parent;
            DataModel = dataModel;

            Children = new BindableCollection<CollectionPointTreeItemViewModel>{
                new CollectionPointTreeItemViewModel(this, new CollectionPoint { Name = "b" }),
                new CollectionPointTreeItemViewModel(this, new CollectionPoint { Name = "a1" }),
                new CollectionPointTreeItemViewModel(this, new CollectionPoint { Name = "a1" }),
                new CollectionPointTreeItemViewModel(this, new CollectionPoint { Name = "a1" })
            };
        }

        public void AddNewCollectionPoint(object o)
        {
            Console.WriteLine(o.ToString());
            Children.Add(new CollectionPointTreeItemViewModel(this, new CollectionPoint { Name = "New Collection Point" }));
        }

        public void AddNewGroup(object o)
        {
            GroupTreeItemViewModel groupVM = new GroupTreeItemViewModel(Parent, new Group { Name = "New Group" });
            Parent.Children.Add(groupVM);
        }

        // cal:Action.TargetWithoutContext="{Binding DataContext, ElementName=StackPanel}"
        public Boolean CanRemoveGroup(object o)
        {
            if (Parent.Children.Count > 1) return true;
            return false;
        }
        public void RemoveGroup(object o)
        {
            Console.WriteLine(o.ToString());
            Parent.Children.Remove(this);

        }
    }
}
