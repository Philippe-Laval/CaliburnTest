namespace Caliburn.Micro.SimpleTreeView
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.Windows;

    [Export(typeof(IShell))]
    public class ShellViewModel : PropertyChangedBase, IShell
    {
        TestData data;
        string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                NotifyOfPropertyChange(() => Name);
                NotifyOfPropertyChange(() => CanSayHello);
            }
        }

        public ShellViewModel()
        {
            data = new TestData();
            data.Load();
        }

        public IList<Group> Groups
        {
            get 
            {
                return data.Groups;
            }
        }

        public void SelectedItemChanged(ITreeItem selectedItem)
        {
          //  String desc = selectedItem.ToString();
            Name = selectedItem.Name;
        }

        public bool CanSayHello
        {
            get { return !string.IsNullOrWhiteSpace(Name); }
        }

        public void SayHello()
        {
            MessageBox.Show(string.Format("Hello {0}!", Name));
        }
    }
}