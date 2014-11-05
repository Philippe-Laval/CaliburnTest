using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.TabPanel
{
    [Export(typeof(SecurityViewModel))]
    public class SecurityViewModel : PropertyChangedBase
    {
    }
}
