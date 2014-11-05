using System.ComponentModel.Composition;

namespace Caliburn.Micro.TabPanel
{
    [Export(typeof(IShell))]
    public class ShellViewModel : PropertyChangedBase, IShell
    {
        [ImportingConstructor]
        public ShellViewModel(GeneralViewModel generalViewModel, DetailsViewModel detailsViewModel, SecurityViewModel securityViewModel)
        {
            General = generalViewModel;
            Details = detailsViewModel;
            Security = securityViewModel;
        }

        public GeneralViewModel General { get; private set; }
        public DetailsViewModel Details { get; private set; }
        public SecurityViewModel Security { get; private set; }

    }
}