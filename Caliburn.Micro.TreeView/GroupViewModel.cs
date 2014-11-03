using Caliburn.Micro.TreeView.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.TreeView
{
    public class GroupViewModel: PropertyChangedBase
    {
        public GroupTreeItemViewModel DataModel { get; private set; }

        public String Name
        {
            get { return DataModel.Name; }
            set
            {
                DataModel.Name = value;
                NotifyOfPropertyChange(() => Name);
            }
        }

        public GroupViewModel(GroupTreeItemViewModel dataModel)
        {
            DataModel = dataModel;
        }
    }
}
