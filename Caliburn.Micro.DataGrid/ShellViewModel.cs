namespace Caliburn.Micro.DataGrid
{
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.Windows;
    using System.Linq;

    [Export(typeof(IShell))]
    public class ShellViewModel : Screen, IShell
    {
        IWindowManager _windowManager;

        [ImportingConstructor]
        public ShellViewModel(IWindowManager windowManager)
        {
            _windowManager = windowManager;
            DisplayName = "Caliburn.Micro.DataGrid";
        }

        IObservableCollection<ArticleViewModel> _items;
        public IObservableCollection<ArticleViewModel> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                NotifyOfPropertyChange(() => Items);
            }
        }

        /*
         * You can look into the source code for the conventions (ConventionManager.cs)

        /// <summary>
        /// Derives the SelectedItem property name.
        /// </summary>
        public static Func<string, IEnumerable<string>> DerivePotentialSelectionNames = name =>{
            var singular = Singularize(name);
            return new[] {
                "Active" + singular,
                "Selected" + singular,
                "Current" + singular
            };
        };
        */
        private ArticleViewModel _selectedItem;
        public ArticleViewModel SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                NotifyOfPropertyChange(() => SelectedItem);
            }
        }



        public void AllArticles()
        {
            Service recover = new Service();  //a model called Recover
            IEnumerable<Article> articles = recover.Articles(); //return a List of Article
            IEnumerable<ArticleViewModel> avmEnumerable = articles.Select(article => new ArticleViewModel(article));
            Items = new BindableCollection<ArticleViewModel>(avmEnumerable);
        }

        public void AddItem()
        {
            ArticleViewModel articleViewModel = new ArticleViewModel(new Article());

            _windowManager.ShowDialog(articleViewModel);

            Items.Add(articleViewModel);
        }

        public void RemoveItem()
        {
            Items.Remove(SelectedItem);
        }

        public void EditItem()
        {
            _windowManager.ShowDialog(SelectedItem);
        }

    }
}