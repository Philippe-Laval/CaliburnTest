using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.DataGrid
{
    public class Service
    {
        public Service()
        {

        }

        public List<Article> Articles()
        {
            return new List<Article>() {
                new Article{ Code="A", Description="description1", Cost=6, Price=5.1M },
                new Article{ Code="B", Description="description2", Cost=12, Price=7.2M },
                new Article{ Code="C", Description="description3", Cost=18, Price=7.3M }
            };
        }

    }
}
