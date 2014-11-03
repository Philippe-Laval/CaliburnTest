using Caliburn.Micro.TreeView.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.TreeView
{
    class IpRangeViewModel : PropertyChangedBase
    {
        protected IpRangeTreeItemViewModel DataModel { get; private set; }

        public String Name
        {
            get { return DataModel.Name; }
            set
            {
                DataModel.Name = value;
                NotifyOfPropertyChange(() => Name);
            }
        }

        public IpRangeViewModel(IpRangeTreeItemViewModel dataModel)
        {
            DataModel = dataModel;
        }
    }
}
