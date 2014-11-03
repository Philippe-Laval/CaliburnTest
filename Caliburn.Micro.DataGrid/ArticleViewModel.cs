using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Caliburn.Micro.DataGrid
{
    public class ArticleViewModel: Screen 
    {
        Article _article;

        public ArticleViewModel(Article article)
        {
            _article = article;
        }
        protected override void OnActivate()
        {
            //MessageBox.Show("ArticleViewModel Activated"); //Don't do this in a real VM.
            base.OnActivate();
        }

        public String Code
        {
            get { return _article.Code; }
            set
            {
                _article.Code = value;
                NotifyOfPropertyChange(() => Code);

            }
        }

        public String Description
        {
            get { return _article.Description; }
            set
            {
                _article.Description = value;
                NotifyOfPropertyChange(() => Description);

            }
        }

        public decimal Cost
        {
            get { return _article.Cost; }
            set
            {
                _article.Cost = value;
                NotifyOfPropertyChange(() => Cost);

            }
        }

        public decimal Price
        {
            get { return _article.Price; }
            set
            {
                _article.Price = value;
                NotifyOfPropertyChange(() => Price);
            }
        }
   
    }
}
