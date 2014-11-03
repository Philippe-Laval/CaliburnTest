using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Caliburn.Micro;
using System.Windows;

namespace Test1
{
    public class MainViewModel : Conductor<IScreen>.Collection.OneActive
    {
        /// <summary>
        /// The searchText property.
        /// </summary>
        private string searchText;

        private string selectedCatalog;

        public MainViewModel()
        {
            DisplayName = "Test1 Main Window";
            SelectedCatalog = "foo";
        }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public string SearchText
        {
            get
            {
                return this.searchText;
            }

            set
            {
                this.searchText = value;
                this.NotifyOfPropertyChange(() => this.searchText);
            }

        }

        /// <summary>
        /// Search action
        /// </summary>
        public void Search()
        {
            MessageBox.Show(String.Format("Search is being performed for text {0}", this.SearchText));
        }

        public List<string> CatalogName
        {
            get
            {
                return new List<string> { "foo", "bar" };
            }
        }

        public string SelectedCatalog
        {
            get
            {
                return this.selectedCatalog;
            }

            set
            {
                this.selectedCatalog = value;
                this.NotifyOfPropertyChange(() => this.SelectedCatalog);
            }
        }

        public void Execute()
        {
            System.Windows.MessageBox.Show(SelectedCatalog);
        }
    }
}
