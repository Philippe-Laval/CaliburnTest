using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Caliburn.Micro;

namespace CaliburnTest1
{
    public class AppViewModel : PropertyChangedBase
    {
        private int _count = 50;

        public int Count
        {
            get { return _count; }
            set
            {
                _count = value;
                NotifyOfPropertyChange(() => Count);
                NotifyOfPropertyChange(() => CanIncrementCount);
                NotifyOfPropertyChange(() => CanDecrementCount);
            }
        }

        public bool CanIncrementCount
        {
            get { return Count < 60; }
        }

        /*
        public void IncrementCount()
        {
            Count++;
        }
        */

        /// <summary>
        /// Notice that the slider we added is the same name as the parameter (delta). 
        /// </summary>
        /// <param name="delta"></param>
        public void IncrementCount(int delta)
        {
            Count += delta;
        }

        public bool CanDecrementCount
        {
            get { return Count > 40; }
        }

        public void DecrementCount()
        {
            Count--;
        }
    }
}
