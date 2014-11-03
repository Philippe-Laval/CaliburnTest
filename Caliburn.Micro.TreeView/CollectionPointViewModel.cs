using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.TreeView
{
    public class CollectionPointViewModel : PropertyChangedBase
    {
         public CollectionPointTreeItemViewModel DataModel { get; private set; }

        public String Name
        {
            get { return DataModel.Name; }
            set
            {
                DataModel.Name = value;
                NotifyOfPropertyChange(() => Name);
            }
        }

        public CollectionPointViewModel(CollectionPointTreeItemViewModel dataModel)
        {
            DataModel = dataModel;
        }
    }
}
