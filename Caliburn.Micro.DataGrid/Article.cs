using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.DataGrid
{
    public class Article : PropertyChangedBase
    {      
        public String Code {get; set;}
        public String Description { get; set; }
        public decimal Cost{get; set;}
        public decimal Price{get; set;}

        public Article()
        {
            Code = "";
            Description = "";
            Cost = 0.0M;
            Price = 0.0M;
        }
    }
}
