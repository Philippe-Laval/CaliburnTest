namespace Caliburn.Micro.TreeView
{
    using Caliburn.Micro.TreeView.Model;
    using System;
    using System.ComponentModel.Composition;
    using System.Windows;

    [Export(typeof(IShell))]
    public class ShellViewModel : Conductor<object>, IShell
    {
        string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                NotifyOfPropertyChange(() => Name);
            }
        }

        public BindableCollection<GroupTreeItemViewModel> Children { get; private set; }

        public ShellViewModel()
        {
            Children = new BindableCollection<GroupTreeItemViewModel>{
                new GroupTreeItemViewModel(this, new Group { Name = "a" }),
                new GroupTreeItemViewModel(this, new Group { Name = "b" }),
                new GroupTreeItemViewModel(this, new Group { Name = "c" }),
                new GroupTreeItemViewModel(this, new Group { Name = "d" })
            };
        }


        public void SelectedItemChanged(object o)
        {
            //ActiveItem = obj;
            Console.WriteLine(o.ToString());
            if (o is GroupTreeItemViewModel)
            {
                GroupTreeItemViewModel g = o as GroupTreeItemViewModel;
                GroupViewModel gVM = new GroupViewModel(g);
                ActivateItem(gVM);
                //ActivateItem(o);
            }
            else if (o is CollectionPointTreeItemViewModel)
            {
                CollectionPointTreeItemViewModel c = o as CollectionPointTreeItemViewModel;
                CollectionPointViewModel gVM = new CollectionPointViewModel(c);
                ActivateItem(gVM);
                //ActivateItem(o);
            }
            else if (o is IpRangeTreeItemViewModel)
            {
                IpRangeTreeItemViewModel ip = o as IpRangeTreeItemViewModel;
                IpRangeViewModel gVM = new IpRangeViewModel(ip);
                ActivateItem(gVM);
                //ActivateItem(o);
            }
        }

    }
}